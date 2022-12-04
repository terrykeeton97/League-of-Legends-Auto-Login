using Auto_Login.Classes;
using Auto_Login.Mappers;
using Auto_Login.UI;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Auto_Login
{
    public partial class Main : Form
    {
        public readonly string JSON_FILE = AppDomain.CurrentDomain.BaseDirectory + "\\accounts.json";
        public readonly string LOG_FILE = AppDomain.CurrentDomain.BaseDirectory + "\\log.txt";
        public bool FILE_EXISTS;

        public Main()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            if(Properties.Settings.Default.startMinimized)
            {
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                notifyIcon.Visible = true;
            }

            if(!Directory.Exists(LocalClientController.ClientInfo()))
            {
                MessageBox.Show("Unable to locate League of Legends install directory. Is it installed?", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            if (!File.Exists(LOG_FILE))
            {
                Log("No log file found");
                Log("Creating log file...");
                File.Create(LOG_FILE);
            }

            Log("Searching for data file");
            if (File.Exists(JSON_FILE))
            {
                FILE_EXISTS = true;
                Log("Data file found");
                Log("Loading data...");
                GetAccountData();
                if (Account_comboBox.Items.Count > 0)
                {
                    Account_comboBox.SelectedIndex = 0;
                    Remove_comboBox.SelectedIndex = 0;
                }

                return;
            }
            FILE_EXISTS = false;
            Log("Data file not found");
            DialogResult result = MessageBox.Show("Unable to retrieve account data, would you like to create a new data file?", "Account Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
                File.Create(JSON_FILE).Close();
        }

        internal void Log(string log, bool clear = false)
        {
            if (clear)
                Console_listBox.Items.Clear();

            Console_listBox.Items.Add(log);
        }

        private void GetAccountData()
        {
            var jsonFile = JsonConvert.DeserializeObject<JsonObject>(File.ReadAllText(JSON_FILE));
            if(jsonFile == null) return;
            foreach (var account in jsonFile.accounts)
            {
                AccountController.AddAccount(account.username, account.password, account.region);
                Log("Adding Account: " + account.username + " [" + account.region + "]");
            }
            UpdateAccountList();
        }

        private void WriteAccountData()
        {
            var accountsToSerialise = AccountController.GetAccounts().Select(x => AccountMapper.Map(x)).ToArray();
            string accountsJson = JsonConvert.SerializeObject(new JsonObject { count = accountsToSerialise.Length, accounts = accountsToSerialise });
            File.WriteAllText(JSON_FILE, accountsJson);
            Log("Account data saved");
        }

        private void UpdateAccountList()
        {
            Account_comboBox.Items.Clear();
            Remove_comboBox.Items.Clear();

            foreach (var item in AccountController.GetAccounts())
            {
                Account_comboBox.Items.Add(item.username);
                Remove_comboBox.Items.Add(item.username + " [" + item.region + "]");
                taskbar_Menu.Items.Add(item.username);
            }
            Log("Updated saved accounts");
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            string[] NEW_ACCOUNT = { Username_textBox.Text, Password_textBox.Text, Server_comboBox.Text };
            if (!FILE_EXISTS)
            {
                Log("Unable to save data to file, does the file exist?");
                return;
            }

            if (Username_textBox.Text.Length < 1 || Password_textBox.Text.Length < 1 || Server_comboBox.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid login to register", "Bad Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AccountController.AddAccount(NEW_ACCOUNT[0], Cryptography.Encrypt(NEW_ACCOUNT[1], Properties.Settings.Default.encryption_Key), NEW_ACCOUNT[2]);
            UpdateAccountList();
            WriteAccountData();
            Account_comboBox.SelectedIndex = 0;
            Remove_comboBox.SelectedIndex = 0;
        }

        private void Remove_Btn_Click(object sender, EventArgs e)
        {
            if (Remove_comboBox.Items.Count > 0)
            {
                Log("Removing selected account...");
                var selectedAccount = AccountController.GetAccounts().ElementAt(Remove_comboBox.SelectedIndex);
                AccountController.RemoveAccount(selectedAccount);
                UpdateAccountList();
                WriteAccountData();
                Remove_comboBox.Text = "";
                Username_textBox.Text = "";
                Password_textBox.Text = "";
                Server_comboBox.SelectedItem = null;
                return;
            }
            Log("Nothing to remove");
        }

        private void Load_Btn_Click(object sender, EventArgs e)
        {
            if (Account_comboBox.SelectedItem == null) return;
          
            var account = AccountController.GetAccount(Account_comboBox.Text);
            Log($"Loading account: {Account_comboBox.SelectedItem}", true);
            Login.Start(account.username, Cryptography.Decrypt(account.password, Properties.Settings.Default.encryption_Key), account.region);
         }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StreamWriter LOGGER = new StreamWriter(LOG_FILE);
                LOGGER.WriteLine(DateTime.Now.ToString());
                LOGGER.WriteLine("____________________________");
                foreach (var item in Console_listBox.Items)
                {
                    LOGGER.WriteLine(item.ToString());
                }
                LOGGER.Close();
                Application.Exit();
            }
            catch(Exception error)
            {
                Log("Error: " + error.ToString()); // TODO fix
            }
        }

        public class JsonObject
        {
            public int count { get; set; }
            public Account[] accounts { get; set; }
        }
        public class Account
        {
            public string username { get; set; }
            public string password { get; set; }
            public string region { get; set; }
        }

        private void Console_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(Console_checkBox.Checked)
                Size = new Size(581, 270);

            if (!Console_checkBox.Checked)
                Size = new Size(334, 270);
        }

        private void Settings_Btn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void taskbar_Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var account = AccountController.GetAccount(e.ClickedItem.Text);
            if (account == null) return; //TODO handle this better. We should throw an exception / error.
            Log($"Loading account: {Account_comboBox.SelectedItem}", true);
            Login.Start(account.username, Cryptography.Decrypt(account.password, Properties.Settings.Default.encryption_Key), account.region);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon.Visible = true;
            }
        }
    }
}

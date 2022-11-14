using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Auto_Login.Classes;
using Newtonsoft.Json;

namespace Auto_Login
{
    public partial class Main : Form
    {
        public string JSON_FILE = AppDomain.CurrentDomain.BaseDirectory + "\\accounts.json";
        public string LOG_FILE = AppDomain.CurrentDomain.BaseDirectory + "\\log.txt";
        public const string ENCRYPTION_KEY = "R5LeZYXebMn8F/N&";
        public bool FILE_EXISTS;

        public Main()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
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
                return;
            }

            FILE_EXISTS = false;
            Log("Data file not found");
            DialogResult log = MessageBox.Show("Unable to retrieve account data, would you like to create a new data file?", "Account Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(log == DialogResult.Yes)
                File.Create(JSON_FILE).Close();
        }

        public void Log(string log, bool clear = false)
        {
            if (clear)
                Console_listBox.Items.Clear();

            Console_listBox.Items.Add(log);
        }

        private void GetAccountData()
        {
            var JSON_ACCOUNTS = JsonConvert.DeserializeObject<JsonObject>(File.ReadAllText(JSON_FILE));
            if(JSON_ACCOUNTS == null) { return; }
            for (int i = 0; i < JSON_ACCOUNTS.count; i++)
            {
                AccountController.AddAccount(JSON_ACCOUNTS.accounts[i].username, JSON_ACCOUNTS.accounts[i].password, JSON_ACCOUNTS.accounts[i].region);
                Log("Adding Account: " + JSON_ACCOUNTS.accounts[i].username + " [" + JSON_ACCOUNTS.accounts[i].region + "]");
            }
            UpdateAccountList();
        }

        private void WriteAccountData()
        {
            Account[] accArray = new Account[AccountController.userAccounts.Count];
            for (int i = 0; i < AccountController.userAccounts.Count; i++)
            {
                UserAccount item = (UserAccount)AccountController.userAccounts[i];
                accArray[i] = new Account { username = item.username, password = item.password, region = item.region };
            }
            string json = JsonConvert.SerializeObject(new JsonObject { count = accArray.Length, accounts = accArray });
            File.WriteAllText(JSON_FILE, json);
            Log("Account data saved");
        }

        private void UpdateAccountList()
        {
            Account_comboBox.Items.Clear();
            Remove_comboBox.Items.Clear();

            foreach (UserAccount item in AccountController.userAccounts)
            {
                Account_comboBox.Items.Add(item.username);
                Remove_comboBox.Items.Add(item.username + " [" + item.region + "]");
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
                MessageBox.Show("Please enter a valid login to register", "Bad Credentials");
                return;
            }

            AccountController.AddAccount(NEW_ACCOUNT[0], Cryptography.Encrypt(NEW_ACCOUNT[1], ENCRYPTION_KEY), NEW_ACCOUNT[2]);
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
                UserAccount ACCOUNT = (UserAccount)AccountController.userAccounts[Remove_comboBox.SelectedIndex];
                AccountController.RemoveAccount(ACCOUNT);
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
            if (Account_comboBox.SelectedItem != null)
            {
                Hide();
                Thread WORK_THREAD = new Thread(() =>
                {
                    BeginInvoke((Action)delegate ()
                    {
                        UserAccount account = (UserAccount)AccountController.userAccounts[0];
                        account = AccountController.GetAccount(Account_comboBox.Text);
                        Log($"Loading account: {Account_comboBox.SelectedItem}", true);
                        Login.Start(account.username, Cryptography.Decrypt(account.password, ENCRYPTION_KEY), account.region);
                    });
                });
                WORK_THREAD.Start();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
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

        public class JsonObject
        {
            //  {"count":1,"accounts":[{"username":"1234","password":"qwert"},{"username":"1234","password":"qwert"}]}
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
                Size = new Size(580, 248);

            if (!Console_checkBox.Checked)
                Size = new Size(335, 248);
        }
    }
}

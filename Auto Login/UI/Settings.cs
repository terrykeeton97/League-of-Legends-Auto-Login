using Auto_Login.Classes;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Input;

namespace Auto_Login.UI
{
    public partial class Settings : Form
    {
        internal static readonly string STARTUP_KEY = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        internal static readonly string STARTUP_VALUE = "Auto Login";
        public Settings()
        {
            InitializeComponent();
            Init();
        }
        internal void Init()
        {
            Key_textBox.Text = Properties.Settings.Default.encryption_Key;
            ShowHide_checkBox.Checked = Properties.Settings.Default.passwordChar;
            Startup_checkBox.Checked = Properties.Settings.Default.systemStart;
            Minimized_checkBox.Checked = Properties.Settings.Default.startMinimized;
            Language_comboBox.Text = Properties.Settings.Default.prefLanguage;
            Input_checkBox.Checked = Properties.Settings.Default.blockInput;
        }
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
            Program.main.Log("Settings saved");
        }

        private void Generate_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("If you already have saved accounts on your current key, you wont be able to decrypt them and login.\n\nAre you sure you want to continue?", "Encryption",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Properties.Settings.Default.encryption_Key = Cryptography.GenerateKey();
                Program.main.Log("Generated new Encryption Key");
                Application.Restart();
            }
        }

        private void Set_Btn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.encryption_Key = Key_textBox.Text;
            Program.main.Log("Set new Encryption Key");
            Application.Restart();
        }

        private void Default_Btn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Program.main.Log("Restored defaults");
            Application.Restart();
        }

        private void ShowHide_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHide_checkBox.Checked)
            {
                Key_textBox.UseSystemPasswordChar = true;
                Properties.Settings.Default.passwordChar = true;
                return;
            }
            Properties.Settings.Default.passwordChar = false;
            Key_textBox.UseSystemPasswordChar = false;
        }

        private void Minimized_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Minimized_checkBox.Checked)
            {
                Properties.Settings.Default.startMinimized = true;
                return;
            }
            Properties.Settings.Default.startMinimized = false;
        }

        private void Startup_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(STARTUP_KEY, true);
            if (Startup_checkBox.Checked)
            {
                Properties.Settings.Default.systemStart = true;
                key.SetValue(STARTUP_VALUE, Application.ExecutablePath.ToString());
                key.Close();
                return;
            }
            Properties.Settings.Default.systemStart = false;
            key.DeleteValue(STARTUP_VALUE);
            key.Close();
        }

        private void PersisSettings_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PersisSettings_checkBox.Checked)
            {
                Properties.Settings.Default.persistedSettings = true;
                return;
            }
            Properties.Settings.Default.persistedSettings = false;
        }

        private void Input_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Input_checkBox.Checked)
            {
                Properties.Settings.Default.blockInput = true;
                return;
            }
            Properties.Settings.Default.blockInput = false;
        }

        private void Windows_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Windows_checkBox.Checked)
            {
                Properties.Settings.Default.windowsClickMenu = true;
                return;
            }
            Properties.Settings.Default.windowsClickMenu = false;
        }

        private void Language_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.prefLanguage = Language_comboBox.Text;
            Console.WriteLine(Properties.Settings.Default.prefLanguage);
        }
    }
}

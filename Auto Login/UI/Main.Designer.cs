namespace Auto_Login
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.HEADER_USERNAME = new System.Windows.Forms.Label();
            this.HEADER_PASSWORD = new System.Windows.Forms.Label();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Server_comboBox = new System.Windows.Forms.ComboBox();
            this.HEADER_SERVER = new System.Windows.Forms.Label();
            this.LINE2 = new Zeroit.Framework.LineSeparators.ZeroitBevelLine();
            this.Account_comboBox = new System.Windows.Forms.ComboBox();
            this.HEADER_ACCOUNT = new System.Windows.Forms.Label();
            this.LINE1 = new Zeroit.Framework.LineSeparators.ZeroitBevelLine();
            this.HEADER_MANAGEACCOUNT = new System.Windows.Forms.Label();
            this.HEADER_LOGIN = new System.Windows.Forms.Label();
            this.Load_Btn = new System.Windows.Forms.Button();
            this.LINE3 = new Zeroit.Framework.LineSeparators.ZeroitBevelLine();
            this.Remove_comboBox = new System.Windows.Forms.ComboBox();
            this.Remove_Btn = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Console_listBox = new System.Windows.Forms.ListBox();
            this.Console_checkBox = new System.Windows.Forms.CheckBox();
            this.Settings_Btn = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.taskbar_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // Username_textBox
            // 
            this.Username_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_textBox.Location = new System.Drawing.Point(72, 32);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(241, 20);
            this.Username_textBox.TabIndex = 0;
            // 
            // Password_textBox
            // 
            this.Password_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_textBox.Location = new System.Drawing.Point(72, 58);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(241, 20);
            this.Password_textBox.TabIndex = 1;
            this.Password_textBox.UseSystemPasswordChar = true;
            // 
            // HEADER_USERNAME
            // 
            this.HEADER_USERNAME.AutoSize = true;
            this.HEADER_USERNAME.Location = new System.Drawing.Point(11, 35);
            this.HEADER_USERNAME.Name = "HEADER_USERNAME";
            this.HEADER_USERNAME.Size = new System.Drawing.Size(55, 13);
            this.HEADER_USERNAME.TabIndex = 2;
            this.HEADER_USERNAME.Text = "Username";
            // 
            // HEADER_PASSWORD
            // 
            this.HEADER_PASSWORD.AutoSize = true;
            this.HEADER_PASSWORD.Location = new System.Drawing.Point(12, 61);
            this.HEADER_PASSWORD.Name = "HEADER_PASSWORD";
            this.HEADER_PASSWORD.Size = new System.Drawing.Size(53, 13);
            this.HEADER_PASSWORD.TabIndex = 3;
            this.HEADER_PASSWORD.Text = "Password";
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(238, 82);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(75, 23);
            this.Add_Btn.TabIndex = 4;
            this.Add_Btn.TabStop = false;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Server_comboBox
            // 
            this.Server_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Server_comboBox.FormattingEnabled = true;
            this.Server_comboBox.Items.AddRange(new object[] {
            "EUW",
            "EUNE",
            "RU",
            "NA",
            "TR"});
            this.Server_comboBox.Location = new System.Drawing.Point(72, 84);
            this.Server_comboBox.Name = "Server_comboBox";
            this.Server_comboBox.Size = new System.Drawing.Size(160, 21);
            this.Server_comboBox.TabIndex = 2;
            // 
            // HEADER_SERVER
            // 
            this.HEADER_SERVER.AutoSize = true;
            this.HEADER_SERVER.Location = new System.Drawing.Point(19, 87);
            this.HEADER_SERVER.Name = "HEADER_SERVER";
            this.HEADER_SERVER.Size = new System.Drawing.Size(38, 13);
            this.HEADER_SERVER.TabIndex = 6;
            this.HEADER_SERVER.Text = "Server";
            // 
            // LINE2
            // 
            this.LINE2.AllowTransparency = true;
            this.LINE2.Angle = 90;
            this.LINE2.Location = new System.Drawing.Point(38, 144);
            this.LINE2.Name = "LINE2";
            this.LINE2.Size = new System.Drawing.Size(276, 2);
            this.LINE2.TabIndex = 7;
            this.LINE2.TabStop = false;
            // 
            // Account_comboBox
            // 
            this.Account_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Account_comboBox.FormattingEnabled = true;
            this.Account_comboBox.Location = new System.Drawing.Point(64, 157);
            this.Account_comboBox.Name = "Account_comboBox";
            this.Account_comboBox.Size = new System.Drawing.Size(168, 21);
            this.Account_comboBox.TabIndex = 4;
            // 
            // HEADER_ACCOUNT
            // 
            this.HEADER_ACCOUNT.AutoSize = true;
            this.HEADER_ACCOUNT.Location = new System.Drawing.Point(11, 161);
            this.HEADER_ACCOUNT.Name = "HEADER_ACCOUNT";
            this.HEADER_ACCOUNT.Size = new System.Drawing.Size(47, 13);
            this.HEADER_ACCOUNT.TabIndex = 9;
            this.HEADER_ACCOUNT.Text = "Account";
            // 
            // LINE1
            // 
            this.LINE1.AllowTransparency = true;
            this.LINE1.Angle = 90;
            this.LINE1.Location = new System.Drawing.Point(92, 14);
            this.LINE1.Name = "LINE1";
            this.LINE1.Size = new System.Drawing.Size(222, 2);
            this.LINE1.TabIndex = 10;
            this.LINE1.TabStop = false;
            // 
            // HEADER_MANAGEACCOUNT
            // 
            this.HEADER_MANAGEACCOUNT.AutoSize = true;
            this.HEADER_MANAGEACCOUNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HEADER_MANAGEACCOUNT.Location = new System.Drawing.Point(9, 7);
            this.HEADER_MANAGEACCOUNT.Name = "HEADER_MANAGEACCOUNT";
            this.HEADER_MANAGEACCOUNT.Size = new System.Drawing.Size(89, 13);
            this.HEADER_MANAGEACCOUNT.TabIndex = 11;
            this.HEADER_MANAGEACCOUNT.Text = "Manage Account";
            // 
            // HEADER_LOGIN
            // 
            this.HEADER_LOGIN.AutoSize = true;
            this.HEADER_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HEADER_LOGIN.Location = new System.Drawing.Point(8, 137);
            this.HEADER_LOGIN.Name = "HEADER_LOGIN";
            this.HEADER_LOGIN.Size = new System.Drawing.Size(33, 13);
            this.HEADER_LOGIN.TabIndex = 12;
            this.HEADER_LOGIN.Text = "Login";
            // 
            // Load_Btn
            // 
            this.Load_Btn.Location = new System.Drawing.Point(238, 157);
            this.Load_Btn.Name = "Load_Btn";
            this.Load_Btn.Size = new System.Drawing.Size(75, 23);
            this.Load_Btn.TabIndex = 13;
            this.Load_Btn.TabStop = false;
            this.Load_Btn.Text = "Load";
            this.Load_Btn.UseVisualStyleBackColor = true;
            this.Load_Btn.Click += new System.EventHandler(this.Load_Btn_Click);
            // 
            // LINE3
            // 
            this.LINE3.AllowTransparency = true;
            this.LINE3.Angle = 90;
            this.LINE3.Location = new System.Drawing.Point(11, 193);
            this.LINE3.Name = "LINE3";
            this.LINE3.Size = new System.Drawing.Size(303, 2);
            this.LINE3.TabIndex = 14;
            this.LINE3.TabStop = false;
            // 
            // Remove_comboBox
            // 
            this.Remove_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Remove_comboBox.FormattingEnabled = true;
            this.Remove_comboBox.Location = new System.Drawing.Point(14, 111);
            this.Remove_comboBox.Name = "Remove_comboBox";
            this.Remove_comboBox.Size = new System.Drawing.Size(218, 21);
            this.Remove_comboBox.TabIndex = 3;
            // 
            // Remove_Btn
            // 
            this.Remove_Btn.Location = new System.Drawing.Point(238, 111);
            this.Remove_Btn.Name = "Remove_Btn";
            this.Remove_Btn.Size = new System.Drawing.Size(75, 23);
            this.Remove_Btn.TabIndex = 18;
            this.Remove_Btn.TabStop = false;
            this.Remove_Btn.Text = "Remove";
            this.Remove_Btn.UseVisualStyleBackColor = true;
            this.Remove_Btn.Click += new System.EventHandler(this.Remove_Btn_Click);
            // 
            // Console_listBox
            // 
            this.Console_listBox.BackColor = System.Drawing.Color.Black;
            this.Console_listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Console_listBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Console_listBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Console_listBox.FormattingEnabled = true;
            this.Console_listBox.ItemHeight = 14;
            this.Console_listBox.Location = new System.Drawing.Point(319, 10);
            this.Console_listBox.Name = "Console_listBox";
            this.Console_listBox.Size = new System.Drawing.Size(242, 212);
            this.Console_listBox.TabIndex = 20;
            this.Console_listBox.TabStop = false;
            // 
            // Console_checkBox
            // 
            this.Console_checkBox.AutoSize = true;
            this.Console_checkBox.Checked = true;
            this.Console_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Console_checkBox.Location = new System.Drawing.Point(11, 206);
            this.Console_checkBox.Name = "Console_checkBox";
            this.Console_checkBox.Size = new System.Drawing.Size(74, 17);
            this.Console_checkBox.TabIndex = 21;
            this.Console_checkBox.TabStop = false;
            this.Console_checkBox.Text = "Show Log";
            this.Console_checkBox.UseVisualStyleBackColor = true;
            this.Console_checkBox.CheckedChanged += new System.EventHandler(this.Console_checkBox_CheckedChanged);
            // 
            // Settings_Btn
            // 
            this.Settings_Btn.Location = new System.Drawing.Point(92, 201);
            this.Settings_Btn.Name = "Settings_Btn";
            this.Settings_Btn.Size = new System.Drawing.Size(222, 23);
            this.Settings_Btn.TabIndex = 22;
            this.Settings_Btn.TabStop = false;
            this.Settings_Btn.Text = "Settings";
            this.Settings_Btn.UseVisualStyleBackColor = true;
            this.Settings_Btn.Click += new System.EventHandler(this.Settings_Btn_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.taskbar_Menu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Auto Login";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // taskbar_Menu
            // 
            this.taskbar_Menu.Name = "taskbar_Menu";
            this.taskbar_Menu.Size = new System.Drawing.Size(61, 4);
            this.taskbar_Menu.Text = "Accounts";
            this.taskbar_Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.taskbar_Menu_ItemClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 231);
            this.ContextMenuStrip = this.taskbar_Menu;
            this.Controls.Add(this.Settings_Btn);
            this.Controls.Add(this.Console_checkBox);
            this.Controls.Add(this.Console_listBox);
            this.Controls.Add(this.Remove_Btn);
            this.Controls.Add(this.Remove_comboBox);
            this.Controls.Add(this.LINE3);
            this.Controls.Add(this.Load_Btn);
            this.Controls.Add(this.HEADER_LOGIN);
            this.Controls.Add(this.HEADER_MANAGEACCOUNT);
            this.Controls.Add(this.LINE1);
            this.Controls.Add(this.HEADER_ACCOUNT);
            this.Controls.Add(this.Account_comboBox);
            this.Controls.Add(this.LINE2);
            this.Controls.Add(this.HEADER_SERVER);
            this.Controls.Add(this.Server_comboBox);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.HEADER_PASSWORD);
            this.Controls.Add(this.HEADER_USERNAME);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Username_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label HEADER_USERNAME;
        private System.Windows.Forms.Label HEADER_PASSWORD;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.ComboBox Server_comboBox;
        private System.Windows.Forms.Label HEADER_SERVER;
        private Zeroit.Framework.LineSeparators.ZeroitBevelLine LINE2;
        private System.Windows.Forms.ComboBox Account_comboBox;
        private System.Windows.Forms.Label HEADER_ACCOUNT;
        private Zeroit.Framework.LineSeparators.ZeroitBevelLine LINE1;
        private System.Windows.Forms.Label HEADER_MANAGEACCOUNT;
        private System.Windows.Forms.Label HEADER_LOGIN;
        private System.Windows.Forms.Button Load_Btn;
        private Zeroit.Framework.LineSeparators.ZeroitBevelLine LINE3;
        private System.Windows.Forms.ComboBox Remove_comboBox;
        private System.Windows.Forms.Button Remove_Btn;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ListBox Console_listBox;
        private System.Windows.Forms.CheckBox Console_checkBox;
        private System.Windows.Forms.Button Settings_Btn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip taskbar_Menu;
    }
}


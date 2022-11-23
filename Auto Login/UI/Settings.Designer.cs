namespace Auto_Login.UI
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Input_checkBox = new System.Windows.Forms.CheckBox();
            this.PersisSettings_checkBox = new System.Windows.Forms.CheckBox();
            this.Minimized_checkBox = new System.Windows.Forms.CheckBox();
            this.Default_Btn = new System.Windows.Forms.Button();
            this.Startup_checkBox = new System.Windows.Forms.CheckBox();
            this.zeroitSeparatorLine1 = new Zeroit.Framework.LineSeparators.ZeroitSeparatorLine();
            this.label6 = new System.Windows.Forms.Label();
            this.Language_comboBox = new System.Windows.Forms.ComboBox();
            this.ShowHide_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Set_Btn = new System.Windows.Forms.Button();
            this.Key_textBox = new System.Windows.Forms.TextBox();
            this.HEADER_LABEL1 = new System.Windows.Forms.Label();
            this.Generate_Btn = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(12, 9);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(433, 280);
            this.tabControl.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Input_checkBox);
            this.tabPage1.Controls.Add(this.PersisSettings_checkBox);
            this.tabPage1.Controls.Add(this.Minimized_checkBox);
            this.tabPage1.Controls.Add(this.Default_Btn);
            this.tabPage1.Controls.Add(this.Startup_checkBox);
            this.tabPage1.Controls.Add(this.zeroitSeparatorLine1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Language_comboBox);
            this.tabPage1.Controls.Add(this.ShowHide_checkBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Set_Btn);
            this.tabPage1.Controls.Add(this.Key_textBox);
            this.tabPage1.Controls.Add(this.HEADER_LABEL1);
            this.tabPage1.Controls.Add(this.Generate_Btn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(425, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encryption";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Input_checkBox
            // 
            this.Input_checkBox.AutoSize = true;
            this.Input_checkBox.Location = new System.Drawing.Point(132, 163);
            this.Input_checkBox.Name = "Input_checkBox";
            this.Input_checkBox.Size = new System.Drawing.Size(80, 17);
            this.Input_checkBox.TabIndex = 39;
            this.Input_checkBox.Text = "Block Input";
            this.toolTip.SetToolTip(this.Input_checkBox, "Block user input while logging in (recommended)\r\nYou can CTRL+ALT+DEL if you get " +
        "stuck");
            this.Input_checkBox.UseVisualStyleBackColor = true;
            this.Input_checkBox.CheckedChanged += new System.EventHandler(this.Input_checkBox_CheckedChanged);
            // 
            // PersisSettings_checkBox
            // 
            this.PersisSettings_checkBox.AutoSize = true;
            this.PersisSettings_checkBox.Location = new System.Drawing.Point(9, 232);
            this.PersisSettings_checkBox.Name = "PersisSettings_checkBox";
            this.PersisSettings_checkBox.Size = new System.Drawing.Size(138, 17);
            this.PersisSettings_checkBox.TabIndex = 36;
            this.PersisSettings_checkBox.Text = "Save Persisted Settings";
            this.toolTip.SetToolTip(this.PersisSettings_checkBox, "Save your in-game settings from your last account (un-tested)\r\n");
            this.PersisSettings_checkBox.UseVisualStyleBackColor = true;
            this.PersisSettings_checkBox.CheckedChanged += new System.EventHandler(this.PersisSettings_checkBox_CheckedChanged);
            // 
            // Minimized_checkBox
            // 
            this.Minimized_checkBox.AutoSize = true;
            this.Minimized_checkBox.Location = new System.Drawing.Point(9, 186);
            this.Minimized_checkBox.Name = "Minimized_checkBox";
            this.Minimized_checkBox.Size = new System.Drawing.Size(97, 17);
            this.Minimized_checkBox.TabIndex = 35;
            this.Minimized_checkBox.Text = "Start Minimized";
            this.Minimized_checkBox.UseVisualStyleBackColor = true;
            this.Minimized_checkBox.CheckedChanged += new System.EventHandler(this.Minimized_checkBox_CheckedChanged);
            // 
            // Default_Btn
            // 
            this.Default_Btn.Location = new System.Drawing.Point(284, 224);
            this.Default_Btn.Name = "Default_Btn";
            this.Default_Btn.Size = new System.Drawing.Size(135, 25);
            this.Default_Btn.TabIndex = 18;
            this.Default_Btn.TabStop = false;
            this.Default_Btn.Text = "Restore Default Settings";
            this.Default_Btn.UseVisualStyleBackColor = true;
            this.Default_Btn.Click += new System.EventHandler(this.Default_Btn_Click);
            // 
            // Startup_checkBox
            // 
            this.Startup_checkBox.AutoSize = true;
            this.Startup_checkBox.Location = new System.Drawing.Point(9, 209);
            this.Startup_checkBox.Name = "Startup_checkBox";
            this.Startup_checkBox.Size = new System.Drawing.Size(117, 17);
            this.Startup_checkBox.TabIndex = 34;
            this.Startup_checkBox.Text = "Start with Windows";
            this.Startup_checkBox.UseVisualStyleBackColor = true;
            this.Startup_checkBox.CheckedChanged += new System.EventHandler(this.Startup_checkBox_CheckedChanged);
            // 
            // zeroitSeparatorLine1
            // 
            this.zeroitSeparatorLine1.AllowTransparency = true;
            this.zeroitSeparatorLine1.BackColor = System.Drawing.Color.Transparent;
            this.zeroitSeparatorLine1.ColorLine = System.Drawing.Color.Black;
            this.zeroitSeparatorLine1.Location = new System.Drawing.Point(10, 153);
            this.zeroitSeparatorLine1.Name = "zeroitSeparatorLine1";
            this.zeroitSeparatorLine1.Size = new System.Drawing.Size(409, 10);
            this.zeroitSeparatorLine1.Style = Zeroit.Framework.LineSeparators.ZeroitSeparatorLine.LineStyle.Solid;
            this.zeroitSeparatorLine1.TabIndex = 33;
            this.zeroitSeparatorLine1.Text = "zeroitSeparatorLine1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Prefered Language";
            // 
            // Language_comboBox
            // 
            this.Language_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Language_comboBox.FormattingEnabled = true;
            this.Language_comboBox.Items.AddRange(new object[] {
            "en_GB",
            "de_DE",
            "fr_FR",
            "es_MX",
            "ru_RU"});
            this.Language_comboBox.Location = new System.Drawing.Point(284, 184);
            this.Language_comboBox.Name = "Language_comboBox";
            this.Language_comboBox.Size = new System.Drawing.Size(135, 21);
            this.Language_comboBox.TabIndex = 32;
            this.Language_comboBox.SelectedIndexChanged += new System.EventHandler(this.Language_comboBox_SelectedIndexChanged);
            // 
            // ShowHide_checkBox
            // 
            this.ShowHide_checkBox.AutoSize = true;
            this.ShowHide_checkBox.Location = new System.Drawing.Point(9, 163);
            this.ShowHide_checkBox.Name = "ShowHide_checkBox";
            this.ShowHide_checkBox.Size = new System.Drawing.Size(122, 17);
            this.ShowHide_checkBox.TabIndex = 19;
            this.ShowHide_checkBox.Text = "Hide Encryption Key";
            this.ShowHide_checkBox.UseVisualStyleBackColor = true;
            this.ShowHide_checkBox.CheckedChanged += new System.EventHandler(this.ShowHide_checkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 52);
            this.label1.TabIndex = 17;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Set_Btn
            // 
            this.Set_Btn.Location = new System.Drawing.Point(132, 41);
            this.Set_Btn.Name = "Set_Btn";
            this.Set_Btn.Size = new System.Drawing.Size(116, 35);
            this.Set_Btn.TabIndex = 16;
            this.Set_Btn.TabStop = false;
            this.Set_Btn.Text = "Set Key";
            this.Set_Btn.UseVisualStyleBackColor = true;
            this.Set_Btn.Click += new System.EventHandler(this.Set_Btn_Click);
            // 
            // Key_textBox
            // 
            this.Key_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Key_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Key_textBox.Location = new System.Drawing.Point(40, 15);
            this.Key_textBox.Name = "Key_textBox";
            this.Key_textBox.Size = new System.Drawing.Size(379, 20);
            this.Key_textBox.TabIndex = 15;
            // 
            // HEADER_LABEL1
            // 
            this.HEADER_LABEL1.AutoSize = true;
            this.HEADER_LABEL1.Location = new System.Drawing.Point(6, 17);
            this.HEADER_LABEL1.Name = "HEADER_LABEL1";
            this.HEADER_LABEL1.Size = new System.Drawing.Size(28, 13);
            this.HEADER_LABEL1.TabIndex = 14;
            this.HEADER_LABEL1.Text = "Key:";
            // 
            // Generate_Btn
            // 
            this.Generate_Btn.Location = new System.Drawing.Point(9, 41);
            this.Generate_Btn.Name = "Generate_Btn";
            this.Generate_Btn.Size = new System.Drawing.Size(117, 35);
            this.Generate_Btn.TabIndex = 13;
            this.Generate_Btn.TabStop = false;
            this.Generate_Btn.Text = "Generate New Key";
            this.Generate_Btn.UseVisualStyleBackColor = true;
            this.Generate_Btn.Click += new System.EventHandler(this.Generate_Btn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 295);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label HEADER_LABEL1;
        private System.Windows.Forms.Button Generate_Btn;
        private System.Windows.Forms.Button Set_Btn;
        private System.Windows.Forms.TextBox Key_textBox;
        private System.Windows.Forms.Button Default_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ShowHide_checkBox;
        private Zeroit.Framework.LineSeparators.ZeroitSeparatorLine zeroitSeparatorLine1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Language_comboBox;
        private System.Windows.Forms.CheckBox Minimized_checkBox;
        private System.Windows.Forms.CheckBox Startup_checkBox;
        private System.Windows.Forms.CheckBox PersisSettings_checkBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox Input_checkBox;
    }
}
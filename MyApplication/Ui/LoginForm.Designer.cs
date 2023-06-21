namespace MyApplication
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            UsernameLabel = new Usf.WinForms.Forms.Label();
            PasswordLabel = new Usf.WinForms.Forms.Label();
            UsernameTextBox = new Usf.WinForms.Forms.TextBox();
            PasswordTextBox = new Usf.WinForms.Forms.TextBox();
            EnterButton = new Usf.WinForms.Forms.Button();
            ExitButton = new Usf.WinForms.Forms.Button();
            LanguageLabel = new Usf.WinForms.Forms.Label();
            radioButton1 = new Usf.WinForms.Forms.RadioButton();
            radioButton2 = new Usf.WinForms.Forms.RadioButton();
            panel1 = new Panel();
            SystemNameLabel = new Usf.WinForms.Forms.Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.Appearance.Font = (Font)resources.GetObject("UsernameLabel.Appearance.Font");
            UsernameLabel.Appearance.ForeColor = (Color)resources.GetObject("UsernameLabel.Appearance.ForeColor");
            UsernameLabel.Appearance.Options.UseFont = true;
            UsernameLabel.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(UsernameLabel, "UsernameLabel");
            UsernameLabel.Name = "UsernameLabel";
            // 
            // PasswordLabel
            // 
            PasswordLabel.Appearance.Font = (Font)resources.GetObject("PasswordLabel.Appearance.Font");
            PasswordLabel.Appearance.ForeColor = (Color)resources.GetObject("PasswordLabel.Appearance.ForeColor");
            PasswordLabel.Appearance.Options.UseFont = true;
            PasswordLabel.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(PasswordLabel, "PasswordLabel");
            PasswordLabel.Name = "PasswordLabel";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.BackColor = Color.LemonChiffon;
            resources.ApplyResources(UsernameTextBox, "UsernameTextBox");
            UsernameTextBox.ForeColor = Color.Maroon;
            UsernameTextBox.Name = "UsernameTextBox";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.LemonChiffon;
            resources.ApplyResources(PasswordTextBox, "PasswordTextBox");
            PasswordTextBox.ForeColor = Color.Maroon;
            PasswordTextBox.Name = "PasswordTextBox";
            // 
            // EnterButton
            // 
            EnterButton.Appearance.BackColor = (Color)resources.GetObject("EnterButton.Appearance.BackColor");
            EnterButton.Appearance.Font = (Font)resources.GetObject("EnterButton.Appearance.Font");
            EnterButton.Appearance.ForeColor = (Color)resources.GetObject("EnterButton.Appearance.ForeColor");
            EnterButton.Appearance.Options.UseBackColor = true;
            EnterButton.Appearance.Options.UseFont = true;
            EnterButton.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(EnterButton, "EnterButton");
            EnterButton.Name = "EnterButton";
            EnterButton.Click += EnterButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Appearance.BackColor = (Color)resources.GetObject("ExitButton.Appearance.BackColor");
            ExitButton.Appearance.Font = (Font)resources.GetObject("ExitButton.Appearance.Font");
            ExitButton.Appearance.ForeColor = (Color)resources.GetObject("ExitButton.Appearance.ForeColor");
            ExitButton.Appearance.Options.UseBackColor = true;
            ExitButton.Appearance.Options.UseFont = true;
            ExitButton.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(ExitButton, "ExitButton");
            ExitButton.Name = "ExitButton";
            ExitButton.Click += ExitButton_Click;
            // 
            // LanguageLabel
            // 
            LanguageLabel.Appearance.Font = (Font)resources.GetObject("LanguageLabel.Appearance.Font");
            LanguageLabel.Appearance.ForeColor = (Color)resources.GetObject("LanguageLabel.Appearance.ForeColor");
            LanguageLabel.Appearance.Options.UseFont = true;
            LanguageLabel.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(LanguageLabel, "LanguageLabel");
            LanguageLabel.Cursor = Cursors.Hand;
            LanguageLabel.Name = "LanguageLabel";
            LanguageLabel.Click += LanguageLabel_Click;
            // 
            // radioButton1
            // 
            resources.ApplyResources(radioButton1, "radioButton1");
            radioButton1.Checked = true;
            radioButton1.ForeColor = Color.DeepSkyBlue;
            radioButton1.Name = "radioButton1";
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            resources.ApplyResources(radioButton2, "radioButton2");
            radioButton2.ForeColor = Color.DeepSkyBlue;
            radioButton2.Name = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(SystemNameLabel);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // SystemNameLabel
            // 
            SystemNameLabel.Appearance.Font = (Font)resources.GetObject("SystemNameLabel.Appearance.Font");
            SystemNameLabel.Appearance.ForeColor = (Color)resources.GetObject("SystemNameLabel.Appearance.ForeColor");
            SystemNameLabel.Appearance.Options.UseFont = true;
            SystemNameLabel.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(SystemNameLabel, "SystemNameLabel");
            SystemNameLabel.Name = "SystemNameLabel";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(LanguageLabel);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // LoginForm
            // 
            AcceptButton = EnterButton;
            Appearance.BackColor = (Color)resources.GetObject("LoginForm.Appearance.BackColor");
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ExitButton;
            ControlBox = false;
            Controls.Add(ExitButton);
            Controls.Add(EnterButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Usf.WinForms.Forms.Label UsernameLabel;
        private Usf.WinForms.Forms.Label PasswordLabel;
        private Usf.WinForms.Forms.TextBox UsernameTextBox;
        private Usf.WinForms.Forms.TextBox PasswordTextBox;
        private Usf.WinForms.Forms.Button EnterButton;
        private Usf.WinForms.Forms.Button ExitButton;
        private Usf.WinForms.Forms.Label LanguageLabel;
        private Usf.WinForms.Forms.RadioButton radioButton1;
        private Usf.WinForms.Forms.RadioButton radioButton2;
        private Panel panel1;
        private Usf.WinForms.Forms.Label SystemNameLabel;
        private Panel panel2;
    }
}
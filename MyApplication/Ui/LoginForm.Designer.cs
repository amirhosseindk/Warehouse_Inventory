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
            UsernameLabel = new Usf.WinForms.Forms.Label();
            PasswordLabel = new Usf.WinForms.Forms.Label();
            UsernameTextBox = new Usf.WinForms.Forms.TextBox();
            PasswordTextBox = new Usf.WinForms.Forms.TextBox();
            EnterButton = new Usf.WinForms.Forms.Button();
            ExitButton = new Usf.WinForms.Forms.Button();
            LanguageLabel = new Usf.WinForms.Forms.Label();
            SystemNameLabel = new Usf.WinForms.Forms.Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.Appearance.Font = new Font("IRANYekan Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameLabel.Appearance.ForeColor = Color.Teal;
            UsernameLabel.Appearance.Options.UseFont = true;
            UsernameLabel.Appearance.Options.UseForeColor = true;
            UsernameLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            UsernameLabel.Location = new Point(26, 42);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(110, 27);
            UsernameLabel.TabIndex = 5;
            UsernameLabel.Text = "label1";
            // 
            // PasswordLabel
            // 
            PasswordLabel.Appearance.Font = new Font("IRANYekan Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.Appearance.ForeColor = Color.Teal;
            PasswordLabel.Appearance.Options.UseFont = true;
            PasswordLabel.Appearance.Options.UseForeColor = true;
            PasswordLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            PasswordLabel.Location = new Point(26, 111);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(110, 27);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "label2";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.BackColor = Color.LemonChiffon;
            UsernameTextBox.Font = new Font("B Yekan", 15F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameTextBox.ForeColor = Color.Maroon;
            UsernameTextBox.Location = new Point(22, 71);
            UsernameTextBox.Multiline = true;
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(232, 40);
            UsernameTextBox.TabIndex = 4;
            UsernameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.LemonChiffon;
            PasswordTextBox.Font = new Font("B Yekan", 15F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTextBox.ForeColor = Color.Maroon;
            PasswordTextBox.Location = new Point(22, 140);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(232, 40);
            PasswordTextBox.TabIndex = 0;
            PasswordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // EnterButton
            // 
            EnterButton.Appearance.Font = new Font("IRANYekan Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            EnterButton.Appearance.ForeColor = Color.Green;
            EnterButton.Appearance.Options.UseFont = true;
            EnterButton.Appearance.Options.UseForeColor = true;
            EnterButton.Location = new Point(22, 202);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(100, 45);
            EnterButton.TabIndex = 1;
            EnterButton.Text = "button1";
            EnterButton.Click += EnterButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Appearance.Font = new Font("IRANYekan Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.Appearance.ForeColor = Color.Red;
            ExitButton.Appearance.Options.UseFont = true;
            ExitButton.Appearance.Options.UseForeColor = true;
            ExitButton.Location = new Point(154, 202);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(100, 45);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "button2";
            ExitButton.Click += ExitButton_Click;
            // 
            // LanguageLabel
            // 
            LanguageLabel.Appearance.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            LanguageLabel.Appearance.ForeColor = Color.DeepSkyBlue;
            LanguageLabel.Appearance.Options.UseFont = true;
            LanguageLabel.Appearance.Options.UseForeColor = true;
            LanguageLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            LanguageLabel.Cursor = Cursors.Hand;
            LanguageLabel.Location = new Point(1, 247);
            LanguageLabel.Name = "LanguageLabel";
            LanguageLabel.Size = new Size(48, 22);
            LanguageLabel.TabIndex = 3;
            LanguageLabel.Text = "label3";
            LanguageLabel.Click += LanguageLabel_Click;
            // 
            // SystemNameLabel
            // 
            SystemNameLabel.Appearance.Font = new Font("IRANYekan Medium", 13F, FontStyle.Bold, GraphicsUnit.Point);
            SystemNameLabel.Appearance.ForeColor = Color.Maroon;
            SystemNameLabel.Appearance.Options.UseFont = true;
            SystemNameLabel.Appearance.Options.UseForeColor = true;
            SystemNameLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            SystemNameLabel.Location = new Point(49, 1);
            SystemNameLabel.Name = "SystemNameLabel";
            SystemNameLabel.Size = new Size(181, 30);
            SystemNameLabel.TabIndex = 7;
            SystemNameLabel.Text = "label3";
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Location = new Point(-2, 34);
            button1.Name = "button1";
            button1.Size = new Size(279, 5);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AcceptButton = EnterButton;
            Appearance.BackColor = Color.Gold;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ExitButton;
            ClientSize = new Size(276, 270);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(SystemNameLabel);
            Controls.Add(LanguageLabel);
            Controls.Add(ExitButton);
            Controls.Add(EnterButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "LoginForm";
            ShowInTaskbar = false;
            Text = "LoginForm";
            Load += LoginForm_Load;
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
        private Usf.WinForms.Forms.Label SystemNameLabel;
        private Button button1;
    }
}
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
            UsernameLabel.Appearance.Font = new Font("IRANYekan Medium", 11F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameLabel.Appearance.ForeColor = Color.Teal;
            UsernameLabel.Appearance.Options.UseFont = true;
            UsernameLabel.Appearance.Options.UseForeColor = true;
            UsernameLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            UsernameLabel.Location = new Point(26, 41);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(110, 25);
            UsernameLabel.TabIndex = 5;
            UsernameLabel.Text = "label1";
            // 
            // PasswordLabel
            // 
            PasswordLabel.Appearance.Font = new Font("IRANYekan Medium", 11F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.Appearance.ForeColor = Color.Teal;
            PasswordLabel.Appearance.Options.UseFont = true;
            PasswordLabel.Appearance.Options.UseForeColor = true;
            PasswordLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            PasswordLabel.Location = new Point(26, 109);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(110, 25);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "label22";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.BackColor = Color.LemonChiffon;
            UsernameTextBox.Font = new Font("B Yekan", 15F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameTextBox.ForeColor = Color.Maroon;
            UsernameTextBox.Location = new Point(22, 69);
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
            PasswordTextBox.Location = new Point(22, 137);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(232, 40);
            PasswordTextBox.TabIndex = 0;
            PasswordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // EnterButton
            // 
            EnterButton.Appearance.BackColor = Color.Aquamarine;
            EnterButton.Appearance.Font = new Font("IRANYekan Medium", 15F, FontStyle.Bold, GraphicsUnit.Point);
            EnterButton.Appearance.ForeColor = Color.Green;
            EnterButton.Appearance.Options.UseBackColor = true;
            EnterButton.Appearance.Options.UseFont = true;
            EnterButton.Appearance.Options.UseForeColor = true;
            EnterButton.Location = new Point(22, 191);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(110, 51);
            EnterButton.TabIndex = 1;
            EnterButton.Text = "button1";
            EnterButton.Click += EnterButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Appearance.BackColor = Color.LightSalmon;
            ExitButton.Appearance.Font = new Font("IRANYekan Medium", 15F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.Appearance.ForeColor = Color.Red;
            ExitButton.Appearance.Options.UseBackColor = true;
            ExitButton.Appearance.Options.UseFont = true;
            ExitButton.Appearance.Options.UseForeColor = true;
            ExitButton.Location = new Point(144, 191);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(110, 51);
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
            LanguageLabel.Location = new Point(1, -2);
            LanguageLabel.Name = "LanguageLabel";
            LanguageLabel.Size = new Size(48, 21);
            LanguageLabel.TabIndex = 3;
            LanguageLabel.Text = "label3";
            LanguageLabel.Click += LanguageLabel_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("B Yekan", 8F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.DeepSkyBlue;
            radioButton1.Location = new Point(208, -2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 21);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Admin";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("B Yekan", 8F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.DeepSkyBlue;
            radioButton2.Location = new Point(150, -2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(52, 21);
            radioButton2.TabIndex = 9;
            radioButton2.Text = "User";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(SystemNameLabel);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 33);
            panel1.TabIndex = 11;
            // 
            // SystemNameLabel
            // 
            SystemNameLabel.Appearance.Font = new Font("IRANYekan Medium", 13F, FontStyle.Bold, GraphicsUnit.Point);
            SystemNameLabel.Appearance.ForeColor = Color.Maroon;
            SystemNameLabel.Appearance.Options.UseFont = true;
            SystemNameLabel.Appearance.Options.UseForeColor = true;
            SystemNameLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            SystemNameLabel.Location = new Point(55, 0);
            SystemNameLabel.Name = "SystemNameLabel";
            SystemNameLabel.Size = new Size(168, 30);
            SystemNameLabel.TabIndex = 8;
            SystemNameLabel.Text = "label3";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(LanguageLabel);
            panel2.Location = new Point(0, 252);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 18);
            panel2.TabIndex = 12;
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
            Controls.Add(ExitButton);
            Controls.Add(EnterButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "LoginForm";
            Text = "LoginForm";
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
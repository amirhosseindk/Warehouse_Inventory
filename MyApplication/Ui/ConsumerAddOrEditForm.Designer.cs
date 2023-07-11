namespace MyApp.Ui
{
    partial class ConsumerAddOrEditForm
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
            ActiveCheckEdit = new Usf.WinForms.Forms.CheckEdit();
            SaveButton = new Usf.WinForms.Forms.ButtonSimlpe();
            DescriptionTextEdit = new Usf.WinForms.Forms.TextEdit();
            AddressTextEdit = new Usf.WinForms.Forms.TextEdit();
            EmailTextEdit = new Usf.WinForms.Forms.TextEdit();
            PhoneTextEdit = new Usf.WinForms.Forms.TextEdit();
            LastNameTextEdit = new Usf.WinForms.Forms.TextEdit();
            FirstNameTextEdit = new Usf.WinForms.Forms.TextEdit();
            DescriptionLabelControl = new Usf.WinForms.Forms.LabelControl();
            AddressLabelControl = new Usf.WinForms.Forms.LabelControl();
            EmailLabelControl = new Usf.WinForms.Forms.LabelControl();
            PhoneLabelControl = new Usf.WinForms.Forms.LabelControl();
            LastNameLabelControl = new Usf.WinForms.Forms.LabelControl();
            FirstNameLabelControl = new Usf.WinForms.Forms.LabelControl();
            ((System.ComponentModel.ISupportInitialize)ActiveCheckEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DescriptionTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddressTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhoneTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FirstNameTextEdit.Properties).BeginInit();
            SuspendLayout();
            // 
            // ActiveCheckEdit
            // 
            ActiveCheckEdit.EditValue = true;
            ActiveCheckEdit.Location = new Point(30, 434);
            ActiveCheckEdit.Margin = new Padding(4);
            ActiveCheckEdit.Name = "ActiveCheckEdit";
            ActiveCheckEdit.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ActiveCheckEdit.Properties.Appearance.ForeColor = Color.Maroon;
            ActiveCheckEdit.Properties.Appearance.Options.UseFont = true;
            ActiveCheckEdit.Properties.Appearance.Options.UseForeColor = true;
            ActiveCheckEdit.Properties.Caption = "Active";
            ActiveCheckEdit.Size = new Size(100, 29);
            ActiveCheckEdit.TabIndex = 22;
            // 
            // SaveButton
            // 
            SaveButton.Appearance.BackColor = Color.LightGreen;
            SaveButton.Appearance.BorderColor = Color.PaleGreen;
            SaveButton.Appearance.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.Appearance.ForeColor = Color.Maroon;
            SaveButton.Appearance.Options.UseBackColor = true;
            SaveButton.Appearance.Options.UseBorderColor = true;
            SaveButton.Appearance.Options.UseFont = true;
            SaveButton.Appearance.Options.UseForeColor = true;
            SaveButton.Location = new Point(143, 423);
            SaveButton.Margin = new Padding(4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(250, 62);
            SaveButton.TabIndex = 33;
            SaveButton.Text = "Save";
            SaveButton.Click += SaveButton_Click;
            // 
            // DescriptionTextEdit
            // 
            DescriptionTextEdit.IsActiveVHText = false;
            DescriptionTextEdit.Location = new Point(143, 324);
            DescriptionTextEdit.Margin = new Padding(4);
            DescriptionTextEdit.Name = "DescriptionTextEdit";
            DescriptionTextEdit.Properties.Appearance.BackColor = Color.White;
            DescriptionTextEdit.Properties.Appearance.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DescriptionTextEdit.Properties.Appearance.Options.UseBackColor = true;
            DescriptionTextEdit.Properties.Appearance.Options.UseFont = true;
            DescriptionTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            DescriptionTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            DescriptionTextEdit.Properties.AutoHeight = false;
            DescriptionTextEdit.Size = new Size(250, 83);
            DescriptionTextEdit.TabIndex = 32;
            // 
            // AddressTextEdit
            // 
            AddressTextEdit.IsActiveVHText = false;
            AddressTextEdit.Location = new Point(143, 225);
            AddressTextEdit.Margin = new Padding(4);
            AddressTextEdit.Name = "AddressTextEdit";
            AddressTextEdit.Properties.Appearance.BackColor = Color.White;
            AddressTextEdit.Properties.Appearance.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddressTextEdit.Properties.Appearance.Options.UseBackColor = true;
            AddressTextEdit.Properties.Appearance.Options.UseFont = true;
            AddressTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            AddressTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            AddressTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            AddressTextEdit.Properties.AutoHeight = false;
            AddressTextEdit.Size = new Size(250, 83);
            AddressTextEdit.TabIndex = 31;
            // 
            // EmailTextEdit
            // 
            EmailTextEdit.IsActiveVHText = true;
            EmailTextEdit.Location = new Point(143, 170);
            EmailTextEdit.Margin = new Padding(4);
            EmailTextEdit.Name = "EmailTextEdit";
            EmailTextEdit.Properties.Appearance.BackColor = Color.White;
            EmailTextEdit.Properties.Appearance.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EmailTextEdit.Properties.Appearance.Options.UseBackColor = true;
            EmailTextEdit.Properties.Appearance.Options.UseFont = true;
            EmailTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            EmailTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            EmailTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            EmailTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            EmailTextEdit.Properties.AutoHeight = false;
            EmailTextEdit.Size = new Size(250, 40);
            EmailTextEdit.TabIndex = 30;
            // 
            // PhoneTextEdit
            // 
            PhoneTextEdit.IsActiveVHText = true;
            PhoneTextEdit.Location = new Point(143, 122);
            PhoneTextEdit.Margin = new Padding(4);
            PhoneTextEdit.Name = "PhoneTextEdit";
            PhoneTextEdit.Properties.Appearance.BackColor = Color.White;
            PhoneTextEdit.Properties.Appearance.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneTextEdit.Properties.Appearance.Options.UseBackColor = true;
            PhoneTextEdit.Properties.Appearance.Options.UseFont = true;
            PhoneTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            PhoneTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            PhoneTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            PhoneTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            PhoneTextEdit.Properties.AutoHeight = false;
            PhoneTextEdit.Properties.MaxLength = 11;
            PhoneTextEdit.Size = new Size(250, 40);
            PhoneTextEdit.TabIndex = 25;
            // 
            // LastNameTextEdit
            // 
            LastNameTextEdit.IsActiveVHText = true;
            LastNameTextEdit.Location = new Point(143, 70);
            LastNameTextEdit.Margin = new Padding(4);
            LastNameTextEdit.Name = "LastNameTextEdit";
            LastNameTextEdit.Properties.Appearance.BackColor = Color.White;
            LastNameTextEdit.Properties.Appearance.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LastNameTextEdit.Properties.Appearance.Options.UseBackColor = true;
            LastNameTextEdit.Properties.Appearance.Options.UseFont = true;
            LastNameTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            LastNameTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            LastNameTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            LastNameTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            LastNameTextEdit.Properties.AutoHeight = false;
            LastNameTextEdit.Size = new Size(250, 40);
            LastNameTextEdit.TabIndex = 24;
            // 
            // FirstNameTextEdit
            // 
            FirstNameTextEdit.IsActiveVHText = true;
            FirstNameTextEdit.Location = new Point(143, 16);
            FirstNameTextEdit.Margin = new Padding(4);
            FirstNameTextEdit.Name = "FirstNameTextEdit";
            FirstNameTextEdit.Properties.Appearance.BackColor = Color.White;
            FirstNameTextEdit.Properties.Appearance.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FirstNameTextEdit.Properties.Appearance.Options.UseBackColor = true;
            FirstNameTextEdit.Properties.Appearance.Options.UseFont = true;
            FirstNameTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            FirstNameTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            FirstNameTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            FirstNameTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            FirstNameTextEdit.Properties.AutoHeight = false;
            FirstNameTextEdit.Size = new Size(250, 40);
            FirstNameTextEdit.TabIndex = 23;
            // 
            // DescriptionLabelControl
            // 
            DescriptionLabelControl.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DescriptionLabelControl.Appearance.ForeColor = Color.Maroon;
            DescriptionLabelControl.Appearance.Options.UseFont = true;
            DescriptionLabelControl.Appearance.Options.UseForeColor = true;
            DescriptionLabelControl.Appearance.Options.UseTextOptions = true;
            DescriptionLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            DescriptionLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            DescriptionLabelControl.Location = new Point(5, 348);
            DescriptionLabelControl.Margin = new Padding(4);
            DescriptionLabelControl.Name = "DescriptionLabelControl";
            DescriptionLabelControl.Size = new Size(130, 34);
            DescriptionLabelControl.TabIndex = 20;
            DescriptionLabelControl.Text = "Description";
            // 
            // AddressLabelControl
            // 
            AddressLabelControl.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddressLabelControl.Appearance.ForeColor = Color.Maroon;
            AddressLabelControl.Appearance.Options.UseFont = true;
            AddressLabelControl.Appearance.Options.UseForeColor = true;
            AddressLabelControl.Appearance.Options.UseTextOptions = true;
            AddressLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            AddressLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            AddressLabelControl.Location = new Point(5, 248);
            AddressLabelControl.Margin = new Padding(4);
            AddressLabelControl.Name = "AddressLabelControl";
            AddressLabelControl.Size = new Size(130, 35);
            AddressLabelControl.TabIndex = 17;
            AddressLabelControl.Text = "Address";
            // 
            // EmailLabelControl
            // 
            EmailLabelControl.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EmailLabelControl.Appearance.ForeColor = Color.Maroon;
            EmailLabelControl.Appearance.Options.UseFont = true;
            EmailLabelControl.Appearance.Options.UseForeColor = true;
            EmailLabelControl.Appearance.Options.UseTextOptions = true;
            EmailLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            EmailLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            EmailLabelControl.Location = new Point(5, 171);
            EmailLabelControl.Margin = new Padding(4);
            EmailLabelControl.Name = "EmailLabelControl";
            EmailLabelControl.Size = new Size(130, 38);
            EmailLabelControl.TabIndex = 16;
            EmailLabelControl.Text = "Email";
            // 
            // PhoneLabelControl
            // 
            PhoneLabelControl.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneLabelControl.Appearance.ForeColor = Color.Maroon;
            PhoneLabelControl.Appearance.Options.UseFont = true;
            PhoneLabelControl.Appearance.Options.UseForeColor = true;
            PhoneLabelControl.Appearance.Options.UseTextOptions = true;
            PhoneLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            PhoneLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            PhoneLabelControl.Location = new Point(5, 122);
            PhoneLabelControl.Margin = new Padding(4);
            PhoneLabelControl.Name = "PhoneLabelControl";
            PhoneLabelControl.Size = new Size(130, 38);
            PhoneLabelControl.TabIndex = 13;
            PhoneLabelControl.Text = "Phone";
            // 
            // LastNameLabelControl
            // 
            LastNameLabelControl.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LastNameLabelControl.Appearance.ForeColor = Color.Maroon;
            LastNameLabelControl.Appearance.Options.UseFont = true;
            LastNameLabelControl.Appearance.Options.UseForeColor = true;
            LastNameLabelControl.Appearance.Options.UseTextOptions = true;
            LastNameLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            LastNameLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            LastNameLabelControl.Location = new Point(5, 70);
            LastNameLabelControl.Margin = new Padding(4);
            LastNameLabelControl.Name = "LastNameLabelControl";
            LastNameLabelControl.Size = new Size(130, 38);
            LastNameLabelControl.TabIndex = 21;
            LastNameLabelControl.Text = "Last Name";
            // 
            // FirstNameLabelControl
            // 
            FirstNameLabelControl.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FirstNameLabelControl.Appearance.ForeColor = Color.Maroon;
            FirstNameLabelControl.Appearance.Options.UseFont = true;
            FirstNameLabelControl.Appearance.Options.UseForeColor = true;
            FirstNameLabelControl.Appearance.Options.UseTextOptions = true;
            FirstNameLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            FirstNameLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            FirstNameLabelControl.Location = new Point(5, 16);
            FirstNameLabelControl.Margin = new Padding(4);
            FirstNameLabelControl.Name = "FirstNameLabelControl";
            FirstNameLabelControl.Size = new Size(130, 38);
            FirstNameLabelControl.TabIndex = 12;
            FirstNameLabelControl.Text = "First Name";
            // 
            // ConsumerAddOrEditForm
            // 
            Appearance.BackColor = Color.LightGoldenrodYellow;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 507);
            Controls.Add(ActiveCheckEdit);
            Controls.Add(SaveButton);
            Controls.Add(DescriptionTextEdit);
            Controls.Add(AddressTextEdit);
            Controls.Add(EmailTextEdit);
            Controls.Add(PhoneTextEdit);
            Controls.Add(LastNameTextEdit);
            Controls.Add(FirstNameTextEdit);
            Controls.Add(DescriptionLabelControl);
            Controls.Add(AddressLabelControl);
            Controls.Add(EmailLabelControl);
            Controls.Add(PhoneLabelControl);
            Controls.Add(LastNameLabelControl);
            Controls.Add(FirstNameLabelControl);
            Name = "ConsumerAddOrEditForm";
            Text = "ConsumerAddOrEditForm";
            Load += ConsumerAddOrEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)ActiveCheckEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DescriptionTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddressTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhoneTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)FirstNameTextEdit.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Usf.WinForms.Forms.CheckEdit ActiveCheckEdit;
        private Usf.WinForms.Forms.ButtonSimlpe SaveButton;
        private Usf.WinForms.Forms.TextEdit DescriptionTextEdit;
        private Usf.WinForms.Forms.TextEdit AddressTextEdit;
        private Usf.WinForms.Forms.TextEdit EmailTextEdit;
        private Usf.WinForms.Forms.TextEdit PhoneTextEdit;
        private Usf.WinForms.Forms.TextEdit LastNameTextEdit;
        private Usf.WinForms.Forms.TextEdit FirstNameTextEdit;
        private Usf.WinForms.Forms.LabelControl DescriptionLabelControl;
        private Usf.WinForms.Forms.LabelControl AddressLabelControl;
        private Usf.WinForms.Forms.LabelControl EmailLabelControl;
        private Usf.WinForms.Forms.LabelControl PhoneLabelControl;
        private Usf.WinForms.Forms.LabelControl LastNameLabelControl;
        private Usf.WinForms.Forms.LabelControl FirstNameLabelControl;
    }
}
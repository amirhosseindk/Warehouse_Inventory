namespace MyApplication
{
    partial class UsersForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            UserDataGridView = new DataGridView();
            UserStartDate = new DataGridViewTextBoxColumn();
            UserID = new DataGridViewTextBoxColumn();
            UserFirstName = new DataGridViewTextBoxColumn();
            UserLastName = new DataGridViewTextBoxColumn();
            UserTel = new DataGridViewTextBoxColumn();
            UserUsername = new DataGridViewTextBoxColumn();
            UserPassword = new DataGridViewTextBoxColumn();
            UserAge = new DataGridViewTextBoxColumn();
            UserGender = new DataGridViewTextBoxColumn();
            UserBirthdate = new DataGridViewTextBoxColumn();
            UserEndDate = new DataGridViewTextBoxColumn();
            UserActive = new DataGridViewTextBoxColumn();
            UserDescription = new DataGridViewTextBoxColumn();
            SearchLabel = new Usf.WinForms.Forms.Label();
            SearchTextBox = new Usf.WinForms.Forms.TextBox();
            UserNewButton = new Usf.WinForms.Forms.Button();
            UserEditButton = new Usf.WinForms.Forms.Button();
            UserStatusButton = new Usf.WinForms.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).BeginInit();
            SuspendLayout();
            // 
            // UserDataGridView
            // 
            UserDataGridView.AllowUserToAddRows = false;
            UserDataGridView.AllowUserToDeleteRows = false;
            UserDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserDataGridView.BackgroundColor = Color.LemonChiffon;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UserDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGridView.Columns.AddRange(new DataGridViewColumn[] { UserStartDate, UserID, UserFirstName, UserLastName, UserTel, UserUsername, UserPassword, UserAge, UserGender, UserBirthdate, UserEndDate, UserActive, UserDescription });
            UserDataGridView.Location = new Point(13, 48);
            UserDataGridView.Margin = new Padding(4);
            UserDataGridView.Name = "UserDataGridView";
            UserDataGridView.ReadOnly = true;
            UserDataGridView.RowTemplate.Height = 25;
            UserDataGridView.Size = new Size(1293, 531);
            UserDataGridView.TabIndex = 1;
            // 
            // UserStartDate
            // 
            UserStartDate.HeaderText = "Start Date";
            UserStartDate.Name = "UserStartDate";
            UserStartDate.ReadOnly = true;
            UserStartDate.Width = 150;
            // 
            // UserID
            // 
            UserID.HeaderText = "User ID";
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            UserID.Visible = false;
            UserID.Width = 150;
            // 
            // UserFirstName
            // 
            UserFirstName.HeaderText = "First Name";
            UserFirstName.Name = "UserFirstName";
            UserFirstName.ReadOnly = true;
            UserFirstName.Width = 150;
            // 
            // UserLastName
            // 
            UserLastName.HeaderText = "Last Name";
            UserLastName.Name = "UserLastName";
            UserLastName.ReadOnly = true;
            UserLastName.Width = 150;
            // 
            // UserTel
            // 
            UserTel.HeaderText = "User Tel";
            UserTel.Name = "UserTel";
            UserTel.ReadOnly = true;
            UserTel.Width = 130;
            // 
            // UserUsername
            // 
            UserUsername.HeaderText = "User Name";
            UserUsername.Name = "UserUsername";
            UserUsername.ReadOnly = true;
            UserUsername.Width = 130;
            // 
            // UserPassword
            // 
            UserPassword.HeaderText = "Password";
            UserPassword.Name = "UserPassword";
            UserPassword.ReadOnly = true;
            // 
            // UserAge
            // 
            UserAge.HeaderText = "Age";
            UserAge.Name = "UserAge";
            UserAge.ReadOnly = true;
            UserAge.Width = 80;
            // 
            // UserGender
            // 
            UserGender.HeaderText = "Gender";
            UserGender.Name = "UserGender";
            UserGender.ReadOnly = true;
            UserGender.Width = 80;
            // 
            // UserBirthdate
            // 
            UserBirthdate.HeaderText = "Birthdate";
            UserBirthdate.Name = "UserBirthdate";
            UserBirthdate.ReadOnly = true;
            UserBirthdate.Width = 150;
            // 
            // UserEndDate
            // 
            UserEndDate.HeaderText = "End Date";
            UserEndDate.Name = "UserEndDate";
            UserEndDate.ReadOnly = true;
            UserEndDate.Width = 150;
            // 
            // UserActive
            // 
            UserActive.HeaderText = "Status";
            UserActive.Name = "UserActive";
            UserActive.ReadOnly = true;
            UserActive.Width = 80;
            // 
            // UserDescription
            // 
            UserDescription.HeaderText = "Description";
            UserDescription.Name = "UserDescription";
            UserDescription.ReadOnly = true;
            UserDescription.Width = 500;
            // 
            // SearchLabel
            // 
            SearchLabel.Appearance.Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchLabel.Appearance.ForeColor = Color.Blue;
            SearchLabel.Appearance.Options.UseFont = true;
            SearchLabel.Appearance.Options.UseForeColor = true;
            SearchLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            SearchLabel.Location = new Point(383, 11);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(64, 30);
            SearchLabel.TabIndex = 5;
            SearchLabel.Text = "label1";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top;
            SearchTextBox.BackColor = Color.LemonChiffon;
            SearchTextBox.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchTextBox.Location = new Point(450, 4);
            SearchTextBox.Margin = new Padding(4);
            SearchTextBox.Multiline = true;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(481, 42);
            SearchTextBox.TabIndex = 4;
            SearchTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // UserNewButton
            // 
            UserNewButton.Anchor = AnchorStyles.Bottom;
            UserNewButton.Appearance.BackColor = Color.Pink;
            UserNewButton.Appearance.Font = new Font("IRANYekan Medium", 15F, FontStyle.Bold, GraphicsUnit.Point);
            UserNewButton.Appearance.Options.UseBackColor = true;
            UserNewButton.Appearance.Options.UseFont = true;
            UserNewButton.Location = new Point(38, 585);
            UserNewButton.Margin = new Padding(4);
            UserNewButton.Name = "UserNewButton";
            UserNewButton.Size = new Size(274, 64);
            UserNewButton.TabIndex = 9;
            UserNewButton.Text = "Add";
            // 
            // UserEditButton
            // 
            UserEditButton.Anchor = AnchorStyles.Bottom;
            UserEditButton.Appearance.BackColor = Color.Pink;
            UserEditButton.Appearance.Font = new Font("IRANYekan Medium", 15F, FontStyle.Bold, GraphicsUnit.Point);
            UserEditButton.Appearance.Options.UseBackColor = true;
            UserEditButton.Appearance.Options.UseFont = true;
            UserEditButton.Location = new Point(532, 585);
            UserEditButton.Margin = new Padding(4);
            UserEditButton.Name = "UserEditButton";
            UserEditButton.Size = new Size(274, 64);
            UserEditButton.TabIndex = 10;
            UserEditButton.Text = "Edit";
            // 
            // UserStatusButton
            // 
            UserStatusButton.Anchor = AnchorStyles.Bottom;
            UserStatusButton.Appearance.BackColor = Color.Pink;
            UserStatusButton.Appearance.Font = new Font("IRANYekan Medium", 15F, FontStyle.Bold, GraphicsUnit.Point);
            UserStatusButton.Appearance.Options.UseBackColor = true;
            UserStatusButton.Appearance.Options.UseFont = true;
            UserStatusButton.Location = new Point(1012, 585);
            UserStatusButton.Margin = new Padding(4);
            UserStatusButton.Name = "UserStatusButton";
            UserStatusButton.Size = new Size(274, 64);
            UserStatusButton.TabIndex = 11;
            UserStatusButton.Text = "Active/DeActive";
            // 
            // UsersForm
            // 
            Appearance.BackColor = Color.Aquamarine;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 654);
            Controls.Add(UserNewButton);
            Controls.Add(UserEditButton);
            Controls.Add(UserStatusButton);
            Controls.Add(SearchLabel);
            Controls.Add(SearchTextBox);
            Controls.Add(UserDataGridView);
            Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(8);
            Name = "UsersForm";
            Text = "UsersForm";
            Load += UsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UserDataGridView;
        private Usf.WinForms.Forms.Label SearchLabel;
        private Usf.WinForms.Forms.TextBox SearchTextBox;
        private Usf.WinForms.Forms.Button UserNewButton;
        private Usf.WinForms.Forms.Button UserEditButton;
        private Usf.WinForms.Forms.Button UserStatusButton;
        private DataGridViewTextBoxColumn UserStartDate;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserFirstName;
        private DataGridViewTextBoxColumn UserLastName;
        private DataGridViewTextBoxColumn UserTel;
        private DataGridViewTextBoxColumn UserUsername;
        private DataGridViewTextBoxColumn UserPassword;
        private DataGridViewTextBoxColumn UserAge;
        private DataGridViewTextBoxColumn UserGender;
        private DataGridViewTextBoxColumn UserBirthdate;
        private DataGridViewTextBoxColumn UserEndDate;
        private DataGridViewTextBoxColumn UserActive;
        private DataGridViewTextBoxColumn UserDescription;
    }
}
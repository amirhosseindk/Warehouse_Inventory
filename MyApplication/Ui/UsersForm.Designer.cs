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
            components = new System.ComponentModel.Container();
            SearchLabel = new Usf.WinForms.Forms.Label();
            SearchTextBox = new Usf.WinForms.Forms.TextBox();
            UserNewButton = new Usf.WinForms.Forms.Button();
            UserEditButton = new Usf.WinForms.Forms.Button();
            UserStatusButton = new Usf.WinForms.Forms.Button();
            UserDataGridView = new Usf.WinForms.Forms.DataGridView();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isActiveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            byUsernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // SearchLabel
            // 
            SearchLabel.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            SearchTextBox.Location = new Point(633, 4);
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
            UserNewButton.Appearance.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            UserNewButton.Appearance.Options.UseBackColor = true;
            UserNewButton.Appearance.Options.UseFont = true;
            UserNewButton.Location = new Point(221, 585);
            UserNewButton.Margin = new Padding(4);
            UserNewButton.Name = "UserNewButton";
            UserNewButton.Size = new Size(274, 64);
            UserNewButton.TabIndex = 9;
            UserNewButton.Text = "Add";
            UserNewButton.Click += UserNewButton_Click;
            // 
            // UserEditButton
            // 
            UserEditButton.Anchor = AnchorStyles.Bottom;
            UserEditButton.Appearance.BackColor = Color.Pink;
            UserEditButton.Appearance.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            UserEditButton.Appearance.Options.UseBackColor = true;
            UserEditButton.Appearance.Options.UseFont = true;
            UserEditButton.Location = new Point(715, 585);
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
            UserStatusButton.Appearance.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            UserStatusButton.Appearance.Options.UseBackColor = true;
            UserStatusButton.Appearance.Options.UseFont = true;
            UserStatusButton.Location = new Point(1195, 585);
            UserStatusButton.Margin = new Padding(4);
            UserStatusButton.Name = "UserStatusButton";
            UserStatusButton.Size = new Size(274, 64);
            UserStatusButton.TabIndex = 11;
            UserStatusButton.Text = "Active/DeActive";
            // 
            // UserDataGridView
            // 
            UserDataGridView.AllowUserToAddRows = false;
            UserDataGridView.AllowUserToDeleteRows = false;
            UserDataGridView.AutoGenerateColumns = false;
            UserDataGridView.BackgroundColor = Color.MistyRose;
            UserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGridView.Columns.AddRange(new DataGridViewColumn[] { userIdDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn, isActiveDataGridViewCheckBoxColumn, byUsernameDataGridViewTextBoxColumn });
            UserDataGridView.DataSource = userBindingSource;
            UserDataGridView.Location = new Point(25, 101);
            UserDataGridView.Name = "UserDataGridView";
            UserDataGridView.ReadOnly = true;
            UserDataGridView.RowHeadersWidth = 51;
            UserDataGridView.RowTemplate.Height = 29;
            UserDataGridView.Size = new Size(1591, 405);
            UserDataGridView.TabIndex = 12;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.ReadOnly = true;
            userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.ReadOnly = true;
            roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            isDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
            isDeletedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            isDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            isDeletedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            isActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            isActiveDataGridViewCheckBoxColumn.Width = 125;
            // 
            // byUsernameDataGridViewTextBoxColumn
            // 
            byUsernameDataGridViewTextBoxColumn.DataPropertyName = "ByUsername";
            byUsernameDataGridViewTextBoxColumn.HeaderText = "ByUsername";
            byUsernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            byUsernameDataGridViewTextBoxColumn.Name = "byUsernameDataGridViewTextBoxColumn";
            byUsernameDataGridViewTextBoxColumn.ReadOnly = true;
            byUsernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Domain.Entities.User);
            // 
            // UsersForm
            // 
            Appearance.BackColor = Color.Aquamarine;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1684, 654);
            Controls.Add(UserDataGridView);
            Controls.Add(UserNewButton);
            Controls.Add(UserEditButton);
            Controls.Add(UserStatusButton);
            Controls.Add(SearchLabel);
            Controls.Add(SearchTextBox);
            Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(8);
            Name = "UsersForm";
            Text = "UsersForm";
            Load += UsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Usf.WinForms.Forms.Label SearchLabel;
        private Usf.WinForms.Forms.TextBox SearchTextBox;
        private Usf.WinForms.Forms.Button UserNewButton;
        private Usf.WinForms.Forms.Button UserEditButton;
        private Usf.WinForms.Forms.Button UserStatusButton;
        private Usf.WinForms.Forms.DataGridView UserDataGridView;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn byUsernameDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
    }
}
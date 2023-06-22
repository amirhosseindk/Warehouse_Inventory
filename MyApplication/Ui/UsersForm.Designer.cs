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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            SearchLabel = new Usf.WinForms.Forms.Label();
            SearchTextBox = new Usf.WinForms.Forms.TextBox();
            UserNewButton = new Usf.WinForms.Forms.Button();
            UserEditButton = new Usf.WinForms.Forms.Button();
            DeleteButton = new Usf.WinForms.Forms.Button();
            userBindingSource = new BindingSource(components);
            Description = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Birthdate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            UserTel = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewTextBoxColumn();
            UserDataGridView = new Usf.WinForms.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SearchLabel
            // 
            SearchLabel.Appearance.Font = (Font)resources.GetObject("SearchLabel.Appearance.Font");
            SearchLabel.Appearance.ForeColor = (Color)resources.GetObject("SearchLabel.Appearance.ForeColor");
            SearchLabel.Appearance.Options.UseFont = true;
            SearchLabel.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(SearchLabel, "SearchLabel");
            SearchLabel.Name = "SearchLabel";
            // 
            // SearchTextBox
            // 
            resources.ApplyResources(SearchTextBox, "SearchTextBox");
            SearchTextBox.BackColor = Color.LemonChiffon;
            SearchTextBox.Name = "SearchTextBox";
            // 
            // UserNewButton
            // 
            resources.ApplyResources(UserNewButton, "UserNewButton");
            UserNewButton.Appearance.BackColor = (Color)resources.GetObject("UserNewButton.Appearance.BackColor");
            UserNewButton.Appearance.Font = (Font)resources.GetObject("UserNewButton.Appearance.Font");
            UserNewButton.Appearance.ForeColor = (Color)resources.GetObject("UserNewButton.Appearance.ForeColor");
            UserNewButton.Appearance.Options.UseBackColor = true;
            UserNewButton.Appearance.Options.UseFont = true;
            UserNewButton.Appearance.Options.UseForeColor = true;
            UserNewButton.Name = "UserNewButton";
            UserNewButton.Click += UserNewButton_Click;
            // 
            // UserEditButton
            // 
            resources.ApplyResources(UserEditButton, "UserEditButton");
            UserEditButton.Appearance.BackColor = (Color)resources.GetObject("UserEditButton.Appearance.BackColor");
            UserEditButton.Appearance.Font = (Font)resources.GetObject("UserEditButton.Appearance.Font");
            UserEditButton.Appearance.Options.UseBackColor = true;
            UserEditButton.Appearance.Options.UseFont = true;
            UserEditButton.Name = "UserEditButton";
            UserEditButton.Click += UserEditButton_Click;
            // 
            // DeleteButton
            // 
            resources.ApplyResources(DeleteButton, "DeleteButton");
            DeleteButton.Appearance.BackColor = (Color)resources.GetObject("StatusButton.Appearance.BackColor");
            DeleteButton.Appearance.Font = (Font)resources.GetObject("StatusButton.Appearance.Font");
            DeleteButton.Appearance.Options.UseBackColor = true;
            DeleteButton.Appearance.Options.UseFont = true;
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Click += DeleteButton_Click;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Domain.Entities.User);
            // 
            // Description
            // 
            Description.DataPropertyName = "UserIdForm";
            resources.ApplyResources(Description, "Description");
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            resources.ApplyResources(Address, "Address");
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            resources.ApplyResources(Email, "Email");
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Birthdate
            // 
            Birthdate.DataPropertyName = "UserIdForm";
            resources.ApplyResources(Birthdate, "Birthdate");
            Birthdate.Name = "Birthdate";
            Birthdate.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "UserIdForm";
            resources.ApplyResources(Status, "Status");
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Role
            // 
            Role.DataPropertyName = "Role";
            resources.ApplyResources(Role, "Role");
            Role.Name = "Role";
            Role.ReadOnly = true;
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            resources.ApplyResources(Password, "Password");
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            resources.ApplyResources(Username, "Username");
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // UserTel
            // 
            UserTel.DataPropertyName = "PhoneNumber";
            resources.ApplyResources(UserTel, "UserTel");
            UserTel.Name = "UserTel";
            UserTel.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            resources.ApplyResources(LastName, "LastName");
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            resources.ApplyResources(FirstName, "FirstName");
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // UserIdForm
            // 
            UserId.DataPropertyName = "UserIdForm";
            resources.ApplyResources(UserId, "UserIdForm");
            UserId.Name = "UserIdForm";
            UserId.ReadOnly = true;
            // 
            // UserDataGridView
            // 
            UserDataGridView.AllowUserToAddRows = false;
            UserDataGridView.AllowUserToDeleteRows = false;
            UserDataGridView.AutoGenerateColumns = false;
            UserDataGridView.BackgroundColor = Color.MistyRose;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            UserDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            UserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGridView.Columns.AddRange(new DataGridViewColumn[] { UserId, FirstName, LastName, UserTel, Username, Password, Role, Status, Birthdate, Email, Address, Description });
            UserDataGridView.DataSource = userBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            UserDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(UserDataGridView, "UserDataGridView");
            UserDataGridView.Name = "UserDataGridView";
            UserDataGridView.ReadOnly = true;
            UserDataGridView.RowTemplate.Height = 29;
            // 
            // UsersForm
            // 
            Appearance.BackColor = (Color)resources.GetObject("UsersForm.Appearance.BackColor");
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UserDataGridView);
            Controls.Add(UserNewButton);
            Controls.Add(UserEditButton);
            Controls.Add(DeleteButton);
            Controls.Add(SearchLabel);
            Controls.Add(SearchTextBox);
            Name = "UsersForm";
            Load += UsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Usf.WinForms.Forms.Label SearchLabel;
        private Usf.WinForms.Forms.TextBox SearchTextBox;
        private Usf.WinForms.Forms.Button UserNewButton;
        private Usf.WinForms.Forms.Button UserEditButton;
        private Usf.WinForms.Forms.Button DeleteButton;
        private DataGridViewTextBoxColumn byUsernameDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Birthdate;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn UserTel;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn UserId;
        private Usf.WinForms.Forms.DataGridView UserDataGridView;
    }
}
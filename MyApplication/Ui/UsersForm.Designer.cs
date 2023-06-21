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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            SearchLabel = new Usf.WinForms.Forms.Label();
            SearchTextBox = new Usf.WinForms.Forms.TextBox();
            UserNewButton = new Usf.WinForms.Forms.Button();
            UserEditButton = new Usf.WinForms.Forms.Button();
            StatusButton = new Usf.WinForms.Forms.Button();
            UserDataGridView = new Usf.WinForms.Forms.DataGridView();
            UserId = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            UserTel = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Birthdate = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
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
            // StatusButton
            // 
            resources.ApplyResources(StatusButton, "StatusButton");
            StatusButton.Appearance.BackColor = (Color)resources.GetObject("StatusButton.Appearance.BackColor");
            StatusButton.Appearance.Font = (Font)resources.GetObject("StatusButton.Appearance.Font");
            StatusButton.Appearance.Options.UseBackColor = true;
            StatusButton.Appearance.Options.UseFont = true;
            StatusButton.Name = "StatusButton";
            // 
            // UserDataGridView
            // 
            UserDataGridView.AllowUserToAddRows = false;
            UserDataGridView.AllowUserToDeleteRows = false;
            UserDataGridView.AutoGenerateColumns = false;
            UserDataGridView.BackgroundColor = Color.MistyRose;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UserDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGridView.Columns.AddRange(new DataGridViewColumn[] { UserId, FirstName, LastName, UserTel, Username, Password, Role, Status, Birthdate, Email, Address, Description });
            UserDataGridView.DataSource = userBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            UserDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(UserDataGridView, "UserDataGridView");
            UserDataGridView.Name = "UserDataGridView";
            UserDataGridView.ReadOnly = true;
            UserDataGridView.RowTemplate.Height = 29;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            resources.ApplyResources(UserId, "UserId");
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            resources.ApplyResources(FirstName, "FirstName");
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            resources.ApplyResources(LastName, "LastName");
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // UserTel
            // 
            UserTel.DataPropertyName = "PhoneNumber";
            resources.ApplyResources(UserTel, "UserTel");
            UserTel.Name = "UserTel";
            UserTel.ReadOnly = true;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            resources.ApplyResources(Username, "Username");
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            resources.ApplyResources(Password, "Password");
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // Role
            // 
            Role.DataPropertyName = "Role";
            resources.ApplyResources(Role, "Role");
            Role.Name = "Role";
            Role.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "UserId";
            resources.ApplyResources(Status, "Status");
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Birthdate
            // 
            Birthdate.DataPropertyName = "UserId";
            resources.ApplyResources(Birthdate, "Birthdate");
            Birthdate.Name = "Birthdate";
            Birthdate.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            resources.ApplyResources(Email, "Email");
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            resources.ApplyResources(Address, "Address");
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // Description
            // 
            Description.DataPropertyName = "UserId";
            resources.ApplyResources(Description, "Description");
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Domain.Entities.User);
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
            Controls.Add(StatusButton);
            Controls.Add(SearchLabel);
            Controls.Add(SearchTextBox);
            Name = "UsersForm";
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
        private Usf.WinForms.Forms.Button StatusButton;
        private Usf.WinForms.Forms.DataGridView UserDataGridView;
        private DataGridViewTextBoxColumn byUsernameDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn UserTel;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Birthdate;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Description;
    }
}
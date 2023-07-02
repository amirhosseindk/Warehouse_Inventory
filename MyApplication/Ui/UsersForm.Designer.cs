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
            UserNewButton = new Usf.WinForms.Forms.ButtonSimlpe();
            UserEditButton = new Usf.WinForms.Forms.ButtonSimlpe();
            UserDeleteButton = new Usf.WinForms.Forms.ButtonSimlpe();
            UserGridControl = new DevExpress.XtraGrid.GridControl();
            userVMRBindingSource = new BindingSource(components);
            UserGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            colBirthdate = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            ((System.ComponentModel.ISupportInitialize)UserGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userVMRBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1.Panel1).BeginInit();
            gridSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1.Panel2).BeginInit();
            gridSplitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // UserNewButton
            // 
            resources.ApplyResources(UserNewButton, "UserNewButton");
            UserNewButton.Appearance.BackColor = (Color)resources.GetObject("UserNewButton.Appearance.BackColor");
            UserNewButton.Appearance.BorderColor = (Color)resources.GetObject("UserNewButton.Appearance.BorderColor");
            UserNewButton.Appearance.Font = (Font)resources.GetObject("UserNewButton.Appearance.Font");
            UserNewButton.Appearance.ForeColor = (Color)resources.GetObject("UserNewButton.Appearance.ForeColor");
            UserNewButton.Appearance.Options.UseBackColor = true;
            UserNewButton.Appearance.Options.UseBorderColor = true;
            UserNewButton.Appearance.Options.UseFont = true;
            UserNewButton.Appearance.Options.UseForeColor = true;
            UserNewButton.Name = "UserNewButton";
            UserNewButton.Click += UserNewButton_Click;
            // 
            // UserEditButton
            // 
            resources.ApplyResources(UserEditButton, "UserEditButton");
            UserEditButton.Appearance.BackColor = (Color)resources.GetObject("UserEditButton.Appearance.BackColor");
            UserEditButton.Appearance.BorderColor = (Color)resources.GetObject("UserEditButton.Appearance.BorderColor");
            UserEditButton.Appearance.Font = (Font)resources.GetObject("UserEditButton.Appearance.Font");
            UserEditButton.Appearance.ForeColor = (Color)resources.GetObject("UserEditButton.Appearance.ForeColor");
            UserEditButton.Appearance.Options.UseBackColor = true;
            UserEditButton.Appearance.Options.UseBorderColor = true;
            UserEditButton.Appearance.Options.UseFont = true;
            UserEditButton.Appearance.Options.UseForeColor = true;
            UserEditButton.Name = "UserEditButton";
            UserEditButton.Click += UserEditButton_Click;
            // 
            // UserDeleteButton
            // 
            resources.ApplyResources(UserDeleteButton, "UserDeleteButton");
            UserDeleteButton.Appearance.BackColor = (Color)resources.GetObject("UserDeleteButton.Appearance.BackColor");
            UserDeleteButton.Appearance.BorderColor = (Color)resources.GetObject("UserDeleteButton.Appearance.BorderColor");
            UserDeleteButton.Appearance.Font = (Font)resources.GetObject("UserDeleteButton.Appearance.Font");
            UserDeleteButton.Appearance.ForeColor = (Color)resources.GetObject("UserDeleteButton.Appearance.ForeColor");
            UserDeleteButton.Appearance.Options.UseBackColor = true;
            UserDeleteButton.Appearance.Options.UseBorderColor = true;
            UserDeleteButton.Appearance.Options.UseFont = true;
            UserDeleteButton.Appearance.Options.UseForeColor = true;
            UserDeleteButton.Name = "UserDeleteButton";
            UserDeleteButton.Click += DeleteButton_Click;
            // 
            // UserGridControl
            // 
            UserGridControl.DataSource = userVMRBindingSource;
            resources.ApplyResources(UserGridControl, "UserGridControl");
            UserGridControl.MainView = UserGridView;
            UserGridControl.Name = "UserGridControl";
            UserGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { UserGridView });
            // 
            // userVMRBindingSource
            // 
            userVMRBindingSource.DataSource = typeof(Application.ViewModels.UserViewModels.UserVMR);
            // 
            // UserGridView
            // 
            UserGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colFirstName, colLastName, colRole, colUsername, colBirthdate, colEmail, colAddress, colPhoneNumber, colDescription, colIsActive });
            UserGridView.GridControl = UserGridControl;
            UserGridView.Name = "UserGridView";
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.MinWidth = 25;
            colId.Name = "colId";
            colId.OptionsColumn.AllowEdit = false;
            resources.ApplyResources(colId, "colId");
            // 
            // colFirstName
            // 
            colFirstName.FieldName = "FirstName";
            colFirstName.MinWidth = 25;
            colFirstName.Name = "colFirstName";
            colFirstName.OptionsColumn.AllowEdit = false;
            resources.ApplyResources(colFirstName, "colFirstName");
            // 
            // colLastName
            // 
            colLastName.FieldName = "LastName";
            colLastName.MinWidth = 25;
            colLastName.Name = "colLastName";
            colLastName.OptionsColumn.AllowEdit = false;
            resources.ApplyResources(colLastName, "colLastName");
            // 
            // colRole
            // 
            colRole.FieldName = "Role";
            colRole.MinWidth = 25;
            colRole.Name = "colRole";
            colRole.OptionsColumn.AllowEdit = false;
            resources.ApplyResources(colRole, "colRole");
            // 
            // colUsername
            // 
            colUsername.FieldName = "Username";
            colUsername.MinWidth = 25;
            colUsername.Name = "colUsername";
            colUsername.OptionsColumn.AllowEdit = false;
            resources.ApplyResources(colUsername, "colUsername");
            // 
            // colBirthdate
            // 
            colBirthdate.FieldName = "Birthdate";
            colBirthdate.MinWidth = 25;
            colBirthdate.Name = "colBirthdate";
            colBirthdate.OptionsColumn.AllowEdit = false;
            resources.ApplyResources(colBirthdate, "colBirthdate");
            // 
            // colEmail
            // 
            colEmail.FieldName = "Email";
            colEmail.MinWidth = 25;
            colEmail.Name = "colEmail";
            colEmail.OptionsColumn.AllowEdit = false;
            resources.ApplyResources(colEmail, "colEmail");
            // 
            // colAddress
            // 
            colAddress.FieldName = "Address";
            colAddress.MinWidth = 25;
            colAddress.Name = "colAddress";
            colAddress.OptionsColumn.AllowEdit = false;
            resources.ApplyResources(colAddress, "colAddress");
            // 
            // colPhoneNumber
            // 
            colPhoneNumber.FieldName = "PhoneNumber";
            colPhoneNumber.MinWidth = 25;
            colPhoneNumber.Name = "colPhoneNumber";
            colPhoneNumber.OptionsColumn.AllowEdit = false;
            resources.ApplyResources(colPhoneNumber, "colPhoneNumber");
            // 
            // colDescription
            // 
            colDescription.FieldName = "Description";
            colDescription.MinWidth = 25;
            colDescription.Name = "colDescription";
            colDescription.OptionsColumn.AllowEdit = false;
            resources.ApplyResources(colDescription, "colDescription");
            // 
            // colIsActive
            // 
            colIsActive.FieldName = "IsActive";
            colIsActive.MinWidth = 25;
            colIsActive.Name = "colIsActive";
            colIsActive.OptionsColumn.AllowEdit = false;
            resources.ApplyResources(colIsActive, "colIsActive");
            // 
            // gridSplitContainer1
            // 
            gridSplitContainer1.Grid = UserGridControl;
            resources.ApplyResources(gridSplitContainer1, "gridSplitContainer1");
            gridSplitContainer1.Name = "gridSplitContainer1";
            // 
            // gridSplitContainer1.Panel1
            // 
            gridSplitContainer1.Panel1.Controls.Add(UserGridControl);
            // 
            // UsersForm
            // 
            Appearance.BackColor = (Color)resources.GetObject("UsersForm.Appearance.BackColor");
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridSplitContainer1);
            Controls.Add(UserDeleteButton);
            Controls.Add(UserEditButton);
            Controls.Add(UserNewButton);
            Name = "UsersForm";
            Load += UsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)UserGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)userVMRBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1.Panel1).EndInit();
            gridSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1.Panel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1).EndInit();
            gridSplitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Usf.WinForms.Forms.Button DeleteButton;
        private DataGridViewTextBoxColumn byUsernameDataGridViewTextBoxColumn;
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
        private Usf.WinForms.Forms.ButtonSimlpe UserNewButton;
        private Usf.WinForms.Forms.ButtonSimlpe UserEditButton;
        private Usf.WinForms.Forms.ButtonSimlpe UserDeleteButton;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.GridControl UserGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView UserGridView;
        private BindingSource userVMRBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthdate;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
    }
}
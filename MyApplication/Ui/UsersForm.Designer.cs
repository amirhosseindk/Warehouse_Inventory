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
            userBindingSource = new BindingSource(components);
            UserGridControl = new DevExpress.XtraGrid.GridControl();
            UserGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            colBirthdate = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            colInsertDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            colUsernameId = new DevExpress.XtraGrid.Columns.GridColumn();
            SearchLabel = new Usf.WinForms.Forms.LabelControl();
            SearchTextBox = new Usf.WinForms.Forms.TextEdit();
            UserNewButton = new Usf.WinForms.Forms.ButtonSimlpe();
            UserEditButton = new Usf.WinForms.Forms.ButtonSimlpe();
            UserDeleteButton = new Usf.WinForms.Forms.ButtonSimlpe();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchTextBox.Properties).BeginInit();
            SuspendLayout();
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Domain.Entities.User);
            // 
            // UserGridControl
            // 
            resources.ApplyResources(UserGridControl, "UserGridControl");
            UserGridControl.DataSource = userBindingSource;
            UserGridControl.EmbeddedNavigator.Margin = (Padding)resources.GetObject("UserGridControl.EmbeddedNavigator.Margin");
            UserGridControl.MainView = UserGridView;
            UserGridControl.Name = "UserGridControl";
            UserGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { UserGridView });
            // 
            // UserGridView
            // 
            UserGridView.Appearance.EvenRow.BackColor = (Color)resources.GetObject("UserGridView.Appearance.EvenRow.BackColor");
            UserGridView.Appearance.EvenRow.Options.UseBackColor = true;
            UserGridView.Appearance.HeaderPanel.BackColor = (Color)resources.GetObject("UserGridView.Appearance.HeaderPanel.BackColor");
            UserGridView.Appearance.HeaderPanel.Font = (Font)resources.GetObject("UserGridView.Appearance.HeaderPanel.Font");
            UserGridView.Appearance.HeaderPanel.ForeColor = (Color)resources.GetObject("UserGridView.Appearance.HeaderPanel.ForeColor");
            UserGridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            UserGridView.Appearance.HeaderPanel.Options.UseFont = true;
            UserGridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            UserGridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            UserGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            UserGridView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            UserGridView.Appearance.Row.BackColor = (Color)resources.GetObject("UserGridView.Appearance.Row.BackColor");
            UserGridView.Appearance.Row.Font = (Font)resources.GetObject("UserGridView.Appearance.Row.Font");
            UserGridView.Appearance.Row.Options.UseBackColor = true;
            UserGridView.Appearance.Row.Options.UseFont = true;
            UserGridView.Appearance.Row.Options.UseTextOptions = true;
            UserGridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            UserGridView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            UserGridView.Appearance.SelectedRow.BackColor = (Color)resources.GetObject("UserGridView.Appearance.SelectedRow.BackColor");
            UserGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            UserGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colUserId, colFirstName, colLastName, Phone, colUsername, colEmail, colAddress, colRole, colBirthdate, colDescription, colInsertDateTime, colIsActive, colUsernameId });
            UserGridView.DetailHeight = 408;
            UserGridView.GridControl = UserGridControl;
            UserGridView.Name = "UserGridView";
            UserGridView.OptionsBehavior.Editable = false;
            UserGridView.OptionsView.ColumnAutoWidth = false;
            UserGridView.OptionsView.EnableAppearanceEvenRow = true;
            UserGridView.OptionsView.ShowGroupPanel = false;
            UserGridView.OptionsView.ShowIndicator = false;
            UserGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colRole, DevExpress.Data.ColumnSortOrder.Ascending) });
            // 
            // colUserId
            // 
            colUserId.FieldName = "UserId";
            colUserId.MinWidth = 18;
            colUserId.Name = "colUserId";
            resources.ApplyResources(colUserId, "colUserId");
            // 
            // colFirstName
            // 
            colFirstName.FieldName = "FirstName";
            colFirstName.MinWidth = 18;
            colFirstName.Name = "colFirstName";
            resources.ApplyResources(colFirstName, "colFirstName");
            // 
            // colLastName
            // 
            colLastName.FieldName = "LastName";
            colLastName.MinWidth = 18;
            colLastName.Name = "colLastName";
            resources.ApplyResources(colLastName, "colLastName");
            // 
            // Phone
            // 
            Phone.FieldName = "PhoneNumber";
            Phone.Name = "Phone";
            resources.ApplyResources(Phone, "Phone");
            // 
            // colUsername
            // 
            colUsername.FieldName = "Username";
            colUsername.MinWidth = 18;
            colUsername.Name = "colUsername";
            resources.ApplyResources(colUsername, "colUsername");
            // 
            // colEmail
            // 
            colEmail.FieldName = "Email";
            colEmail.MinWidth = 18;
            colEmail.Name = "colEmail";
            resources.ApplyResources(colEmail, "colEmail");
            // 
            // colAddress
            // 
            colAddress.FieldName = "Address";
            colAddress.MinWidth = 18;
            colAddress.Name = "colAddress";
            resources.ApplyResources(colAddress, "colAddress");
            // 
            // colRole
            // 
            colRole.FieldName = "Role";
            colRole.MinWidth = 18;
            colRole.Name = "colRole";
            resources.ApplyResources(colRole, "colRole");
            // 
            // colBirthdate
            // 
            colBirthdate.FieldName = "Birthdate";
            colBirthdate.MinWidth = 18;
            colBirthdate.Name = "colBirthdate";
            resources.ApplyResources(colBirthdate, "colBirthdate");
            // 
            // colDescription
            // 
            colDescription.FieldName = "Description";
            colDescription.MinWidth = 18;
            colDescription.Name = "colDescription";
            resources.ApplyResources(colDescription, "colDescription");
            // 
            // colInsertDateTime
            // 
            colInsertDateTime.FieldName = "CreatedAt";
            colInsertDateTime.MinWidth = 18;
            colInsertDateTime.Name = "colInsertDateTime";
            resources.ApplyResources(colInsertDateTime, "colInsertDateTime");
            // 
            // colIsActive
            // 
            colIsActive.FieldName = "IsActive";
            colIsActive.MinWidth = 18;
            colIsActive.Name = "colIsActive";
            resources.ApplyResources(colIsActive, "colIsActive");
            // 
            // colUsernameId
            // 
            colUsernameId.FieldName = "UsernameId";
            colUsernameId.MinWidth = 18;
            colUsernameId.Name = "colUsernameId";
            resources.ApplyResources(colUsernameId, "colUsernameId");
            // 
            // SearchLabel
            // 
            SearchLabel.Appearance.Font = (Font)resources.GetObject("SearchLabel.Appearance.Font");
            SearchLabel.Appearance.ForeColor = (Color)resources.GetObject("SearchLabel.Appearance.ForeColor");
            SearchLabel.Appearance.Options.UseFont = true;
            SearchLabel.Appearance.Options.UseForeColor = true;
            SearchLabel.Appearance.Options.UseTextOptions = true;
            SearchLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(SearchLabel, "SearchLabel");
            SearchLabel.Name = "SearchLabel";
            // 
            // SearchTextBox
            // 
            SearchTextBox.IsActiveVHText = true;
            resources.ApplyResources(SearchTextBox, "SearchTextBox");
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Properties.Appearance.BackColor = (Color)resources.GetObject("SearchTextBox.Properties.Appearance.BackColor");
            SearchTextBox.Properties.Appearance.Font = (Font)resources.GetObject("SearchTextBox.Properties.Appearance.Font");
            SearchTextBox.Properties.Appearance.Options.UseBackColor = true;
            SearchTextBox.Properties.Appearance.Options.UseFont = true;
            SearchTextBox.Properties.Appearance.Options.UseTextOptions = true;
            SearchTextBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            SearchTextBox.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            SearchTextBox.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            SearchTextBox.Properties.AutoHeight = (bool)resources.GetObject("SearchTextBox.Properties.AutoHeight");
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
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
            // UsersForm
            // 
            Appearance.BackColor = (Color)resources.GetObject("UsersForm.Appearance.BackColor");
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UserDeleteButton);
            Controls.Add(UserEditButton);
            Controls.Add(UserNewButton);
            Controls.Add(SearchTextBox);
            Controls.Add(SearchLabel);
            Controls.Add(UserGridControl);
            Name = "UsersForm";
            Load += UsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchTextBox.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private DevExpress.XtraGrid.GridControl UserGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView UserGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthdate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colUsernameId;
        private Usf.WinForms.Forms.LabelControl SearchLabel;
        private Usf.WinForms.Forms.TextEdit SearchTextBox;
        private Usf.WinForms.Forms.ButtonSimlpe UserNewButton;
        private Usf.WinForms.Forms.ButtonSimlpe UserEditButton;
        private Usf.WinForms.Forms.ButtonSimlpe UserDeleteButton;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn Phone;
    }
}
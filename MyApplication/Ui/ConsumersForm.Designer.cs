namespace MyApplication
{
    partial class ConsumersForm
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
            UserDeleteButton = new Usf.WinForms.Forms.ButtonSimlpe();
            UserEditButton = new Usf.WinForms.Forms.ButtonSimlpe();
            UserNewButton = new Usf.WinForms.Forms.ButtonSimlpe();
            ConsumerGridControl = new DevExpress.XtraGrid.GridControl();
            ConsumerGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)ConsumerGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ConsumerGridView).BeginInit();
            SuspendLayout();
            // 
            // UserDeleteButton
            // 
            UserDeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UserDeleteButton.Appearance.BackColor = Color.Wheat;
            UserDeleteButton.Appearance.BorderColor = Color.PaleGreen;
            UserDeleteButton.Appearance.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            UserDeleteButton.Appearance.ForeColor = Color.Maroon;
            UserDeleteButton.Appearance.Options.UseBackColor = true;
            UserDeleteButton.Appearance.Options.UseBorderColor = true;
            UserDeleteButton.Appearance.Options.UseFont = true;
            UserDeleteButton.Appearance.Options.UseForeColor = true;
            UserDeleteButton.Location = new Point(899, 689);
            UserDeleteButton.Margin = new Padding(3, 4, 3, 4);
            UserDeleteButton.Name = "UserDeleteButton";
            UserDeleteButton.Size = new Size(300, 65);
            UserDeleteButton.TabIndex = 4;
            UserDeleteButton.Text = "Delete";
            UserDeleteButton.Click += UserDeleteButton_Click;
            // 
            // UserEditButton
            // 
            UserEditButton.Anchor = AnchorStyles.Bottom;
            UserEditButton.Appearance.BackColor = Color.Wheat;
            UserEditButton.Appearance.BorderColor = Color.PaleGreen;
            UserEditButton.Appearance.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            UserEditButton.Appearance.ForeColor = Color.Maroon;
            UserEditButton.Appearance.Options.UseBackColor = true;
            UserEditButton.Appearance.Options.UseBorderColor = true;
            UserEditButton.Appearance.Options.UseFont = true;
            UserEditButton.Appearance.Options.UseForeColor = true;
            UserEditButton.Location = new Point(488, 689);
            UserEditButton.Margin = new Padding(3, 4, 3, 4);
            UserEditButton.Name = "UserEditButton";
            UserEditButton.Size = new Size(300, 65);
            UserEditButton.TabIndex = 5;
            UserEditButton.Text = "Edit";
            UserEditButton.Click += UserEditButton_Click;
            // 
            // UserNewButton
            // 
            UserNewButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UserNewButton.Appearance.BackColor = Color.Wheat;
            UserNewButton.Appearance.BorderColor = Color.PaleGreen;
            UserNewButton.Appearance.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            UserNewButton.Appearance.ForeColor = Color.Maroon;
            UserNewButton.Appearance.Options.UseBackColor = true;
            UserNewButton.Appearance.Options.UseBorderColor = true;
            UserNewButton.Appearance.Options.UseFont = true;
            UserNewButton.Appearance.Options.UseForeColor = true;
            UserNewButton.Location = new Point(64, 689);
            UserNewButton.Margin = new Padding(3, 4, 3, 4);
            UserNewButton.Name = "UserNewButton";
            UserNewButton.Size = new Size(300, 65);
            UserNewButton.TabIndex = 6;
            UserNewButton.Text = "ADD";
            UserNewButton.Click += UserNewButton_Click;
            // 
            // ConsumerGridControl
            // 
            ConsumerGridControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ConsumerGridControl.EmbeddedNavigator.Margin = new Padding(3, 4, 3, 4);
            ConsumerGridControl.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            ConsumerGridControl.Location = new Point(4, 7);
            ConsumerGridControl.MainView = ConsumerGridView;
            ConsumerGridControl.Margin = new Padding(3, 4, 3, 4);
            ConsumerGridControl.Name = "ConsumerGridControl";
            ConsumerGridControl.Size = new Size(1250, 674);
            ConsumerGridControl.TabIndex = 7;
            ConsumerGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { ConsumerGridView });
            // 
            // ConsumerGridView
            // 
            ConsumerGridView.Appearance.EvenRow.BackColor = Color.FromArgb(192, 255, 255);
            ConsumerGridView.Appearance.EvenRow.Options.UseBackColor = true;
            ConsumerGridView.Appearance.HeaderPanel.BackColor = Color.CornflowerBlue;
            ConsumerGridView.Appearance.HeaderPanel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ConsumerGridView.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            ConsumerGridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            ConsumerGridView.Appearance.HeaderPanel.Options.UseFont = true;
            ConsumerGridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            ConsumerGridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            ConsumerGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            ConsumerGridView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            ConsumerGridView.Appearance.Row.BackColor = Color.FromArgb(255, 255, 192);
            ConsumerGridView.Appearance.Row.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ConsumerGridView.Appearance.Row.Options.UseBackColor = true;
            ConsumerGridView.Appearance.Row.Options.UseFont = true;
            ConsumerGridView.Appearance.Row.Options.UseTextOptions = true;
            ConsumerGridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            ConsumerGridView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            ConsumerGridView.Appearance.SelectedRow.BackColor = Color.FromArgb(192, 255, 192);
            ConsumerGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            ConsumerGridView.AppearancePrint.HeaderPanel.BackColor = Color.Pink;
            ConsumerGridView.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
            ConsumerGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colFirstName, colLastName, colPhoneNumber, colIsActive, colEmail, colAddress, colDescription });
            ConsumerGridView.DetailHeight = 489;
            ConsumerGridView.GridControl = ConsumerGridControl;
            ConsumerGridView.Name = "ConsumerGridView";
            ConsumerGridView.OptionsBehavior.AutoPopulateColumns = false;
            ConsumerGridView.OptionsView.ColumnAutoWidth = false;
            ConsumerGridView.OptionsView.EnableAppearanceEvenRow = true;
            ConsumerGridView.OptionsView.ShowIndicator = false;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.MinWidth = 25;
            colId.Name = "colId";
            colId.OptionsColumn.AllowEdit = false;
            colId.Width = 93;
            // 
            // colFirstName
            // 
            colFirstName.FieldName = "FirstName";
            colFirstName.MinWidth = 25;
            colFirstName.Name = "colFirstName";
            colFirstName.OptionsColumn.AllowEdit = false;
            colFirstName.Visible = true;
            colFirstName.VisibleIndex = 0;
            colFirstName.Width = 120;
            // 
            // colLastName
            // 
            colLastName.FieldName = "LastName";
            colLastName.MinWidth = 25;
            colLastName.Name = "colLastName";
            colLastName.OptionsColumn.AllowEdit = false;
            colLastName.Visible = true;
            colLastName.VisibleIndex = 1;
            colLastName.Width = 150;
            // 
            // colPhoneNumber
            // 
            colPhoneNumber.AppearanceCell.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            colPhoneNumber.AppearanceCell.Options.UseFont = true;
            colPhoneNumber.FieldName = "PhoneNumber";
            colPhoneNumber.MinWidth = 25;
            colPhoneNumber.Name = "colPhoneNumber";
            colPhoneNumber.OptionsColumn.AllowEdit = false;
            colPhoneNumber.Visible = true;
            colPhoneNumber.VisibleIndex = 2;
            colPhoneNumber.Width = 130;
            // 
            // colIsActive
            // 
            colIsActive.FieldName = "IsActive";
            colIsActive.MinWidth = 25;
            colIsActive.Name = "colIsActive";
            colIsActive.OptionsColumn.AllowEdit = false;
            colIsActive.Visible = true;
            colIsActive.VisibleIndex = 3;
            colIsActive.Width = 110;
            // 
            // colEmail
            // 
            colEmail.FieldName = "Email";
            colEmail.MinWidth = 25;
            colEmail.Name = "colEmail";
            colEmail.OptionsColumn.AllowEdit = false;
            colEmail.Visible = true;
            colEmail.VisibleIndex = 4;
            colEmail.Width = 300;
            // 
            // colAddress
            // 
            colAddress.FieldName = "Address";
            colAddress.MinWidth = 25;
            colAddress.Name = "colAddress";
            colAddress.OptionsColumn.AllowEdit = false;
            colAddress.Visible = true;
            colAddress.VisibleIndex = 5;
            colAddress.Width = 500;
            // 
            // colDescription
            // 
            colDescription.FieldName = "Description";
            colDescription.MinWidth = 25;
            colDescription.Name = "colDescription";
            colDescription.OptionsColumn.AllowEdit = false;
            colDescription.Visible = true;
            colDescription.VisibleIndex = 6;
            colDescription.Width = 800;
            // 
            // ConsumersForm
            // 
            Appearance.BackColor = Color.LightGoldenrodYellow;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 760);
            Controls.Add(UserDeleteButton);
            Controls.Add(UserEditButton);
            Controls.Add(UserNewButton);
            Controls.Add(ConsumerGridControl);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(7, 9, 7, 9);
            Name = "ConsumersForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)ConsumerGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)ConsumerGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Usf.WinForms.Forms.ButtonSimlpe UserDeleteButton;
        private Usf.WinForms.Forms.ButtonSimlpe UserEditButton;
        private Usf.WinForms.Forms.ButtonSimlpe UserNewButton;
        private DevExpress.XtraGrid.GridControl ConsumerGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ConsumerGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    }
}
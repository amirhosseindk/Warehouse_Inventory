namespace MyApplication.Ui
{
    partial class SuppliersForm
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
            DeleteButton = new Usf.WinForms.Forms.ButtonSimlpe();
            EditButton = new Usf.WinForms.Forms.ButtonSimlpe();
            NewButton = new Usf.WinForms.Forms.ButtonSimlpe();
            SupplierGridControl = new DevExpress.XtraGrid.GridControl();
            SupplierGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)SupplierGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SupplierGridView).BeginInit();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteButton.Appearance.BackColor = Color.Wheat;
            DeleteButton.Appearance.BorderColor = Color.PaleGreen;
            DeleteButton.Appearance.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.Appearance.ForeColor = Color.Maroon;
            DeleteButton.Appearance.Options.UseBackColor = true;
            DeleteButton.Appearance.Options.UseBorderColor = true;
            DeleteButton.Appearance.Options.UseFont = true;
            DeleteButton.Appearance.Options.UseForeColor = true;
            DeleteButton.Location = new Point(899, 687);
            DeleteButton.Margin = new Padding(3, 4, 3, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(300, 65);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Delete";
            DeleteButton.Click += UserDeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Bottom;
            EditButton.Appearance.BackColor = Color.Wheat;
            EditButton.Appearance.BorderColor = Color.PaleGreen;
            EditButton.Appearance.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.Appearance.ForeColor = Color.Maroon;
            EditButton.Appearance.Options.UseBackColor = true;
            EditButton.Appearance.Options.UseBorderColor = true;
            EditButton.Appearance.Options.UseFont = true;
            EditButton.Appearance.Options.UseForeColor = true;
            EditButton.Location = new Point(488, 687);
            EditButton.Margin = new Padding(3, 4, 3, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(300, 65);
            EditButton.TabIndex = 9;
            EditButton.Text = "Edit";
            EditButton.Click += UserEditButton_Click;
            // 
            // NewButton
            // 
            NewButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NewButton.Appearance.BackColor = Color.Wheat;
            NewButton.Appearance.BorderColor = Color.PaleGreen;
            NewButton.Appearance.Font = new Font("Microsoft Sans Serif", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            NewButton.Appearance.ForeColor = Color.Maroon;
            NewButton.Appearance.Options.UseBackColor = true;
            NewButton.Appearance.Options.UseBorderColor = true;
            NewButton.Appearance.Options.UseFont = true;
            NewButton.Appearance.Options.UseForeColor = true;
            NewButton.Location = new Point(64, 687);
            NewButton.Margin = new Padding(3, 4, 3, 4);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(300, 65);
            NewButton.TabIndex = 10;
            NewButton.Text = "ADD";
            NewButton.Click += UserNewButton_Click;
            // 
            // SupplierGridControl
            // 
            SupplierGridControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SupplierGridControl.EmbeddedNavigator.Margin = new Padding(3, 4, 3, 4);
            SupplierGridControl.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            SupplierGridControl.Location = new Point(4, 9);
            SupplierGridControl.MainView = SupplierGridView;
            SupplierGridControl.Margin = new Padding(3, 4, 3, 4);
            SupplierGridControl.Name = "SupplierGridControl";
            SupplierGridControl.Size = new Size(1250, 670);
            SupplierGridControl.TabIndex = 11;
            SupplierGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { SupplierGridView });
            // 
            // SupplierGridView
            // 
            SupplierGridView.Appearance.EvenRow.BackColor = Color.FromArgb(192, 255, 255);
            SupplierGridView.Appearance.EvenRow.Options.UseBackColor = true;
            SupplierGridView.Appearance.HeaderPanel.BackColor = Color.CornflowerBlue;
            SupplierGridView.Appearance.HeaderPanel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SupplierGridView.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            SupplierGridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            SupplierGridView.Appearance.HeaderPanel.Options.UseFont = true;
            SupplierGridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            SupplierGridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            SupplierGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            SupplierGridView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            SupplierGridView.Appearance.Row.BackColor = Color.FromArgb(255, 255, 192);
            SupplierGridView.Appearance.Row.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SupplierGridView.Appearance.Row.Options.UseBackColor = true;
            SupplierGridView.Appearance.Row.Options.UseFont = true;
            SupplierGridView.Appearance.Row.Options.UseTextOptions = true;
            SupplierGridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            SupplierGridView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            SupplierGridView.Appearance.SelectedRow.BackColor = Color.FromArgb(192, 255, 192);
            SupplierGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            SupplierGridView.AppearancePrint.HeaderPanel.BackColor = Color.Pink;
            SupplierGridView.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
            SupplierGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colFirstName, colLastName, colPhoneNumber, colIsActive, colEmail, colAddress, colDescription });
            SupplierGridView.DetailHeight = 489;
            SupplierGridView.GridControl = SupplierGridControl;
            SupplierGridView.Name = "SupplierGridView";
            SupplierGridView.OptionsBehavior.AutoPopulateColumns = false;
            SupplierGridView.OptionsView.ColumnAutoWidth = false;
            SupplierGridView.OptionsView.EnableAppearanceEvenRow = true;
            SupplierGridView.OptionsView.ShowIndicator = false;
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
            // SuppliersForm
            // 
            Appearance.BackColor = Color.LightGoldenrodYellow;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 760);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(NewButton);
            Controls.Add(SupplierGridControl);
            Margin = new Padding(11, 9, 11, 9);
            Name = "SuppliersForm";
            Text = "SuppliersForm";
            Load += SupplersButton_Load;
            ((System.ComponentModel.ISupportInitialize)SupplierGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)SupplierGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Usf.WinForms.Forms.ButtonSimlpe DeleteButton;
        private Usf.WinForms.Forms.ButtonSimlpe EditButton;
        private Usf.WinForms.Forms.ButtonSimlpe NewButton;
        private DevExpress.XtraGrid.GridControl SupplierGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView SupplierGridView;
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
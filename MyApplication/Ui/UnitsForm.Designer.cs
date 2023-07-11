namespace MyApp.Ui
{
    partial class UnitsForm
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            UnitControl = new DevExpress.XtraGrid.GridControl();
            UnitView = new DevExpress.XtraGrid.Views.Tile.TileView();
            DeleteButton = new Usf.WinForms.Forms.ButtonSimlpe();
            CreateButton = new Usf.WinForms.Forms.ButtonSimlpe();
            EditButton = new Usf.WinForms.Forms.ButtonSimlpe();
            ((System.ComponentModel.ISupportInitialize)UnitControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UnitView).BeginInit();
            SuspendLayout();
            // 
            // UnitControl
            // 
            UnitControl.Location = new Point(12, 12);
            UnitControl.MainView = UnitView;
            UnitControl.Name = "UnitControl";
            UnitControl.Size = new Size(776, 301);
            UnitControl.TabIndex = 0;
            UnitControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { UnitView });
            // 
            // UnitView
            // 
            UnitView.GridControl = UnitControl;
            UnitView.Name = "UnitView";
            UnitView.OptionsTiles.ItemSize = new Size(100, 100);
            UnitView.OptionsTiles.RowCount = 9;
            UnitView.TileColumns.Add(tableColumnDefinition1);
            UnitView.TileColumns.Add(tableColumnDefinition2);
            UnitView.TileColumns.Add(tableColumnDefinition3);
            UnitView.TileRows.Add(tableRowDefinition1);
            UnitView.TileRows.Add(tableRowDefinition2);
            UnitView.TileRows.Add(tableRowDefinition3);
            tableSpan1.ColumnSpan = 3;
            tableSpan1.RowSpan = 3;
            UnitView.TileSpans.Add(tableSpan1);
            // 
            // DeleteButton
            // 
            DeleteButton.Appearance.BackColor = Color.PowderBlue;
            DeleteButton.Appearance.BorderColor = Color.PaleGreen;
            DeleteButton.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.Appearance.ForeColor = Color.Maroon;
            DeleteButton.Appearance.Options.UseBackColor = true;
            DeleteButton.Appearance.Options.UseBorderColor = true;
            DeleteButton.Appearance.Options.UseFont = true;
            DeleteButton.Appearance.Options.UseForeColor = true;
            DeleteButton.Location = new Point(12, 376);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(225, 62);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "Delete";
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.Appearance.BackColor = Color.PowderBlue;
            CreateButton.Appearance.BorderColor = Color.PaleGreen;
            CreateButton.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateButton.Appearance.ForeColor = Color.Maroon;
            CreateButton.Appearance.Options.UseBackColor = true;
            CreateButton.Appearance.Options.UseBorderColor = true;
            CreateButton.Appearance.Options.UseFont = true;
            CreateButton.Appearance.Options.UseForeColor = true;
            CreateButton.Location = new Point(290, 376);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(225, 62);
            CreateButton.TabIndex = 1;
            CreateButton.Text = "Create";
            CreateButton.Click += CreateButton_Click;
            // 
            // EditButton
            // 
            EditButton.Appearance.BackColor = Color.PowderBlue;
            EditButton.Appearance.BorderColor = Color.PaleGreen;
            EditButton.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.Appearance.ForeColor = Color.Maroon;
            EditButton.Appearance.Options.UseBackColor = true;
            EditButton.Appearance.Options.UseBorderColor = true;
            EditButton.Appearance.Options.UseFont = true;
            EditButton.Appearance.Options.UseForeColor = true;
            EditButton.Location = new Point(563, 376);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(225, 62);
            EditButton.TabIndex = 1;
            EditButton.Text = "Edit";
            EditButton.Click += EditButton_Click;
            // 
            // UnitsForm
            // 
            Appearance.BackColor = Color.LightGoldenrodYellow;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditButton);
            Controls.Add(CreateButton);
            Controls.Add(DeleteButton);
            Controls.Add(UnitControl);
            Name = "UnitsForm";
            Text = "UnitsForm";
            Load += UnitsForm_Load;
            ((System.ComponentModel.ISupportInitialize)UnitControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)UnitView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl UnitControl;
        private DevExpress.XtraGrid.Views.Tile.TileView UnitView;
        private Usf.WinForms.Forms.ButtonSimlpe DeleteButton;
        private Usf.WinForms.Forms.ButtonSimlpe CreateButton;
        private Usf.WinForms.Forms.ButtonSimlpe EditButton;
    }
}
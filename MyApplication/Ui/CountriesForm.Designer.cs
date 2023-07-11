namespace MyApplication
{
    partial class CountriesForm
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
            CountriesGrid = new DevExpress.XtraGrid.GridControl();
            CountriesView = new DevExpress.XtraGrid.Views.Tile.TileView();
            DeleteButton = new Usf.WinForms.Forms.ButtonSimlpe();
            CreateButton = new Usf.WinForms.Forms.ButtonSimlpe();
            EditButton = new Usf.WinForms.Forms.ButtonSimlpe();
            ((System.ComponentModel.ISupportInitialize)CountriesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CountriesView).BeginInit();
            SuspendLayout();
            // 
            // CountriesGrid
            // 
            CountriesGrid.Location = new Point(2, 12);
            CountriesGrid.MainView = CountriesView;
            CountriesGrid.Name = "CountriesGrid";
            CountriesGrid.Size = new Size(744, 312);
            CountriesGrid.TabIndex = 0;
            CountriesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { CountriesView });
            // 
            // CountriesView
            // 
            CountriesView.GridControl = CountriesGrid;
            CountriesView.Name = "CountriesView";
            CountriesView.OptionsTiles.ItemSize = new Size(100, 100);
            CountriesView.OptionsTiles.RowCount = 9;
            CountriesView.TileColumns.Add(tableColumnDefinition1);
            CountriesView.TileColumns.Add(tableColumnDefinition2);
            CountriesView.TileColumns.Add(tableColumnDefinition3);
            CountriesView.TileRows.Add(tableRowDefinition1);
            CountriesView.TileRows.Add(tableRowDefinition2);
            CountriesView.TileRows.Add(tableRowDefinition3);
            tableSpan1.ColumnSpan = 3;
            tableSpan1.RowSpan = 3;
            CountriesView.TileSpans.Add(tableSpan1);
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
            DeleteButton.Location = new Point(30, 367);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(166, 62);
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
            CreateButton.Location = new Point(291, 367);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(166, 62);
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
            EditButton.Location = new Point(534, 367);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(166, 62);
            EditButton.TabIndex = 1;
            EditButton.Text = "Edit";
            EditButton.Click += EditButton_Click;
            // 
            // CountriesForm
            // 
            Appearance.BackColor = Color.LightGoldenrodYellow;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 465);
            Controls.Add(EditButton);
            Controls.Add(CreateButton);
            Controls.Add(DeleteButton);
            Controls.Add(CountriesGrid);
            Margin = new Padding(11, 9, 11, 9);
            Name = "CountriesForm";
            Text = "CountriesForm";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)CountriesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)CountriesView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl CountriesGrid;
        private DevExpress.XtraGrid.Views.Tile.TileView CountriesView;
        private Usf.WinForms.Forms.ButtonSimlpe DeleteButton;
        private Usf.WinForms.Forms.ButtonSimlpe CreateButton;
        private Usf.WinForms.Forms.ButtonSimlpe EditButton;
    }
}
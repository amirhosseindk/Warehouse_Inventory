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
            CountriesGrid = new DevExpress.XtraGrid.GridControl();
            CountriesView = new DevExpress.XtraGrid.Views.Tile.TileView();
            ((System.ComponentModel.ISupportInitialize)CountriesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CountriesView).BeginInit();
            SuspendLayout();
            // 
            // CountriesGrid
            // 
            CountriesGrid.Location = new Point(7, 12);
            CountriesGrid.MainView = CountriesView;
            CountriesGrid.Name = "CountriesGrid";
            CountriesGrid.Size = new Size(634, 250);
            CountriesGrid.TabIndex = 0;
            CountriesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { CountriesView });
            // 
            // CountriesView
            // 
            CountriesView.GridControl = CountriesGrid;
            CountriesView.Name = "CountriesView";
            CountriesView.OptionsTiles.ItemSize = new Size(100, 100);
            CountriesView.OptionsTiles.RowCount = 9;
            tableColumnDefinition1.Length.Value = 0D;
            tableColumnDefinition2.Length.Value = 71D;
            tableColumnDefinition3.Length.Value = 0D;
            CountriesView.TileColumns.Add(tableColumnDefinition1);
            CountriesView.TileColumns.Add(tableColumnDefinition2);
            CountriesView.TileColumns.Add(tableColumnDefinition3);
            tableRowDefinition1.Length.Value = 0D;
            tableRowDefinition2.Length.Value = 80D;
            tableRowDefinition3.Length.Value = 0D;
            CountriesView.TileRows.Add(tableRowDefinition1);
            CountriesView.TileRows.Add(tableRowDefinition2);
            CountriesView.TileRows.Add(tableRowDefinition3);
            // 
            // CountriesForm
            // 
            Appearance.BackColor = Color.LightGoldenrodYellow;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 495);
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
    }
}
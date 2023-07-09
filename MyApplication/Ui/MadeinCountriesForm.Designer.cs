namespace MyApplication
{
    partial class MadeinCountriesForm
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
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            colName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            colCommodities = new DevExpress.XtraGrid.Columns.TileViewColumn();
            colId = new DevExpress.XtraGrid.Columns.TileViewColumn();
            colInsertDateTime = new DevExpress.XtraGrid.Columns.TileViewColumn();
            colUpdateDateTime = new DevExpress.XtraGrid.Columns.TileViewColumn();
            colDeleteDateTime = new DevExpress.XtraGrid.Columns.TileViewColumn();
            colIsDeleted = new DevExpress.XtraGrid.Columns.TileViewColumn();
            colIsActive = new DevExpress.XtraGrid.Columns.TileViewColumn();
            colUsernameId = new DevExpress.XtraGrid.Columns.TileViewColumn();
            textEdit1 = new Usf.WinForms.Forms.TextEdit();
            buttonSimlpe1 = new Usf.WinForms.Forms.ButtonSimlpe();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tileView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // colName
            // 
            colName.FieldName = "Name";
            colName.MinWidth = 25;
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 0;
            colName.Width = 94;
            // 
            // gridControl1
            // 
            gridControl1.DataSource = typeof(Domain.Entities.MadeInCountry);
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = tileView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(646, 495);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { tileView1 });
            // 
            // tileView1
            // 
            tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colName, colCommodities, colId, colInsertDateTime, colUpdateDateTime, colDeleteDateTime, colIsDeleted, colIsActive, colUsernameId });
            tileView1.GridControl = gridControl1;
            tileView1.Name = "tileView1";
            tileView1.OptionsTiles.RowCount = 5;
            tableColumnDefinition1.Length.Value = 0D;
            tableColumnDefinition2.Length.Value = 70D;
            tableColumnDefinition3.Length.Value = 0D;
            tileView1.TileColumns.Add(tableColumnDefinition1);
            tileView1.TileColumns.Add(tableColumnDefinition2);
            tileView1.TileColumns.Add(tableColumnDefinition3);
            tableRowDefinition1.Length.Value = 0D;
            tableRowDefinition2.Length.Value = 80D;
            tableRowDefinition3.Length.Value = 0D;
            tileView1.TileRows.Add(tableRowDefinition1);
            tileView1.TileRows.Add(tableRowDefinition2);
            tileView1.TileRows.Add(tableRowDefinition3);
            tileViewItemElement1.Column = colName;
            tileViewItemElement1.ColumnIndex = 1;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.RowIndex = 1;
            tileViewItemElement1.Text = "colName";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileView1.TileTemplate.Add(tileViewItemElement1);
            // 
            // colCommodities
            // 
            colCommodities.FieldName = "Commodities";
            colCommodities.MinWidth = 25;
            colCommodities.Name = "colCommodities";
            colCommodities.Visible = true;
            colCommodities.VisibleIndex = 1;
            colCommodities.Width = 94;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.MinWidth = 25;
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 2;
            colId.Width = 94;
            // 
            // colInsertDateTime
            // 
            colInsertDateTime.FieldName = "InsertDateTime";
            colInsertDateTime.MinWidth = 25;
            colInsertDateTime.Name = "colInsertDateTime";
            colInsertDateTime.Visible = true;
            colInsertDateTime.VisibleIndex = 3;
            colInsertDateTime.Width = 94;
            // 
            // colUpdateDateTime
            // 
            colUpdateDateTime.FieldName = "UpdateDateTime";
            colUpdateDateTime.MinWidth = 25;
            colUpdateDateTime.Name = "colUpdateDateTime";
            colUpdateDateTime.Visible = true;
            colUpdateDateTime.VisibleIndex = 4;
            colUpdateDateTime.Width = 94;
            // 
            // colDeleteDateTime
            // 
            colDeleteDateTime.FieldName = "DeleteDateTime";
            colDeleteDateTime.MinWidth = 25;
            colDeleteDateTime.Name = "colDeleteDateTime";
            colDeleteDateTime.Visible = true;
            colDeleteDateTime.VisibleIndex = 5;
            colDeleteDateTime.Width = 94;
            // 
            // colIsDeleted
            // 
            colIsDeleted.FieldName = "IsDeleted";
            colIsDeleted.MinWidth = 25;
            colIsDeleted.Name = "colIsDeleted";
            colIsDeleted.Visible = true;
            colIsDeleted.VisibleIndex = 6;
            colIsDeleted.Width = 94;
            // 
            // colIsActive
            // 
            colIsActive.FieldName = "IsActive";
            colIsActive.MinWidth = 25;
            colIsActive.Name = "colIsActive";
            colIsActive.Visible = true;
            colIsActive.VisibleIndex = 7;
            colIsActive.Width = 94;
            // 
            // colUsernameId
            // 
            colUsernameId.FieldName = "UsernameId";
            colUsernameId.MinWidth = 25;
            colUsernameId.Name = "colUsernameId";
            colUsernameId.Visible = true;
            colUsernameId.VisibleIndex = 8;
            colUsernameId.Width = 94;
            // 
            // textEdit1
            // 
            textEdit1.Dock = DockStyle.Bottom;
            textEdit1.IsActiveVHText = true;
            textEdit1.Location = new Point(0, 455);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Appearance.BackColor = Color.LemonChiffon;
            textEdit1.Properties.Appearance.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textEdit1.Properties.Appearance.Options.UseBackColor = true;
            textEdit1.Properties.Appearance.Options.UseFont = true;
            textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            textEdit1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            textEdit1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            textEdit1.Properties.AutoHeight = false;
            textEdit1.Size = new Size(646, 40);
            textEdit1.TabIndex = 1;
            // 
            // buttonSimlpe1
            // 
            buttonSimlpe1.Appearance.BackColor = Color.PowderBlue;
            buttonSimlpe1.Appearance.BorderColor = Color.PaleGreen;
            buttonSimlpe1.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSimlpe1.Appearance.ForeColor = Color.Maroon;
            buttonSimlpe1.Appearance.Options.UseBackColor = true;
            buttonSimlpe1.Appearance.Options.UseBorderColor = true;
            buttonSimlpe1.Appearance.Options.UseFont = true;
            buttonSimlpe1.Appearance.Options.UseForeColor = true;
            buttonSimlpe1.Location = new Point(0, 409);
            buttonSimlpe1.Name = "buttonSimlpe1";
            buttonSimlpe1.Size = new Size(646, 46);
            buttonSimlpe1.TabIndex = 1;
            buttonSimlpe1.Text = "buttonSimlpe1";
            buttonSimlpe1.Click += buttonSimlpe1_Click;
            // 
            // MadeinCountriesForm
            // 
            Appearance.BackColor = Color.LightGoldenrodYellow;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 495);
            Controls.Add(buttonSimlpe1);
            Controls.Add(textEdit1);
            Controls.Add(gridControl1);
            Margin = new Padding(11, 9, 11, 9);
            Name = "MadeinCountriesForm";
            Text = "MadeinCountriesForm";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tileView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCommodities;
        private DevExpress.XtraGrid.Columns.TileViewColumn colId;
        private DevExpress.XtraGrid.Columns.TileViewColumn colInsertDateTime;
        private DevExpress.XtraGrid.Columns.TileViewColumn colUpdateDateTime;
        private DevExpress.XtraGrid.Columns.TileViewColumn colDeleteDateTime;
        private DevExpress.XtraGrid.Columns.TileViewColumn colIsDeleted;
        private DevExpress.XtraGrid.Columns.TileViewColumn colIsActive;
        private DevExpress.XtraGrid.Columns.TileViewColumn colUsernameId;
        private Usf.WinForms.Forms.TextEdit textEdit1;
        private Usf.WinForms.Forms.ButtonSimlpe buttonSimlpe1;
    }
}
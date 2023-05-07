namespace MyApplication.Ui
{
    partial class RequestForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            InventoryTransferButton = new Usf.WinForms.Forms.Button();
            AddToRequestButton = new Usf.WinForms.Forms.Button();
            PrintInventoryTransferButton = new Usf.WinForms.Forms.Button();
            PrintInvoiceButton = new Usf.WinForms.Forms.Button();
            DeleteButton = new Usf.WinForms.Forms.Button();
            InvoiceButton = new Usf.WinForms.Forms.Button();
            AddToShopingButton = new Usf.WinForms.Forms.Button();
            CountLabel = new Usf.WinForms.Forms.Label();
            NumberLabel = new Usf.WinForms.Forms.Label();
            DateLabel = new Usf.WinForms.Forms.Label();
            RegistrarLabel = new Usf.WinForms.Forms.Label();
            CustomerLabel = new Usf.WinForms.Forms.Label();
            TotalAmountLabel = new Usf.WinForms.Forms.Label();
            NumberRequestLabel = new Usf.WinForms.Forms.Label();
            DateRequestLabel = new Usf.WinForms.Forms.Label();
            UserFullNameLabel = new Usf.WinForms.Forms.Label();
            CustomerFullNameLabel = new Usf.WinForms.Forms.Label();
            AmountLabel = new Usf.WinForms.Forms.Label();
            CustomerInRequestFormDataGridView = new Usf.WinForms.Forms.DataGridView();
            CustomerCode = new DataGridViewTextBoxColumn();
            CustomerFirstName = new DataGridViewTextBoxColumn();
            CustomerLastName = new DataGridViewTextBoxColumn();
            CustomerTel = new DataGridViewTextBoxColumn();
            CustomerType = new DataGridViewTextBoxColumn();
            SearchCustomerLabel = new Usf.WinForms.Forms.Label();
            SearchProductLabel = new Usf.WinForms.Forms.Label();
            ProductInRequestFormDataGridView = new Usf.WinForms.Forms.DataGridView();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductLastPrice = new DataGridViewTextBoxColumn();
            ProductLastStock = new DataGridViewTextBoxColumn();
            ProductUnit = new DataGridViewTextBoxColumn();
            RialsLabel = new Usf.WinForms.Forms.Label();
            RequestFormDataGridView = new Usf.WinForms.Forms.DataGridView();
            RequestRow = new DataGridViewTextBoxColumn();
            RequestProductName = new DataGridViewTextBoxColumn();
            RequestProductCount = new DataGridViewTextBoxColumn();
            RequestProductUnit = new DataGridViewTextBoxColumn();
            RequestProductPrice = new DataGridViewTextBoxColumn();
            SearchCustomerTextBox = new Usf.WinForms.Forms.TextBox();
            SearchProductTextBox = new Usf.WinForms.Forms.TextBox();
            Row = new DataGridViewTextBoxColumn();
            CountTextBox = new Usf.WinForms.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)CustomerInRequestFormDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductInRequestFormDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RequestFormDataGridView).BeginInit();
            SuspendLayout();
            // 
            // InventoryTransferButton
            // 
            InventoryTransferButton.Anchor = AnchorStyles.Left;
            InventoryTransferButton.Appearance.BackColor = Color.LightGreen;
            InventoryTransferButton.Appearance.Font = new Font("IRANYekan Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            InventoryTransferButton.Appearance.Options.UseBackColor = true;
            InventoryTransferButton.Appearance.Options.UseFont = true;
            InventoryTransferButton.Location = new Point(30, 199);
            InventoryTransferButton.Name = "InventoryTransferButton";
            InventoryTransferButton.Size = new Size(273, 40);
            InventoryTransferButton.TabIndex = 1;
            InventoryTransferButton.Text = "Inventory Transfer New";
            // 
            // AddToRequestButton
            // 
            AddToRequestButton.Anchor = AnchorStyles.Right;
            AddToRequestButton.Appearance.BackColor = Color.LightGreen;
            AddToRequestButton.Appearance.Font = new Font("IRANYekan Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            AddToRequestButton.Appearance.Options.UseBackColor = true;
            AddToRequestButton.Appearance.Options.UseFont = true;
            AddToRequestButton.Location = new Point(773, 199);
            AddToRequestButton.Name = "AddToRequestButton";
            AddToRequestButton.Size = new Size(218, 40);
            AddToRequestButton.TabIndex = 5;
            AddToRequestButton.Text = "Add to Request";
            // 
            // PrintInventoryTransferButton
            // 
            PrintInventoryTransferButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PrintInventoryTransferButton.Appearance.BackColor = Color.LightGreen;
            PrintInventoryTransferButton.Appearance.Font = new Font("IRANYekan Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            PrintInventoryTransferButton.Appearance.Options.UseBackColor = true;
            PrintInventoryTransferButton.Appearance.Options.UseFont = true;
            PrintInventoryTransferButton.Location = new Point(626, 473);
            PrintInventoryTransferButton.Name = "PrintInventoryTransferButton";
            PrintInventoryTransferButton.Size = new Size(256, 40);
            PrintInventoryTransferButton.TabIndex = 7;
            PrintInventoryTransferButton.Text = "Print Inventory Transter";
            // 
            // PrintInvoiceButton
            // 
            PrintInvoiceButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PrintInvoiceButton.Appearance.BackColor = Color.LightGreen;
            PrintInvoiceButton.Appearance.Font = new Font("IRANYekan Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            PrintInvoiceButton.Appearance.Options.UseBackColor = true;
            PrintInvoiceButton.Appearance.Options.UseFont = true;
            PrintInvoiceButton.Location = new Point(905, 473);
            PrintInvoiceButton.Name = "PrintInvoiceButton";
            PrintInvoiceButton.Size = new Size(163, 40);
            PrintInvoiceButton.TabIndex = 8;
            PrintInvoiceButton.Text = "Print Invoice";
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteButton.Appearance.BackColor = Color.FromArgb(255, 128, 128);
            DeleteButton.Appearance.Font = new Font("IRANYekan Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.Appearance.ForeColor = Color.Black;
            DeleteButton.Appearance.Options.UseBackColor = true;
            DeleteButton.Appearance.Options.UseFont = true;
            DeleteButton.Appearance.Options.UseForeColor = true;
            DeleteButton.Location = new Point(1089, 473);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(126, 40);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            // 
            // InvoiceButton
            // 
            InvoiceButton.Anchor = AnchorStyles.Left;
            InvoiceButton.Appearance.BackColor = Color.LightGreen;
            InvoiceButton.Appearance.Font = new Font("IRANYekan Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            InvoiceButton.Appearance.Options.UseBackColor = true;
            InvoiceButton.Appearance.Options.UseFont = true;
            InvoiceButton.Location = new Point(324, 199);
            InvoiceButton.Name = "InvoiceButton";
            InvoiceButton.Size = new Size(184, 40);
            InvoiceButton.TabIndex = 2;
            InvoiceButton.Text = "Invoice New";
            // 
            // AddToShopingButton
            // 
            AddToShopingButton.Anchor = AnchorStyles.Right;
            AddToShopingButton.Appearance.BackColor = Color.LightGreen;
            AddToShopingButton.Appearance.Font = new Font("IRANYekan Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            AddToShopingButton.Appearance.Options.UseBackColor = true;
            AddToShopingButton.Appearance.Options.UseFont = true;
            AddToShopingButton.Location = new Point(1013, 199);
            AddToShopingButton.Name = "AddToShopingButton";
            AddToShopingButton.Size = new Size(202, 40);
            AddToShopingButton.TabIndex = 6;
            AddToShopingButton.Text = "Add to Shoping";
            // 
            // CountLabel
            // 
            CountLabel.Anchor = AnchorStyles.Right;
            CountLabel.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CountLabel.Appearance.ForeColor = Color.Teal;
            CountLabel.Appearance.Options.UseFont = true;
            CountLabel.Appearance.Options.UseForeColor = true;
            CountLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            CountLabel.Location = new Point(616, 202);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(56, 30);
            CountLabel.TabIndex = 5;
            CountLabel.Text = "Count";
            // 
            // NumberLabel
            // 
            NumberLabel.Anchor = AnchorStyles.Left;
            NumberLabel.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NumberLabel.Appearance.ForeColor = Color.Teal;
            NumberLabel.Appearance.Options.UseFont = true;
            NumberLabel.Appearance.Options.UseForeColor = true;
            NumberLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            NumberLabel.Location = new Point(82, 283);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(120, 30);
            NumberLabel.TabIndex = 6;
            NumberLabel.Text = "Number :";
            // 
            // DateLabel
            // 
            DateLabel.Anchor = AnchorStyles.Left;
            DateLabel.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DateLabel.Appearance.ForeColor = Color.Teal;
            DateLabel.Appearance.Options.UseFont = true;
            DateLabel.Appearance.Options.UseForeColor = true;
            DateLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            DateLabel.Location = new Point(82, 323);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(120, 30);
            DateLabel.TabIndex = 7;
            DateLabel.Text = "Date :";
            // 
            // RegistrarLabel
            // 
            RegistrarLabel.Anchor = AnchorStyles.Left;
            RegistrarLabel.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegistrarLabel.Appearance.ForeColor = Color.Teal;
            RegistrarLabel.Appearance.Options.UseFont = true;
            RegistrarLabel.Appearance.Options.UseForeColor = true;
            RegistrarLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            RegistrarLabel.Location = new Point(82, 359);
            RegistrarLabel.Name = "RegistrarLabel";
            RegistrarLabel.Size = new Size(120, 30);
            RegistrarLabel.TabIndex = 8;
            RegistrarLabel.Text = "User :";
            // 
            // CustomerLabel
            // 
            CustomerLabel.Anchor = AnchorStyles.Left;
            CustomerLabel.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerLabel.Appearance.ForeColor = Color.Teal;
            CustomerLabel.Appearance.Options.UseFont = true;
            CustomerLabel.Appearance.Options.UseForeColor = true;
            CustomerLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            CustomerLabel.Location = new Point(82, 395);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(120, 30);
            CustomerLabel.TabIndex = 9;
            CustomerLabel.Text = "Customer :";
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.Anchor = AnchorStyles.Left;
            TotalAmountLabel.Appearance.BackColor = Color.Transparent;
            TotalAmountLabel.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TotalAmountLabel.Appearance.ForeColor = Color.Teal;
            TotalAmountLabel.Appearance.Options.UseBackColor = true;
            TotalAmountLabel.Appearance.Options.UseFont = true;
            TotalAmountLabel.Appearance.Options.UseForeColor = true;
            TotalAmountLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            TotalAmountLabel.Location = new Point(82, 437);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(120, 30);
            TotalAmountLabel.TabIndex = 10;
            TotalAmountLabel.Text = "Amount :";
            // 
            // NumberRequestLabel
            // 
            NumberRequestLabel.Anchor = AnchorStyles.Left;
            NumberRequestLabel.Appearance.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point);
            NumberRequestLabel.Appearance.ForeColor = Color.Red;
            NumberRequestLabel.Appearance.Options.UseFont = true;
            NumberRequestLabel.Appearance.Options.UseForeColor = true;
            NumberRequestLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            NumberRequestLabel.Location = new Point(195, 283);
            NumberRequestLabel.Name = "NumberRequestLabel";
            NumberRequestLabel.Size = new Size(194, 30);
            NumberRequestLabel.TabIndex = 11;
            NumberRequestLabel.Text = "609";
            // 
            // DateRequestLabel
            // 
            DateRequestLabel.Anchor = AnchorStyles.Left;
            DateRequestLabel.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DateRequestLabel.Appearance.ForeColor = Color.Black;
            DateRequestLabel.Appearance.Options.UseFont = true;
            DateRequestLabel.Appearance.Options.UseForeColor = true;
            DateRequestLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            DateRequestLabel.Location = new Point(195, 323);
            DateRequestLabel.Name = "DateRequestLabel";
            DateRequestLabel.Size = new Size(195, 30);
            DateRequestLabel.TabIndex = 12;
            DateRequestLabel.Text = "1402/02/13";
            // 
            // UserFullNameLabel
            // 
            UserFullNameLabel.Anchor = AnchorStyles.Left;
            UserFullNameLabel.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UserFullNameLabel.Appearance.ForeColor = Color.Black;
            UserFullNameLabel.Appearance.Options.UseFont = true;
            UserFullNameLabel.Appearance.Options.UseForeColor = true;
            UserFullNameLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            UserFullNameLabel.Location = new Point(195, 359);
            UserFullNameLabel.Name = "UserFullNameLabel";
            UserFullNameLabel.Size = new Size(195, 30);
            UserFullNameLabel.TabIndex = 12;
            UserFullNameLabel.Text = "Ebrahim Bakhtiari";
            // 
            // CustomerFullNameLabel
            // 
            CustomerFullNameLabel.Anchor = AnchorStyles.Left;
            CustomerFullNameLabel.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerFullNameLabel.Appearance.ForeColor = Color.Black;
            CustomerFullNameLabel.Appearance.Options.UseFont = true;
            CustomerFullNameLabel.Appearance.Options.UseForeColor = true;
            CustomerFullNameLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            CustomerFullNameLabel.Location = new Point(195, 395);
            CustomerFullNameLabel.Name = "CustomerFullNameLabel";
            CustomerFullNameLabel.Size = new Size(194, 30);
            CustomerFullNameLabel.TabIndex = 12;
            CustomerFullNameLabel.Text = "Iran Rayaneh Company";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Left;
            AmountLabel.Appearance.BackColor = Color.Transparent;
            AmountLabel.Appearance.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.Appearance.ForeColor = Color.Blue;
            AmountLabel.Appearance.Options.UseBackColor = true;
            AmountLabel.Appearance.Options.UseFont = true;
            AmountLabel.Appearance.Options.UseForeColor = true;
            AmountLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            AmountLabel.Location = new Point(195, 437);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(207, 30);
            AmountLabel.TabIndex = 12;
            AmountLabel.Text = "150/000/000";
            // 
            // CustomerInRequestFormDataGridView
            // 
            CustomerInRequestFormDataGridView.AllowUserToAddRows = false;
            CustomerInRequestFormDataGridView.AllowUserToDeleteRows = false;
            CustomerInRequestFormDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomerInRequestFormDataGridView.BackgroundColor = Color.MistyRose;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            CustomerInRequestFormDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            CustomerInRequestFormDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerInRequestFormDataGridView.Columns.AddRange(new DataGridViewColumn[] { CustomerCode, CustomerFirstName, CustomerLastName, CustomerTel, CustomerType });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            CustomerInRequestFormDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            CustomerInRequestFormDataGridView.Location = new Point(4, 43);
            CustomerInRequestFormDataGridView.Name = "CustomerInRequestFormDataGridView";
            CustomerInRequestFormDataGridView.ReadOnly = true;
            CustomerInRequestFormDataGridView.RowTemplate.Height = 25;
            CustomerInRequestFormDataGridView.Size = new Size(528, 150);
            CustomerInRequestFormDataGridView.TabIndex = 13;
            // 
            // CustomerCode
            // 
            CustomerCode.HeaderText = "Code";
            CustomerCode.Name = "CustomerCode";
            CustomerCode.ReadOnly = true;
            CustomerCode.Width = 50;
            // 
            // CustomerFirstName
            // 
            CustomerFirstName.HeaderText = "FirstName";
            CustomerFirstName.Name = "CustomerFirstName";
            CustomerFirstName.ReadOnly = true;
            // 
            // CustomerLastName
            // 
            CustomerLastName.HeaderText = "LastName";
            CustomerLastName.Name = "CustomerLastName";
            CustomerLastName.ReadOnly = true;
            CustomerLastName.Width = 145;
            // 
            // CustomerTel
            // 
            CustomerTel.HeaderText = "Tel";
            CustomerTel.Name = "CustomerTel";
            CustomerTel.ReadOnly = true;
            CustomerTel.Width = 110;
            // 
            // CustomerType
            // 
            CustomerType.HeaderText = "Type";
            CustomerType.Name = "CustomerType";
            CustomerType.ReadOnly = true;
            CustomerType.Width = 80;
            // 
            // SearchCustomerLabel
            // 
            SearchCustomerLabel.Appearance.Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchCustomerLabel.Appearance.ForeColor = Color.Teal;
            SearchCustomerLabel.Appearance.Options.UseFont = true;
            SearchCustomerLabel.Appearance.Options.UseForeColor = true;
            SearchCustomerLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            SearchCustomerLabel.Location = new Point(93, 9);
            SearchCustomerLabel.Name = "SearchCustomerLabel";
            SearchCustomerLabel.Size = new Size(64, 30);
            SearchCustomerLabel.TabIndex = 14;
            SearchCustomerLabel.Text = "label1";
            // 
            // SearchProductLabel
            // 
            SearchProductLabel.Appearance.Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchProductLabel.Appearance.ForeColor = Color.Teal;
            SearchProductLabel.Appearance.Options.UseFont = true;
            SearchProductLabel.Appearance.Options.UseForeColor = true;
            SearchProductLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            SearchProductLabel.Location = new Point(768, 9);
            SearchProductLabel.Name = "SearchProductLabel";
            SearchProductLabel.Size = new Size(64, 30);
            SearchProductLabel.TabIndex = 15;
            SearchProductLabel.Text = "label1";
            // 
            // ProductInRequestFormDataGridView
            // 
            ProductInRequestFormDataGridView.AllowUserToAddRows = false;
            ProductInRequestFormDataGridView.AllowUserToDeleteRows = false;
            ProductInRequestFormDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ProductInRequestFormDataGridView.BackgroundColor = Color.MistyRose;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            ProductInRequestFormDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            ProductInRequestFormDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductInRequestFormDataGridView.Columns.AddRange(new DataGridViewColumn[] { ProductCode, ProductName, ProductLastPrice, ProductLastStock, ProductUnit });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            ProductInRequestFormDataGridView.DefaultCellStyle = dataGridViewCellStyle10;
            ProductInRequestFormDataGridView.Location = new Point(538, 43);
            ProductInRequestFormDataGridView.Name = "ProductInRequestFormDataGridView";
            ProductInRequestFormDataGridView.ReadOnly = true;
            ProductInRequestFormDataGridView.RowTemplate.Height = 25;
            ProductInRequestFormDataGridView.Size = new Size(758, 150);
            ProductInRequestFormDataGridView.TabIndex = 16;
            // 
            // ProductCode
            // 
            ProductCode.HeaderText = "Code";
            ProductCode.Name = "ProductCode";
            ProductCode.ReadOnly = true;
            ProductCode.Width = 50;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 240;
            // 
            // ProductLastPrice
            // 
            ProductLastPrice.HeaderText = "Last Price";
            ProductLastPrice.Name = "ProductLastPrice";
            ProductLastPrice.ReadOnly = true;
            ProductLastPrice.Width = 175;
            // 
            // ProductLastStock
            // 
            ProductLastStock.HeaderText = "Last Stock";
            ProductLastStock.Name = "ProductLastStock";
            ProductLastStock.ReadOnly = true;
            ProductLastStock.Width = 150;
            // 
            // ProductUnit
            // 
            ProductUnit.HeaderText = "Unit";
            ProductUnit.Name = "ProductUnit";
            ProductUnit.ReadOnly = true;
            // 
            // RialsLabel
            // 
            RialsLabel.Anchor = AnchorStyles.Left;
            RialsLabel.Appearance.BackColor = Color.Transparent;
            RialsLabel.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RialsLabel.Appearance.ForeColor = Color.Teal;
            RialsLabel.Appearance.Options.UseBackColor = true;
            RialsLabel.Appearance.Options.UseFont = true;
            RialsLabel.Appearance.Options.UseForeColor = true;
            RialsLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            RialsLabel.Location = new Point(407, 438);
            RialsLabel.Name = "RialsLabel";
            RialsLabel.Size = new Size(88, 30);
            RialsLabel.TabIndex = 17;
            RialsLabel.Text = "Rials";
            // 
            // RequestFormDataGridView
            // 
            RequestFormDataGridView.AllowUserToAddRows = false;
            RequestFormDataGridView.AllowUserToDeleteRows = false;
            RequestFormDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            RequestFormDataGridView.BackgroundColor = Color.MistyRose;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            RequestFormDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            RequestFormDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RequestFormDataGridView.Columns.AddRange(new DataGridViewColumn[] { RequestRow, RequestProductName, RequestProductCount, RequestProductUnit, RequestProductPrice });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            RequestFormDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            RequestFormDataGridView.Location = new Point(538, 254);
            RequestFormDataGridView.Name = "RequestFormDataGridView";
            RequestFormDataGridView.ReadOnly = true;
            RequestFormDataGridView.RowTemplate.Height = 25;
            RequestFormDataGridView.Size = new Size(758, 213);
            RequestFormDataGridView.TabIndex = 18;
            // 
            // RequestRow
            // 
            RequestRow.HeaderText = "Row";
            RequestRow.Name = "RequestRow";
            RequestRow.ReadOnly = true;
            RequestRow.Width = 50;
            // 
            // RequestProductName
            // 
            RequestProductName.HeaderText = "Product Name";
            RequestProductName.Name = "RequestProductName";
            RequestProductName.ReadOnly = true;
            RequestProductName.Width = 250;
            // 
            // RequestProductCount
            // 
            RequestProductCount.HeaderText = "Count";
            RequestProductCount.Name = "RequestProductCount";
            RequestProductCount.ReadOnly = true;
            RequestProductCount.Width = 80;
            // 
            // RequestProductUnit
            // 
            RequestProductUnit.HeaderText = "Unit";
            RequestProductUnit.Name = "RequestProductUnit";
            RequestProductUnit.ReadOnly = true;
            RequestProductUnit.Width = 115;
            // 
            // RequestProductPrice
            // 
            RequestProductPrice.HeaderText = "Product Price";
            RequestProductPrice.Name = "RequestProductPrice";
            RequestProductPrice.ReadOnly = true;
            RequestProductPrice.Width = 220;
            // 
            // SearchCustomerTextBox
            // 
            SearchCustomerTextBox.BackColor = Color.PowderBlue;
            SearchCustomerTextBox.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchCustomerTextBox.Location = new Point(152, 9);
            SearchCustomerTextBox.Name = "SearchCustomerTextBox";
            SearchCustomerTextBox.Size = new Size(250, 27);
            SearchCustomerTextBox.TabIndex = 0;
            SearchCustomerTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SearchProductTextBox
            // 
            SearchProductTextBox.BackColor = Color.PowderBlue;
            SearchProductTextBox.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchProductTextBox.Location = new Point(827, 9);
            SearchProductTextBox.Name = "SearchProductTextBox";
            SearchProductTextBox.Size = new Size(250, 27);
            SearchProductTextBox.TabIndex = 3;
            SearchProductTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Row
            // 
            Row.HeaderText = "Row";
            Row.Name = "Row";
            Row.ReadOnly = true;
            Row.Width = 50;
            // 
            // CountTextBox
            // 
            CountTextBox.BackColor = Color.PowderBlue;
            CountTextBox.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CountTextBox.Location = new Point(669, 204);
            CountTextBox.Name = "CountTextBox";
            CountTextBox.Size = new Size(65, 27);
            CountTextBox.TabIndex = 4;
            CountTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // RequestForm
            // 
            Appearance.BackColor = Color.LightGoldenrodYellow;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 518);
            Controls.Add(CountTextBox);
            Controls.Add(SearchProductTextBox);
            Controls.Add(SearchCustomerTextBox);
            Controls.Add(RequestFormDataGridView);
            Controls.Add(RialsLabel);
            Controls.Add(ProductInRequestFormDataGridView);
            Controls.Add(SearchProductLabel);
            Controls.Add(SearchCustomerLabel);
            Controls.Add(CustomerInRequestFormDataGridView);
            Controls.Add(AmountLabel);
            Controls.Add(CustomerFullNameLabel);
            Controls.Add(UserFullNameLabel);
            Controls.Add(DateRequestLabel);
            Controls.Add(NumberRequestLabel);
            Controls.Add(TotalAmountLabel);
            Controls.Add(CustomerLabel);
            Controls.Add(RegistrarLabel);
            Controls.Add(DateLabel);
            Controls.Add(NumberLabel);
            Controls.Add(CountLabel);
            Controls.Add(InvoiceButton);
            Controls.Add(AddToShopingButton);
            Controls.Add(AddToRequestButton);
            Controls.Add(PrintInventoryTransferButton);
            Controls.Add(DeleteButton);
            Controls.Add(PrintInvoiceButton);
            Controls.Add(InventoryTransferButton);
            Margin = new Padding(7, 6, 7, 6);
            MaximizeBox = false;
            Name = "RequestForm";
            Text = "InventoryTransferForm";
            Load += InventoryTransferForm_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerInRequestFormDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductInRequestFormDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)RequestFormDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Usf.WinForms.Forms.Button InventoryTransferButton;
        private Usf.WinForms.Forms.Button AddToRequestButton;
        private Usf.WinForms.Forms.TextBox textBox4;
        private DataGridView dataGridView3;
        private Usf.WinForms.Forms.Button PrintInventoryTransferButton;
        private Usf.WinForms.Forms.Button PrintInvoiceButton;
        private Usf.WinForms.Forms.Button DeleteButton;
        private Usf.WinForms.Forms.Button InvoiceButton;
        private Usf.WinForms.Forms.Button AddToShopingButton;
        private Usf.WinForms.Forms.Label CountLabel;
        private Usf.WinForms.Forms.Label NumberLabel;
        private Usf.WinForms.Forms.Label DateLabel;
        private Usf.WinForms.Forms.Label RegistrarLabel;
        private Usf.WinForms.Forms.Label CustomerLabel;
        private Usf.WinForms.Forms.Label TotalAmountLabel;
        private Usf.WinForms.Forms.Label NumberRequestLabel;
        private Usf.WinForms.Forms.Label DateRequestLabel;
        private Usf.WinForms.Forms.Label UserFullNameLabel;
        private Usf.WinForms.Forms.Label CustomerFullNameLabel;
        private Usf.WinForms.Forms.Label AmountLabel;
        private DataGridViewTextBoxColumn ProductCount;
        private DataGridViewTextBoxColumn Column1;
        private Usf.WinForms.Forms.DataGridView CustomerInRequestFormDataGridView;
        private Usf.WinForms.Forms.Label SearchCustomerLabel;
        private Usf.WinForms.Forms.Label SearchProductLabel;
        private Usf.WinForms.Forms.TextBox SearchCustomerTextBox;
        private Usf.WinForms.Forms.DataGridView ProductInRequestFormDataGridView;
        private Usf.WinForms.Forms.Label RialsLabel;
        private Usf.WinForms.Forms.DataGridView RequestFormDataGridView;
        private Usf.WinForms.Forms.TextBox SearchProductTextBox;
        private DataGridViewTextBoxColumn CustomerCode;
        private DataGridViewTextBoxColumn CustomerFirstName;
        private DataGridViewTextBoxColumn CustomerLastName;
        private DataGridViewTextBoxColumn CustomerTel;
        private DataGridViewTextBoxColumn CustomerType;
        private DataGridViewTextBoxColumn Row;
        private Usf.WinForms.Forms.TextBox CountTextBox;
        private DataGridViewTextBoxColumn RequestRow;
        private DataGridViewTextBoxColumn RequestProductName;
        private DataGridViewTextBoxColumn RequestProductCount;
        private DataGridViewTextBoxColumn RequestProductUnit;
        private DataGridViewTextBoxColumn RequestProductPrice;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductLastPrice;
        private DataGridViewTextBoxColumn ProductLastStock;
        private DataGridViewTextBoxColumn ProductUnit;
    }
}
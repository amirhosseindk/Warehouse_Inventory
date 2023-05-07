namespace MyApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            MenuButton = new ToolStripDropDownButton();
            UsersButton = new ToolStripMenuItem();
            CustomersButton = new ToolStripMenuItem();
            ProductsButton = new ToolStripMenuItem();
            SupplersButton = new ToolStripMenuItem();
            StoreroomsButton = new ToolStripMenuItem();
            StorekeepersButton = new ToolStripMenuItem();
            MaesureUnitsButton = new ToolStripMenuItem();
            CountriesButton = new ToolStripMenuItem();
            LoginsHistorButton = new ToolStripMenuItem();
            AccessButton = new ToolStripMenuItem();
            PasswordButton = new ToolStripMenuItem();
            BackupButton = new ToolStripMenuItem();
            AboutButton = new ToolStripMenuItem();
            RequestInMainFormButton = new ToolStripButton();
            InventoryTransferInMainFormButton = new ToolStripButton();
            FactorInMainFormButton = new ToolStripButton();
            ShopingInMainFormButton = new ToolStripButton();
            ReportsInMainFormButton = new ToolStripButton();
            MessagesInMainFormButton = new ToolStripButton();
            pictureBox1 = new PictureBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.PowderBlue;
            toolStrip1.Font = new Font("IRANYekan Medium", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            toolStrip1.Items.AddRange(new ToolStripItem[] { MenuButton, RequestInMainFormButton, InventoryTransferInMainFormButton, FactorInMainFormButton, ShopingInMainFormButton, ReportsInMainFormButton, MessagesInMainFormButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(788, 83);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // MenuButton
            // 
            MenuButton.AutoSize = false;
            MenuButton.DropDownItems.AddRange(new ToolStripItem[] { UsersButton, CustomersButton, ProductsButton, SupplersButton, StoreroomsButton, StorekeepersButton, MaesureUnitsButton, CountriesButton, LoginsHistorButton, AccessButton, PasswordButton, BackupButton, AboutButton });
            MenuButton.Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MenuButton.Image = (Image)resources.GetObject("MenuButton.Image");
            MenuButton.ImageScaling = ToolStripItemImageScaling.None;
            MenuButton.ImageTransparentColor = Color.Magenta;
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(100, 76);
            MenuButton.Text = "Menu";
            MenuButton.TextDirection = ToolStripTextDirection.Horizontal;
            MenuButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // UsersButton
            // 
            UsersButton.BackColor = Color.LightSkyBlue;
            UsersButton.Image = (Image)resources.GetObject("UsersButton.Image");
            UsersButton.ImageScaling = ToolStripItemImageScaling.None;
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(216, 54);
            UsersButton.Text = "Users";
            UsersButton.Click += MenuButton_Click;
            // 
            // CustomersButton
            // 
            CustomersButton.BackColor = Color.DeepSkyBlue;
            CustomersButton.Image = (Image)resources.GetObject("CustomersButton.Image");
            CustomersButton.ImageScaling = ToolStripItemImageScaling.None;
            CustomersButton.Name = "CustomersButton";
            CustomersButton.Size = new Size(216, 54);
            CustomersButton.Text = "Customers";
            CustomersButton.Click += MenuButton_Click;
            // 
            // ProductsButton
            // 
            ProductsButton.BackColor = Color.LightSkyBlue;
            ProductsButton.Image = (Image)resources.GetObject("ProductsButton.Image");
            ProductsButton.ImageScaling = ToolStripItemImageScaling.None;
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(216, 54);
            ProductsButton.Text = "Products";
            ProductsButton.Click += MenuButton_Click;
            // 
            // SupplersButton
            // 
            SupplersButton.BackColor = Color.DeepSkyBlue;
            SupplersButton.Image = (Image)resources.GetObject("SupplersButton.Image");
            SupplersButton.ImageScaling = ToolStripItemImageScaling.None;
            SupplersButton.Name = "SupplersButton";
            SupplersButton.Size = new Size(216, 54);
            SupplersButton.Text = "Suppler";
            SupplersButton.Click += MenuButton_Click;
            // 
            // StoreroomsButton
            // 
            StoreroomsButton.BackColor = Color.LightSkyBlue;
            StoreroomsButton.Image = (Image)resources.GetObject("StoreroomsButton.Image");
            StoreroomsButton.ImageScaling = ToolStripItemImageScaling.None;
            StoreroomsButton.Name = "StoreroomsButton";
            StoreroomsButton.Size = new Size(216, 54);
            StoreroomsButton.Text = "Storeroom";
            StoreroomsButton.Click += MenuButton_Click;
            // 
            // StorekeepersButton
            // 
            StorekeepersButton.BackColor = Color.DeepSkyBlue;
            StorekeepersButton.Image = (Image)resources.GetObject("StorekeepersButton.Image");
            StorekeepersButton.ImageScaling = ToolStripItemImageScaling.None;
            StorekeepersButton.Name = "StorekeepersButton";
            StorekeepersButton.Size = new Size(216, 54);
            StorekeepersButton.Text = "Storekeeper";
            StorekeepersButton.Click += MenuButton_Click;
            // 
            // MaesureUnitsButton
            // 
            MaesureUnitsButton.BackColor = Color.LightSkyBlue;
            MaesureUnitsButton.Image = (Image)resources.GetObject("MaesureUnitsButton.Image");
            MaesureUnitsButton.ImageScaling = ToolStripItemImageScaling.None;
            MaesureUnitsButton.Name = "MaesureUnitsButton";
            MaesureUnitsButton.Size = new Size(216, 54);
            MaesureUnitsButton.Text = "Unit";
            MaesureUnitsButton.Click += MenuButton_Click;
            // 
            // CountriesButton
            // 
            CountriesButton.BackColor = Color.DeepSkyBlue;
            CountriesButton.Image = (Image)resources.GetObject("CountriesButton.Image");
            CountriesButton.ImageScaling = ToolStripItemImageScaling.None;
            CountriesButton.Name = "CountriesButton";
            CountriesButton.Size = new Size(216, 54);
            CountriesButton.Text = "Country";
            CountriesButton.Click += MenuButton_Click;
            // 
            // LoginsHistorButton
            // 
            LoginsHistorButton.BackColor = Color.LightSkyBlue;
            LoginsHistorButton.Image = (Image)resources.GetObject("LoginsHistorButton.Image");
            LoginsHistorButton.ImageScaling = ToolStripItemImageScaling.None;
            LoginsHistorButton.Name = "LoginsHistorButton";
            LoginsHistorButton.Size = new Size(216, 54);
            LoginsHistorButton.Text = "Login Histor";
            LoginsHistorButton.Click += MenuButton_Click;
            // 
            // AccessButton
            // 
            AccessButton.BackColor = Color.DeepSkyBlue;
            AccessButton.Image = (Image)resources.GetObject("AccessButton.Image");
            AccessButton.ImageScaling = ToolStripItemImageScaling.None;
            AccessButton.Name = "AccessButton";
            AccessButton.Size = new Size(216, 54);
            AccessButton.Text = "Access";
            AccessButton.Click += MenuButton_Click;
            // 
            // PasswordButton
            // 
            PasswordButton.BackColor = Color.LightSkyBlue;
            PasswordButton.Image = (Image)resources.GetObject("PasswordButton.Image");
            PasswordButton.ImageScaling = ToolStripItemImageScaling.None;
            PasswordButton.Name = "PasswordButton";
            PasswordButton.Size = new Size(216, 54);
            PasswordButton.Text = "Password";
            PasswordButton.Click += MenuButton_Click;
            // 
            // BackupButton
            // 
            BackupButton.BackColor = Color.DeepSkyBlue;
            BackupButton.Image = (Image)resources.GetObject("BackupButton.Image");
            BackupButton.ImageScaling = ToolStripItemImageScaling.None;
            BackupButton.Name = "BackupButton";
            BackupButton.Size = new Size(216, 54);
            BackupButton.Text = "Backup";
            BackupButton.Click += MenuButton_Click;
            // 
            // AboutButton
            // 
            AboutButton.BackColor = Color.LightSkyBlue;
            AboutButton.Image = (Image)resources.GetObject("AboutButton.Image");
            AboutButton.ImageScaling = ToolStripItemImageScaling.None;
            AboutButton.Name = "AboutButton";
            AboutButton.Size = new Size(216, 54);
            AboutButton.Text = "About us";
            AboutButton.Click += MenuButton_Click;
            // 
            // RequestInMainFormButton
            // 
            RequestInMainFormButton.AutoSize = false;
            RequestInMainFormButton.BackColor = Color.Orange;
            RequestInMainFormButton.Image = (Image)resources.GetObject("RequestInMainFormButton.Image");
            RequestInMainFormButton.ImageScaling = ToolStripItemImageScaling.None;
            RequestInMainFormButton.ImageTransparentColor = Color.Magenta;
            RequestInMainFormButton.Name = "RequestInMainFormButton";
            RequestInMainFormButton.Size = new Size(170, 80);
            RequestInMainFormButton.Text = "Request";
            RequestInMainFormButton.TextImageRelation = TextImageRelation.ImageAboveText;
            RequestInMainFormButton.Click += Button_Click;
            // 
            // InventoryTransferInMainFormButton
            // 
            InventoryTransferInMainFormButton.AutoSize = false;
            InventoryTransferInMainFormButton.Image = (Image)resources.GetObject("InventoryTransferInMainFormButton.Image");
            InventoryTransferInMainFormButton.ImageScaling = ToolStripItemImageScaling.None;
            InventoryTransferInMainFormButton.ImageTransparentColor = Color.Magenta;
            InventoryTransferInMainFormButton.Name = "InventoryTransferInMainFormButton";
            InventoryTransferInMainFormButton.Size = new Size(100, 80);
            InventoryTransferInMainFormButton.Text = "Transfers";
            InventoryTransferInMainFormButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // FactorInMainFormButton
            // 
            FactorInMainFormButton.AutoSize = false;
            FactorInMainFormButton.Image = (Image)resources.GetObject("FactorInMainFormButton.Image");
            FactorInMainFormButton.ImageScaling = ToolStripItemImageScaling.None;
            FactorInMainFormButton.ImageTransparentColor = Color.Magenta;
            FactorInMainFormButton.Name = "FactorInMainFormButton";
            FactorInMainFormButton.Size = new Size(100, 80);
            FactorInMainFormButton.Text = "Factor";
            FactorInMainFormButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ShopingInMainFormButton
            // 
            ShopingInMainFormButton.AutoSize = false;
            ShopingInMainFormButton.Image = (Image)resources.GetObject("ShopingInMainFormButton.Image");
            ShopingInMainFormButton.ImageScaling = ToolStripItemImageScaling.None;
            ShopingInMainFormButton.ImageTransparentColor = Color.Magenta;
            ShopingInMainFormButton.Name = "ShopingInMainFormButton";
            ShopingInMainFormButton.Size = new Size(100, 80);
            ShopingInMainFormButton.Text = "Shoping";
            ShopingInMainFormButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ReportsInMainFormButton
            // 
            ReportsInMainFormButton.AutoSize = false;
            ReportsInMainFormButton.Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ReportsInMainFormButton.Image = (Image)resources.GetObject("ReportsInMainFormButton.Image");
            ReportsInMainFormButton.ImageScaling = ToolStripItemImageScaling.None;
            ReportsInMainFormButton.ImageTransparentColor = Color.Magenta;
            ReportsInMainFormButton.Name = "ReportsInMainFormButton";
            ReportsInMainFormButton.Size = new Size(100, 76);
            ReportsInMainFormButton.Text = "Reports";
            ReportsInMainFormButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MessagesInMainFormButton
            // 
            MessagesInMainFormButton.AutoSize = false;
            MessagesInMainFormButton.Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MessagesInMainFormButton.Image = (Image)resources.GetObject("MessagesInMainFormButton.Image");
            MessagesInMainFormButton.ImageScaling = ToolStripItemImageScaling.None;
            MessagesInMainFormButton.ImageTransparentColor = Color.Magenta;
            MessagesInMainFormButton.Name = "MessagesInMainFormButton";
            MessagesInMainFormButton.Size = new Size(100, 76);
            MessagesInMainFormButton.Text = "Messages";
            MessagesInMainFormButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 83);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(788, 385);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            Appearance.BackColor = Color.LightGoldenrodYellow;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 468);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(7, 9, 7, 9);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton MessagesInMainFormButton;
        private ToolStripButton ReportsInMainFormButton;
        private ToolStripDropDownButton MenuButton;
        private ToolStripMenuItem UsersButton;
        private ToolStripMenuItem AccessButton;
        private ToolStripMenuItem PasswordButton;
        private ToolStripMenuItem BackupButton;
        private PictureBox pictureBox1;
        private ToolStripMenuItem AboutButton;
        private ToolStripMenuItem SupplersButton;
        private ToolStripMenuItem StoreroomsButton;
        private ToolStripMenuItem StorekeepersButton;
        private ToolStripMenuItem MaesureUnitsButton;
        private ToolStripMenuItem CountriesButton;
        private ToolStripMenuItem LoginsHistorButton;
        private ToolStripButton RequestInMainFormButton;
        private ToolStripMenuItem CustomersButton;
        private ToolStripMenuItem ProductsButton;
        private ToolStripButton InventoryTransferInMainFormButton;
        private ToolStripButton FactorInMainFormButton;
        private ToolStripButton ShopingInMainFormButton;
    }
}
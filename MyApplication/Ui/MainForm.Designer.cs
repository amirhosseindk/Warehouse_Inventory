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
            SupplersButton = new ToolStripMenuItem();
            CustomersButton = new ToolStripMenuItem();
            StoreroomsButton = new ToolStripMenuItem();
            StorekeepersButton = new ToolStripMenuItem();
            UnitsButton = new ToolStripMenuItem();
            CountriesButton = new ToolStripMenuItem();
            LoginHistorButton = new ToolStripMenuItem();
            AccessButton = new ToolStripMenuItem();
            PasswordButton = new ToolStripMenuItem();
            BackupButton = new ToolStripMenuItem();
            AboutButton = new ToolStripMenuItem();
            ProductsButton = new ToolStripButton();
            ReportsButton = new ToolStripButton();
            MessagesButton = new ToolStripButton();
            pictureBox1 = new PictureBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.PowderBlue;
            toolStrip1.Font = new Font("IRANYekan Medium", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            toolStrip1.Items.AddRange(new ToolStripItem[] { MenuButton, ProductsButton, ReportsButton, MessagesButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(429, 79);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // MenuButton
            // 
            MenuButton.AutoSize = false;
            MenuButton.DropDownItems.AddRange(new ToolStripItem[] { UsersButton, SupplersButton, CustomersButton, StoreroomsButton, StorekeepersButton, UnitsButton, CountriesButton, LoginHistorButton, AccessButton, PasswordButton, BackupButton, AboutButton });
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
            // SupplersButton
            // 
            SupplersButton.BackColor = Color.DeepSkyBlue;
            SupplersButton.Image = (Image)resources.GetObject("SupplersButton.Image");
            SupplersButton.ImageScaling = ToolStripItemImageScaling.None;
            SupplersButton.Name = "SupplersButton";
            SupplersButton.Size = new Size(216, 54);
            SupplersButton.Text = "Suppler";
            // 
            // CustomersButton
            // 
            CustomersButton.BackColor = Color.LightSkyBlue;
            CustomersButton.Image = (Image)resources.GetObject("CustomersButton.Image");
            CustomersButton.ImageScaling = ToolStripItemImageScaling.None;
            CustomersButton.Name = "CustomersButton";
            CustomersButton.Size = new Size(216, 54);
            CustomersButton.Text = "Customer";
            CustomersButton.Click += MenuButton_Click;
            // 
            // StoreroomsButton
            // 
            StoreroomsButton.BackColor = Color.DeepSkyBlue;
            StoreroomsButton.Image = (Image)resources.GetObject("StoreroomsButton.Image");
            StoreroomsButton.ImageScaling = ToolStripItemImageScaling.None;
            StoreroomsButton.Name = "StoreroomsButton";
            StoreroomsButton.Size = new Size(216, 54);
            StoreroomsButton.Text = "Storeroom";
            // 
            // StorekeepersButton
            // 
            StorekeepersButton.BackColor = Color.LightSkyBlue;
            StorekeepersButton.Image = (Image)resources.GetObject("StorekeepersButton.Image");
            StorekeepersButton.ImageScaling = ToolStripItemImageScaling.None;
            StorekeepersButton.Name = "StorekeepersButton";
            StorekeepersButton.Size = new Size(216, 54);
            StorekeepersButton.Text = "Storekeeper";
            // 
            // UnitsButton
            // 
            UnitsButton.BackColor = Color.DeepSkyBlue;
            UnitsButton.Image = (Image)resources.GetObject("UnitsButton.Image");
            UnitsButton.ImageScaling = ToolStripItemImageScaling.None;
            UnitsButton.Name = "UnitsButton";
            UnitsButton.Size = new Size(216, 54);
            UnitsButton.Text = "Unit";
            // 
            // CountriesButton
            // 
            CountriesButton.BackColor = Color.LightSkyBlue;
            CountriesButton.Image = (Image)resources.GetObject("CountriesButton.Image");
            CountriesButton.ImageScaling = ToolStripItemImageScaling.None;
            CountriesButton.Name = "CountriesButton";
            CountriesButton.Size = new Size(216, 54);
            CountriesButton.Text = "Country";
            // 
            // LoginHistorButton
            // 
            LoginHistorButton.BackColor = Color.DeepSkyBlue;
            LoginHistorButton.Image = (Image)resources.GetObject("LoginHistorButton.Image");
            LoginHistorButton.ImageScaling = ToolStripItemImageScaling.None;
            LoginHistorButton.Name = "LoginHistorButton";
            LoginHistorButton.Size = new Size(216, 54);
            LoginHistorButton.Text = "Login Histor";
            // 
            // AccessButton
            // 
            AccessButton.BackColor = Color.LightSkyBlue;
            AccessButton.Image = (Image)resources.GetObject("AccessButton.Image");
            AccessButton.ImageScaling = ToolStripItemImageScaling.None;
            AccessButton.Name = "AccessButton";
            AccessButton.Size = new Size(216, 54);
            AccessButton.Text = "Access";
            AccessButton.Click += MenuButton_Click;
            // 
            // PasswordButton
            // 
            PasswordButton.BackColor = Color.DeepSkyBlue;
            PasswordButton.Image = (Image)resources.GetObject("PasswordButton.Image");
            PasswordButton.ImageScaling = ToolStripItemImageScaling.None;
            PasswordButton.Name = "PasswordButton";
            PasswordButton.Size = new Size(216, 54);
            PasswordButton.Text = "Password";
            PasswordButton.Click += MenuButton_Click;
            // 
            // BackupButton
            // 
            BackupButton.BackColor = Color.LightSkyBlue;
            BackupButton.Image = (Image)resources.GetObject("BackupButton.Image");
            BackupButton.ImageScaling = ToolStripItemImageScaling.None;
            BackupButton.Name = "BackupButton";
            BackupButton.Size = new Size(216, 54);
            BackupButton.Text = "Backup";
            BackupButton.Click += MenuButton_Click;
            // 
            // AboutButton
            // 
            AboutButton.BackColor = Color.DeepSkyBlue;
            AboutButton.Image = (Image)resources.GetObject("AboutButton.Image");
            AboutButton.ImageScaling = ToolStripItemImageScaling.None;
            AboutButton.Name = "AboutButton";
            AboutButton.Size = new Size(216, 54);
            AboutButton.Text = "About us";
            // 
            // ProductsButton
            // 
            ProductsButton.AutoSize = false;
            ProductsButton.BackColor = Color.Orange;
            ProductsButton.Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ProductsButton.Image = (Image)resources.GetObject("ProductsButton.Image");
            ProductsButton.ImageScaling = ToolStripItemImageScaling.None;
            ProductsButton.ImageTransparentColor = Color.Magenta;
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(100, 76);
            ProductsButton.Text = "Product";
            ProductsButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ProductsButton.Click += Button_Click;
            // 
            // ReportsButton
            // 
            ReportsButton.AutoSize = false;
            ReportsButton.Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ReportsButton.Image = (Image)resources.GetObject("ReportsButton.Image");
            ReportsButton.ImageScaling = ToolStripItemImageScaling.None;
            ReportsButton.ImageTransparentColor = Color.Magenta;
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Size = new Size(100, 76);
            ReportsButton.Text = "Report";
            ReportsButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MessagesButton
            // 
            MessagesButton.AutoSize = false;
            MessagesButton.Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MessagesButton.Image = (Image)resources.GetObject("MessagesButton.Image");
            MessagesButton.ImageScaling = ToolStripItemImageScaling.None;
            MessagesButton.ImageTransparentColor = Color.Magenta;
            MessagesButton.Name = "MessagesButton";
            MessagesButton.Size = new Size(100, 76);
            MessagesButton.Text = "Message";
            MessagesButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 79);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 389);
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
            ClientSize = new Size(429, 468);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(7, 9, 7, 9);
            Name = "MainForm";
            ShowInTaskbar = false;
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
        private ToolStripButton ProductsButton;
        private ToolStripButton MessagesButton;
        private ToolStripButton ReportsButton;
        private ToolStripDropDownButton MenuButton;
        private ToolStripMenuItem UsersButton;
        private ToolStripMenuItem AccessButton;
        private ToolStripMenuItem PasswordButton;
        private ToolStripMenuItem CustomersButton;
        private ToolStripMenuItem BackupButton;
        private PictureBox pictureBox1;
        private ToolStripMenuItem AboutButton;
        private ToolStripMenuItem SupplersButton;
        private ToolStripMenuItem StoreroomsButton;
        private ToolStripMenuItem StorekeepersButton;
        private ToolStripMenuItem UnitsButton;
        private ToolStripMenuItem CountriesButton;
        private ToolStripMenuItem LoginHistorButton;
    }
}
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class MainForm : Usf.WinForms.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();

            #region Language

            ResourceManager resource = new ResourceManager
                ("Resources.DataDictionary", typeof(Resources.DataDictionary).Assembly);

            ProductsButton.Text =
                resource.GetString(name: nameof(ProductsButton));

            ReportsButton.Text =
                resource.GetString(name: nameof(ReportsButton));

            MessagesButton.Text =
                resource.GetString(name: nameof(MessagesButton));

            MenuButton.Text =
                resource.GetString(name: nameof(MenuButton));

            UsersButton.Text =
                resource.GetString(name: nameof(UsersButton));

            SupplersButton.Text =
                resource.GetString(name: nameof(SupplersButton));

            CustomersButton.Text =
                resource.GetString(name: nameof(CustomersButton));

            StoreroomsButton.Text =
                resource.GetString(name: nameof(StoreroomsButton));

            StorekeepersButton.Text =
                resource.GetString(name: nameof(StorekeepersButton));

            UnitsButton.Text =
                resource.GetString(name: nameof(UnitsButton));

            CountriesButton.Text =
                resource.GetString(name: nameof(CountriesButton));

            AccessButton.Text =
                resource.GetString(name: nameof(AccessButton));

            PasswordButton.Text =
                resource.GetString(name: nameof(PasswordButton));

            BackupButton.Text =
                resource.GetString(name: nameof(BackupButton));

            AboutButton.Text =
                resource.GetString(name: nameof(AboutButton));

            this.Text =
                resource.GetString(name: nameof(MainForm));

            #endregion / Language

        }

        // Loaded
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }
        }

        // Click on Setting Button 
        private void MenuButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripMenuItem? Itembutton =
                sender as System.Windows.Forms.ToolStripMenuItem;

            if (Itembutton != null)
            {
                switch (Itembutton.Name)
                {
                    case "UsersButton":
                        {
                            new UsersForm().ShowDialog();
                            break;
                        }
                    case "AccessButton":
                        {
                            new AccessForm().ShowDialog();
                            break;
                        }
                    case "PasswordButton":
                        {
                            new PasswordForm().ShowDialog();
                            break;
                        }
                    case "CustomersButton":
                        {
                            new CustomerForm().ShowDialog();
                            break;
                        }
                    case "BackupButton":
                        {
                            new BackupForm().ShowDialog();
                            break;
                        }
                }
            }
        }

        // Click on Button in the Menu
        private void Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripButton? button =
                sender as System.Windows.Forms.ToolStripButton;

            if (button != null)
            {
                switch (button.Name)
                {
                    case "ProductsButton":
                        {
                            new ProductsForm().ShowDialog();
                            break;
                        }

                }
            }
        }
    }
}
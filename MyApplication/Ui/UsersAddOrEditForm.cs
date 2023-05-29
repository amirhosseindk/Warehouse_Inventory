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

namespace MyApplication.Ui
{
    public partial class UsersAddOrEditForm : Usf.WinForms.Forms.Form
    {
        public UsersAddOrEditForm()
        {
            InitializeComponent();

            #region Language

            ResourceManager resource = new ResourceManager
                ("Resources.DataDictionary", typeof(Resources.DataDictionary).Assembly);

            StartDateLabel.Text =
                resource.GetString(name: nameof(StartDateLabel));

            FirstNameLabel.Text =
                resource.GetString(name: nameof(FirstNameLabel));

            LastNameLabel.Text =
                resource.GetString(name: nameof(LastNameLabel));

            TelLabel.Text =
                resource.GetString(name: nameof(TelLabel));

            UsernameLabel.Text =
                resource.GetString(name: nameof(UsernameLabel));

            PasswordLabel.Text =
                resource.GetString(name: nameof(PasswordLabel));

            RolLabel.Text =
                resource.GetString(name: nameof(RolLabel));

            EmailLabel.Text =
                resource.GetString(name: nameof(EmailLabel));

            AddressLabel.Text =
                resource.GetString(name: nameof(AddressLabel));

            BirthdateLabel.Text =
                resource.GetString(name: nameof(BirthdateLabel));

            AgeLabel.Text =
                resource.GetString(name: nameof(AgeLabel));

            ActiveCheckBox.Text =
                resource.GetString(name: nameof(ActiveCheckBox));

            GenderLabel.Text =
                resource.GetString(name: nameof(GenderLabel));

            MenRadioButton.Text =
                resource.GetString(name: nameof(MenRadioButton));

            WomenRadioButton.Text =
                resource.GetString(name: nameof(WomenRadioButton));

            SaveButton.Text =
                resource.GetString(name: nameof(SaveButton));

            this.Text = resource.GetString(name: nameof(UsersAddOrEditForm));

            #endregion / Language
        }

        // Loaded
        private void UsersAddOrEdit_Load(object sender, EventArgs e)
        {
            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
                AddressTextBox.TextAlign = HorizontalAlignment.Left;
            }
        }
    }
}
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
    public partial class UsersForm : Usf.WinForms.Forms.Form
    {
        public UsersForm()
        {
            InitializeComponent();

            #region Language

            ResourceManager resource = new ResourceManager
                ("Resources.DataDictionary", typeof(Resources.DataDictionary).Assembly);

            SearchLabel.Text =
                resource.GetString(name: nameof(SearchLabel));

            UserNewButton.Text =
                resource.GetString(name: nameof(UserNewButton));

            UserEditButton.Text =
                resource.GetString(name: nameof(UserEditButton));

            UserStatusButton.Text =
                resource.GetString(name: nameof(UserStatusButton));

            UserDataGridView.Columns[0].HeaderText =
                resource.GetString(name: nameof(UserStartDate));

            UserDataGridView.Columns[2].HeaderText =
                resource.GetString(name: nameof(UserFirstName));

            UserDataGridView.Columns[3].HeaderText =
                resource.GetString(name: nameof(UserLastName));

            UserDataGridView.Columns[4].HeaderText =
                resource.GetString(name: nameof(UserTel));

            UserDataGridView.Columns[5].HeaderText =
                resource.GetString(name: nameof(UserUsername));

            UserDataGridView.Columns[6].HeaderText =
                resource.GetString(name: nameof(UserPassword));

            UserDataGridView.Columns[7].HeaderText =
                resource.GetString(name: nameof(UserAge));

            UserDataGridView.Columns[8].HeaderText =
                resource.GetString(name: nameof(UserGender));

            UserDataGridView.Columns[9].HeaderText =
                resource.GetString(name: nameof(UserBirthdate));

            UserDataGridView.Columns[10].HeaderText =
                resource.GetString(name: nameof(UserEndDate));

            UserDataGridView.Columns[11].HeaderText =
                resource.GetString(name: nameof(UserActive));

            UserDataGridView.Columns[12].HeaderText =
                resource.GetString(name: nameof(UserDescription));

            this.Text =
                resource.GetString(name: nameof(UsersForm));

            #endregion / Language
        }

        // Loaded
        private void UsersForm_Load(object sender, EventArgs e)
        {
            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }
        }
    }
}
using Application.IServices;
using Application.ViewModels.UserViewModels;
using Microsoft.Extensions.DependencyInjection;
using MyApplication.Ui;
using System.Resources;

namespace MyApplication
{
    public partial class UsersForm : Usf.WinForms.Forms.Form
    {
        private readonly IUserService _userService;

        public UsersForm(IUserService userService)
        {
            _userService = userService;

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

            DeleteButton.Text =
                resource.GetString(name: nameof(DeleteButton));

            UserDataGridView.Columns[1].HeaderText =
                resource.GetString(name: nameof(FirstName));

            UserDataGridView.Columns[2].HeaderText =
                resource.GetString(name: nameof(LastName));

            UserDataGridView.Columns[3].HeaderText =
                resource.GetString(name: nameof(UserTel));

            UserDataGridView.Columns[4].HeaderText =
                resource.GetString(name: nameof(Username));

            UserDataGridView.Columns[5].HeaderText =
                resource.GetString(name: nameof(Password));

            UserDataGridView.Columns[6].HeaderText =
                resource.GetString(name: nameof(Role));

            UserDataGridView.Columns[7].HeaderText =
                resource.GetString(name: nameof(Status));

            UserDataGridView.Columns[8].HeaderText =
                resource.GetString(name: nameof(Birthdate));

            UserDataGridView.Columns[9].HeaderText =
                resource.GetString(name: nameof(Email));

            UserDataGridView.Columns[10].HeaderText =
                resource.GetString(name: nameof(Address));

            UserDataGridView.Columns[11].HeaderText =
                resource.GetString(name: nameof(Description));

            this.Text =
                resource.GetString(name: nameof(UsersForm));

            #endregion / Language

        }

        // Loaded
        private async void UsersForm_Load(object sender, EventArgs e)
        {
            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;

                this.RightToLeftLayout = true;
            }

            var usersUF = await _userService.GetUsersAsync(CancellationToken.None);

            UserDataGridView.DataSource = usersUF.ToList();

        }

        // Add
        private void UserNewButton_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var form = scope.ServiceProvider.GetRequiredService<UsersAddOrEditForm>();

                form.ShowDialog();
            }
        }

        // Edit
        private void UserEditButton_Click(object sender, EventArgs e)
        {
            if (UserDataGridView.SelectedRows.Count == 1)
            {
                var selectedRow = UserDataGridView.SelectedRows[0];
                var user = new UserVMId
                {
                    UserId = (Guid)selectedRow.Cells["UserIdForm"].Value
                };
                if (user.UserId != Guid.Empty)
                {
                    using (var scope = Program.ServiceProvider.CreateScope())
                    {
                        var form = scope.ServiceProvider.GetRequiredService<UsersAddOrEditForm>();
                        form.UserIdForm = user.UserId;
                        form.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("no user selected");
                }
            }
            else
            {
                MessageBox.Show("just select 1 user to use this button");
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if(UserDataGridView.SelectedRows.Count == 1)
            {
                var selectedRow = UserDataGridView.SelectedRows[0];
                var user = new UserVMId
                {
                    UserId = (Guid)selectedRow.Cells["UserIdForm"].Value
                };
                if (user.UserId != Guid.Empty)
                {
                    await _userService.DeleteUserAsync(user, CancellationToken.None);
                    UserDataGridView.Update();
                }
                else 
                {
                    MessageBox.Show("no user selected");
                }   
            }
            else
            {
                MessageBox.Show("just select 1 user to use this button");
            }
        }
    }
}
using Application.IServices;
using Application.ViewModels.UserViewModels;
using System.Resources;

namespace MyApplication.Ui
{
    public partial class UsersAddOrEditForm : Usf.WinForms.Forms.Form
    {
        public Guid UserIdForm { get; set; }
        private readonly IUserService _userService;
        private readonly IUserVMValidator _userVMValidator;

        public UsersAddOrEditForm(IUserService userService, IUserVMValidator userVMValidator)
        {
            _userService = userService;
            _userVMValidator = userVMValidator;
            InitializeComponent();

            #region Language

            ResourceManager resource = new ResourceManager
                ("Resources.DataDictionary", typeof(Resources.DataDictionary).Assembly);

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

            BirthdateLabel.Text =
                resource.GetString(name: nameof(BirthdateLabel));

            AddressLabel.Text =
                resource.GetString(name: nameof(AddressLabel));

            DescriptionLabel.Text =
                resource.GetString(name: nameof(DescriptionLabel));

            ActiveCheckBox.Text =
                resource.GetString(name: nameof(ActiveCheckBox));

            SaveButton.Text =
                resource.GetString(name: nameof(SaveButton));

            this.Text = resource.GetString(name: nameof(UsersAddOrEditForm));
            _userVMValidator = userVMValidator;

            #endregion / Language

        }

        // Loaded
        private async void UsersAddOrEdit_Load(object sender, EventArgs e)
        {
            FirstNameTextBox.Focus();

            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
                AddressTextBox.TextAlign = HorizontalAlignment.Left;
            }

            if (UserIdForm != Guid.Empty)
            {
                var user = new UserVMId
                {
                    UserId = UserIdForm
                };
                var userVM = await _userService.GetUserByIdAsync(user, CancellationToken.None);
                FirstNameTextBox.Text = userVM.FirstName;
                textBox1.Text = userVM.LastName;
                TelTextBox.Text = userVM.PhoneNumber;
                UsernameTextBox.Text = userVM.Username;
                EmailTextBox.Text = userVM.Email;
                BirthdateTextBox.Text = userVM.Birthdate.ToString();
                AddressTextBox.Text = userVM.Address;
                DescriptionTextBox.Text = userVM.Description;
            }
        }

        // Save
        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var userVM = new Application.ViewModels.UserViewModels.UserVMCU
            {
                UserId = UserIdForm != Guid.Empty ? UserIdForm : Guid.NewGuid(),
                FirstName = FirstNameTextBox.Text,
                LastName = textBox1.Text,
                PhoneNumber = TelTextBox.Text,
                Username = UsernameTextBox.Text,
                Password = PasswordTextBox.Text,
                Role = "admin",
                Birthdate = Convert.ToDateTime(BirthdateTextBox.Text),
                Email = EmailTextBox.Text,
                Address = AddressTextBox.Text,
                Description = DescriptionTextBox.Text,
                IsActive = ActiveCheckBox.Checked
            };

            var validationResult = _userVMValidator.Validate(userVM);

            if (validationResult.IsValid)
            {
                if (UserIdForm != Guid.Empty)
                {
                    await _userService.UpdateUserAsync(userVM, CancellationToken.None);
                }
                else
                {
                    await _userService.CreateUserAsync(userVM, CancellationToken.None);
                }
            }
            else
            {
                foreach (var error in validationResult.Errors)
                {
                    MessageBox.Show($"Property: {error.PropertyName}, Error: {error.ErrorMessage}");
                }
            }
        }
    }
}
using Application.IServices;
using System.Resources;

namespace MyApplication.Ui
{
    public partial class UsersAddOrEditForm : Usf.WinForms.Forms.Form
    {
        private readonly IUserService _userService;
        private readonly IUserDtoValidator _userDtoValidator;

        public UsersAddOrEditForm(IUserService userService, IUserDtoValidator userDtoValidator)
        {
            _userService = userService;
            _userDtoValidator = userDtoValidator;
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
            _userDtoValidator = userDtoValidator;

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

        private async void SaveButton_Click(object sender, EventArgs e)
        {
                var userDto = new Application.Dto.UserDto
                {
                    FirstName = FirstNameTextBox.Text,
                    LastName = textBox1.Text,
                    PhoneNumber = TelTextBox.Text,
                    Email = EmailTextBox.Text,
                    Username = UsernameTextBox.Text,
                    Password = PasswordTextBox.Text,
                    Role = "admin",
                    Address = AddressTextBox.Text,
                    UserId = Guid.NewGuid(),
                };
                var validationResult = _userDtoValidator.Validate(userDto);
                if (validationResult.IsValid)
                {
                    await _userService.CreateUserAsync(userDto, CancellationToken.None);
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
using Application.IServices;
using Domain.Entities;
using MyApplication;

namespace MyApp.Ui
{
    public partial class ConsumerAddOrEditForm : Usf.WinForms.Forms.Form
    {
        private readonly IConsumerService _consumerService;
        public Guid ConsumerIdForm { get; set; } = Guid.Empty;

        public ConsumerAddOrEditForm(IConsumerService consumerService)
        {
            _consumerService = consumerService;
            InitializeComponent();
        }

        private async void ConsumerAddOrEditForm_Load(object sender, EventArgs e)
        {
            FirstNameTextEdit.Focus();

            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;

                this.RightToLeftLayout = true;
            }

            if (ConsumerIdForm != Guid.Empty)
            {
                var consumer = await _consumerService.GetByIdAsync(ConsumerIdForm, CancellationToken.None);
                FirstNameTextEdit.Text = consumer.Name;
                LastNameTextEdit.Text = consumer.LastName;
                PhoneTextEdit.Text = consumer.Phone;
                AddressTextEdit.Text = consumer.Address;
                DescriptionTextEdit.Text = consumer.Description;
                ActiveCheckEdit.Checked = consumer.IsActive;
                EmailTextEdit.Text = consumer.Email;
            }

        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var con = new Consumer
            {
                Id = ConsumerIdForm != Guid.Empty ? ConsumerIdForm : Guid.NewGuid(),
                Name = FirstNameTextEdit.Text,
                LastName = LastNameTextEdit.Text,
                Phone = PhoneTextEdit.Text,
                Address = AddressTextEdit.Text,
                Description = DescriptionTextEdit.Text,
                IsActive = ActiveCheckEdit.Checked,
                Email = EmailTextEdit.Text,
                UsernameId = Program.usernameid
            };

            if (ConsumerIdForm != Guid.Empty)
            {
                await _consumerService.UpdateAsync(con, CancellationToken.None);
                DialogResult = DialogResult.OK;
            }
            else
            {
                await _consumerService.CreateAsync(con, CancellationToken.None);
                DialogResult = DialogResult.OK;
            }
        }
    }
}

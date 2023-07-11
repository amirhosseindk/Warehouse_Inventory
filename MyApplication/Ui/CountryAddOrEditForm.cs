using Application.IServices;
using Domain.Entities;
using MyApplication;

namespace MyApp.Ui
{
    public partial class CountryAddOrEditForm : Usf.WinForms.Forms.Form
    {
        private readonly ICountryService _countryService;
        public Guid CountryIdForm { get; set; } = Guid.Empty;

        public CountryAddOrEditForm(ICountryService countryService)
        {
            _countryService = countryService;
            InitializeComponent();
        }

        private async void CountryAddOrEditForm_Load(object sender, EventArgs e)
        {
            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }

            if (CountryIdForm != Guid.Empty)
            {
                var country = await _countryService.GetByIdAsync(CountryIdForm, CancellationToken.None);
                textBox1.Text = country.Name;
                checkBox1.Checked = country.IsActive;
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var country = new MadeInCountry
            {
                Id = CountryIdForm != Guid.Empty ? CountryIdForm : Guid.NewGuid(),
                Name = textBox1.Text,
                IsActive = checkBox1.Checked,
                UsernameId = Program.usernameid
            };
            if (CountryIdForm != Guid.Empty)
            {
                await _countryService.UpdateAsync(country, CancellationToken.None);
                DialogResult = DialogResult.OK;
            }
            else
            {
                await _countryService.CreateAsync(country, CancellationToken.None);
                DialogResult = DialogResult.OK;
            }
        }
    }
}

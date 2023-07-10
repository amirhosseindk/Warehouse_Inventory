using Application.IServices;
using System.Resources;

namespace MyApplication
{
    public partial class CountriesForm : Usf.WinForms.Forms.Form
    {
        private readonly ICountryService _countryService;
        public CountriesForm(ICountryService countryService)
        {
            _countryService = countryService;

            InitializeComponent();

            #region Language

            ResourceManager resource = new ResourceManager
               ("Resources.DataDictionary", typeof(Resources.DataDictionary).Assembly);

            this.Text =
                resource.GetString(name: nameof(CountriesForm));

            #endregion / Language
        }

        // Loaded
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }
            RefreshFormAsync();
        }

        private async void RefreshFormAsync()
        {
            var countries = await _countryService.GetAllAsync(CancellationToken.None);

            CountriesGrid.DataSource = countries.ToList();
        }
    }
}
using Application.IServices;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using Domain.Entities;
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

            // Assuming CountriesView is your TileView
            CountriesView.TileTemplate.Clear(); // Clear the existing template

            TileViewItemElement mainElement = new TileViewItemElement();
            mainElement.Column = CountriesView.Columns["Name"]; // Set the column to be displayed
            mainElement.TextAlignment = TileItemContentAlignment.MiddleCenter; // Center the text


            CountriesView.TileTemplate.Add(mainElement); // Add the element to the template
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            var country = new MadeInCountry
            {
                Name = CountryTextBox.Text,
                Id = Guid.NewGuid(),
                IsActive = ActiveCheckBox.Checked,
                UsernameId = Program.usernameid
            };
            await _countryService.CreateAsync(country, CancellationToken.None);
            RefreshFormAsync();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
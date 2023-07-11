using Application.IServices;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using Microsoft.Extensions.DependencyInjection;
using MyApplication;

namespace MyApp.Ui
{
    public partial class UnitsForm : Usf.WinForms.Forms.Form
    {
        private readonly IMeasureService _measureService;

        public UnitsForm(IMeasureService measureService)
        {
            _measureService = measureService;
            InitializeComponent();
        }

        private void UnitsForm_Load(object sender, EventArgs e)
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
            var countries = await _measureService.GetAllAsync(CancellationToken.None);

            UnitControl.DataSource = countries.ToList();

            // Assuming CountriesView is your TileView
            UnitView.TileTemplate.Clear(); // Clear the existing template

            TileViewItemElement mainElement = new TileViewItemElement();
            mainElement.Column = UnitView.Columns["Name"]; // Set the column to be displayed
            mainElement.TextAlignment = TileItemContentAlignment.MiddleCenter; // Center the text


            UnitView.TileTemplate.Add(mainElement); // Add the element to the template
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var CurrentID = (Guid)UnitView.GetRowCellValue(UnitView.FocusedRowHandle, "Id");
            string Name = (string)UnitView.GetRowCellValue(UnitView.FocusedRowHandle, "Name");

            if (MessageBox.Show($"آیا {Name} حذف شود؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                await _measureService.DeleteAsync(CurrentID, CancellationToken.None);

                RefreshFormAsync();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var form = scope.ServiceProvider.GetRequiredService<UnitAddOrEditForm>();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshFormAsync();
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var form = scope.ServiceProvider.GetRequiredService<UnitAddOrEditForm>();

                var CurrentID = (Guid)UnitView.GetRowCellValue(UnitView.FocusedRowHandle, "Id");

                form.UnitIdForm = CurrentID;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshFormAsync();
                }
            }
        }
    }
}

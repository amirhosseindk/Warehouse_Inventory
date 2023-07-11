using Application.IServices;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Ui;
using System.Resources;

namespace MyApplication.Ui
{
    public partial class SuppliersForm : Usf.WinForms.Forms.Form
    {
        private readonly ISupplierService _supplierService;
        public SuppliersForm(ISupplierService supplierService)
        {
            _supplierService = supplierService;

            InitializeComponent();

            #region Language

            ResourceManager resource = new ResourceManager
                ("Resources.DataDictionary", typeof(Resources.DataDictionary).Assembly);


            this.Text =
                resource.GetString(name: nameof(SuppliersForm));

            #endregion /Language
        }

        // Loaded
        private void SupplersButton_Load(object sender, EventArgs e)
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
            var usersUF = await _supplierService.GetAllAsync(CancellationToken.None);
            SupplierGridControl.DataSource = usersUF.ToList();
        }

        private void UserNewButton_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var form = scope.ServiceProvider.GetRequiredService<SupplierAddOrEditForm>();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshFormAsync();
                }
            }
        }

        private void UserEditButton_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var form = scope.ServiceProvider.GetRequiredService<SupplierAddOrEditForm>();

                var CurrentID = (Guid)SupplierGridView.GetRowCellValue(SupplierGridView.FocusedRowHandle, colId);

                form.SupplierIdForm = CurrentID;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshFormAsync();
                }
            }
        }

        private async void UserDeleteButton_Click(object sender, EventArgs e)
        {
            var CurrentID = (Guid)SupplierGridView.GetRowCellValue(SupplierGridView.FocusedRowHandle, colId);
            string FName = (string)SupplierGridView.GetRowCellValue(SupplierGridView.FocusedRowHandle, colFirstName);
            string LName = (string)SupplierGridView.GetRowCellValue(SupplierGridView.FocusedRowHandle, colLastName);
            var FullName = FName + " " + LName;

            if (MessageBox.Show($"آیا {FullName} حذف شود؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                await _supplierService.DeleteAsync(CurrentID, CancellationToken.None);

                RefreshFormAsync();
            }
        }
    }
}
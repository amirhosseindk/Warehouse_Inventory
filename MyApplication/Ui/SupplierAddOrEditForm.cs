using Application.IServices;
using Domain.Entities;
using Infrastructure.Services;
using MyApplication;

namespace MyApp.Ui
{
    public partial class SupplierAddOrEditForm : Usf.WinForms.Forms.Form
    {
        private readonly ISupplierService _supplierService;
        public Guid SupplierIdForm { get; set; } = Guid.Empty;

        public SupplierAddOrEditForm(ISupplierService supplierService)
        {
            _supplierService = supplierService;
            InitializeComponent();
        }

        private async void SupplierAddOrEdit_Load(object sender, EventArgs e)
        {
            FirstNameTextEdit.Focus();

            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;

                this.RightToLeftLayout = true;
            }

            if (SupplierIdForm != Guid.Empty)
            {
                var supplier = await _supplierService.GetByIdAsync(SupplierIdForm, CancellationToken.None);
                FirstNameTextEdit.Text = supplier.Name;
                LastNameTextEdit.Text = supplier.LastName;
                PhoneTextEdit.Text = supplier.Phone;
                AddressTextEdit.Text = supplier.Address;
                DescriptionTextEdit.Text = supplier.Description;
                ActiveCheckEdit.Checked = supplier.IsActive;
                EmailTextEdit.Text = supplier.Email;
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier
            {
                Id = SupplierIdForm != Guid.Empty ? SupplierIdForm : Guid.NewGuid(),
                Name = FirstNameTextEdit.Text,
                LastName = LastNameTextEdit.Text,
                Phone = PhoneTextEdit.Text,
                Address = AddressTextEdit.Text,
                Description = DescriptionTextEdit.Text,
                IsActive = ActiveCheckEdit.Checked,
                Email = EmailTextEdit.Text,
                UsernameId = Program.usernameid
            };

            if (SupplierIdForm != Guid.Empty)
            {
                await _supplierService.UpdateAsync(supplier, CancellationToken.None);
                DialogResult = DialogResult.OK;
            }
            else
            {
                await _supplierService.CreateAsync(supplier, CancellationToken.None);
                DialogResult = DialogResult.OK;
            }
        }
    }
}

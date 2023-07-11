using Application.IServices;
using Domain.Entities;
using MyApplication;

namespace MyApp.Ui
{
    public partial class UnitAddOrEditForm : Usf.WinForms.Forms.Form
    {
        private readonly IMeasureService _measureService;
        public Guid UnitIdForm { get; set; } = Guid.Empty;

        public UnitAddOrEditForm(IMeasureService measureService)
        {
            _measureService = measureService;
            InitializeComponent();
        }

        private async void UnitAddOrEditForm_Load(object sender, EventArgs e)
        {
            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }

            if (UnitIdForm != Guid.Empty)
            {
                var Unit = await _measureService.GetByIdAsync(UnitIdForm, CancellationToken.None);
                textBox1.Text = Unit.Name;
                checkBox1.Checked = Unit.IsActive;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var country = new UnitMeasure
            {
                Id = UnitIdForm != Guid.Empty ? UnitIdForm : Guid.NewGuid(),
                Name = textBox1.Text,
                IsActive = checkBox1.Checked,
                UsernameId = Program.usernameid
            };
            if (UnitIdForm != Guid.Empty)
            {
                await _measureService.UpdateAsync(country, CancellationToken.None);
                DialogResult = DialogResult.OK;
            }
            else
            {
                await _measureService.CreateAsync(country, CancellationToken.None);
                DialogResult = DialogResult.OK;
            }
        }
    }
}

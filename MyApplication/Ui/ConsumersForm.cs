﻿using Application.IServices;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Ui;
using System.Resources;

namespace MyApplication
{
    public partial class ConsumersForm : Usf.WinForms.Forms.Form
    {
        private readonly IConsumerService _consumerService;
        public ConsumersForm(IConsumerService consumerService)
        {
            _consumerService = consumerService;

            InitializeComponent();

            #region Language

            ResourceManager resource = new ResourceManager
               ("Resources.DataDictionary", typeof(Resources.DataDictionary).Assembly);

            this.Text =
                resource.GetString(name: nameof(ConsumersForm));

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
            var usersUF = await _consumerService.GetAllAsync(CancellationToken.None);

            ConsumerGridControl.DataSource = usersUF.ToList();

        }

        private void UserNewButton_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var form = scope.ServiceProvider.GetRequiredService<ConsumerAddOrEditForm>();

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
                var form = scope.ServiceProvider.GetRequiredService<ConsumerAddOrEditForm>();

                var CurrentID = (Guid)ConsumerGridView.GetRowCellValue(ConsumerGridView.FocusedRowHandle, colId);

                form.ConsumerIdForm = CurrentID;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshFormAsync();
                }
            }
        }

        private async void UserDeleteButton_Click(object sender, EventArgs e)
        {
            var CurrentID = (Guid)ConsumerGridView.GetRowCellValue(ConsumerGridView.FocusedRowHandle, colId);
            string FName = (string)ConsumerGridView.GetRowCellValue(ConsumerGridView.FocusedRowHandle, colFirstName);
            string LName = (string)ConsumerGridView.GetRowCellValue(ConsumerGridView.FocusedRowHandle, colLastName);
            var FullName = FName + " " + LName;

            if (MessageBox.Show($"آیا {FullName} حذف شود؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                await _consumerService.DeleteAsync(CurrentID, CancellationToken.None);

                RefreshFormAsync();
            }
        }
    }
}
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usf.WinForms.Forms
{
    public partial class Form : DevExpress.XtraEditors.XtraForm
    {
        public Form()
        {
            InitializeComponent();

            Appearance.BackColor = Color.LightGoldenrodYellow;
            Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StartPosition = FormStartPosition.CenterScreen;
            Name = "Form";
        }

        // Loaded
        private void Form_Load(object sender, EventArgs e)
        {

        }
    }
}
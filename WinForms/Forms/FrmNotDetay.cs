using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WinForms.Forms
{
    public partial class FrmNotDetay : DevExpress.XtraEditors.XtraForm
    {
        public FrmNotDetay()
        {
            InitializeComponent();
        }
        public string metin;

        private void FrmNotDetay_Load(object sender, EventArgs e)
        {
            richNotDetay.Text = metin;
        }
    }
}
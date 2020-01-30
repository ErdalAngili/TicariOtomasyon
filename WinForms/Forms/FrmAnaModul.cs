using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Forms
{
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }
        FrmMusteriler FrmMusteriler;
        private void barMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmMusteriler == null)
            {
                FrmMusteriler = new FrmMusteriler();
                FrmMusteriler.MdiParent = this;
                FrmMusteriler.Show();
            }
        }
        FrmUrunler FrmUrunler;
        private void barUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmUrunler==null)
            {
                FrmUrunler = new FrmUrunler();
                FrmUrunler.MdiParent = this;
                FrmUrunler.Show();
            }
        }
    }
}

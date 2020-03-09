﻿using System;
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
        FrmFirmalar frmFirmalar;
        private void barFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFirmalar==null)
            {
                frmFirmalar = new FrmFirmalar();
                frmFirmalar.MdiParent = this;
                frmFirmalar.Show();
            }
        }
        FrmPersoneller frmPersoneller;
        private void barPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersoneller==null)
            {
                frmPersoneller = new FrmPersoneller();
                frmPersoneller.MdiParent = this;
                frmPersoneller.Show();
            }
        }
        FrmIletisim frmIletisim;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmIletisim==null)
            {
                frmIletisim = new FrmIletisim();
                frmIletisim.MdiParent = this;
                frmIletisim.Show();
            }
        }
        FrmGiderler frmgiderler;
        private void barGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmgiderler==null)
            {
                frmgiderler = new FrmGiderler();
                frmgiderler.MdiParent = this;
                frmgiderler.Show();
            }
        }
        FrmBankalar frmBankalar;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmBankalar==null)
            {
                frmBankalar = new FrmBankalar();
                frmBankalar.MdiParent = this;
                frmBankalar.Show();
            }
        }
        FrmFaturalar frmFaturalar;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFaturalar==null)
            {
                frmFaturalar = new FrmFaturalar();
                frmFaturalar.MdiParent = this;
                frmFaturalar.Show();
            }
        }
        FrmNotlar frmNotlar;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmNotlar==null)
            {
                frmNotlar = new FrmNotlar();
                frmNotlar.MdiParent = this;
                frmNotlar.Show();
            }
        }
        FrmHareketler frmHareketler;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmHareketler==null)
            {
                frmHareketler = new FrmHareketler();
                frmHareketler.MdiParent = this;
                frmHareketler.Show();
            }
        }
    }
}

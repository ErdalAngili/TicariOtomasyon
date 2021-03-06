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
            if (FrmMusteriler == null || FrmMusteriler.IsDisposed)
            {
                FrmMusteriler = new FrmMusteriler();
                FrmMusteriler.MdiParent = this;
                FrmMusteriler.Show();
            }
        }
        FrmUrunler FrmUrunler;
        private void barUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmUrunler==null||FrmUrunler.IsDisposed)
            {
                FrmUrunler = new FrmUrunler();
                FrmUrunler.MdiParent = this;
                FrmUrunler.Show();
            }
        }
        FrmFirmalar frmFirmalar;
        private void barFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFirmalar==null|| frmFirmalar.IsDisposed)
            {
                frmFirmalar = new FrmFirmalar();
                frmFirmalar.MdiParent = this;
                frmFirmalar.Show();
            }
        }
        FrmPersoneller frmPersoneller;
        private void barPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersoneller==null|| frmPersoneller.IsDisposed)
            {
                frmPersoneller = new FrmPersoneller();
                frmPersoneller.MdiParent = this;
                frmPersoneller.Show();
            }
        }
        FrmIletisim frmIletisim;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmIletisim==null|| frmIletisim.IsDisposed)
            {
                frmIletisim = new FrmIletisim();
                frmIletisim.MdiParent = this;
                frmIletisim.Show();
            }
        }
        FrmGiderler frmgiderler;
        private void barGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmgiderler==null|| frmgiderler.IsDisposed)
            {
                frmgiderler = new FrmGiderler();
                frmgiderler.MdiParent = this;
                frmgiderler.Show();
            }
        }
        FrmBankalar frmBankalar;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmBankalar==null|| frmBankalar.IsDisposed)
            {
                frmBankalar = new FrmBankalar();
                frmBankalar.MdiParent = this;
                frmBankalar.Show();
            }
        }
        FrmFaturalar frmFaturalar;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFaturalar==null|| frmFaturalar.IsDisposed)
            {
                frmFaturalar = new FrmFaturalar();
                frmFaturalar.MdiParent = this;
                frmFaturalar.Show();
            }
        }
        FrmNotlar frmNotlar;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmNotlar==null|| frmNotlar.IsDisposed)
            {
                frmNotlar = new FrmNotlar();
                frmNotlar.MdiParent = this;
                frmNotlar.Show();
            }
        }
        FrmHareketler frmHareketler;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmHareketler==null|| frmHareketler.IsDisposed)
            {
                frmHareketler = new FrmHareketler();
                frmHareketler.MdiParent = this;
                frmHareketler.Show();
            }
        }
        FrmStoklar frmStoklar;
        private void barStok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmStoklar==null||frmStoklar.IsDisposed)
            {
                frmStoklar = new FrmStoklar();
                frmStoklar.MdiParent = this;
                frmStoklar.Show();
            }
        }
        FrmAyarlar frmAyarlar;
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAyarlar == null|| frmAyarlar.IsDisposed)
            {
                frmAyarlar = new FrmAyarlar();
                frmAyarlar.Show();
            }
        }
        FrmKasa frmKasa;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKasa == null|| frmKasa.IsDisposed)
            {
                frmKasa = new FrmKasa();
                frmKasa.MdiParent = this;
                frmKasa.Show();
            }
        }
        FrmAnaSayfa FrmAnaSayfa;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmAnaSayfa==null|| FrmAnaSayfa.IsDisposed)
            {
                FrmAnaSayfa = new FrmAnaSayfa();
                FrmAnaSayfa.MdiParent = this;
                FrmAnaSayfa.Show();
            }
        }

        private void FrmAnaModul_Load(object sender, EventArgs e)
        {
            if (FrmAnaSayfa == null)
            {
                FrmAnaSayfa = new FrmAnaSayfa();
                FrmAnaSayfa.MdiParent = this;
                FrmAnaSayfa.Show();
            }
        }
    }
}

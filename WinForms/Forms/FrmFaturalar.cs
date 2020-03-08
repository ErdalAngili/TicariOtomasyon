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
using System.Data.SqlClient;
using Common.Baglanti;

namespace WinForms.Forms
{
    public partial class FrmFaturalar : DevExpress.XtraEditors.XtraForm
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        sqlbaglanti sqlbaglanti = new sqlbaglanti();
        FrmFaturaUrun faturaUrun = new FrmFaturaUrun();
        void Listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from FATURABILGI",sqlbaglanti.baglanti());
            DataTable table = new DataTable();
            adapter.Fill(table);
            myGridControl1.DataSource = table;
        }
        void FirmaListele()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select FATURABILGIID,SIRANO,ALICI from FATURABILGI", sqlbaglanti.baglanti());
            adapter.Fill(table);
            lookFirma.Properties.ValueMember = "FATURABILGIID";
            lookFirma.Properties.DisplayMember = "SIRANO";
            lookFirma.Properties.DisplayMember = "ALICI";
            lookFirma.Properties.DataSource = table;
        }
        void Temizle()
        {
            TxtFaturaBilgiID.Text = string.Empty;
            TxtSeri.Text = string.Empty;
            TxtSıraNo.Text = string.Empty;
            MaskTarih.Text = string.Empty;
            MaskSaat.Text = string.Empty;
            TxtVergiDairesi.Text = string.Empty;
            TxtAlici.Text = string.Empty;
            TxtTeslimAlan.Text = string.Empty;
            TxtTeslimEden.Text = string.Empty;
        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            Listele();
            FirmaListele();
            Temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (lookFirma.EditValue==null)
            {
                if (MessageBox.Show("kaydı onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("insert into FATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", sqlbaglanti.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtSeri.Text);
                    komut.Parameters.AddWithValue("@p2", TxtSıraNo.Text);
                    komut.Parameters.AddWithValue("@p3", MaskTarih.Text);
                    komut.Parameters.AddWithValue("@p4", MaskSaat.Text);
                    komut.Parameters.AddWithValue("@p5", TxtVergiDairesi.Text);
                    komut.Parameters.AddWithValue("@p6", TxtAlici.Text);
                    komut.Parameters.AddWithValue("@p7", TxtTeslimEden.Text);
                    komut.Parameters.AddWithValue("@p8", TxtTeslimAlan.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarılı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    sqlbaglanti.baglanti().Close();
                    Listele();
                }
                else
                {
                    MessageBox.Show("Kayıt İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Listele();
                }

            }
            if (lookFirma.EditValue!=null)
            {
                SqlCommand komut2 = new SqlCommand("insert into FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)",sqlbaglanti.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtUrunAd.Text);
                komut2.Parameters.AddWithValue("@p2", MaskMiktar.Text);
                komut2.Parameters.AddWithValue("@p3", MaskFiyat.Text);
                komut2.Parameters.AddWithValue("@p4", TxtTutar.Text);
                komut2.Parameters.AddWithValue("@p5", lookFirma.EditValue);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Fatura Detayı Kayıt Edildi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlbaglanti.baglanti().Close();
            }
        }

        private void myGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = myGridView1.GetDataRow(myGridView1.FocusedRowHandle);
            if (row!=null)
            {
                TxtFaturaBilgiID.Text = row["FATURABILGIID"].ToString();
                TxtSeri.Text = row["SERI"].ToString();
                TxtSıraNo.Text = row["SIRANO"].ToString();
                MaskTarih.Text = row["TARIH"].ToString();
                MaskSaat.Text = row["SAAT"].ToString();
                TxtVergiDairesi.Text = row["VERGIDAIRE"].ToString();
                TxtAlici.Text = row["ALICI"].ToString();
                TxtTeslimEden.Text = row["TESLIMEDEN"].ToString();
                TxtTeslimAlan.Text = row["TESLIMALAN"].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void TxtTutar_Click(object sender, EventArgs e)
        {
            double miktar, fiyat, tutar;
            miktar = Convert.ToDouble(MaskMiktar.Text);
            fiyat = Convert.ToDouble(MaskFiyat.Text);
            tutar = miktar * fiyat;
            TxtTutar.Text = tutar.ToString();
            FirmaListele();
        }
        private void btnAlanTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        
        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Faturayı Detayı Silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut2 = new SqlCommand("Delete from FATURADETAY where FATURAID=@p2", sqlbaglanti.baglanti());
                komut2.Parameters.AddWithValue("@p2", TxtFaturaBilgiID.Text);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Fatura Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlbaglanti.baglanti().Close();
                if (MessageBox.Show("Faturayı Silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("Delete from FATURABILGI where FATURABILGIID=@p1", sqlbaglanti.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtFaturaBilgiID.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Fatura Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlbaglanti.baglanti().Close();
                    Listele();
                    FirmaListele();
                    Temizle();
                }
            }
            else
            {
                    MessageBox.Show("Silme İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Listele();
                    FirmaListele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Güncelleme İşlemi Yapılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update FATURABILGI set SERI=@p1,SIRANO=@p2,TARIH=@p3,SAAT=@p4,VERGIDAIRE=@p5,ALICI=@p6,TESLIMEDEN=@p7,TESLIMALAN=@p8 where FATURABILGIID=@p9", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtSeri.Text);
                komut.Parameters.AddWithValue("@p2", TxtSıraNo.Text);
                komut.Parameters.AddWithValue("@p3", MaskTarih.Text);
                komut.Parameters.AddWithValue("@p4", MaskSaat.Text);
                komut.Parameters.AddWithValue("@p5", TxtVergiDairesi.Text);
                komut.Parameters.AddWithValue("@p6", TxtAlici.Text);
                komut.Parameters.AddWithValue("@p7", TxtTeslimEden.Text);
                komut.Parameters.AddWithValue("@p8", TxtTeslimAlan.Text);
                komut.Parameters.AddWithValue("@p9", TxtFaturaBilgiID.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme İşlemi Başarılı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
                sqlbaglanti.baglanti().Close();
                FirmaListele();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Yapılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
                FirmaListele();
            }
        }

        private void myGridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrun FaturaUrun = new FrmFaturaUrun();
            DataRow row = myGridView1.GetDataRow(myGridView1.FocusedRowHandle);
            if (row!=null)
            {
                FaturaUrun.id = row["FATURABILGIID"].ToString();
            }
            FaturaUrun.Show();
        }
    }
}
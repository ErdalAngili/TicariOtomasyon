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
    public partial class FrmFaturaUrunDüzenleme : DevExpress.XtraEditors.XtraForm
    {
        public FrmFaturaUrunDüzenleme()
        {
            InitializeComponent();
        }
        
        public string Urunid;
        sqlbaglanti sqlbaglanti = new sqlbaglanti();
        private void FrmFaturaUrunDüzenleme_Load(object sender, EventArgs e)
        {
            TxtUrunId.Text = Urunid;
            SqlCommand komut = new SqlCommand("Select * from FATURADETAY where FATURAURUNID=@p1", sqlbaglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", Urunid);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                TxtUrunAd.Text = reader[1].ToString();
                MaskMiktar.Text = reader[2].ToString();
                MaskFiyat.Text = reader[3].ToString();
                TxtTutar.Text = reader[4].ToString();
                sqlbaglanti.baglanti().Close();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Güncelleme İşlemi Yapılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update FATURADETAY set URUNAD=@p1,MIKTAR=@p2,FIYAT=@p3,TUTAR=@p4 where FATURAURUNID=@p5", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtUrunAd.Text);
                komut.Parameters.AddWithValue("@p2", MaskMiktar.Text);
                komut.Parameters.AddWithValue("@p3", decimal.Parse(MaskFiyat.Text));
                komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtTutar.Text));
                komut.Parameters.AddWithValue("@p5", TxtUrunId.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme İşlemi Başarılı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlbaglanti.baglanti().Close();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Yapılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Faturayı Silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from FATURADETAY where FATURAURUNID=@p1", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtUrunId.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Fatura Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlbaglanti.baglanti().Close();
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
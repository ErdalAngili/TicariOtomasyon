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
    public partial class FrmPersoneller : DevExpress.XtraEditors.XtraForm
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        sqlbaglanti sqlbaglanti = new sqlbaglanti();
        void PersonelListele()
        {
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From PERSONELLER",sqlbaglanti.baglanti());
            da.Fill(table);
            myGridControl1.DataSource = table;
        }
        void Temizle()
        {
            TxtAd.Text = string.Empty;
            TxtSoyad.Text = string.Empty;
            TxtMail.Text = string.Empty;
            MaskTelefon.Text = string.Empty;
            MaskTC.Text = string.Empty;
            Comil.Text = string.Empty;
            Comilce.Text = string.Empty;
            TxtGorev.Text = string.Empty;
            RichAdres.Text = string.Empty;
        }
        void Sehirlistele()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR from ILLER",sqlbaglanti.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Comil.Items.Add(dr[0]);
            }
            sqlbaglanti.baglanti().Close();

        }

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            PersonelListele();
            Sehirlistele();
            Temizle();
        }

        private void Comil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comilce.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE From ILCELER where SEHIR=@p1",sqlbaglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", Comil.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Comilce.Items.Add(dr[0]);
            }
            sqlbaglanti.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydı onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Insert into PERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MaskTelefon.Text);
                komut.Parameters.AddWithValue("@p4", MaskTC.Text);
                komut.Parameters.AddWithValue("@p5", TxtMail.Text);
                komut.Parameters.AddWithValue("@p6", Comil.Text);
                komut.Parameters.AddWithValue("@p7", Comilce.Text);
                komut.Parameters.AddWithValue("@p8", RichAdres.Text);
                komut.Parameters.AddWithValue("@p9", TxtGorev.Text);
                komut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close();
                Temizle();
                PersonelListele();
            }
            else
            {
                MessageBox.Show("Kayıt İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PersonelListele();
            }
        }

        private void myGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = myGridView1.GetDataRow(myGridView1.FocusedRowHandle);
            if (row!=null)
            {
                TxtId.Text = row["ID"].ToString();
                TxtAd.Text = row["AD"].ToString();
                TxtSoyad.Text = row["SOYAD"].ToString();
                MaskTelefon.Text = row["TELEFON"].ToString();
                MaskTC.Text = row["TC"].ToString();
                TxtMail.Text = row["MAIL"].ToString();
                Comil.Text = row["IL"].ToString();
                Comilce.Text = row["ILCE"].ToString();
                RichAdres.Text = row["ADRES"].ToString();
                TxtGorev.Text = row["GOREV"].ToString();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silme işlemini Onalıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from PERSONELLER where ID=@p1",sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                komut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close();
                PersonelListele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PersonelListele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Güncelleme İşlemini Onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update PERSONELLER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TC=@p4,MAIL=@p5,IL=@p6,ILCE=@p7,ADRES=@p8,GOREV=@p9 where ID=@p10",sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MaskTelefon.Text);
                komut.Parameters.AddWithValue("@p4", MaskTC.Text);
                komut.Parameters.AddWithValue("@p5", TxtMail.Text);
                komut.Parameters.AddWithValue("@p6", Comil.Text);
                komut.Parameters.AddWithValue("@p7", Comilce.Text);
                komut.Parameters.AddWithValue("@p8", RichAdres.Text);
                komut.Parameters.AddWithValue("@p9", TxtGorev.Text);
                komut.Parameters.AddWithValue("@p10", TxtId.Text);
                komut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close();
                PersonelListele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PersonelListele();
            }
        }

        private void btnAlanTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
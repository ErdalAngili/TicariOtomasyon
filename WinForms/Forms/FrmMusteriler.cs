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
    public partial class FrmMusteriler : DevExpress.XtraEditors.XtraForm
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        sqlbaglanti sqlbaglanti = new sqlbaglanti();

        void GridListele()
        {
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from MUSTERILER",sqlbaglanti.baglanti());
            da.Fill(table);
            myGridControl1.DataSource = table;
        }
        void SehirListele()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR from ILLER",sqlbaglanti.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Comil.Items.Add(dr[0]);
            }
            sqlbaglanti.baglanti().Close();
        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            SehirListele();
            GridListele();
        }

        private void Comil_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select ILCE from ILCELER where SEHIR=@p1",sqlbaglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", Comil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Comilce.Items.Add(dr[0]);
            }
            sqlbaglanti.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("kaydı onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Insert into MUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MaskTelefon.Text);
                komut.Parameters.AddWithValue("@p4", MskTelefonIki.Text);
                komut.Parameters.AddWithValue("@p5", MaskTC.Text);
                komut.Parameters.AddWithValue("@p6", TxtMail.Text);
                komut.Parameters.AddWithValue("@p7", Comil.Text);
                komut.Parameters.AddWithValue("@p8", Comilce.Text);
                komut.Parameters.AddWithValue("@p9", RichAdres.Text);
                komut.Parameters.AddWithValue("@p10", TxtVergiDaire.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlbaglanti.baglanti().Close();

            }
            else
            {
                MessageBox.Show("Kayıt İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GridListele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Güncelleme yapmak İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update MUSTERILER set AD=@p1,SOYAD=@P2,TELEFON=@P3,TELEFON2=@P4,TC=@P5,MAIL=@P6,IL=@P7,ILCE=@P8,ADRES=@P9,VERGIDAIRE=@P10 where ID=@p11", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MaskTelefon.Text);
                komut.Parameters.AddWithValue("@p4", MskTelefonIki.Text);
                komut.Parameters.AddWithValue("@p5", MaskTC.Text);
                komut.Parameters.AddWithValue("@p6", TxtMail.Text);
                komut.Parameters.AddWithValue("@p7", Comil.Text);
                komut.Parameters.AddWithValue("@p8", Comilce.Text);
                komut.Parameters.AddWithValue("@p9", RichAdres.Text);
                komut.Parameters.AddWithValue("@p10", TxtVergiDaire.Text);
                komut.Parameters.AddWithValue("@p11", TxtId.Text);
                komut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close();
                GridListele();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GridListele();
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Müşteriyi Silmek istiyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From MUSTERILER where ID=@p1",sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                komut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close();
                GridListele();
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GridListele();
            }
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = myGridView1.GetDataRow(myGridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MaskTelefon.Text = dr["TELEFON"].ToString();
                MskTelefonIki.Text = dr["TELEFON2"].ToString();
                MaskTC.Text = dr["TC"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                Comil.Text = dr["IL"].ToString();
                Comilce.Text = dr["ILCE"].ToString();
                RichAdres.Text = dr["ADRES"].ToString();
                TxtVergiDaire.Text = dr["VERGIDAIRE"].ToString();
            }

        }
    }
}
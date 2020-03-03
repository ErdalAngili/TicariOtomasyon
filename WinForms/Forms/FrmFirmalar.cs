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
    public partial class FrmFirmalar : DevExpress.XtraEditors.XtraForm
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        sqlbaglanti sqlbaglanti = new sqlbaglanti();
        void FirmalarListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from FIRMALAR",sqlbaglanti.baglanti());
            da.Fill(dt);
            myGridControl1.DataSource = dt;
        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR from ILLER", sqlbaglanti.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                Comil.Items.Add(dr[0]);
            }
            sqlbaglanti.baglanti().Close();
        }
        void Temizle()
        {
            TxtAd.Text = string.Empty;
            TxtId.Text = string.Empty;
            TxtSektor.Text = string.Empty;
            TxtYetkılıAdSoyad.Text = string.Empty;
            TxtYetkılıstatu.Text = string.Empty;
            TxtVergiDaire.Text = string.Empty;
            TxtKodBir.Text = string.Empty;
            TxtKodiki.Text = string.Empty;
            TxtKodUc.Text = string.Empty;
            MaskFax.Text = string.Empty;
            MaskMail.Text = string.Empty;
            MaskTC.Text = string.Empty;
            MaskTelefon.Text = string.Empty;
            MaskTelefonIki.Text = string.Empty;
            MaskTelefonUc.Text = string.Empty;
            RichAdres.Text = string.Empty;
            Comil.Text = string.Empty;
            Comilce.Text = string.Empty;
        }
        void KodAciklama()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 from KODLAR", sqlbaglanti.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                RichKodBir.Text = dr[0].ToString();
            }
            sqlbaglanti.baglanti().Close();
        }
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            sehirlistesi();
            FirmalarListesi();
            KodAciklama();
            Temizle();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Firma Eklensin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Insert into FIRMALAR (AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtYetkılıstatu.Text);
                komut.Parameters.AddWithValue("@p3", TxtYetkılıAdSoyad.Text);
                komut.Parameters.AddWithValue("@p4", MaskTC.Text);
                komut.Parameters.AddWithValue("@p5", TxtSektor.Text);
                komut.Parameters.AddWithValue("@p6", MaskTelefon.Text);
                komut.Parameters.AddWithValue("@p7", MaskTelefonIki.Text);
                komut.Parameters.AddWithValue("@p8", MaskTelefonUc.Text);
                komut.Parameters.AddWithValue("@p9", MaskMail.Text);
                komut.Parameters.AddWithValue("@p10", MaskFax.Text);
                komut.Parameters.AddWithValue("@p11", Comil.Text);
                komut.Parameters.AddWithValue("@p12", Comilce.Text);
                komut.Parameters.AddWithValue("@p13", TxtVergiDaire.Text);
                komut.Parameters.AddWithValue("@p14", RichAdres.Text);
                komut.Parameters.AddWithValue("@p15", TxtKodBir.Text);
                komut.Parameters.AddWithValue("@p16", TxtKodiki.Text);
                komut.Parameters.AddWithValue("@p17", TxtKodUc.Text);
                komut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close();
                Temizle();
                FirmalarListesi();
            }
            else
            {
                MessageBox.Show("Kayıt Eklenmedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirmalarListesi();
            }

        }
        private void myGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = myGridView1.GetDataRow(myGridView1.FocusedRowHandle);
            if (row!=null)
            {
                TxtId.Text = row["ID"].ToString();
                TxtAd.Text = row["AD"].ToString();
                TxtSektor.Text = row["SEKTOR"].ToString();
                TxtYetkılıAdSoyad.Text = row["YETKILIADSOYAD"].ToString();
                TxtYetkılıstatu.Text = row["YETKILISTATU"].ToString();
                MaskTC.Text = row["YETKILITC"].ToString();
                MaskTelefon.Text = row["TELEFON1"].ToString();
                MaskTelefonIki.Text = row["TELEFON2"].ToString();
                MaskTelefonUc.Text = row["TELEFON3"].ToString();
                MaskFax.Text = row["FAX"].ToString();
                MaskMail.Text = row["MAIL"].ToString();
                Comil.Text = row["IL"].ToString();
                Comilce.Text = row["ILCE"].ToString();
                TxtVergiDaire.Text = row["VERGIDAIRE"].ToString();
                RichAdres.Text = row["ADRES"].ToString();
                TxtKodBir.Text = row["OZELKOD1"].ToString();
                TxtKodiki.Text = row["OZELKOD2"].ToString();
                TxtKodUc.Text = row["OZELKOD3"].ToString();
            }
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Güncelleme İşlemi Yapılsın mı?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update FIRMALAR set AD=@p1, SEKTOR=@p2, YETKILIADSOYAD=@P3, YETKILISTATU=@P4, YETKILITC=@P5, TELEFON1=@p6, TELEFON2=@p7, TELEFON3=@p8, FAX=@p9, MAIL=@p10, IL=@p11, ILCE=@p12, VERGIDAIRE=@p13, ADRES=@p14, OZELKOD1=@p15, OZELKOD2=@p16, OZELKOD3=@p17 where ID=@p18", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSektor.Text);
                komut.Parameters.AddWithValue("@p3", TxtYetkılıAdSoyad.Text);
                komut.Parameters.AddWithValue("@p4", TxtYetkılıstatu.Text);
                komut.Parameters.AddWithValue("@p5", MaskTC.Text);
                komut.Parameters.AddWithValue("@p6", MaskTelefon.Text);
                komut.Parameters.AddWithValue("@p7", MaskTelefonIki.Text);
                komut.Parameters.AddWithValue("@p8", MaskTelefonUc.Text);
                komut.Parameters.AddWithValue("@p9", MaskFax.Text);
                komut.Parameters.AddWithValue("@p10", MaskMail.Text);
                komut.Parameters.AddWithValue("@p11", Comil.Text);
                komut.Parameters.AddWithValue("@p12", Comilce.Text);
                komut.Parameters.AddWithValue("@p13", TxtVergiDaire.Text);
                komut.Parameters.AddWithValue("@p14", RichAdres.Text);
                komut.Parameters.AddWithValue("@p15", TxtKodBir.Text);
                komut.Parameters.AddWithValue("@p16", TxtKodiki.Text);
                komut.Parameters.AddWithValue("@p17", TxtKodUc.Text);
                komut.Parameters.AddWithValue("@p18", TxtId.Text);
                komut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close();
                Temizle();
                FirmalarListesi();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Yapılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirmalarListesi();
            }

        }
        private void Comil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comilce.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE from ILCELER where SEHIR=@p1",sqlbaglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", Comil.SelectedIndex+1);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                Comilce.Items.Add(reader[0]);
            }
            sqlbaglanti.baglanti().Close();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Firmayı Silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from FIRMALAR where ID=@p1", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                komut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close();
                FirmalarListesi();
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirmalarListesi();
            }

        }
    }
}
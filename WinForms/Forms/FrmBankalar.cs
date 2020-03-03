using Common.Baglanti;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinForms.Forms
{
    public partial class FrmBankalar : DevExpress.XtraEditors.XtraForm
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }
        sqlbaglanti sqlbaglanti = new sqlbaglanti();
        void Listele()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From BANKALAR inner join FIRMALAR on BANKALAR.FIRMAID=FIRMALAR.ID",sqlbaglanti.baglanti());
            adapter.Fill(table);
            myGridControl1.DataSource = table;
        }
        void sehirListele()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR from ILLER",sqlbaglanti.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                Comil.Items.Add(reader[0]);
            }
            sqlbaglanti.baglanti().Close();
        }
        void FirmaListele()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select ID,AD from FIRMALAR",sqlbaglanti.baglanti());
            adapter.Fill(table);
            lookFirma.Properties.ValueMember = "ID";
            lookFirma.Properties.DisplayMember = "AD";
            lookFirma.Properties.DataSource = table;
        }
        void Temizle()
        {
            TxtId.Text = string.Empty;
            TxtAd.Text = string.Empty;
            Comil.Text = string.Empty;
            Comilce.Text = string.Empty;
            TxtSube.Text = string.Empty;
            MaskIban.Text = string.Empty;
            MaskHesap.Text = string.Empty;
            TxtYetkili.Text = string.Empty;
            MskTelefon.Text = string.Empty;
            MaskTarih.Text = string.Empty;
            TxtHesapTuru.Text = string.Empty;
            lookFirma.Text = string.Empty;

        }
        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            Listele();
            sehirListele();
            FirmaListele();
            Temizle();
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

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("kaydı onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("insert into BANKALAR (BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", Comil.Text);
                komut.Parameters.AddWithValue("@p3", Comilce.Text);
                komut.Parameters.AddWithValue("@p4", TxtSube.Text);
                komut.Parameters.AddWithValue("@p5", MaskIban.Text);
                komut.Parameters.AddWithValue("@p6", MaskHesap.Text);
                komut.Parameters.AddWithValue("@p7", TxtYetkili.Text);
                komut.Parameters.AddWithValue("@p8", MskTelefon.Text);
                komut.Parameters.AddWithValue("@p9", MaskTarih.Text);
                komut.Parameters.AddWithValue("@p10", TxtHesapTuru.Text);
                komut.Parameters.AddWithValue("@p11", lookFirma.EditValue);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlbaglanti.baglanti().Close();
                Listele();
            }
            else
            {
                MessageBox.Show("Kayıt İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
            }
        }

        private void myGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = myGridView1.GetDataRow(myGridView1.FocusedRowHandle);
            if (row!=null)
            {
                TxtId.Text = row["ID"].ToString();
                TxtAd.Text = row["BANKAADI"].ToString();
                Comil.Text = row["IL"].ToString();
                Comilce.Text = row["ILCE"].ToString();
                TxtSube.Text = row["SUBE"].ToString();
                MaskIban.Text = row["IBAN"].ToString();
                MaskHesap.Text = row["HESAPNO"].ToString();
                TxtYetkili.Text = row["YETKILI"].ToString();
                MskTelefon.Text = row["TELEFON"].ToString();
                MaskTarih.Text = row["TARIH"].ToString();
                TxtHesapTuru.Text = row["HESAPTURU"].ToString();
                lookFirma.Text = row["FIRMAID"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Firmayı Silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from BANKALAR where ID=@p1", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Başarılı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlbaglanti.baglanti().Close();
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
            }

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Güncelleme İşlemi Yapılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update BANKALAR set BANKAADI=@p1,IL=@p2,ILCE=@p3,SUBE=@p4,IBAN=@p5,HESAPNO=@p6,YETKILI=@p7,TELEFON=@p8,TARIH=@p9,HESAPTURU=@p10,FIRMAID=@p11 where ID=@p12", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", Comil.Text);
                komut.Parameters.AddWithValue("@p3", Comilce.Text);
                komut.Parameters.AddWithValue("@p4", TxtSube.Text);
                komut.Parameters.AddWithValue("@p5", MaskIban.Text);
                komut.Parameters.AddWithValue("@p6", MaskHesap.Text);
                komut.Parameters.AddWithValue("@p7", TxtYetkili.Text);
                komut.Parameters.AddWithValue("@p8", MskTelefon.Text);
                komut.Parameters.AddWithValue("@p9", MaskTarih.Text);
                komut.Parameters.AddWithValue("@p10", TxtHesapTuru.Text);
                komut.Parameters.AddWithValue("@p11", lookFirma.EditValue);
                komut.Parameters.AddWithValue("@p12", TxtId.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme İşlemi Başarılı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
                sqlbaglanti.baglanti().Close();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Yapılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
            }
        }
    }
}
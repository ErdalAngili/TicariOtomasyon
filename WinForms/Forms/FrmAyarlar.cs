using Common.Baglanti;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinForms.Forms
{
    public partial class FrmAyarlar : DevExpress.XtraEditors.XtraForm
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        sqlbaglanti sqlbaglanti = new sqlbaglanti();
        void Listele()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from ADMIN", sqlbaglanti.baglanti());
            adapter.Fill(table);
            myGridControl1.DataSource = table;
            
        }
        void Temizle()
        {
            Txtkuladi.Text = string.Empty;
            TxtSifre.Text = string.Empty;
        }
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (BtnKaydet.Text=="Kaydet")
            {
                SqlCommand komut = new SqlCommand("insert into ADMIN values (@p1,@p2)", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtkuladi.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                komut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close();
                MessageBox.Show("Yeni Kullanıcı Kayıt Edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            if (BtnKaydet.Text=="Güncelle")
            {
                SqlCommand komutupdate = new SqlCommand("Update ADMIN set SIFRE=@p2 where KULLANICIAD=@p1", sqlbaglanti.baglanti());
                komutupdate.Parameters.AddWithValue("@p2", TxtSifre.Text);
                komutupdate.Parameters.AddWithValue("@p1", Txtkuladi.Text);
                komutupdate.ExecuteNonQuery();
                MessageBox.Show("Kayıt Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }

        }

        private void myGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = myGridView1.GetDataRow(myGridView1.FocusedRowHandle);
            if (row != null)
            {
                Txtkuladi.Text = row["KULLANICIAD"].ToString();
                TxtSifre.Text = row["SIFRE"].ToString();
            }
        }

        private void Txtkuladi_EditValueChanged(object sender, EventArgs e)
        {
            if (Txtkuladi.Text!="")
            {
                BtnKaydet.Text = "Güncelle";
                BtnKaydet.ImageOptions.Image = WinForms.Properties.Resources.convert_32x32;
            }
            else
            {
                BtnKaydet.Text = "Kaydet";
                BtnKaydet.ImageOptions.Image = WinForms.Properties.Resources.save_32x32;
            }
        }
    }
}
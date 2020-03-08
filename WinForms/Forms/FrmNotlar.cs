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
    public partial class FrmNotlar : DevExpress.XtraEditors.XtraForm
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        sqlbaglanti sqlbaglanti = new sqlbaglanti();
        void Listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from NOTLAR",sqlbaglanti.baglanti());
            DataTable table = new DataTable();
            adapter.Fill(table);
            myGridControl1.DataSource = table;
        }
        void Temizle()
        {
            MaskTarih.Text = string.Empty;
            MskSaat.Text = string.Empty;
            TxtBaslik.Text = string.Empty;
            RichDetay.Text = string.Empty;
            TxtOlusturan.Text = string.Empty;
            TxtHitap.Text = string.Empty;
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("kaydı onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("insert into NOTLAR (TARIH,SAAT,BASLIK,DETAY,OLUSTURAN,HITAP) values (@p1,@p2,@p3,@p4,@p5,@p6)", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", MaskTarih.Text);
                komut.Parameters.AddWithValue("@p2", MskSaat.Text);
                komut.Parameters.AddWithValue("@p3", TxtBaslik.Text);
                komut.Parameters.AddWithValue("@p4", RichDetay.Text);
                komut.Parameters.AddWithValue("@p5", TxtOlusturan.Text);
                komut.Parameters.AddWithValue("@p6", TxtHitap.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlbaglanti.baglanti().Close();
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Kayıt İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
            }


        }

        private void btnAlanTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void myGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = myGridView1.GetDataRow(myGridView1.FocusedRowHandle);
            if (row!=null)
            {
                MaskTarih.Text = row["TARIH"].ToString();
                MskSaat.Text = row["SAAT"].ToString();
                TxtBaslik.Text = row["BASLIK"].ToString();
                RichDetay.Text = row["DETAY"].ToString();
                TxtOlusturan.Text = row["OLUSTURAN"].ToString();
                TxtHitap.Text = row["HITAP"].ToString();
                TxtNotID.Text = row["ID"].ToString();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Notu Silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from NOTLAR where ID=@p1", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtNotID.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Not Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand komut = new SqlCommand("Update NOTLAR set TARIH=@P1,SAAT=@P2,BASLIK=@P3,DETAY=@P4,OLUSTURAN=@P5,HITAP=@P6 where ID=@p7", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", MaskTarih.Text);
                komut.Parameters.AddWithValue("@p2", MskSaat.Text);
                komut.Parameters.AddWithValue("@p3", TxtBaslik.Text);
                komut.Parameters.AddWithValue("@p4", RichDetay.Text);
                komut.Parameters.AddWithValue("@p5", TxtOlusturan.Text);
                komut.Parameters.AddWithValue("@p6", TxtHitap.Text);
                komut.Parameters.AddWithValue("@p7", TxtNotID.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Not Bilgisi Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlbaglanti.baglanti().Close();
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Yapılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
            }

        }

        private void myGridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay frmNotDetay = new FrmNotDetay();
            DataRow row = myGridView1.GetDataRow(myGridView1.FocusedRowHandle);
            if (row!=null)
            {
                frmNotDetay.metin = row["DETAY"].ToString();
            }
            frmNotDetay.Show();
        }
    }
}
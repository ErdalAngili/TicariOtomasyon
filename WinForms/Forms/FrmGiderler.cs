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
    public partial class FrmGiderler : DevExpress.XtraEditors.XtraForm
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        sqlbaglanti sqlbaglanti = new sqlbaglanti();
        void giderlistesi()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from GIDERLER",sqlbaglanti.baglanti());
            adapter.Fill(table);
            myGridControl1.DataSource = table;
        }
        void Temizle()
        {
            TxtId.Text = string.Empty;
            comAy.Text = string.Empty;
            comYıl.Text = string.Empty;
            TxtElektrik.Text = string.Empty;
            TxtSu.Text = string.Empty;
            TxtDogalgaz.Text = string.Empty;
            TxtInternet.Text = string.Empty;
            TxtMaas.Text = string.Empty;
            TxtEkstra.Text = string.Empty;
            RichNot.Text = string.Empty;
        }
        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            giderlistesi();
            Temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydı onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Insert into GIDERLER (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", comAy.Text);
                komut.Parameters.AddWithValue("@p2", comYıl.Text);
                komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtElektrik.Text));
                komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtSu.Text));
                komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtDogalgaz.Text));
                komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtInternet.Text));
                komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtMaas.Text));
                komut.Parameters.AddWithValue("@p8", decimal.Parse(TxtEkstra.Text));
                komut.Parameters.AddWithValue("@p9", RichNot.Text);
                komut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close();
                giderlistesi();
                Temizle();
            }
            else
            {
                MessageBox.Show("Kayıt İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                giderlistesi();
                Temizle();
            }


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Güncelleme yapmak İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update GIDERLER set AY=@p1,YIL=@p2,ELEKTRIK=@p3,SU=@p4,DOGALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EKSTRA=@p8,NOTLAR=@p9 where ID=@p10",sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", comAy.Text);
                komut.Parameters.AddWithValue("@p2", comYıl.Text);
                komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtElektrik.Text));
                komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtSu.Text));
                komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtDogalgaz.Text));
                komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtInternet.Text));
                komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtMaas.Text));
                komut.Parameters.AddWithValue("@p8", decimal.Parse(TxtEkstra.Text));
                komut.Parameters.AddWithValue("@p9", RichNot.Text);
                komut.Parameters.AddWithValue("@p10", TxtId.Text);
                komut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close();
                giderlistesi();
                Temizle();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                giderlistesi();
                Temizle();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Müşteriyi Silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from GIDERLER where ID=@p1",sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                komut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close();
                giderlistesi();
                Temizle();
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                giderlistesi();
                Temizle();
            }
        }

        private void myGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = myGridView1.GetDataRow(myGridView1.FocusedRowHandle);
            if (row != null)
            {
                TxtId.Text = row["ID"].ToString();
                comAy.Text = row["AY"].ToString();
                comYıl.Text = row["YIL"].ToString();
                TxtElektrik.Text = row["ELEKTRIK"].ToString();
                TxtSu.Text = row["SU"].ToString();
                TxtDogalgaz.Text = row["DOGALGAZ"].ToString();
                TxtInternet.Text = row["INTERNET"].ToString();
                TxtMaas.Text = row["MAASLAR"].ToString();
                TxtEkstra.Text = row["EKSTRA"].ToString();
                RichNot.Text = row["NOTLAR"].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
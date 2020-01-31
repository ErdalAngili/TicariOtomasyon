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
    public partial class FrmUrunler : DevExpress.XtraEditors.XtraForm
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        sqlbaglanti sqlbaglanti = new sqlbaglanti();
        void GridListele()
        {
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from URUNLER", sqlbaglanti.baglanti());
            da.Fill(table);
            myGridControl1.DataSource = table;
        }
        void Temizle()
        {
            TxtAd.Text = string.Empty;
            TxtModel.Text = string.Empty;
            TxtMarka.Text = string.Empty;
            TxtMaliyet.Text = string.Empty;
            TxtId.Text = string.Empty;
            NudAdet.Value = 0;
            MskYil.Text = string.Empty;
            TxtSatis.Text = string.Empty;
            RichDetay.Text = string.Empty;
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            GridListele();
            Temizle();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ürün Kayıt Edilsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Insert into URUNLER (URUNAD,MARKA,MODEL,YIL,ADET,MALIYET,SATISFIYAT,DETAY) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
                komut.Parameters.AddWithValue("@p3", TxtModel.Text);
                komut.Parameters.AddWithValue("@p4", MskYil.Text);
                komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Text).ToString()));
                komut.Parameters.AddWithValue("@p6", decimal.Parse((TxtMaliyet.Text).ToString()));
                komut.Parameters.AddWithValue("@p7", decimal.Parse((TxtSatis.Text).ToString()));
                komut.Parameters.AddWithValue("@p8", RichDetay.Text);
                komut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close();
                GridListele();
            }
            else
            {
                MessageBox.Show("Ürün Kayıt Edilmedi", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                GridListele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ürün Güncellensin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update URUNLER set URUNAD=@p1,MARKA=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,MALIYET=@p6,SATISFIYAT=@p7,DETAY=@p8 where ID=@p9",sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
                komut.Parameters.AddWithValue("@p3", TxtModel.Text);
                komut.Parameters.AddWithValue("@p4", MskYil.Text);
                komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Text).ToString()));
                komut.Parameters.AddWithValue("@p6", decimal.Parse((TxtMaliyet.Text).ToString()));
                komut.Parameters.AddWithValue("@p7", decimal.Parse((TxtSatis.Text).ToString()));
                komut.Parameters.AddWithValue("@p8", RichDetay.Text);
                komut.Parameters.AddWithValue("@p9", TxtId.Text);
                komut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close();
                GridListele();
            }
            else
            {
                MessageBox.Show("Ürün Güncellenmesi Yapılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GridListele();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ürün Silin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From URUNLER where ID=@p1",sqlbaglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                komut.ExecuteNonQuery();
                sqlbaglanti.baglanti().Close();
                GridListele();
            }
            else
            {
                MessageBox.Show("Ürün Silinemedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GridListele();
            }
        }

        private void myGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = myGridView1.GetDataRow(myGridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            TxtAd.Text = dr["URUNAD"].ToString();
            TxtMarka.Text = dr["MARKA"].ToString();
            TxtModel.Text = dr["MODEL"].ToString();
            MskYil.Text = dr["YIL"].ToString();
            NudAdet.Value = int.Parse(dr["ADET"].ToString());
            TxtMaliyet.Text = dr["MALIYET"].ToString();
            TxtSatis.Text = dr["SATISFIYAT"].ToString();
            RichDetay.Text = dr["DETAY"].ToString();
        }
    }
}
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
using Common.Baglanti;
using System.Data.SqlClient;

namespace WinForms.Forms
{
    public partial class FrmStoklar : DevExpress.XtraEditors.XtraForm
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        sqlbaglanti sqlbaglanti = new sqlbaglanti();

        void Listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select URUNAD,sum(ADET) As 'Miktar' from URUNLER group by URUNAD", sqlbaglanti.baglanti());
            DataTable table = new DataTable();
            adapter.Fill(table);
            myGridControl1.DataSource = table;
        }
        void ChartUrunEkleme()
        {
            SqlCommand komut = new SqlCommand("Select URUNAD,sum(ADET) As 'Miktar' from URUNLER group by URUNAD", sqlbaglanti.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(reader[0]), int.Parse(reader[1].ToString()));
            }
            sqlbaglanti.baglanti().Close();
        }
        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            Listele();
            ChartUrunEkleme();
        }

        private void myGridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmStokDetay frmStokDetay = new FrmStokDetay();
            DataRow row = myGridView1.GetDataRow(myGridView1.FocusedRowHandle);
            if (row!=null)
            {
                frmStokDetay.Ad = row["URUNAD"].ToString();
            }
            frmStokDetay.Show();
        }
    }
}
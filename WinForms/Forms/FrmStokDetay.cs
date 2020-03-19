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
    public partial class FrmStokDetay : DevExpress.XtraEditors.XtraForm
    {
        public FrmStokDetay()
        {
            InitializeComponent();
        }
        public string Ad;
        sqlbaglanti sqlbaglanti = new sqlbaglanti();
        private void FrmStokDetay_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from URUNLER where URUNAD='" + Ad + "'", sqlbaglanti.baglanti());
            adapter.Fill(table);
            myGridControl1.DataSource = table;
        }
    }
}
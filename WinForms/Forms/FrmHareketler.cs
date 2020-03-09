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
    public partial class FrmHareketler : DevExpress.XtraEditors.XtraForm
    {
        public FrmHareketler()
        {
            InitializeComponent();
        }
        sqlbaglanti sqlbaglanti = new sqlbaglanti();
        void MusteriHareketler()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Exec MusteriHareketler", sqlbaglanti.baglanti());
            adapter.Fill(table);
            myGridControl1.DataSource = table;
        }
        void FirmaHareketler()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Exec FirmaHareketler", sqlbaglanti.baglanti());
            adapter.Fill(table);
            myGridControl2.DataSource = table;
        }
        private void FrmHareketler_Load(object sender, EventArgs e)
        {
            MusteriHareketler();
            FirmaHareketler();
        }
    }
}
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
    public partial class FrmFaturaUrun : DevExpress.XtraEditors.XtraForm
    {
        public FrmFaturaUrun()
        {
            InitializeComponent();
        }
        public string id;
        sqlbaglanti sqlbaglanti = new sqlbaglanti();


        void Listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from FATURADETAY where FATURAID='" + id + "'", sqlbaglanti.baglanti());
            DataTable table = new DataTable();
            adapter.Fill(table);
            myGridControl1.DataSource = table;
        }
        private void FrmFaturaUrun_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void myGridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDüzenleme frmFaturaUrunDüzenleme = new FrmFaturaUrunDüzenleme();
            DataRow row = myGridView1.GetDataRow(myGridView1.FocusedRowHandle);
            if (row!=null)
            {
                frmFaturaUrunDüzenleme.Urunid = row["FATURAURUNID"].ToString();
            }
            frmFaturaUrunDüzenleme.Show();
        }
    }
}
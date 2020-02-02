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
    public partial class FrmIletisim : DevExpress.XtraEditors.XtraForm
    {
        public FrmIletisim()
        {
            InitializeComponent();
        }

        sqlbaglanti sqlbaglanti = new sqlbaglanti();
        void MusteriIletisimListesi()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select AD,SOYAD,TELEFON,TELEFON2,MAIL from MUSTERILER",sqlbaglanti.baglanti());
            adapter.Fill(table);
            myGridControl1.DataSource = table;
        }
        void FirmaIletisimListesi()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select AD,YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX from FIRMALAR",sqlbaglanti.baglanti());
            adapter.Fill(table);
            myGridControl2.DataSource = table;
        }

        private void FrmIletisim_Load(object sender, EventArgs e)
        {
            MusteriIletisimListesi();
            FirmaIletisimListesi();
        }

        private void myGridView2_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frmmail = new FrmMail();
            DataRow row = myGridView1.GetDataRow(myGridView1.FocusedRowHandle);
            if (row != null)
            {
                frmmail.mail = row["MAIL"].ToString();
            }
            frmmail.Show();
        }

        private void myGridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frmmail = new FrmMail();
            DataRow row = myGridView1.GetDataRow(myGridView1.FocusedRowHandle);
            if (row != null)
            {
                frmmail.mail = row["MAIL"].ToString();
            }
            frmmail.Show();
        }
    }
}
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
using System.Xml;

namespace WinForms.Forms
{
    public partial class FrmAnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        sqlbaglanti sqlbaglanti = new sqlbaglanti();
        void Stok()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select URUNAD, sum(ADET) as 'ADET' from URUNLER group by URUNAD having sum(ADET)<=20 order by sum(ADET)", sqlbaglanti.baglanti());
            adapter.Fill(table);
            GridControlStoklar.DataSource = table;
        }
        void Ajanda()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select top 10 TARIH,SAAT,BASLIK from NOTLAR order by ID desc", sqlbaglanti.baglanti());
            adapter.Fill(table);
            GridControlAjanda.DataSource = table;
        }
        void FirmaHareket()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Exec FirmaHareketHome", sqlbaglanti.baglanti());
            adapter.Fill(table);
            GridControlSonOn.DataSource = table;
        }
        void Fihrist()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select AD,TELEFON1 from FIRMALAR", sqlbaglanti.baglanti());
            adapter.Fill(table);
            GridControlFihrist.DataSource = table;
        }
        void döviz()
        {
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
        }
        void haberler()
        {
            XmlTextReader oku = new XmlTextReader("https://www.sabah.com.tr/rss/anasayfa.xml");
            while (oku.Read())
            {
                if (oku.Name=="title")
                {
                    listBox1.Items.Add(oku.ReadString());
                }
            }
        }
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            Stok();
            Ajanda();
            FirmaHareket();
            Fihrist();
            döviz();
            haberler();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac==60)
            {
                webBrowser1.Refresh();
                listBox1.Items.Clear();
                haberler();
            }
            if (sayac==61)
            {
                sayac = 0;
            }
            
        }
    }
}
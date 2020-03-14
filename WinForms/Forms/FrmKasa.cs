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
using DevExpress.Charts;

namespace WinForms.Forms
{
    public partial class FrmKasa : DevExpress.XtraEditors.XtraForm
    {
        public FrmKasa()
        {
            InitializeComponent();
        }
        sqlbaglanti sqlbaglanti = new sqlbaglanti();

        void MusteriHareket()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Execute MusteriHareketler", sqlbaglanti.baglanti());
            adapter.Fill(table);
            myGridControl1.DataSource = table;
        }
        void FirmaHareket()
        {
            DataTable tab = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("Execute FirmaHareketler", sqlbaglanti.baglanti());
            adap.Fill(tab);
            myGridControl2.DataSource = tab;
        }
        void ToplamTutar()
        {
            SqlCommand komut = new SqlCommand("Select sum(TUTAR) from FATURADETAY", sqlbaglanti.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                lblToplamTutar.Text = reader[0].ToString() + " ₺";
            }
            sqlbaglanti.baglanti().Close();
        }
        void Odeme()
        {
            SqlCommand komut = new SqlCommand("Select (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKSTRA) from GIDERLER order by ID asc", sqlbaglanti.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                lblOdemeler.Text = reader[0].ToString() + " ₺";
            }
            sqlbaglanti.baglanti().Close();
        }
        void PersonelMaas()
        {
            SqlCommand komut = new SqlCommand("Select MAASLAR from GIDERLER order by ID asc", sqlbaglanti.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                lblPersonelMaas.Text = reader[0].ToString() + " ₺";
            }
            sqlbaglanti.baglanti().Close();
        }
        void MusteriSaayi()
        {
            SqlCommand komut = new SqlCommand("Select Count(*) from MUSTERILER", sqlbaglanti.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                lblMusteriSayisi.Text = reader[0].ToString() + " Kişi";
            }
            sqlbaglanti.baglanti().Close();
        }
        void FirmaSaayi()
        {
            SqlCommand komut = new SqlCommand("Select Count(*) from FIRMALAR", sqlbaglanti.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                lblFirmaSayisi.Text = reader[0].ToString();
            }
            sqlbaglanti.baglanti().Close();
        }
        void PersonelSaayi()
        {
            SqlCommand komut = new SqlCommand("Select Count(*) from PERSONELLER", sqlbaglanti.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                lblPersonelSayisi.Text = reader[0].ToString() + " Kişi";
            }
            sqlbaglanti.baglanti().Close();
        }
        void FirmaSehirSayisi()
        {
            SqlCommand komut = new SqlCommand("Select Count(Distinct(IL)) from FIRMALAR", sqlbaglanti.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                lblFirmaSehirSayisi.Text = reader[0].ToString();
            }
            sqlbaglanti.baglanti().Close();
        }
        void MusteriSehirSayisi()
        {
            SqlCommand komut = new SqlCommand("Select Count(Distinct(IL)) from MUSTERILER", sqlbaglanti.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                lblMusteriSehirSayisi.Text = reader[0].ToString();
            }
            sqlbaglanti.baglanti().Close();
        }
        void ToplamStok()
        {
            SqlCommand komut = new SqlCommand("Select sum(ADET) from URUNLER", sqlbaglanti.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                lblStok.Text = reader[0].ToString() + " Adet";
            }
            sqlbaglanti.baglanti().Close();
        }
        void CikisListesi()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From GIDERLER", sqlbaglanti.baglanti());
            adapter.Fill(table);
            myGridControl3.DataSource = table;
        }
        private void FrmKasa_Load(object sender, EventArgs e)
        {
            MusteriHareket();
            FirmaHareket();
            ToplamTutar();
            Odeme();
            PersonelMaas();
            MusteriSaayi();
            FirmaSaayi();
            PersonelSaayi();
            FirmaSehirSayisi();
            MusteriSehirSayisi();
            ToplamStok();
            CikisListesi();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Çıkış Hareketleri kodları
            sayac++;
            if (sayac > 0 && sayac <= 5)
            {
                //Elektrik Faturası son 4 ay
                groupControl11.Text = "Elektrik Faturası";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("Select top 4 AY,ELEKTRIK from GIDERLER order by ID Desc", sqlbaglanti.baglanti());
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                sqlbaglanti.baglanti().Close();
            }
            if (sayac > 6 && sayac <= 10)
            {
                //Su Faturası son 4 ay
                groupControl11.Text = "Su Faturası";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("Select top 4 AY,SU from GIDERLER order by ID Desc", sqlbaglanti.baglanti());
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                sqlbaglanti.baglanti().Close();
            }
            if (sayac > 11 && sayac <= 15)
            {
                //Su Faturası son 4 ay
                groupControl11.Text = "Doğal Gaz Faturası";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("Select top 4 AY,DOGALGAZ from GIDERLER order by ID Desc", sqlbaglanti.baglanti());
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                sqlbaglanti.baglanti().Close();
            }
            if (sayac > 16 && sayac <= 20)
            {
                //Su Faturası son 4 ay
                groupControl11.Text = "İnternet Faturası";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("Select top 4 AY,INTERNET from GIDERLER order by ID Desc", sqlbaglanti.baglanti());
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                sqlbaglanti.baglanti().Close();
            }
            if (sayac > 21 && sayac <= 25)
            {
                //Su Faturası son 4 ay
                groupControl11.Text = "Ekstra";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("Select top 4 AY,EKSTRA from GIDERLER order by ID Desc", sqlbaglanti.baglanti());
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                sqlbaglanti.baglanti().Close();
            }
            if (sayac==26)
            {
                sayac = 0;
            }
        }
        int sayac2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            //Çıkış Hareketleri kodları
            sayac2++;
            if (sayac2 > 0 && sayac2 <= 5)
            {
                groupControl12.Text = "2019 Elektrik Faturası";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("Select top 4 AY,YIL,ELEKTRIK from GIDERLER where YIL='2019' order by ID Desc", sqlbaglanti.baglanti());
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[2]));
                }
                sqlbaglanti.baglanti().Close();
            }
            if (sayac2 > 6 && sayac2 <= 10)
            {
                groupControl12.Text = "2019 Su Faturası";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("Select top 4 AY,YIL,SU from GIDERLER where YIL='2019' order by ID Desc", sqlbaglanti.baglanti());
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[2]));
                }
                sqlbaglanti.baglanti().Close();
            }
            if (sayac2 > 11 && sayac2 <= 15)
            {
                groupControl12.Text = "2019 Doğal Gaz Faturası";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("Select top 4 AY,YIL,DOGALGAZ from GIDERLER where YIL='2019' order by ID Desc", sqlbaglanti.baglanti());
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[2]));
                }
                sqlbaglanti.baglanti().Close();
            }
            if (sayac2 > 16 && sayac2 <= 20)
            {
                groupControl12.Text = "2019 İnternet Faturası";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("Select top 4 AY,YIL,INTERNET from GIDERLER where YIL='2019' order by ID Desc", sqlbaglanti.baglanti());
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[2]));
                }
                sqlbaglanti.baglanti().Close();
            }
            if (sayac2 > 21 && sayac2 <= 25)
            {
                groupControl12.Text = "2019 Ekstra";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("Select AY,YIL,EKSTRA from GIDERLER where YIL='2019' order by ID Desc", sqlbaglanti.baglanti());
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[2]));
                }
                sqlbaglanti.baglanti().Close();
            }
            if (sayac2 > 26 && sayac2 <= 30)
            {
                groupControl12.Text = "2020 Elektrik Faturası";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("Select top 4 AY,YIL,ELEKTRIK from GIDERLER where YIL='2020' order by ID Desc", sqlbaglanti.baglanti());
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[2]));
                }
                sqlbaglanti.baglanti().Close();
            }
            if (sayac2 > 31 && sayac2 <= 35)
            {
                groupControl12.Text = "2020 Su Faturası";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("Select top 4 AY,YIL,SU from GIDERLER where YIL='2020' order by ID Desc", sqlbaglanti.baglanti());
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[2]));
                }
                sqlbaglanti.baglanti().Close();
            }
            if (sayac2 > 36 && sayac2 <= 40)
            {
                groupControl12.Text = "2020 Doğal Gaz Faturası";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("Select top 4 AY,YIL,DOGALGAZ from GIDERLER where YIL='2020' order by ID Desc", sqlbaglanti.baglanti());
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[2]));
                }
                sqlbaglanti.baglanti().Close();
            }
            if (sayac2 > 41 && sayac2 <= 45)
            {
                groupControl12.Text = "2020 İnternet Faturası";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("Select top 4 AY,YIL,INTERNET from GIDERLER where YIL='2020' order by ID Desc", sqlbaglanti.baglanti());
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[2]));
                }
                sqlbaglanti.baglanti().Close();
            }
            if (sayac2 > 46 && sayac2 <= 50)
            {
                groupControl12.Text = "2020 Ekstra Faturası";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("Select top 4 AY,YIL,EKSTRA from GIDERLER where YIL='2020' order by ID Desc", sqlbaglanti.baglanti());
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[2]));
                }
                sqlbaglanti.baglanti().Close();
            }
            if (sayac2 == 51)
            {
                sayac2 = 0;
            }
        }
    }
}
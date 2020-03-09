namespace WinForms.Forms
{
    partial class FrmHareketler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.myGridControl1 = new WinForms.UserControl.MyGridControl.MyGridControl();
            this.myGridView1 = new WinForms.UserControl.MyGridControl.MyGridView();
            this.colID = new WinForms.UserControl.MyGridControl.MyGridColumn();
            this.gridURUNID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridADET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPERSONEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMUSTERI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTOPLAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFATURAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridNOTLAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.myGridControl2 = new WinForms.UserControl.MyGridControl.MyGridControl();
            this.myGridView2 = new WinForms.UserControl.MyGridControl.MyGridView();
            this.colID1 = new WinForms.UserControl.MyGridControl.MyGridColumn();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.myGridControl3 = new WinForms.UserControl.MyGridControl.MyGridControl();
            this.myGridView3 = new WinForms.UserControl.MyGridControl.MyGridView();
            this.colID2 = new WinForms.UserControl.MyGridControl.MyGridColumn();
            this.URUNID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PERSONEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TOPLAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOTLAR = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1910, 1048);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Controls.Add(this.myGridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1904, 1019);
            this.xtraTabPage1.Text = "Müşteri Hareketleri";
            // 
            // myGridControl1
            // 
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(1904, 1019);
            this.myGridControl1.TabIndex = 0;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1});
            // 
            // myGridView1
            // 
            this.myGridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.myGridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.myGridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.myGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myGridView1.Appearance.Row.BackColor = System.Drawing.Color.Aquamarine;
            this.myGridView1.Appearance.Row.BackColor2 = System.Drawing.Color.LightGreen;
            this.myGridView1.Appearance.Row.Options.UseBackColor = true;
            this.myGridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.myGridView1.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Black;
            this.myGridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.myGridView1.Appearance.ViewCaption.Options.UseForeColor = true;
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.gridURUNID,
            this.gridADET,
            this.gridPERSONEL,
            this.gridMUSTERI,
            this.gridFIYAT,
            this.gridTOPLAM,
            this.gridFATURAID,
            this.gridTARIH,
            this.gridNOTLAR});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsMenu.EnableColumnMenu = false;
            this.myGridView1.OptionsMenu.EnableFooterMenu = false;
            this.myGridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView1.OptionsView.ColumnAutoWidth = false;
            this.myGridView1.OptionsView.ShowGroupPanel = false;
            this.myGridView1.OptionsView.ShowViewCaption = true;
            this.myGridView1.ViewCaption = "Müşteri Hareket Listesi";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // gridURUNID
            // 
            this.gridURUNID.Caption = "ÜRÜN AD";
            this.gridURUNID.FieldName = "URUNAD";
            this.gridURUNID.Name = "gridURUNID";
            this.gridURUNID.Visible = true;
            this.gridURUNID.VisibleIndex = 0;
            this.gridURUNID.Width = 215;
            // 
            // gridADET
            // 
            this.gridADET.Caption = "ADET";
            this.gridADET.FieldName = "ADET";
            this.gridADET.Name = "gridADET";
            this.gridADET.Visible = true;
            this.gridADET.VisibleIndex = 1;
            this.gridADET.Width = 200;
            // 
            // gridPERSONEL
            // 
            this.gridPERSONEL.Caption = "PERSONEL AD SOYAD";
            this.gridPERSONEL.FieldName = "AD SOYAD";
            this.gridPERSONEL.Name = "gridPERSONEL";
            this.gridPERSONEL.Visible = true;
            this.gridPERSONEL.VisibleIndex = 2;
            this.gridPERSONEL.Width = 210;
            // 
            // gridMUSTERI
            // 
            this.gridMUSTERI.Caption = "MÜŞTERİ AD SOYAD";
            this.gridMUSTERI.FieldName = "MUSTERI AD SOYAD";
            this.gridMUSTERI.Name = "gridMUSTERI";
            this.gridMUSTERI.Visible = true;
            this.gridMUSTERI.VisibleIndex = 3;
            this.gridMUSTERI.Width = 210;
            // 
            // gridFIYAT
            // 
            this.gridFIYAT.Caption = "FİYAT";
            this.gridFIYAT.FieldName = "FIYAT";
            this.gridFIYAT.Name = "gridFIYAT";
            this.gridFIYAT.Visible = true;
            this.gridFIYAT.VisibleIndex = 4;
            this.gridFIYAT.Width = 210;
            // 
            // gridTOPLAM
            // 
            this.gridTOPLAM.Caption = "TOPLAM";
            this.gridTOPLAM.FieldName = "TOPLAM";
            this.gridTOPLAM.Name = "gridTOPLAM";
            this.gridTOPLAM.Visible = true;
            this.gridTOPLAM.VisibleIndex = 5;
            this.gridTOPLAM.Width = 210;
            // 
            // gridFATURAID
            // 
            this.gridFATURAID.Caption = "FATURA";
            this.gridFATURAID.FieldName = "FATURAID";
            this.gridFATURAID.Name = "gridFATURAID";
            this.gridFATURAID.Visible = true;
            this.gridFATURAID.VisibleIndex = 6;
            this.gridFATURAID.Width = 210;
            // 
            // gridTARIH
            // 
            this.gridTARIH.Caption = "TARİH";
            this.gridTARIH.FieldName = "TARIH";
            this.gridTARIH.Name = "gridTARIH";
            this.gridTARIH.Visible = true;
            this.gridTARIH.VisibleIndex = 7;
            this.gridTARIH.Width = 210;
            // 
            // gridNOTLAR
            // 
            this.gridNOTLAR.Caption = "NOTLAR";
            this.gridNOTLAR.FieldName = "NOTLAR";
            this.gridNOTLAR.Name = "gridNOTLAR";
            this.gridNOTLAR.Visible = true;
            this.gridNOTLAR.VisibleIndex = 8;
            this.gridNOTLAR.Width = 210;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 9F);
            this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage2.Controls.Add(this.myGridControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1904, 1019);
            this.xtraTabPage2.Text = "Firma Hareketleri";
            // 
            // myGridControl2
            // 
            this.myGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl2.Location = new System.Drawing.Point(0, 0);
            this.myGridControl2.MainView = this.myGridView2;
            this.myGridControl2.Name = "myGridControl2";
            this.myGridControl2.Size = new System.Drawing.Size(1904, 1019);
            this.myGridControl2.TabIndex = 0;
            this.myGridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView2});
            // 
            // myGridView2
            // 
            this.myGridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.myGridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.myGridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.myGridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myGridView2.Appearance.Row.BackColor = System.Drawing.Color.Aquamarine;
            this.myGridView2.Appearance.Row.BackColor2 = System.Drawing.Color.LightGreen;
            this.myGridView2.Appearance.Row.Options.UseBackColor = true;
            this.myGridView2.Appearance.ViewCaption.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.myGridView2.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Black;
            this.myGridView2.Appearance.ViewCaption.Options.UseFont = true;
            this.myGridView2.Appearance.ViewCaption.Options.UseForeColor = true;
            this.myGridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.URUNID,
            this.ADET,
            this.PERSONEL,
            this.gridColumn4,
            this.FIYAT,
            this.TOPLAM,
            this.FATURAID,
            this.TARIH,
            this.NOTLAR});
            this.myGridView2.GridControl = this.myGridControl2;
            this.myGridView2.Name = "myGridView2";
            this.myGridView2.OptionsMenu.EnableColumnMenu = false;
            this.myGridView2.OptionsMenu.EnableFooterMenu = false;
            this.myGridView2.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView2.OptionsView.ColumnAutoWidth = false;
            this.myGridView2.OptionsView.ShowGroupPanel = false;
            this.myGridView2.OptionsView.ShowViewCaption = true;
            this.myGridView2.ViewCaption = "Firma Hareket Listesi";
            // 
            // colID1
            // 
            this.colID1.Caption = "ID";
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.AllowEdit = false;
            this.colID1.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 9F);
            this.xtraTabPage3.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage3.Controls.Add(this.myGridControl3);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1904, 1019);
            this.xtraTabPage3.Text = "Stok Hareketleri";
            // 
            // myGridControl3
            // 
            this.myGridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl3.Location = new System.Drawing.Point(0, 0);
            this.myGridControl3.MainView = this.myGridView3;
            this.myGridControl3.Name = "myGridControl3";
            this.myGridControl3.Size = new System.Drawing.Size(1904, 1019);
            this.myGridControl3.TabIndex = 0;
            this.myGridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView3});
            // 
            // myGridView3
            // 
            this.myGridView3.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.myGridView3.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.myGridView3.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.myGridView3.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myGridView3.Appearance.ViewCaption.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.myGridView3.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Black;
            this.myGridView3.Appearance.ViewCaption.Options.UseFont = true;
            this.myGridView3.Appearance.ViewCaption.Options.UseForeColor = true;
            this.myGridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID2});
            this.myGridView3.GridControl = this.myGridControl3;
            this.myGridView3.Name = "myGridView3";
            this.myGridView3.OptionsMenu.EnableColumnMenu = false;
            this.myGridView3.OptionsMenu.EnableFooterMenu = false;
            this.myGridView3.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView3.OptionsView.ColumnAutoWidth = false;
            this.myGridView3.OptionsView.ShowGroupPanel = false;
            this.myGridView3.OptionsView.ShowViewCaption = true;
            this.myGridView3.ViewCaption = "Stok Hareket Listesi";
            // 
            // colID2
            // 
            this.colID2.Caption = "ID";
            this.colID2.FieldName = "ID";
            this.colID2.Name = "colID2";
            this.colID2.OptionsColumn.AllowEdit = false;
            this.colID2.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // URUNID
            // 
            this.URUNID.Caption = "ÜRÜN AD";
            this.URUNID.FieldName = "URUNAD";
            this.URUNID.Name = "URUNID";
            this.URUNID.Visible = true;
            this.URUNID.VisibleIndex = 0;
            this.URUNID.Width = 215;
            // 
            // ADET
            // 
            this.ADET.Caption = "ADET";
            this.ADET.FieldName = "ADET";
            this.ADET.Name = "ADET";
            this.ADET.Visible = true;
            this.ADET.VisibleIndex = 1;
            this.ADET.Width = 208;
            // 
            // PERSONEL
            // 
            this.PERSONEL.Caption = "PERSONEL AD SOYAD";
            this.PERSONEL.FieldName = "AD SOYAD";
            this.PERSONEL.Name = "PERSONEL";
            this.PERSONEL.Visible = true;
            this.PERSONEL.VisibleIndex = 2;
            this.PERSONEL.Width = 208;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "FİRMA AD";
            this.gridColumn4.FieldName = "FIRMA AD";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 208;
            // 
            // FIYAT
            // 
            this.FIYAT.Caption = "FİYAT";
            this.FIYAT.FieldName = "FIYAT";
            this.FIYAT.Name = "FIYAT";
            this.FIYAT.Visible = true;
            this.FIYAT.VisibleIndex = 4;
            this.FIYAT.Width = 208;
            // 
            // TOPLAM
            // 
            this.TOPLAM.Caption = "TOPLAM";
            this.TOPLAM.FieldName = "TOPLAM";
            this.TOPLAM.Name = "TOPLAM";
            this.TOPLAM.Visible = true;
            this.TOPLAM.VisibleIndex = 5;
            this.TOPLAM.Width = 208;
            // 
            // FATURAID
            // 
            this.FATURAID.Caption = "FATURA ID";
            this.FATURAID.FieldName = "FATURAID";
            this.FATURAID.Name = "FATURAID";
            this.FATURAID.Visible = true;
            this.FATURAID.VisibleIndex = 6;
            this.FATURAID.Width = 208;
            // 
            // TARIH
            // 
            this.TARIH.Caption = "TARİH";
            this.TARIH.FieldName = "TARIH";
            this.TARIH.Name = "TARIH";
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 7;
            this.TARIH.Width = 208;
            // 
            // NOTLAR
            // 
            this.NOTLAR.Caption = "NOTLAR";
            this.NOTLAR.FieldName = "NOTLAR";
            this.NOTLAR.Name = "NOTLAR";
            this.NOTLAR.Visible = true;
            this.NOTLAR.VisibleIndex = 8;
            this.NOTLAR.Width = 214;
            // 
            // FrmHareketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 1048);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FrmHareketler";
            this.Text = "Hareketler";
            this.Load += new System.EventHandler(this.FrmHareketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private UserControl.MyGridControl.MyGridControl myGridControl1;
        private UserControl.MyGridControl.MyGridView myGridView1;
        private UserControl.MyGridControl.MyGridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn gridURUNID;
        private DevExpress.XtraGrid.Columns.GridColumn gridADET;
        private DevExpress.XtraGrid.Columns.GridColumn gridPERSONEL;
        private DevExpress.XtraGrid.Columns.GridColumn gridMUSTERI;
        private DevExpress.XtraGrid.Columns.GridColumn gridFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn gridTOPLAM;
        private DevExpress.XtraGrid.Columns.GridColumn gridFATURAID;
        private DevExpress.XtraGrid.Columns.GridColumn gridTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn gridNOTLAR;
        private UserControl.MyGridControl.MyGridControl myGridControl2;
        private UserControl.MyGridControl.MyGridView myGridView2;
        private UserControl.MyGridControl.MyGridColumn colID1;
        private UserControl.MyGridControl.MyGridControl myGridControl3;
        private UserControl.MyGridControl.MyGridView myGridView3;
        private UserControl.MyGridControl.MyGridColumn colID2;
        private DevExpress.XtraGrid.Columns.GridColumn URUNID;
        private DevExpress.XtraGrid.Columns.GridColumn ADET;
        private DevExpress.XtraGrid.Columns.GridColumn PERSONEL;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn FIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn TOPLAM;
        private DevExpress.XtraGrid.Columns.GridColumn FATURAID;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
        private DevExpress.XtraGrid.Columns.GridColumn NOTLAR;
    }
}
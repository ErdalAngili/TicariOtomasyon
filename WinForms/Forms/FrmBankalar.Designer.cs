namespace WinForms.Forms
{
    partial class FrmBankalar
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
            this.myGridControl1 = new WinForms.UserControl.MyGridControl.MyGridControl();
            this.myGridView1 = new WinForms.UserControl.MyGridControl.MyGridView();
            this.colID = new WinForms.UserControl.MyGridControl.MyGridColumn();
            this.gridBANKAADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridILCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSUBE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHESAPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridYETKILI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTELEFON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHESAPTURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFIRMAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.TxtYetkili = new DevExpress.XtraEditors.TextEdit();
            this.lookFirma = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.MaskTarih = new System.Windows.Forms.MaskedTextBox();
            this.MaskHesap = new System.Windows.Forms.MaskedTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.Comilce = new System.Windows.Forms.ComboBox();
            this.Comil = new System.Windows.Forms.ComboBox();
            this.MaskIban = new System.Windows.Forms.MaskedTextBox();
            this.TxtHesapTuru = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSube = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHesapTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // myGridControl1
            // 
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(1573, 1048);
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
            this.myGridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.myGridView1.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Black;
            this.myGridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.myGridView1.Appearance.ViewCaption.Options.UseForeColor = true;
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.gridBANKAADI,
            this.gridIL,
            this.gridILCE,
            this.gridSUBE,
            this.gridIBAN,
            this.gridHESAPNO,
            this.gridYETKILI,
            this.gridTELEFON,
            this.gridTARIH,
            this.gridHESAPTURU,
            this.gridFIRMAID});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsMenu.EnableColumnMenu = false;
            this.myGridView1.OptionsMenu.EnableFooterMenu = false;
            this.myGridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView1.OptionsView.ColumnAutoWidth = false;
            this.myGridView1.OptionsView.ShowGroupPanel = false;
            this.myGridView1.OptionsView.ShowViewCaption = true;
            this.myGridView1.ViewCaption = "Bankalar";
            this.myGridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.myGridView1_FocusedRowChanged);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // gridBANKAADI
            // 
            this.gridBANKAADI.Caption = "BANKA ADI";
            this.gridBANKAADI.FieldName = "BANKAADI";
            this.gridBANKAADI.Name = "gridBANKAADI";
            this.gridBANKAADI.Visible = true;
            this.gridBANKAADI.VisibleIndex = 0;
            this.gridBANKAADI.Width = 141;
            // 
            // gridIL
            // 
            this.gridIL.Caption = "İL";
            this.gridIL.FieldName = "IL";
            this.gridIL.Name = "gridIL";
            this.gridIL.Visible = true;
            this.gridIL.VisibleIndex = 1;
            this.gridIL.Width = 135;
            // 
            // gridILCE
            // 
            this.gridILCE.Caption = "İLÇE";
            this.gridILCE.FieldName = "ILCE";
            this.gridILCE.Name = "gridILCE";
            this.gridILCE.Visible = true;
            this.gridILCE.VisibleIndex = 2;
            this.gridILCE.Width = 135;
            // 
            // gridSUBE
            // 
            this.gridSUBE.Caption = "ŞUBE";
            this.gridSUBE.FieldName = "SUBE";
            this.gridSUBE.Name = "gridSUBE";
            this.gridSUBE.Visible = true;
            this.gridSUBE.VisibleIndex = 3;
            this.gridSUBE.Width = 141;
            // 
            // gridIBAN
            // 
            this.gridIBAN.Caption = "İBAN";
            this.gridIBAN.FieldName = "IBAN";
            this.gridIBAN.Name = "gridIBAN";
            this.gridIBAN.Visible = true;
            this.gridIBAN.VisibleIndex = 4;
            this.gridIBAN.Width = 161;
            // 
            // gridHESAPNO
            // 
            this.gridHESAPNO.Caption = "HESAP NO";
            this.gridHESAPNO.FieldName = "HESAPNO";
            this.gridHESAPNO.Name = "gridHESAPNO";
            this.gridHESAPNO.Visible = true;
            this.gridHESAPNO.VisibleIndex = 5;
            this.gridHESAPNO.Width = 141;
            // 
            // gridYETKILI
            // 
            this.gridYETKILI.Caption = "YETKİLİ";
            this.gridYETKILI.FieldName = "YETKILI";
            this.gridYETKILI.Name = "gridYETKILI";
            this.gridYETKILI.Visible = true;
            this.gridYETKILI.VisibleIndex = 6;
            this.gridYETKILI.Width = 142;
            // 
            // gridTELEFON
            // 
            this.gridTELEFON.Caption = "TELEFON";
            this.gridTELEFON.FieldName = "TELEFON";
            this.gridTELEFON.Name = "gridTELEFON";
            this.gridTELEFON.Visible = true;
            this.gridTELEFON.VisibleIndex = 7;
            this.gridTELEFON.Width = 141;
            // 
            // gridTARIH
            // 
            this.gridTARIH.Caption = "TARİH";
            this.gridTARIH.FieldName = "TARIH";
            this.gridTARIH.Name = "gridTARIH";
            this.gridTARIH.Visible = true;
            this.gridTARIH.VisibleIndex = 8;
            this.gridTARIH.Width = 139;
            // 
            // gridHESAPTURU
            // 
            this.gridHESAPTURU.Caption = "HESAP TÜRÜ";
            this.gridHESAPTURU.FieldName = "HESAPTURU";
            this.gridHESAPTURU.Name = "gridHESAPTURU";
            this.gridHESAPTURU.Visible = true;
            this.gridHESAPTURU.VisibleIndex = 9;
            this.gridHESAPTURU.Width = 138;
            // 
            // gridFIRMAID
            // 
            this.gridFIRMAID.Caption = "FİRMA ADI";
            this.gridFIRMAID.FieldName = "AD";
            this.gridFIRMAID.Name = "gridFIRMAID";
            this.gridFIRMAID.Visible = true;
            this.gridFIRMAID.VisibleIndex = 10;
            this.gridFIRMAID.Width = 140;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.TxtYetkili);
            this.groupControl1.Controls.Add(this.lookFirma);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.MaskTarih);
            this.groupControl1.Controls.Add(this.MaskHesap);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.Comilce);
            this.groupControl1.Controls.Add(this.Comil);
            this.groupControl1.Controls.Add(this.MaskIban);
            this.groupControl1.Controls.Add(this.TxtHesapTuru);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtId);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.MskTelefon);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtSube);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TxtAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1573, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(338, 1046);
            this.groupControl1.TabIndex = 5;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.ImageOptions.SvgImage = global::WinForms.Properties.Resources.removedataitems1;
            this.BtnTemizle.Location = new System.Drawing.Point(113, 616);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(194, 36);
            this.BtnTemizle.TabIndex = 43;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.Location = new System.Drawing.Point(113, 256);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYetkili.Properties.Appearance.Options.UseFont = true;
            this.TxtYetkili.Size = new System.Drawing.Size(194, 26);
            this.TxtYetkili.TabIndex = 42;
            // 
            // lookFirma
            // 
            this.lookFirma.Location = new System.Drawing.Point(113, 402);
            this.lookFirma.Name = "lookFirma";
            this.lookFirma.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.lookFirma.Properties.Appearance.Options.UseFont = true;
            this.lookFirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookFirma.Properties.NullText = "Lütfen Firma Seçiniz";
            this.lookFirma.Size = new System.Drawing.Size(194, 26);
            this.lookFirma.TabIndex = 41;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(60, 405);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 20);
            this.labelControl8.TabIndex = 39;
            this.labelControl8.Text = "FİRMA:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(60, 332);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(47, 20);
            this.labelControl12.TabIndex = 38;
            this.labelControl12.Text = "TARİH:";
            // 
            // MaskTarih
            // 
            this.MaskTarih.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaskTarih.Location = new System.Drawing.Point(113, 329);
            this.MaskTarih.Mask = "00/00/0000";
            this.MaskTarih.Name = "MaskTarih";
            this.MaskTarih.Size = new System.Drawing.Size(194, 25);
            this.MaskTarih.TabIndex = 37;
            this.MaskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // MaskHesap
            // 
            this.MaskHesap.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.MaskHesap.Location = new System.Drawing.Point(113, 220);
            this.MaskHesap.Name = "MaskHesap";
            this.MaskHesap.Size = new System.Drawing.Size(194, 25);
            this.MaskHesap.TabIndex = 36;
            this.MaskHesap.ValidatingType = typeof(int);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(34, 223);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(73, 20);
            this.labelControl11.TabIndex = 35;
            this.labelControl11.Text = "HESAP NO:";
            // 
            // Comilce
            // 
            this.Comilce.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.Comilce.FormattingEnabled = true;
            this.Comilce.Location = new System.Drawing.Point(113, 108);
            this.Comilce.Name = "Comilce";
            this.Comilce.Size = new System.Drawing.Size(194, 28);
            this.Comilce.TabIndex = 32;
            // 
            // Comil
            // 
            this.Comil.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.Comil.FormattingEnabled = true;
            this.Comil.Location = new System.Drawing.Point(113, 69);
            this.Comil.Name = "Comil";
            this.Comil.Size = new System.Drawing.Size(194, 28);
            this.Comil.TabIndex = 31;
            this.Comil.SelectedIndexChanged += new System.EventHandler(this.Comil_SelectedIndexChanged);
            // 
            // MaskIban
            // 
            this.MaskIban.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.MaskIban.Location = new System.Drawing.Point(113, 184);
            this.MaskIban.Name = "MaskIban";
            this.MaskIban.Size = new System.Drawing.Size(194, 25);
            this.MaskIban.TabIndex = 29;
            this.MaskIban.ValidatingType = typeof(int);
            // 
            // TxtHesapTuru
            // 
            this.TxtHesapTuru.Location = new System.Drawing.Point(113, 365);
            this.TxtHesapTuru.Name = "TxtHesapTuru";
            this.TxtHesapTuru.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtHesapTuru.Properties.Appearance.Options.UseFont = true;
            this.TxtHesapTuru.Size = new System.Drawing.Size(194, 26);
            this.TxtHesapTuru.TabIndex = 28;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(16, 368);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(91, 20);
            this.labelControl10.TabIndex = 27;
            this.labelControl10.Text = "HESAP TÜRÜ:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(72, 111);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 20);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "İLÇE:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(303, 1014);
            this.TxtId.Name = "TxtId";
            this.TxtId.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtId.Properties.Appearance.Options.UseFont = true;
            this.TxtId.Size = new System.Drawing.Size(19, 26);
            this.TxtId.TabIndex = 24;
            this.TxtId.Visible = false;
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = global::WinForms.Properties.Resources.close_32x32;
            this.BtnSil.Location = new System.Drawing.Point(113, 568);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(194, 36);
            this.BtnSil.TabIndex = 23;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = global::WinForms.Properties.Resources.convert_32x32;
            this.BtnGuncelle.Location = new System.Drawing.Point(112, 520);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(194, 36);
            this.BtnGuncelle.TabIndex = 22;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = global::WinForms.Properties.Resources.save_32x32;
            this.BtnKaydet.Location = new System.Drawing.Point(113, 472);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(194, 36);
            this.BtnKaydet.TabIndex = 21;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(89, 72);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(18, 20);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "İL:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(50, 259);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 20);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "YETKİLİ:";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTelefon.Location = new System.Drawing.Point(113, 293);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(194, 25);
            this.MskTelefon.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(40, 296);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 20);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "TELEFON:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(70, 187);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 20);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "İBAN:";
            // 
            // TxtSube
            // 
            this.TxtSube.Location = new System.Drawing.Point(113, 147);
            this.TxtSube.Name = "TxtSube";
            this.TxtSube.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSube.Properties.Appearance.Options.UseFont = true;
            this.TxtSube.Size = new System.Drawing.Size(194, 26);
            this.TxtSube.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(68, 150);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 20);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "ŞUBE:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(113, 32);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Properties.Appearance.Options.UseFont = true;
            this.TxtAd.Size = new System.Drawing.Size(194, 26);
            this.TxtAd.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "BANKA ADI:";
            // 
            // FrmBankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 1048);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.myGridControl1);
            this.Name = "FrmBankalar";
            this.Text = "Bankalar";
            this.Load += new System.EventHandler(this.FrmBankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHesapTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.MyGridControl.MyGridControl myGridControl1;
        private UserControl.MyGridControl.MyGridView myGridView1;
        private UserControl.MyGridControl.MyGridColumn colID;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox Comilce;
        private System.Windows.Forms.ComboBox Comil;
        private System.Windows.Forms.MaskedTextBox MaskIban;
        private DevExpress.XtraEditors.TextEdit TxtHesapTuru;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtSube;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox MaskHesap;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.MaskedTextBox MaskTarih;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn gridBANKAADI;
        private DevExpress.XtraGrid.Columns.GridColumn gridIL;
        private DevExpress.XtraGrid.Columns.GridColumn gridILCE;
        private DevExpress.XtraGrid.Columns.GridColumn gridSUBE;
        private DevExpress.XtraGrid.Columns.GridColumn gridIBAN;
        private DevExpress.XtraGrid.Columns.GridColumn gridHESAPNO;
        private DevExpress.XtraGrid.Columns.GridColumn gridYETKILI;
        private DevExpress.XtraGrid.Columns.GridColumn gridTELEFON;
        private DevExpress.XtraGrid.Columns.GridColumn gridTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn gridHESAPTURU;
        private DevExpress.XtraGrid.Columns.GridColumn gridFIRMAID;
        private DevExpress.XtraEditors.LookUpEdit lookFirma;
        private DevExpress.XtraEditors.TextEdit TxtYetkili;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
    }
}
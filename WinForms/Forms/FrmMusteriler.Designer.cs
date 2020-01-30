namespace WinForms.Forms
{
    partial class FrmMusteriler
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtMail = new WinForms.UserControl.MyTextMail.MyTextMail();
            this.Comilce = new System.Windows.Forms.ComboBox();
            this.Comil = new System.Windows.Forms.ComboBox();
            this.MaskTC = new System.Windows.Forms.MaskedTextBox();
            this.MaskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtVergiDaire = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RichAdres = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.MskTelefonIki = new System.Windows.Forms.MaskedTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiDaire.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).BeginInit();
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
            this.colID});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsMenu.EnableColumnMenu = false;
            this.myGridView1.OptionsMenu.EnableFooterMenu = false;
            this.myGridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView1.OptionsView.ColumnAutoWidth = false;
            this.myGridView1.OptionsView.ShowGroupPanel = false;
            this.myGridView1.OptionsView.ShowViewCaption = true;
            this.myGridView1.ViewCaption = "Müşteri Listesi";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtMail);
            this.groupControl1.Controls.Add(this.Comilce);
            this.groupControl1.Controls.Add(this.Comil);
            this.groupControl1.Controls.Add(this.MaskTC);
            this.groupControl1.Controls.Add(this.MaskTelefon);
            this.groupControl1.Controls.Add(this.TxtVergiDaire);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtId);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.RichAdres);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.MskTelefonIki);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtSoyad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TxtAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1573, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(338, 1046);
            this.groupControl1.TabIndex = 4;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(113, 215);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.TxtMail.Properties.Appearance.Options.UseFont = true;
            this.TxtMail.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.TxtMail.Properties.Mask.EditMask = "((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_" +
    "-])+)+";
            this.TxtMail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TxtMail.Properties.MaxLength = 50;
            this.TxtMail.Size = new System.Drawing.Size(194, 26);
            this.TxtMail.TabIndex = 34;
            // 
            // Comilce
            // 
            this.Comilce.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.Comilce.FormattingEnabled = true;
            this.Comilce.Location = new System.Drawing.Point(113, 289);
            this.Comilce.Name = "Comilce";
            this.Comilce.Size = new System.Drawing.Size(194, 28);
            this.Comilce.TabIndex = 32;
            // 
            // Comil
            // 
            this.Comil.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.Comil.FormattingEnabled = true;
            this.Comil.Location = new System.Drawing.Point(113, 252);
            this.Comil.Name = "Comil";
            this.Comil.Size = new System.Drawing.Size(194, 28);
            this.Comil.TabIndex = 31;
            this.Comil.SelectedIndexChanged += new System.EventHandler(this.Comil_SelectedIndexChanged);
            // 
            // MaskTC
            // 
            this.MaskTC.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaskTC.Location = new System.Drawing.Point(113, 178);
            this.MaskTC.Mask = "00000000000";
            this.MaskTC.Name = "MaskTC";
            this.MaskTC.Size = new System.Drawing.Size(194, 25);
            this.MaskTC.TabIndex = 30;
            this.MaskTC.ValidatingType = typeof(int);
            // 
            // MaskTelefon
            // 
            this.MaskTelefon.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.MaskTelefon.Location = new System.Drawing.Point(112, 106);
            this.MaskTelefon.Mask = "(999) 000-0000";
            this.MaskTelefon.Name = "MaskTelefon";
            this.MaskTelefon.Size = new System.Drawing.Size(194, 25);
            this.MaskTelefon.TabIndex = 29;
            // 
            // TxtVergiDaire
            // 
            this.TxtVergiDaire.Location = new System.Drawing.Point(113, 326);
            this.TxtVergiDaire.Name = "TxtVergiDaire";
            this.TxtVergiDaire.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVergiDaire.Properties.Appearance.Options.UseFont = true;
            this.TxtVergiDaire.Size = new System.Drawing.Size(194, 26);
            this.TxtVergiDaire.TabIndex = 28;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(17, 329);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(90, 20);
            this.labelControl10.TabIndex = 27;
            this.labelControl10.Text = "VERGİ DAİRE:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(72, 292);
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
            this.BtnSil.Location = new System.Drawing.Point(113, 609);
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
            this.BtnGuncelle.Location = new System.Drawing.Point(112, 561);
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
            this.BtnKaydet.Location = new System.Drawing.Point(113, 513);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(194, 36);
            this.BtnKaydet.TabIndex = 21;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RichAdres
            // 
            this.RichAdres.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RichAdres.Location = new System.Drawing.Point(113, 363);
            this.RichAdres.Name = "RichAdres";
            this.RichAdres.Size = new System.Drawing.Size(194, 138);
            this.RichAdres.TabIndex = 20;
            this.RichAdres.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(77, 181);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(30, 20);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "T.C:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(59, 366);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 20);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "ADRES:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(89, 255);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(18, 20);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "İL:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(69, 218);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(38, 20);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "MAİL:";
            // 
            // MskTelefonIki
            // 
            this.MskTelefonIki.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTelefonIki.Location = new System.Drawing.Point(113, 143);
            this.MskTelefonIki.Mask = "(999) 000-0000";
            this.MskTelefonIki.Name = "MskTelefonIki";
            this.MskTelefonIki.Size = new System.Drawing.Size(194, 25);
            this.MskTelefonIki.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(32, 146);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 20);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "TELEFON2:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(40, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 20);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "TELEFON:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(113, 69);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Properties.Appearance.Options.UseFont = true;
            this.TxtSoyad.Size = new System.Drawing.Size(194, 26);
            this.TxtSoyad.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(57, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 20);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "SOYAD:";
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
            this.labelControl1.Location = new System.Drawing.Point(84, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ad:";
            // 
            // FrmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 1048);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.myGridControl1);
            this.Name = "FrmMusteriler";
            this.Text = "Müşteriler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiDaire.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox MaskTC;
        private System.Windows.Forms.MaskedTextBox MaskTelefon;
        private DevExpress.XtraEditors.TextEdit TxtVergiDaire;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RichAdres;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.MaskedTextBox MskTelefonIki;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private UserControl.MyTextMail.MyTextMail TxtMail;
    }
}
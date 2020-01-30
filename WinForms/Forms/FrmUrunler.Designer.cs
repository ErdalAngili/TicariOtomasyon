namespace WinForms.Forms
{
    partial class FrmUrunler
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
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RichDetay = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSatis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMaliyet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.MskYil = new System.Windows.Forms.MaskedTextBox();
            this.NudAdet = new System.Windows.Forms.NumericUpDown();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaliyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).BeginInit();
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
            this.myGridView1.ViewCaption = "Ürün Listesi";
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtId);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.RichDetay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.TxtSatis);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.TxtMaliyet);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.MskYil);
            this.groupControl1.Controls.Add(this.NudAdet);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TxtModel);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtMarka);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TxtAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1573, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(340, 1040);
            this.groupControl1.TabIndex = 2;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(324, 565);
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
            this.BtnSil.ImageOptions.Image = global::WinForms.Properties.Resources.close_32x321;
            this.BtnSil.Location = new System.Drawing.Point(107, 513);
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
            this.BtnGuncelle.ImageOptions.Image = global::WinForms.Properties.Resources.convert_32x321;
            this.BtnGuncelle.Location = new System.Drawing.Point(107, 466);
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
            this.BtnKaydet.ImageOptions.Image = global::WinForms.Properties.Resources.save_32x321;
            this.BtnKaydet.Location = new System.Drawing.Point(107, 419);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(194, 36);
            this.BtnKaydet.TabIndex = 21;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RichDetay
            // 
            this.RichDetay.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RichDetay.Location = new System.Drawing.Point(107, 289);
            this.RichDetay.Name = "RichDetay";
            this.RichDetay.Size = new System.Drawing.Size(194, 118);
            this.RichDetay.TabIndex = 20;
            this.RichDetay.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(57, 181);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(37, 20);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Adet:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(50, 292);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 20);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Detay:";
            // 
            // TxtSatis
            // 
            this.TxtSatis.Location = new System.Drawing.Point(106, 252);
            this.TxtSatis.Name = "TxtSatis";
            this.TxtSatis.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSatis.Properties.Appearance.Options.UseFont = true;
            this.TxtSatis.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtSatis.Size = new System.Drawing.Size(195, 26);
            this.TxtSatis.TabIndex = 16;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(19, 255);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 20);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Satış Fiyat:";
            // 
            // TxtMaliyet
            // 
            this.TxtMaliyet.Location = new System.Drawing.Point(107, 215);
            this.TxtMaliyet.Name = "TxtMaliyet";
            this.TxtMaliyet.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMaliyet.Properties.Appearance.Options.UseFont = true;
            this.TxtMaliyet.Properties.Mask.EditMask = "n";
            this.TxtMaliyet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtMaliyet.Size = new System.Drawing.Size(194, 26);
            this.TxtMaliyet.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(41, 218);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 20);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Maliyet:";
            // 
            // MskYil
            // 
            this.MskYil.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskYil.Location = new System.Drawing.Point(107, 143);
            this.MskYil.Mask = "0000";
            this.MskYil.Name = "MskYil";
            this.MskYil.Size = new System.Drawing.Size(194, 25);
            this.MskYil.TabIndex = 12;
            this.MskYil.ValidatingType = typeof(int);
            // 
            // NudAdet
            // 
            this.NudAdet.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NudAdet.Location = new System.Drawing.Point(107, 179);
            this.NudAdet.Name = "NudAdet";
            this.NudAdet.Size = new System.Drawing.Size(194, 25);
            this.NudAdet.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(72, 146);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(22, 20);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Yıl:";
            // 
            // TxtModel
            // 
            this.TxtModel.Location = new System.Drawing.Point(107, 106);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtModel.Properties.Appearance.Options.UseFont = true;
            this.TxtModel.Size = new System.Drawing.Size(194, 26);
            this.TxtModel.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(50, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 20);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Model:";
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(107, 69);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMarka.Properties.Appearance.Options.UseFont = true;
            this.TxtMarka.Size = new System.Drawing.Size(194, 26);
            this.TxtMarka.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(47, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 20);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Marka:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(107, 32);
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
            this.labelControl1.Location = new System.Drawing.Point(71, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ad:";
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 1048);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.myGridControl1);
            this.Name = "FrmUrunler";
            this.Text = "Ürünler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaliyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.MyGridControl.MyGridControl myGridControl1;
        private UserControl.MyGridControl.MyGridView myGridView1;
        private UserControl.MyGridControl.MyGridColumn colID;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RichDetay;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit TxtSatis;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtMaliyet;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.MaskedTextBox MskYil;
        private System.Windows.Forms.NumericUpDown NudAdet;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtModel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtMarka;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
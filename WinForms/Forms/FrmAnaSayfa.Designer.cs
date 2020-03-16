namespace WinForms.Forms
{
    partial class FrmAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.GridControlStoklar = new WinForms.UserControl.MyGridControl.MyGridControl();
            this.myGridView1 = new WinForms.UserControl.MyGridControl.MyGridView();
            this.colID = new WinForms.UserControl.MyGridControl.MyGridColumn();
            this.gridURUNAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridADET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.GridControlSonOn = new WinForms.UserControl.MyGridControl.MyGridControl();
            this.myGridView3 = new WinForms.UserControl.MyGridControl.MyGridView();
            this.myGridColumn2 = new WinForms.UserControl.MyGridControl.MyGridColumn();
            this.ColumnURUNAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnADET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnTOPLAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.GridControlAjanda = new WinForms.UserControl.MyGridControl.MyGridControl();
            this.myGridView2 = new WinForms.UserControl.MyGridControl.MyGridView();
            this.myGridColumn1 = new WinForms.UserControl.MyGridControl.MyGridColumn();
            this.gridTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSAAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBASLIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.GridControlFihrist = new WinForms.UserControl.MyGridControl.MyGridControl();
            this.myGridView4 = new WinForms.UserControl.MyGridControl.MyGridView();
            this.myGridColumn3 = new WinForms.UserControl.MyGridControl.MyGridColumn();
            this.gridAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTELEFON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlSonOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlAjanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlFihrist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.GridControlStoklar);
            this.groupControl1.Location = new System.Drawing.Point(5, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(596, 363);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Azalan Stoklar";
            // 
            // GridControlStoklar
            // 
            this.GridControlStoklar.Location = new System.Drawing.Point(2, 19);
            this.GridControlStoklar.MainView = this.myGridView1;
            this.GridControlStoklar.Name = "GridControlStoklar";
            this.GridControlStoklar.Size = new System.Drawing.Size(590, 339);
            this.GridControlStoklar.TabIndex = 0;
            this.GridControlStoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridURUNAD,
            this.gridADET});
            this.myGridView1.GridControl = this.GridControlStoklar;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsMenu.EnableColumnMenu = false;
            this.myGridView1.OptionsMenu.EnableFooterMenu = false;
            this.myGridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView1.OptionsView.ColumnAutoWidth = false;
            this.myGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // gridURUNAD
            // 
            this.gridURUNAD.Caption = "ÜRÜN AD";
            this.gridURUNAD.FieldName = "URUNAD";
            this.gridURUNAD.Name = "gridURUNAD";
            this.gridURUNAD.Visible = true;
            this.gridURUNAD.VisibleIndex = 0;
            this.gridURUNAD.Width = 285;
            // 
            // gridADET
            // 
            this.gridADET.Caption = "ADET";
            this.gridADET.FieldName = "ADET";
            this.gridADET.Name = "gridADET";
            this.gridADET.Visible = true;
            this.gridADET.VisibleIndex = 1;
            this.gridADET.Width = 286;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.GridControlSonOn);
            this.groupControl2.Location = new System.Drawing.Point(5, 470);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(596, 363);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Son 10 Hareket";
            // 
            // GridControlSonOn
            // 
            this.GridControlSonOn.Location = new System.Drawing.Point(2, 19);
            this.GridControlSonOn.MainView = this.myGridView3;
            this.GridControlSonOn.Name = "GridControlSonOn";
            this.GridControlSonOn.Size = new System.Drawing.Size(590, 339);
            this.GridControlSonOn.TabIndex = 1;
            this.GridControlSonOn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView3});
            // 
            // myGridView3
            // 
            this.myGridView3.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.myGridView3.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.myGridView3.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.myGridView3.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myGridView3.Appearance.Row.BackColor = System.Drawing.Color.Aquamarine;
            this.myGridView3.Appearance.Row.BackColor2 = System.Drawing.Color.LightGreen;
            this.myGridView3.Appearance.Row.Options.UseBackColor = true;
            this.myGridView3.Appearance.ViewCaption.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.myGridView3.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Black;
            this.myGridView3.Appearance.ViewCaption.Options.UseFont = true;
            this.myGridView3.Appearance.ViewCaption.Options.UseForeColor = true;
            this.myGridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.myGridColumn2,
            this.ColumnURUNAD,
            this.ColumnADET,
            this.ColumnAD,
            this.ColumnFIYAT,
            this.ColumnTOPLAM});
            this.myGridView3.GridControl = this.GridControlSonOn;
            this.myGridView3.Name = "myGridView3";
            this.myGridView3.OptionsMenu.EnableColumnMenu = false;
            this.myGridView3.OptionsMenu.EnableFooterMenu = false;
            this.myGridView3.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView3.OptionsView.ColumnAutoWidth = false;
            this.myGridView3.OptionsView.ShowGroupPanel = false;
            // 
            // myGridColumn2
            // 
            this.myGridColumn2.Caption = "ID";
            this.myGridColumn2.FieldName = "ID";
            this.myGridColumn2.Name = "myGridColumn2";
            this.myGridColumn2.OptionsColumn.AllowEdit = false;
            this.myGridColumn2.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // ColumnURUNAD
            // 
            this.ColumnURUNAD.Caption = "ÜRÜN AD";
            this.ColumnURUNAD.FieldName = "URUNAD";
            this.ColumnURUNAD.Name = "ColumnURUNAD";
            this.ColumnURUNAD.Visible = true;
            this.ColumnURUNAD.VisibleIndex = 0;
            this.ColumnURUNAD.Width = 131;
            // 
            // ColumnADET
            // 
            this.ColumnADET.Caption = "ADET";
            this.ColumnADET.FieldName = "ADET";
            this.ColumnADET.Name = "ColumnADET";
            this.ColumnADET.Visible = true;
            this.ColumnADET.VisibleIndex = 1;
            this.ColumnADET.Width = 103;
            // 
            // ColumnAD
            // 
            this.ColumnAD.Caption = "AD";
            this.ColumnAD.FieldName = "AD";
            this.ColumnAD.Name = "ColumnAD";
            this.ColumnAD.Visible = true;
            this.ColumnAD.VisibleIndex = 2;
            this.ColumnAD.Width = 131;
            // 
            // ColumnFIYAT
            // 
            this.ColumnFIYAT.Caption = "FİYAT";
            this.ColumnFIYAT.FieldName = "FIYAT";
            this.ColumnFIYAT.Name = "ColumnFIYAT";
            this.ColumnFIYAT.Visible = true;
            this.ColumnFIYAT.VisibleIndex = 3;
            this.ColumnFIYAT.Width = 103;
            // 
            // ColumnTOPLAM
            // 
            this.ColumnTOPLAM.Caption = "TOPLAM";
            this.ColumnTOPLAM.FieldName = "TOPLAM";
            this.ColumnTOPLAM.Name = "ColumnTOPLAM";
            this.ColumnTOPLAM.Visible = true;
            this.ColumnTOPLAM.VisibleIndex = 4;
            this.ColumnTOPLAM.Width = 103;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.GridControlAjanda);
            this.groupControl3.Location = new System.Drawing.Point(676, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(596, 363);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Ajanda";
            // 
            // GridControlAjanda
            // 
            this.GridControlAjanda.Location = new System.Drawing.Point(2, 19);
            this.GridControlAjanda.MainView = this.myGridView2;
            this.GridControlAjanda.Name = "GridControlAjanda";
            this.GridControlAjanda.Size = new System.Drawing.Size(590, 339);
            this.GridControlAjanda.TabIndex = 1;
            this.GridControlAjanda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.myGridColumn1,
            this.gridTARIH,
            this.gridSAAT,
            this.gridBASLIK});
            this.myGridView2.GridControl = this.GridControlAjanda;
            this.myGridView2.Name = "myGridView2";
            this.myGridView2.OptionsMenu.EnableColumnMenu = false;
            this.myGridView2.OptionsMenu.EnableFooterMenu = false;
            this.myGridView2.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView2.OptionsView.ColumnAutoWidth = false;
            this.myGridView2.OptionsView.ShowGroupPanel = false;
            // 
            // myGridColumn1
            // 
            this.myGridColumn1.Caption = "ID";
            this.myGridColumn1.FieldName = "ID";
            this.myGridColumn1.Name = "myGridColumn1";
            this.myGridColumn1.OptionsColumn.AllowEdit = false;
            this.myGridColumn1.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // gridTARIH
            // 
            this.gridTARIH.Caption = "TARİH";
            this.gridTARIH.FieldName = "TARIH";
            this.gridTARIH.Name = "gridTARIH";
            this.gridTARIH.Visible = true;
            this.gridTARIH.VisibleIndex = 0;
            this.gridTARIH.Width = 190;
            // 
            // gridSAAT
            // 
            this.gridSAAT.Caption = "SAAT";
            this.gridSAAT.FieldName = "SAAT";
            this.gridSAAT.Name = "gridSAAT";
            this.gridSAAT.Visible = true;
            this.gridSAAT.VisibleIndex = 1;
            this.gridSAAT.Width = 190;
            // 
            // gridBASLIK
            // 
            this.gridBASLIK.Caption = "BAŞLIK";
            this.gridBASLIK.FieldName = "BASLIK";
            this.gridBASLIK.Name = "gridBASLIK";
            this.gridBASLIK.Visible = true;
            this.gridBASLIK.VisibleIndex = 2;
            this.gridBASLIK.Width = 191;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.GridControlFihrist);
            this.groupControl4.Location = new System.Drawing.Point(676, 470);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(596, 363);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "FİHRİST";
            // 
            // GridControlFihrist
            // 
            this.GridControlFihrist.Location = new System.Drawing.Point(2, 19);
            this.GridControlFihrist.MainView = this.myGridView4;
            this.GridControlFihrist.Name = "GridControlFihrist";
            this.GridControlFihrist.Size = new System.Drawing.Size(590, 339);
            this.GridControlFihrist.TabIndex = 1;
            this.GridControlFihrist.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView4});
            // 
            // myGridView4
            // 
            this.myGridView4.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.myGridView4.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.myGridView4.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.myGridView4.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myGridView4.Appearance.Row.BackColor = System.Drawing.Color.Aquamarine;
            this.myGridView4.Appearance.Row.BackColor2 = System.Drawing.Color.LightGreen;
            this.myGridView4.Appearance.Row.Options.UseBackColor = true;
            this.myGridView4.Appearance.ViewCaption.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.myGridView4.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Black;
            this.myGridView4.Appearance.ViewCaption.Options.UseFont = true;
            this.myGridView4.Appearance.ViewCaption.Options.UseForeColor = true;
            this.myGridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.myGridColumn3,
            this.gridAD,
            this.gridTELEFON});
            this.myGridView4.GridControl = this.GridControlFihrist;
            this.myGridView4.Name = "myGridView4";
            this.myGridView4.OptionsMenu.EnableColumnMenu = false;
            this.myGridView4.OptionsMenu.EnableFooterMenu = false;
            this.myGridView4.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView4.OptionsView.ColumnAutoWidth = false;
            this.myGridView4.OptionsView.ShowGroupPanel = false;
            // 
            // myGridColumn3
            // 
            this.myGridColumn3.Caption = "ID";
            this.myGridColumn3.FieldName = "ID";
            this.myGridColumn3.Name = "myGridColumn3";
            this.myGridColumn3.OptionsColumn.AllowEdit = false;
            this.myGridColumn3.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // gridAD
            // 
            this.gridAD.Caption = "AD";
            this.gridAD.FieldName = "AD";
            this.gridAD.Name = "gridAD";
            this.gridAD.Visible = true;
            this.gridAD.VisibleIndex = 0;
            this.gridAD.Width = 285;
            // 
            // gridTELEFON
            // 
            this.gridTELEFON.Caption = "TELEFON";
            this.gridTELEFON.FieldName = "TELEFON1";
            this.gridTELEFON.Name = "gridTELEFON";
            this.gridTELEFON.Visible = true;
            this.gridTELEFON.VisibleIndex = 1;
            this.gridTELEFON.Width = 286;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1338, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(570, 833);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.webBrowser1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(564, 805);
            this.xtraTabPage1.Text = "Döviz Kurları";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(564, 805);
            this.webBrowser1.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.pictureBox1);
            this.xtraTabPage2.Controls.Add(this.listBox1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(564, 805);
            this.xtraTabPage2.Text = "Haberler";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinForms.Properties.Resources._646c5778cb2613cb7afc9984e852efea;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(556, 692);
            this.listBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 1048);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmAnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlSonOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlAjanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlFihrist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControl.MyGridControl.MyGridControl GridControlStoklar;
        private UserControl.MyGridControl.MyGridView myGridView1;
        private UserControl.MyGridControl.MyGridColumn colID;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private UserControl.MyGridControl.MyGridControl GridControlSonOn;
        private UserControl.MyGridControl.MyGridView myGridView3;
        private UserControl.MyGridControl.MyGridColumn myGridColumn2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private UserControl.MyGridControl.MyGridControl GridControlAjanda;
        private UserControl.MyGridControl.MyGridView myGridView2;
        private UserControl.MyGridControl.MyGridColumn myGridColumn1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private UserControl.MyGridControl.MyGridControl GridControlFihrist;
        private UserControl.MyGridControl.MyGridView myGridView4;
        private UserControl.MyGridControl.MyGridColumn myGridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridURUNAD;
        private DevExpress.XtraGrid.Columns.GridColumn gridADET;
        private DevExpress.XtraGrid.Columns.GridColumn gridTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn gridSAAT;
        private DevExpress.XtraGrid.Columns.GridColumn gridBASLIK;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnURUNAD;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnADET;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnAD;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnTOPLAM;
        private DevExpress.XtraGrid.Columns.GridColumn gridAD;
        private DevExpress.XtraGrid.Columns.GridColumn gridTELEFON;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
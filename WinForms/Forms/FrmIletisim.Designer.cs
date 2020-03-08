namespace WinForms.Forms
{
    partial class FrmIletisim
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
            this.ColAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSOYAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTELEFON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTELEFON2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.myGridControl2 = new WinForms.UserControl.MyGridControl.MyGridControl();
            this.myGridView2 = new WinForms.UserControl.MyGridControl.MyGridView();
            this.ColFAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTELEFON3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TELEFON2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTELEFON1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColYETKILIADSOYAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID1 = new WinForms.UserControl.MyGridControl.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1904, 1041);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.myGridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1898, 1013);
            this.xtraTabPage1.Text = "Müşteriler";
            // 
            // myGridControl1
            // 
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(1898, 1013);
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
            this.ColAD,
            this.ColSOYAD,
            this.ColTELEFON,
            this.ColTELEFON2,
            this.ColMAIL});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsMenu.EnableColumnMenu = false;
            this.myGridView1.OptionsMenu.EnableFooterMenu = false;
            this.myGridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView1.OptionsView.ColumnAutoWidth = false;
            this.myGridView1.OptionsView.ShowGroupPanel = false;
            this.myGridView1.OptionsView.ShowViewCaption = true;
            this.myGridView1.ViewCaption = "Müşteri İletişim Listesi";
            this.myGridView1.DoubleClick += new System.EventHandler(this.myGridView1_DoubleClick);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // ColAD
            // 
            this.ColAD.Caption = "AD";
            this.ColAD.FieldName = "AD";
            this.ColAD.Name = "ColAD";
            this.ColAD.Visible = true;
            this.ColAD.VisibleIndex = 0;
            this.ColAD.Width = 370;
            // 
            // ColSOYAD
            // 
            this.ColSOYAD.Caption = "SOYAD";
            this.ColSOYAD.FieldName = "SOYAD";
            this.ColSOYAD.Name = "ColSOYAD";
            this.ColSOYAD.Visible = true;
            this.ColSOYAD.VisibleIndex = 1;
            this.ColSOYAD.Width = 370;
            // 
            // ColTELEFON
            // 
            this.ColTELEFON.Caption = "TELEFON";
            this.ColTELEFON.FieldName = "TELEFON";
            this.ColTELEFON.Name = "ColTELEFON";
            this.ColTELEFON.Visible = true;
            this.ColTELEFON.VisibleIndex = 2;
            this.ColTELEFON.Width = 370;
            // 
            // ColTELEFON2
            // 
            this.ColTELEFON2.Caption = "TELEFON2";
            this.ColTELEFON2.FieldName = "TELEFON2";
            this.ColTELEFON2.Name = "ColTELEFON2";
            this.ColTELEFON2.Visible = true;
            this.ColTELEFON2.VisibleIndex = 3;
            this.ColTELEFON2.Width = 370;
            // 
            // ColMAIL
            // 
            this.ColMAIL.Caption = "MAIL";
            this.ColMAIL.FieldName = "MAIL";
            this.ColMAIL.Name = "ColMAIL";
            this.ColMAIL.Visible = true;
            this.ColMAIL.VisibleIndex = 4;
            this.ColMAIL.Width = 398;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.myGridControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1898, 1013);
            this.xtraTabPage2.Text = "Firmalar";
            // 
            // myGridControl2
            // 
            this.myGridControl2.Location = new System.Drawing.Point(0, 0);
            this.myGridControl2.MainView = this.myGridView2;
            this.myGridControl2.Name = "myGridControl2";
            this.myGridControl2.Size = new System.Drawing.Size(1898, 1018);
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
            this.ColFAX,
            this.MAIL,
            this.ColTELEFON3,
            this.TELEFON2,
            this.ColTELEFON1,
            this.ColYETKILIADSOYAD,
            this.AD,
            this.colID1});
            this.myGridView2.GridControl = this.myGridControl2;
            this.myGridView2.Name = "myGridView2";
            this.myGridView2.OptionsMenu.EnableColumnMenu = false;
            this.myGridView2.OptionsMenu.EnableFooterMenu = false;
            this.myGridView2.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView2.OptionsView.ColumnAutoWidth = false;
            this.myGridView2.OptionsView.ShowGroupPanel = false;
            this.myGridView2.OptionsView.ShowViewCaption = true;
            this.myGridView2.ViewCaption = "Firma İletişim Listesi";
            this.myGridView2.DoubleClick += new System.EventHandler(this.myGridView2_DoubleClick);
            // 
            // ColFAX
            // 
            this.ColFAX.Caption = "FAX";
            this.ColFAX.FieldName = "FAX";
            this.ColFAX.Name = "ColFAX";
            this.ColFAX.Visible = true;
            this.ColFAX.VisibleIndex = 6;
            this.ColFAX.Width = 264;
            // 
            // MAIL
            // 
            this.MAIL.Caption = "MAIL";
            this.MAIL.FieldName = "MAIL";
            this.MAIL.Name = "MAIL";
            this.MAIL.Visible = true;
            this.MAIL.VisibleIndex = 5;
            this.MAIL.Width = 265;
            // 
            // ColTELEFON3
            // 
            this.ColTELEFON3.Caption = "TELEFON 3";
            this.ColTELEFON3.FieldName = "TELEFON3";
            this.ColTELEFON3.Name = "ColTELEFON3";
            this.ColTELEFON3.Visible = true;
            this.ColTELEFON3.VisibleIndex = 4;
            this.ColTELEFON3.Width = 270;
            // 
            // TELEFON2
            // 
            this.TELEFON2.Caption = "TELEFON 2";
            this.TELEFON2.FieldName = "TELEFON2";
            this.TELEFON2.Name = "TELEFON2";
            this.TELEFON2.Visible = true;
            this.TELEFON2.VisibleIndex = 3;
            this.TELEFON2.Width = 270;
            // 
            // ColTELEFON1
            // 
            this.ColTELEFON1.Caption = "TELEFON 1";
            this.ColTELEFON1.FieldName = "TELEFON1";
            this.ColTELEFON1.Name = "ColTELEFON1";
            this.ColTELEFON1.Visible = true;
            this.ColTELEFON1.VisibleIndex = 2;
            this.ColTELEFON1.Width = 270;
            // 
            // ColYETKILIADSOYAD
            // 
            this.ColYETKILIADSOYAD.Caption = "YETKİLİ AD SOYAD";
            this.ColYETKILIADSOYAD.FieldName = "YETKILIADSOYAD";
            this.ColYETKILIADSOYAD.Name = "ColYETKILIADSOYAD";
            this.ColYETKILIADSOYAD.Visible = true;
            this.ColYETKILIADSOYAD.VisibleIndex = 1;
            this.ColYETKILIADSOYAD.Width = 270;
            // 
            // AD
            // 
            this.AD.Caption = "AD";
            this.AD.FieldName = "AD";
            this.AD.Name = "AD";
            this.AD.Visible = true;
            this.AD.VisibleIndex = 0;
            this.AD.Width = 270;
            // 
            // colID1
            // 
            this.colID1.Caption = "ID";
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.AllowEdit = false;
            this.colID1.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // FrmIletisim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 1048);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FrmIletisim";
            this.Text = "FrmIletisim";
            this.Load += new System.EventHandler(this.FrmIletisim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private UserControl.MyGridControl.MyGridControl myGridControl1;
        private UserControl.MyGridControl.MyGridView myGridView1;
        private UserControl.MyGridControl.MyGridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn ColAD;
        private DevExpress.XtraGrid.Columns.GridColumn ColSOYAD;
        private DevExpress.XtraGrid.Columns.GridColumn ColTELEFON;
        private DevExpress.XtraGrid.Columns.GridColumn ColTELEFON2;
        private DevExpress.XtraGrid.Columns.GridColumn ColMAIL;
        private UserControl.MyGridControl.MyGridControl myGridControl2;
        private UserControl.MyGridControl.MyGridView myGridView2;
        private UserControl.MyGridControl.MyGridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn ColFAX;
        private DevExpress.XtraGrid.Columns.GridColumn MAIL;
        private DevExpress.XtraGrid.Columns.GridColumn ColTELEFON3;
        private DevExpress.XtraGrid.Columns.GridColumn TELEFON2;
        private DevExpress.XtraGrid.Columns.GridColumn ColTELEFON1;
        private DevExpress.XtraGrid.Columns.GridColumn ColYETKILIADSOYAD;
        private DevExpress.XtraGrid.Columns.GridColumn AD;
    }
}
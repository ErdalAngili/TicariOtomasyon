namespace WinForms.Forms
{
    partial class FrmAyarlar
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
            this.gridKULLANICIAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSifre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Txtkuladi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtkuladi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // myGridControl1
            // 
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(499, 194);
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
            this.gridKULLANICIAD,
            this.gridSifre});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsMenu.EnableColumnMenu = false;
            this.myGridView1.OptionsMenu.EnableFooterMenu = false;
            this.myGridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView1.OptionsView.ColumnAutoWidth = false;
            this.myGridView1.OptionsView.ShowGroupPanel = false;
            this.myGridView1.OptionsView.ShowViewCaption = true;
            this.myGridView1.ViewCaption = "Kullancı Listesi";
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
            // gridKULLANICIAD
            // 
            this.gridKULLANICIAD.Caption = "KULLANICI ADI";
            this.gridKULLANICIAD.FieldName = "KULLANICIAD";
            this.gridKULLANICIAD.Name = "gridKULLANICIAD";
            this.gridKULLANICIAD.Visible = true;
            this.gridKULLANICIAD.VisibleIndex = 0;
            this.gridKULLANICIAD.Width = 240;
            // 
            // gridSifre
            // 
            this.gridSifre.Caption = "ŞİFRE";
            this.gridSifre.FieldName = "SIFRE";
            this.gridSifre.Name = "gridSifre";
            this.gridSifre.Visible = true;
            this.gridSifre.VisibleIndex = 1;
            this.gridSifre.Width = 240;
            // 
            // Txtkuladi
            // 
            this.Txtkuladi.Location = new System.Drawing.Point(139, 217);
            this.Txtkuladi.Name = "Txtkuladi";
            this.Txtkuladi.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtkuladi.Properties.Appearance.Options.UseFont = true;
            this.Txtkuladi.Size = new System.Drawing.Size(194, 26);
            this.Txtkuladi.TabIndex = 3;
            this.Txtkuladi.EditValueChanged += new System.EventHandler(this.Txtkuladi_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 217);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 20);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "KULLANICI AD:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(139, 265);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Properties.Appearance.Options.UseFont = true;
            this.TxtSifre.Size = new System.Drawing.Size(194, 26);
            this.TxtSifre.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(87, 265);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 20);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "ŞİFRE:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = global::WinForms.Properties.Resources.save_32x32;
            this.BtnKaydet.Location = new System.Drawing.Point(139, 325);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(194, 36);
            this.BtnKaydet.TabIndex = 13;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // FrmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 394);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Txtkuladi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.myGridControl1);
            this.Name = "FrmAyarlar";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.FrmAyarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtkuladi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl.MyGridControl.MyGridControl myGridControl1;
        private UserControl.MyGridControl.MyGridView myGridView1;
        private UserControl.MyGridControl.MyGridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn gridKULLANICIAD;
        private DevExpress.XtraGrid.Columns.GridColumn gridSifre;
        private DevExpress.XtraEditors.TextEdit Txtkuladi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
    }
}
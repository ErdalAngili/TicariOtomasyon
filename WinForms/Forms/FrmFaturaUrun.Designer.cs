namespace WinForms.Forms
{
    partial class FrmFaturaUrun
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
            this.gridURUNAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMIKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFATURAID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // myGridControl1
            // 
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(1018, 335);
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
            this.gridURUNAD,
            this.gridMIKTAR,
            this.gridFIYAT,
            this.gridTUTAR,
            this.gridFATURAID});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsMenu.EnableColumnMenu = false;
            this.myGridView1.OptionsMenu.EnableFooterMenu = false;
            this.myGridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView1.OptionsView.ColumnAutoWidth = false;
            this.myGridView1.OptionsView.ShowGroupPanel = false;
            this.myGridView1.OptionsView.ShowViewCaption = true;
            this.myGridView1.ViewCaption = "Ürün Listesi";
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
            // gridURUNAD
            // 
            this.gridURUNAD.Caption = "ÜRÜN AD";
            this.gridURUNAD.FieldName = "URUNAD";
            this.gridURUNAD.Name = "gridURUNAD";
            this.gridURUNAD.Visible = true;
            this.gridURUNAD.VisibleIndex = 0;
            this.gridURUNAD.Width = 200;
            // 
            // gridMIKTAR
            // 
            this.gridMIKTAR.Caption = "MİKTAR";
            this.gridMIKTAR.FieldName = "MIKTAR";
            this.gridMIKTAR.Name = "gridMIKTAR";
            this.gridMIKTAR.Visible = true;
            this.gridMIKTAR.VisibleIndex = 1;
            this.gridMIKTAR.Width = 200;
            // 
            // gridFIYAT
            // 
            this.gridFIYAT.Caption = "FİYAT";
            this.gridFIYAT.FieldName = "FIYAT";
            this.gridFIYAT.Name = "gridFIYAT";
            this.gridFIYAT.Visible = true;
            this.gridFIYAT.VisibleIndex = 2;
            this.gridFIYAT.Width = 200;
            // 
            // gridTUTAR
            // 
            this.gridTUTAR.Caption = "TUTAR";
            this.gridTUTAR.FieldName = "TUTAR";
            this.gridTUTAR.Name = "gridTUTAR";
            this.gridTUTAR.Visible = true;
            this.gridTUTAR.VisibleIndex = 3;
            this.gridTUTAR.Width = 200;
            // 
            // gridFATURAID
            // 
            this.gridFATURAID.Caption = "FATURA ID";
            this.gridFATURAID.FieldName = "FATURAID";
            this.gridFATURAID.Name = "gridFATURAID";
            this.gridFATURAID.Visible = true;
            this.gridFATURAID.VisibleIndex = 4;
            this.gridFATURAID.Width = 200;
            // 
            // FrmFaturaUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1018, 335);
            this.Controls.Add(this.myGridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFaturaUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Ürün";
            this.Load += new System.EventHandler(this.FrmFaturaUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UserControl.MyGridControl.MyGridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn gridURUNAD;
        private DevExpress.XtraGrid.Columns.GridColumn gridMIKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn gridFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn gridTUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn gridFATURAID;
        public UserControl.MyGridControl.MyGridControl myGridControl1;
        public UserControl.MyGridControl.MyGridView myGridView1;
    }
}
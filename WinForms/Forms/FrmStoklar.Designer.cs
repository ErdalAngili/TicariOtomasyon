namespace WinForms.Forms
{
    partial class FrmStoklar
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.myGridControl1 = new WinForms.UserControl.MyGridControl.MyGridControl();
            this.myGridView1 = new WinForms.UserControl.MyGridControl.MyGridView();
            this.colID = new WinForms.UserControl.MyGridControl.MyGridColumn();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.gridURUNAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // myGridControl1
            // 
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(868, 1050);
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
            this.gridMiktar});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsMenu.EnableColumnMenu = false;
            this.myGridView1.OptionsMenu.EnableFooterMenu = false;
            this.myGridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView1.OptionsView.ColumnAutoWidth = false;
            this.myGridView1.OptionsView.ShowGroupPanel = false;
            this.myGridView1.OptionsView.ShowViewCaption = true;
            this.myGridView1.ViewCaption = "Stok Listesi";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // chartControl1
            // 
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(867, 0);
            this.chartControl1.Name = "chartControl1";
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            pieSeriesView1.HeightToWidthRatio = 0.7D;
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(1045, 1050);
            this.chartControl1.TabIndex = 1;
            // 
            // gridURUNAD
            // 
            this.gridURUNAD.Caption = "ÜRÜN AD";
            this.gridURUNAD.FieldName = "URUNAD";
            this.gridURUNAD.Name = "gridURUNAD";
            this.gridURUNAD.Visible = true;
            this.gridURUNAD.VisibleIndex = 0;
            this.gridURUNAD.Width = 450;
            // 
            // gridMiktar
            // 
            this.gridMiktar.Caption = "Miktar";
            this.gridMiktar.FieldName = "Miktar";
            this.gridMiktar.Name = "gridMiktar";
            this.gridMiktar.Visible = true;
            this.gridMiktar.VisibleIndex = 1;
            this.gridMiktar.Width = 400;
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 1048);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.myGridControl1);
            this.Name = "FrmStoklar";
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.MyGridControl.MyGridControl myGridControl1;
        private UserControl.MyGridControl.MyGridView myGridView1;
        private UserControl.MyGridControl.MyGridColumn colID;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridURUNAD;
        private DevExpress.XtraGrid.Columns.GridColumn gridMiktar;
    }
}
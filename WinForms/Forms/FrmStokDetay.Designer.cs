namespace WinForms.Forms
{
    partial class FrmStokDetay
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
            this.gridMARKA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMODEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridYIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridADET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMALIYET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSATISFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDETAY = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.myGridControl1.Size = new System.Drawing.Size(946, 324);
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
            this.gridMARKA,
            this.gridMODEL,
            this.gridYIL,
            this.gridADET,
            this.gridMALIYET,
            this.gridSATISFIYAT,
            this.gridDETAY});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsMenu.EnableColumnMenu = false;
            this.myGridView1.OptionsMenu.EnableFooterMenu = false;
            this.myGridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridView1.OptionsView.ColumnAutoWidth = false;
            this.myGridView1.OptionsView.ShowGroupPanel = false;
            this.myGridView1.ViewCaption = "Detay Listesi";
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
            this.gridURUNAD.Width = 132;
            // 
            // gridMARKA
            // 
            this.gridMARKA.Caption = "MARKA";
            this.gridMARKA.FieldName = "MARKA";
            this.gridMARKA.Name = "gridMARKA";
            this.gridMARKA.Visible = true;
            this.gridMARKA.VisibleIndex = 1;
            this.gridMARKA.Width = 100;
            // 
            // gridMODEL
            // 
            this.gridMODEL.Caption = "MODEL";
            this.gridMODEL.FieldName = "MODEL";
            this.gridMODEL.Name = "gridMODEL";
            this.gridMODEL.Visible = true;
            this.gridMODEL.VisibleIndex = 2;
            this.gridMODEL.Width = 100;
            // 
            // gridYIL
            // 
            this.gridYIL.Caption = "YIL";
            this.gridYIL.FieldName = "YIL";
            this.gridYIL.Name = "gridYIL";
            this.gridYIL.Visible = true;
            this.gridYIL.VisibleIndex = 3;
            this.gridYIL.Width = 110;
            // 
            // gridADET
            // 
            this.gridADET.Caption = "ADET";
            this.gridADET.FieldName = "ADET";
            this.gridADET.Name = "gridADET";
            this.gridADET.Visible = true;
            this.gridADET.VisibleIndex = 4;
            this.gridADET.Width = 100;
            // 
            // gridMALIYET
            // 
            this.gridMALIYET.Caption = "MALİYET";
            this.gridMALIYET.FieldName = "MALIYET";
            this.gridMALIYET.Name = "gridMALIYET";
            this.gridMALIYET.Visible = true;
            this.gridMALIYET.VisibleIndex = 5;
            this.gridMALIYET.Width = 100;
            // 
            // gridSATISFIYAT
            // 
            this.gridSATISFIYAT.Caption = "SATIŞ FİYAT";
            this.gridSATISFIYAT.FieldName = "SATISFIYAT";
            this.gridSATISFIYAT.Name = "gridSATISFIYAT";
            this.gridSATISFIYAT.Visible = true;
            this.gridSATISFIYAT.VisibleIndex = 6;
            this.gridSATISFIYAT.Width = 100;
            // 
            // gridDETAY
            // 
            this.gridDETAY.Caption = "DETAY";
            this.gridDETAY.FieldName = "DETAY";
            this.gridDETAY.Name = "gridDETAY";
            this.gridDETAY.Visible = true;
            this.gridDETAY.VisibleIndex = 7;
            this.gridDETAY.Width = 185;
            // 
            // FrmStokDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(946, 324);
            this.Controls.Add(this.myGridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStokDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Detay";
            this.Load += new System.EventHandler(this.FrmStokDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.MyGridControl.MyGridControl myGridControl1;
        private UserControl.MyGridControl.MyGridView myGridView1;
        private UserControl.MyGridControl.MyGridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn gridURUNAD;
        private DevExpress.XtraGrid.Columns.GridColumn gridMARKA;
        private DevExpress.XtraGrid.Columns.GridColumn gridMODEL;
        private DevExpress.XtraGrid.Columns.GridColumn gridYIL;
        private DevExpress.XtraGrid.Columns.GridColumn gridADET;
        private DevExpress.XtraGrid.Columns.GridColumn gridMALIYET;
        private DevExpress.XtraGrid.Columns.GridColumn gridSATISFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn gridDETAY;
    }
}
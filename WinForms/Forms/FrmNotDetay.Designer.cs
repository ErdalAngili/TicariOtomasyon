namespace WinForms.Forms
{
    partial class FrmNotDetay
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
            this.richNotDetay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richNotDetay
            // 
            this.richNotDetay.BackColor = System.Drawing.Color.LemonChiffon;
            this.richNotDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richNotDetay.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.richNotDetay.Location = new System.Drawing.Point(0, 0);
            this.richNotDetay.Name = "richNotDetay";
            this.richNotDetay.ReadOnly = true;
            this.richNotDetay.Size = new System.Drawing.Size(705, 310);
            this.richNotDetay.TabIndex = 0;
            this.richNotDetay.Text = "";
            // 
            // FrmNotDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(705, 310);
            this.Controls.Add(this.richNotDetay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNotDetay";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Detay";
            this.Load += new System.EventHandler(this.FrmNotDetay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richNotDetay;
    }
}
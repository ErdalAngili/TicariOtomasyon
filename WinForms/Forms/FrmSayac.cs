using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WinForms.Forms
{
    public partial class FrmSayac : DevExpress.XtraEditors.XtraForm
    {
        public FrmSayac()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value==100)
            {
                FrmAnaModul frmAnaModul = new FrmAnaModul();
                frmAnaModul.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
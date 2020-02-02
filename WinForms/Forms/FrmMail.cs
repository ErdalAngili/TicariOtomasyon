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
using System.Net;
using System.Net.Mail;

namespace WinForms.Forms
{
    public partial class FrmMail : DevExpress.XtraEditors.XtraForm
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        public string mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            TxtMailAdres.Text = mail;
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Mesajı Göndermek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MailMessage msj = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("Gönderen Mail", "Gönderen Mail Şifre");
                istemci.Port = 587;
                istemci.Host = "smtp.live.com";
                istemci.EnableSsl = true;
                msj.To.Add(TxtMailAdres.Text);
                msj.From = new MailAddress("Gönderen Mail");
                msj.Subject = TxtBaslik.Text;
                msj.Body = RichMesaj.Text;
                istemci.Send(msj);
                MessageBox.Show("Mesaj Gönderildi", "Uyarı", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Mesajı Gönderilemedi?", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
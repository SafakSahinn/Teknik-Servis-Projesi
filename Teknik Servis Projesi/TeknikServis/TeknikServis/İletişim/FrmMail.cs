using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TeknikServis.İletişim
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            string frommail = "gönderici";
            string sifre = "kendişifrem";
            string alici = TxtAliciMail.Text;
            string konu = TxtKonu.Text;
            string icerik = RchMesaj.Text;
            mail.From = new MailAddress(frommail);
            mail.To.Add(alici);
            mail.Subject = konu;
            mail.Body = icerik;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(frommail, sifre);
            smtp.EnableSsl = true;
            smtp.Send(mail);
            MessageBox.Show("Mail gönderildi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void PictureCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtAliciMail_Click(object sender, EventArgs e)
        {
            if (TxtAliciMail.Text == "Mail Adresi")
            {
                TxtAliciMail.Text = "";
            }
        }

        private void TxtKonu_Click(object sender, EventArgs e)
        {
            if (TxtKonu.Text == "Konu")
            {
                TxtKonu.Text = "";
            }
        }

        private void RchMesaj_Click(object sender, EventArgs e)
        {
            if (RchMesaj.Text == "İçerik")
            {
                RchMesaj.Text = "";
            }
        }
    }
}

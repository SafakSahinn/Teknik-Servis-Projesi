using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN
                        where x.KULLANICIAD == TxtKullaniciAd.Text && x.SIFRE == TxtSifre.Text
                        select x;
            if (sorgu.Any())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı giriş!", "Uyarı!");
            }
        }

        private void PictureCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtKuallaniciAd_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAd.Text == "Kullanıcı Adı")
            {
                TxtKullaniciAd.Text = "";
            }
        }

        private void TxtSifre_Click(object sender, EventArgs e)
        {
            if (TxtSifre.Text == "Şifre")
            {
                TxtSifre.Text = "";
            }
        }
    }
}

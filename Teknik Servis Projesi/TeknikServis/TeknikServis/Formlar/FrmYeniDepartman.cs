using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmYeniDepartman : Form
    {
        public FrmYeniDepartman()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtDepartmanAd.Text.Length <= 50 && TxtDepartmanAd.Text != "")
            {
                TBLDEPARTMAN t = new TBLDEPARTMAN();
                t.AD = TxtDepartmanAd.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman bilgileri kaydedildi!", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgileri kontrol ediniz! Kayıt yapılamadı", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PictureCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtDepartmanAd_Click(object sender, EventArgs e)
        {
            if (TxtDepartmanAd.Text == "Departman Adı")
            {
                TxtDepartmanAd.Text = "";
            }
        }
    }
}

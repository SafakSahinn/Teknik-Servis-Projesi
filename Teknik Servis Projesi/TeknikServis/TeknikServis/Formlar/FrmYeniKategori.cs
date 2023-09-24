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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtKategoriAd.Text != "" && TxtKategoriAd.Text.Length <= 30)
            {
                TBLKATEGORI t = new TBLKATEGORI();
                t.AD = TxtKategoriAd.Text;
                db.TBLKATEGORI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori sisteme kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori adı 30 karakterden daha uzun olmamalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtKategoriAd_Click(object sender, EventArgs e)
        {
            if (TxtKategoriAd.Text == "Kategori Adı")
            {
                TxtKategoriAd.Text = "";
            }
        }

        private void PictureCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

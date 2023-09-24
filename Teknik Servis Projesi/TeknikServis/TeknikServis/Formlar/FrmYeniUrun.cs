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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        void temizle()
        {
            TxtUrunAd.Text = "";
            TxtMarka.Text = "";
            TxtAlisFiyat.Text = "";
            TxtSatisFiyat.Text = "";
            TxtStok.Text = "";
            LueKategori.Text = "";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtUrunAd.Text != "" && TxtMarka.Text != "" && TxtAlisFiyat.Text != "" && TxtSatisFiyat.Text != "" && TxtStok.Text != "" && TxtMarka.Text != "" && LueKategori.Text != "")
            {
                if (TxtUrunAd.Text.Length <= 30 && TxtMarka.Text.Length <= 30)
                {
                    TBLURUN t = new TBLURUN();
                    t.AD = TxtUrunAd.Text;
                    t.MARKA = TxtMarka.Text;
                    t.KATEGORI = byte.Parse(LueKategori.EditValue.ToString());
                    t.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
                    t.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
                    t.STOK = short.Parse(TxtStok.Text);
                    db.TBLURUN.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Ürün bilgileri sisteme kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
                else
                {
                    MessageBox.Show("Ürün adı ve markası 30 karakterden daha uzun olamaz! Lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ürün bilgilerini eksik girdiniz! Lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtUrunAd_Click(object sender, EventArgs e)
        {
            if (TxtUrunAd.Text == "Ürün Adı")
            {
                TxtUrunAd.Text = "";
            }
        }

        private void TxtMarka_Click(object sender, EventArgs e)
        {
            if (TxtMarka.Text == "Marka")
            {
                TxtMarka.Text = "";
            }
        }

        private void TxtAlisFiyat_Click(object sender, EventArgs e)
        {
            if (TxtAlisFiyat.Text == "Alış Fiyatı")
            {
                TxtAlisFiyat.Text = "";
            }
        }

        private void TxtSatisFiyat_Click(object sender, EventArgs e)
        {
            if (TxtSatisFiyat.Text == "Satış Fiyatı")
            {
                TxtSatisFiyat.Text = "";
            }
        }

        private void TxtStok_Click(object sender, EventArgs e)
        {
            if (TxtStok.Text == "Stok")
            {
                TxtStok.Text = "";
            }
        }

        private void PictureCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            LueKategori.Properties.DataSource = (from x in db.TBLKATEGORI
                                                select new
                                                {
                                                    x.ID,
                                                    x.AD
                                                }).ToList();
        }
    }
}

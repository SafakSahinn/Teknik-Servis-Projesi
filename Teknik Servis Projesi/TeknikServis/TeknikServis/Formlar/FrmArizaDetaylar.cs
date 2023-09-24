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
    public partial class FrmArizaDetaylar : Form
    {
        public FrmArizaDetaylar()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtSeriNo.Text != "" && TxtTarih.Text != "" && CmbDurumBilgisi.Text != "" && RchAciklama.Text != "")
            {
                if (RchAciklama.Text.Length <= 250)
                {
                    TBLURUNTAKIP t = new TBLURUNTAKIP();
                    t.SERINO = TxtSeriNo.Text;
                    t.TARIH = DateTime.Parse(TxtTarih.Text);
                    t.ACIKLAMA = RchAciklama.Text;
                    db.TBLURUNTAKIP.Add(t);

                    TBLURUNKABUL tb = new TBLURUNKABUL();
                    int urunid = int.Parse(id.ToString());
                    var deger = db.TBLURUNKABUL.Find(urunid);
                    deger.DURUMDETAY = CmbDurumBilgisi.Text;
                    db.SaveChanges();

                    MessageBox.Show("Arıza detayları kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Arıza açıklaması 250 karakterden daha uzun olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Arıza bilgileri eksik girildi! Lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        public string id, serino, durumbilgisi;

        private void PictureCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmArizaDetaylar_Load(object sender, EventArgs e)
        {
            TxtSeriNo.Text = serino;
            CmbDurumBilgisi.Text = durumbilgisi;
        }
    }
}

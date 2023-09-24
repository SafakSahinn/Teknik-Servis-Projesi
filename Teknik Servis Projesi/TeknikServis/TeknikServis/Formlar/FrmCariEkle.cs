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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        int secilen;

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtCariAd.Text != "" && TxtCariSoyad.Text != "" && TxtCariTelefon.Text != "" && TxtCariMail.Text != "" && LueIl.Text != "" && LueIl.Text != "İl" && LueIlce.Text != "" && LueIlce.Text != "İlçe" && TxtCarıBanka.Text != "" && TxtCariVergiDairesi.Text != "" && TxtCariVergiNumarası.Text != "" && TxtCariStatu.Text != "" && RchCariAdres.Text != "")
            {
                if (TxtCariAd.Text.Length <= 30 && TxtCariSoyad.Text.Length <= 30 && TxtCariTelefon.Text.Length <= 20 && TxtCariMail.Text.Length <= 50 && TxtCarıBanka.Text.Length <= 50 && TxtCariVergiDairesi.Text.Length <= 50 && TxtCariVergiNumarası.Text.Length <= 50 && TxtCariStatu.Text.Length <= 50 && RchCariAdres.Text.Length <= 250)
                {
                    TBLCARI t = new TBLCARI();
                    t.AD = TxtCariAd.Text;
                    t.SOYAD = TxtCariSoyad.Text;
                    t.TELEFON = TxtCariTelefon.Text;
                    t.MAIL = TxtCariMail.Text;
                    t.IL = LueIl.Text;
                    t.ILCE = LueIlce.Text;
                    t.BANKA = TxtCarıBanka.Text;
                    t.VERGIDAIRESI = TxtCariVergiDairesi.Text;
                    t.VERGINO = TxtCariVergiNumarası.Text;
                    t.STATU = TxtCariStatu.Text;
                    t.ADRES = RchCariAdres.Text;
                    db.TBLCARI.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Yeni cari bilgileri sisteme eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cari bilgilerini hatalı girdiniz! Lütfen girdiğiniz karakter sayısını kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Cari bilgilerini eksik girdiniz! Lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtCariAd_Click(object sender, EventArgs e)
        {
            if (TxtCariAd.Text == "Ad")
            {
                TxtCariAd.Text = "";
            }
        }

        private void TxtCariSoyad_Click(object sender, EventArgs e)
        {
            if (TxtCariSoyad.Text == "Soyad")
            {
                TxtCariSoyad.Text = "";
            }
        }

        private void TxtCariTelefon_Click(object sender, EventArgs e)
        {
            if (TxtCariTelefon.Text == "Telefon")
            {
                TxtCariTelefon.Text = "";
            }
        }

        private void TxtCariMail_Click(object sender, EventArgs e)
        {
            if (TxtCariMail.Text == "Mail")
            {
                TxtCariMail.Text = "";
            }
        }

        private void TxtCarıBanka_Click(object sender, EventArgs e)
        {
            if (TxtCarıBanka.Text == "Banka")
            {
                TxtCarıBanka.Text = "";
            }
        }

        private void TxtCariVergiDairesi_Click(object sender, EventArgs e)
        {
            if (TxtCariVergiDairesi.Text == "Vergi Dairesi")
            {
                TxtCariVergiDairesi.Text = "";
            }
        }

        private void TxtCariVergiNumarası_Click(object sender, EventArgs e)
        {
            if (TxtCariVergiNumarası.Text == "Vergi Numarası")
            {
                TxtCariVergiNumarası.Text = "";
            }
        }

        private void TxtCariStatu_Click(object sender, EventArgs e)
        {
            if (TxtCariStatu.Text == "Statü")
            {
                TxtCariStatu.Text = "";
            }
        }

        private void RchCariAdres_Click(object sender, EventArgs e)
        {
            if (RchCariAdres.Text == "Adres")
            {
                RchCariAdres.Text = "";
            }
        }

        private void PictureCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCariEkle_Load(object sender, EventArgs e)
        {
            LueIl.Properties.DataSource = (from x in db.TBLILLER
                                           select new
                                           {
                                               x.id,
                                               x.sehir
                                           }).ToList();
        }

        private void LueIl_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(LueIl.EditValue.ToString());
            LueIlce.Properties.DataSource = (from x in db.TBLILCELER
                                             select new
                                             {
                                                 x.id,
                                                 x.ilce,
                                                 x.sehir
                                             }).Where(y => y.sehir == secilen).ToList();
        }
    }
}

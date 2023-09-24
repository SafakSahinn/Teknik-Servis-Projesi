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
    public partial class FrmUrunSatis : Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNHAREKET t = new TBLURUNHAREKET();
            t.URUN = int.Parse(LueUrunId.EditValue.ToString());
            t.MUSTERI = int.Parse(LueMusteri.EditValue.ToString());
            t.PERSONEL = short.Parse(LuePersonel.EditValue.ToString());
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            t.ADET = short.Parse(TxtAdet.Text);
            t.FIYAT = decimal.Parse(TxtSatisFiyat.Text);
            t.URUNSERINO = TxtSeriNo.Text;
            db.TBLURUNHAREKET.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün satış işlemi gerçekleşti!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PictureCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUrunSatis_Load(object sender, EventArgs e)
        {
            LueUrunId.Properties.DataSource = (from x in db.TBLURUN
                                               select new
                                               {
                                                   x.ID,
                                                   x.AD
                                               }).ToList();

            LueMusteri.Properties.DataSource = (from x in db.TBLCARI
                                                select new
                                                {
                                                    x.ID,
                                                    AD = x.AD + " " + x.SOYAD
                                                }).ToList();

            LuePersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        private void TxtAdet_Click(object sender, EventArgs e)
        {
            if (TxtAdet.Text == "Adet")
            {
                TxtAdet.Text = "";
            }
        }

        private void TxtSatisFiyat_Click(object sender, EventArgs e)
        {
            if (TxtSatisFiyat.Text == "Satış Fiyatı")
            {
                TxtSatisFiyat.Text = "";
            }
        }
    }
}

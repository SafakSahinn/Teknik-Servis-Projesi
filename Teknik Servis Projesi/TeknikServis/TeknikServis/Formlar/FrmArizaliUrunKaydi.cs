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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        private void BtnMusteriGetir_Click(object sender, EventArgs e)
        {
            var verigetir = db.TBLURUNHAREKET.SingleOrDefault(x => x.URUNSERINO == TxtSeriNo.Text);
            if (verigetir != null)
            {
                LueMusteriId.Properties.DataSource = (from x in db.TBLURUNHAREKET
                                                      select new
                                                      {
                                                          x.TBLCARI.ID,
                                                          AD = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                                                          x.URUNSERINO
                                                      }).Where(y => y.URUNSERINO == TxtSeriNo.Text).ToList();

                LuePersonel.Properties.DataSource = (from x in db.TBLURUNHAREKET
                                                     select new
                                                     {
                                                         x.TBLPERSONEL.ID,
                                                         AD = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                                                         x.URUNSERINO
                                                     }).Where(y => y.URUNSERINO == TxtSeriNo.Text).ToList();

                MessageBox.Show("Ürüne ait müşteri ve personel bilgileri getirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (LueMusteriId.Text != "Müşteri" && LuePersonel.Text != "Personel" && TxtTarih.Text != "" && TxtSeriNo.Text != "")
            {
                TBLURUNKABUL t = new TBLURUNKABUL();
                t.CARI = int.Parse(LueMusteriId.EditValue.ToString());
                t.PERSONEL = short.Parse(LuePersonel.EditValue.ToString());
                t.GELISTARIH = DateTime.Parse(TxtTarih.Text);
                t.URUNSERINO = TxtSeriNo.Text;
                t.DURUMDETAY = "Ürün kaydoldu";
                db.TBLURUNKABUL.Add(t);
                db.SaveChanges();
                MessageBox.Show("Arızalı ürün kaydı yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ürün bilgilerini eksik girdiniz! Lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PictureCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            //Müşteri
            LueMusteriId.Properties.DataSource = (from x in db.TBLCARI
                                                  select new
                                                  {
                                                      x.ID,
                                                      AD = x.AD + " " + x.SOYAD,
                                                  }).ToList();

            //Personel
            LuePersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD,
                                                 }).ToList();
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            if (TxtSeriNo.Text == "SeriN")
            {
                TxtSeriNo.Text = "";
            }
        }
    }
}

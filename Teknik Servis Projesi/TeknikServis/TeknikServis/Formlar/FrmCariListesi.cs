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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        int secilen;

        void listele()
        {
            var degerler = from x in db.TBLCARI
                           select new
                           {
                               x.ID,
                               x.AD,
                               x.SOYAD,
                               x.TELEFON,
                               x.MAIL,
                               x.IL,
                               x.ILCE,
                               x.BANKA,
                               x.VERGIDAIRESI,
                               x.VERGINO,
                               x.STATU,
                               x.ADRES
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        void temizle()
        {
            TxtCarıId.Text = "";
            TxtCariAd.Text = "";
            TxtCariSoyad.Text = "";
            TxtCariTelefon.Text = "";
            TxtMail.Text = "";
            LueIl.Text = "";
            LueIlce.Text = "";
            TxtCariBanka.Text = "";
            TxtCariVergiDairesi.Text = "";
            TxtCariVergiNo.Text = "";
            TxtCariStatu.Text = "";
            RchAdres.Text = "";
        }

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            LblToplamCariSayisi.Text = db.TBLCARI.Count().ToString();
            LblToplamIlSayisi.Text = db.TBLCARI.Select(x => x.IL).Distinct().Count().ToString();
            LblToplamIlceSayisi.Text = db.TBLCARI.Select(x => x.ILCE).Distinct().Count().ToString();

            LblEnFazlaCariliIl.Text = (from x in db.TBLCARI
                                       orderby
                                       x.AD descending
                                       select x.IL).FirstOrDefault();

            LueIl.Properties.DataSource = (from x in db.TBLILLER
                                           select new
                                           {
                                               x.id,
                                               x.sehir
                                           }).ToList();
            listele();
            temizle();
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

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtCariAd.Text != "" && TxtCariSoyad.Text != "" && TxtCariTelefon.Text != "" && TxtMail.Text != "" && LueIl.Text != "" && LueIl.Text != "İl" && LueIlce.Text != "" && LueIlce.Text != "İlçe" && TxtCariBanka.Text != "" && TxtCariVergiDairesi.Text != "" && TxtCariVergiNo.Text != "" && TxtCariStatu.Text != "" && RchAdres.Text != "")
            {
                if (TxtCariAd.Text.Length <= 30 && TxtCariSoyad.Text.Length <= 30 && TxtCariTelefon.Text.Length <= 20 && TxtMail.Text.Length <= 50 && TxtCariBanka.Text.Length <= 50 && TxtCariVergiDairesi.Text.Length <= 50 && TxtCariVergiNo.Text.Length <= 50 && TxtCariStatu.Text.Length <= 50 && RchAdres.Text.Length <= 250)
                {
                    TBLCARI t = new TBLCARI();
                    t.AD = TxtCariAd.Text;
                    t.SOYAD = TxtCariSoyad.Text;
                    t.TELEFON = TxtCariTelefon.Text;
                    t.MAIL = TxtMail.Text;
                    t.IL = LueIl.Text;
                    t.ILCE = LueIlce.Text;
                    t.BANKA = TxtCariBanka.Text;
                    t.VERGIDAIRESI = TxtCariVergiDairesi.Text;
                    t.VERGINO = TxtCariVergiNo.Text;
                    t.STATU = TxtCariStatu.Text;
                    t.ADRES = RchAdres.Text;
                    db.TBLCARI.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Cari bilgileri kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Cari bilgilerini hatalı girdiniz! Girdiğiniz karakter sayısını lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Cari bilgilerini eksik girdiniz! Lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtCarıId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtCariAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtCariSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            TxtCariTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            LueIl.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            LueIlce.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
            TxtCariBanka.Text = gridView1.GetFocusedRowCellValue("BANKA").ToString();
            TxtCariVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRESI").ToString();
            TxtCariVergiNo.Text = gridView1.GetFocusedRowCellValue("VERGINO").ToString();
            TxtCariStatu.Text = gridView1.GetFocusedRowCellValue("STATU").ToString();
            RchAdres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Cari kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                int id = int.Parse(TxtCarıId.Text);
                var deger = db.TBLCARI.Find(id);
                db.TBLCARI.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Cari kaydı sistemden silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Cari kaydını güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                int id = int.Parse(TxtCarıId.Text);
                var deger = db.TBLCARI.Find(id);
                deger.AD = TxtCariAd.Text;
                deger.SOYAD = TxtCariSoyad.Text;
                deger.TELEFON = TxtCariTelefon.Text;
                deger.MAIL = TxtMail.Text;
                deger.IL = LueIl.Text;
                deger.ILCE = LueIlce.Text;
                deger.BANKA = TxtCariBanka.Text;
                deger.VERGIDAIRESI = TxtCariVergiDairesi.Text;
                deger.VERGINO = TxtCariVergiNo.Text;
                deger.STATU = TxtCariStatu.Text;
                deger.ADRES = RchAdres.Text;
                db.SaveChanges();
                MessageBox.Show("Cari bilgileri güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }
    }
}

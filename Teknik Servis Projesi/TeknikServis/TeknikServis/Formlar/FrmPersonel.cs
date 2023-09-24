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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        void listele()
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        void temizle()
        {
            TxtPersonelId.Text = "";
            TxtPersonelAd.Text = "";
            TxtPersonelSoyad.Text = "";
            LueDepartman.EditValue = "";
            TxtMail.Text = "";
            TxtTelefon.Text = "";
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            listele();

            LueDepartman.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                  select new
                                                  {
                                                      x.ID,
                                                      x.AD
                                                  }).ToList();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtPersonelAd.Text != "" && TxtPersonelSoyad.Text != "" && TxtMail.Text != "" && TxtTelefon.Text != "")
            {
                if (TxtPersonelAd.Text.Length <= 30 && TxtPersonelSoyad.Text.Length <= 30 && TxtMail.Text.Length <= 50 && TxtTelefon.Text.Length <= 20)
                {
                    TBLPERSONEL t = new TBLPERSONEL();
                    t.AD = TxtPersonelAd.Text;
                    t.SOYAD = TxtPersonelSoyad.Text;
                    t.MAIL = TxtMail.Text;
                    t.TELEFON = TxtTelefon.Text;
                    //t.DEPERTMAN = byte.Parse(LueDepartman.EditValue.ToString()); model hatası düzeltilmesi gerekli
                    db.TBLPERSONEL.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Personel bilgileri kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Fatura bilgilerini hatalı girdiniz! Girdiğiniz karakter sayısını lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Personel bilgileri eksik girdiniz! Lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtPersonelId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtPersonelAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtPersonelSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            //LueDepartman.Text = gridView1.GetFocusedRowCellValue("DEPARTMAN").ToString(); // model isim hatası depertman yerine departman olacak
            TxtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            TxtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Perosnel kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                int id = int.Parse(TxtPersonelId.Text);
                var deger = db.TBLPERSONEL.Find(id);
                db.TBLPERSONEL.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Personel kaydı sistemden silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Personel kaydını güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                int id = int.Parse(TxtPersonelId.Text);
                var deger = db.TBLPERSONEL.Find(id);
                deger.AD = TxtPersonelAd.Text;
                deger.SOYAD = TxtPersonelSoyad.Text;
                //deger.DEPERTMAN = LueDepartman.Text; //model hatası düzeltilmesi lazım
                deger.MAIL = TxtMail.Text;
                deger.TELEFON = TxtTelefon.Text;
                db.SaveChanges();
                MessageBox.Show("Fatura bilgileri güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}

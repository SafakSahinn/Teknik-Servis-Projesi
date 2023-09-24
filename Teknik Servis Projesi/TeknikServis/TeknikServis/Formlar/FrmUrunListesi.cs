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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        void listele()
        {
            var degerler = from u in db.TBLURUN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               KATEGORI = u.TBLKATEGORI.AD,
                               u.STOK,
                               u.ALISFIYAT,
                               u.SATISFIYAT
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        void temizle()
        {
            TxtUrunId.Text = "";
            TxtUrunAd.Text = "";
            TxtMarka.Text = "";
            TxtAlisFiyat.Text = "";
            TxtSatisFiyat.Text = "";
            TxtStok.Text = "";
            LueKategori.EditValue = "";
        }

        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            listele();
            LueKategori.Properties.DataSource = (from x in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
            temizle();
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
                    t.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
                    t.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
                    t.STOK = short.Parse(TxtStok.Text);
                    t.DURUM = false;
                    t.KATEGORI = byte.Parse(LueKategori.EditValue.ToString());
                    db.TBLURUN.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Ürün Sisteme Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
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

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtUrunId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            TxtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            TxtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            TxtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
            LueKategori.Text = gridView1.GetFocusedRowCellValue("KATEGORI").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Ürün kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                int id = int.Parse(TxtUrunId.Text);
                var deger = db.TBLURUN.Find(id);
                db.TBLURUN.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Ürün kaydı sistemden silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Ürün kaydını güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                int id = int.Parse(TxtUrunId.Text);
                var deger = db.TBLURUN.Find(id);
                deger.AD = TxtUrunAd.Text;
                deger.MARKA = TxtMarka.Text;
                deger.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
                deger.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
                deger.STOK = short.Parse(TxtStok.Text);
                deger.KATEGORI = byte.Parse(LueKategori.EditValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Ürün bilgileri güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        void listele()
        {
            var degerler = from k in db.TBLKATEGORI
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        void temizle()
        {
            TxtKategorId.Text = "";
            TxtKategoriAd.Text = "";
        }

        private void FrmKategori_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtKategoriAd.Text != "")
            {
                if (TxtKategoriAd.Text.Length <= 30)
                {
                    TBLKATEGORI t = new TBLKATEGORI();
                    t.AD = TxtKategoriAd.Text;
                    db.TBLKATEGORI.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Kategori sisteme kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Kategori adı 30 karakterden daha uzun olamaz! Lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Kategori adı boş bırakılamaz! Lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Kategori kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                int id = int.Parse(TxtKategorId.Text);
                var deger = db.TBLKATEGORI.Find(id);
                db.TBLKATEGORI.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Ürün Sistemden Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Kategori kaydını güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                int id = int.Parse(TxtKategorId.Text);
                var deger = db.TBLKATEGORI.Find(id);
                deger.AD = TxtKategoriAd.Text;
                db.SaveChanges();
                MessageBox.Show("Kategori Bilgisi Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtKategorId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtKategoriAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}

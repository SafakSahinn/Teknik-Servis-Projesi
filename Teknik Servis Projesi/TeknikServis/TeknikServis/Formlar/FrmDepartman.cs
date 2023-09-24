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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        void listele()
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.ACIKLAMA
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        void temizle()
        {
            TxtDepartmanId.Text = "";
            TxtDepartmanAd.Text = "";
            RchDepartmanAciklama.Text = "";
        }

        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            listele();
            LblToplamDepartmanSayisi.Text = db.TBLDEPARTMAN.Count().ToString();
            LblToplamPersonelSayisi.Text = db.TBLPERSONEL.Count().ToString();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtDepartmanAd.Text != "" && RchDepartmanAciklama.Text != "")
            {
                if (TxtDepartmanAd.Text.Length <= 50 && RchDepartmanAciklama.Text.Length <= 100)
                {
                    TBLDEPARTMAN t = new TBLDEPARTMAN();
                    t.AD = TxtDepartmanAd.Text;
                    t.ACIKLAMA = RchDepartmanAciklama.Text;
                    db.TBLDEPARTMAN.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Departman bilgileri kaydedildi!", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Departman bilgilerini hatalı girdiniz! Girdiğiniz karakter sayısını lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Departman bilgilerini eksik girdiniz! Lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Departman kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                int id = int.Parse(TxtDepartmanId.Text);
                var deger = db.TBLDEPARTMAN.Find(id);
                db.TBLDEPARTMAN.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Departman Sistemden Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtDepartmanId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtDepartmanAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            RchDepartmanAciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Departman kaydını güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                int id = int.Parse(TxtDepartmanId.Text);
                var deger = db.TBLDEPARTMAN.Find(id);
                deger.AD = TxtDepartmanAd.Text;
                deger.ACIKLAMA = RchDepartmanAciklama.Text;
                db.SaveChanges();
                MessageBox.Show("Departman bilgisi güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

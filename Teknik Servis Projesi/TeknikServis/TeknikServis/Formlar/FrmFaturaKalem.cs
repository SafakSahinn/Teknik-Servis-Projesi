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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        void listele()
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        void temizle()
        {
            TxtDetayID.Text = "";
            LueUrun.EditValue = "";
            TxtAdet.Text = "";
            TxtFiyat.Text = "";
            TxtTutar.Text = "";
            TxtFaturaId.Text = "";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (LueUrun.Text != "" && TxtAdet.Text != "" && TxtFiyat.Text != "" && TxtTutar.Text != "" && TxtFaturaId.Text != "")
            {
                TBLFATURADETAY t = new TBLFATURADETAY();
                t.URUN = LueUrun.Text;
                t.ADET = short.Parse(TxtAdet.Text);
                t.FIYAT = decimal.Parse(TxtFiyat.Text);
                t.TUTAR = decimal.Parse(TxtTutar.Text);
                t.FATURAID = int.Parse(TxtFaturaId.Text);
                db.TBLFATURADETAY.Add(t);
                db.SaveChanges();
                MessageBox.Show("Fatura detayları kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Fatura bilgileri eksik girdiniz! Lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            listele();

            LueUrun.Properties.DataSource = (from x in db.TBLURUN
                                             select new
                                             {
                                                 x.ID,
                                                 x.AD
                                             }).ToList();
            temizle();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtDetayID.Text = gridView1.GetFocusedRowCellValue("FATURADETAYID").ToString();
            LueUrun.Text = gridView1.GetFocusedRowCellValue("URUN").ToString();
            TxtAdet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            TxtFiyat.Text = gridView1.GetFocusedRowCellValue("FIYAT").ToString();
            TxtTutar.Text = gridView1.GetFocusedRowCellValue("TUTAR").ToString();
            TxtFaturaId.Text = gridView1.GetFocusedRowCellValue("FATURAID").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Fatura kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                int id = int.Parse(TxtDetayID.Text);
                var deger = db.TBLFATURADETAY.Find(id);
                db.TBLFATURADETAY.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Fatura kaydı sistemden silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Fatura kaydını güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                int id = int.Parse(TxtDetayID.Text);
                var deger = db.TBLFATURADETAY.Find(id);
                deger.URUN = LueUrun.Text;
                deger.ADET = short.Parse(TxtAdet.Text);
                deger.FIYAT = decimal.Parse(TxtFiyat.Text);
                deger.TUTAR = decimal.Parse(TxtTutar.Text);
                deger.FATURAID = int.Parse(TxtFaturaId.Text);
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

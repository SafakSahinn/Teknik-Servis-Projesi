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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        void listele()
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARI = u.TBLCARI.AD + " " + u.TBLCARI.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD + " " + u.TBLPERSONEL.SOYAD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        void temizle()
        {
            TxtFaturaId.Text = "";
            TxtSeri.Text = "";
            TxtSiraNo.Text = "";
            TxtTarih.Text = "";
            TxtSaat.Text = "";
            TxtVergiDairesi.Text = "";
            LueCari.EditValue = "";
            LuePersonel.EditValue = "";
        }

        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            listele();

            LueCari.Properties.DataSource = (from x in db.TBLCARI
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
            temizle();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtSeri.Text != "" && TxtSiraNo.Text != "" && TxtTarih.Text != "" && TxtSaat.Text != "" && TxtVergiDairesi.Text != "" && LueCari.Text != "" && LuePersonel.Text != "")
            {
                if (TxtSeri.Text.Length <= 1 && TxtSiraNo.Text.Length <= 6 && TxtVergiDairesi.Text.Length <= 50)
                {
                    TBLFATURABILGI t = new TBLFATURABILGI();
                    t.SERI = TxtSeri.Text;
                    t.SIRANO = TxtSiraNo.Text;
                    t.TARIH = DateTime.Parse(TxtTarih.Text);
                    t.SAAT = TxtSaat.Text;
                    t.VERGIDAIRE = TxtVergiDairesi.Text;
                    t.CARI = int.Parse(LueCari.EditValue.ToString());
                    t.PERSONEL = short.Parse(LuePersonel.EditValue.ToString());
                    db.TBLFATURABILGI.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Fatura bilgileri sisteme kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fatura bilgilerini hatalı girdiniz! Girdiğiniz karakter sayısını lütfen kontrol ediniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Fatura bilgileri eksik girdiniz! Lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopup fr = new FrmFaturaKalemPopup();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtFaturaId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtSeri.Text = gridView1.GetFocusedRowCellValue("SERI").ToString();
            TxtSiraNo.Text = gridView1.GetFocusedRowCellValue("SIRANO").ToString();
            TxtTarih.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            TxtSaat.Text = gridView1.GetFocusedRowCellValue("SAAT").ToString();
            TxtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRE").ToString();
            LueCari.Text = gridView1.GetFocusedRowCellValue("CARI").ToString();
            LuePersonel.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Fatura kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                int id = int.Parse(TxtFaturaId.Text);
                var deger = db.TBLFATURABILGI.Find(id);
                db.TBLFATURABILGI.Remove(deger);
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
                int id = int.Parse(TxtFaturaId.Text);
                var deger = db.TBLFATURABILGI.Find(id);
                deger.SERI = TxtSeri.Text;
                deger.SIRANO = TxtSiraNo.Text;
                deger.TARIH = DateTime.Parse(TxtTarih.Text);
                deger.SAAT = TxtSaat.Text;
                deger.VERGIDAIRE = TxtVergiDairesi.Text;
                deger.CARI = int.Parse(LueCari.EditValue.ToString());
                deger.PERSONEL = short.Parse(LueCari.EditValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Fatura bilgileri güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }
    }
}

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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        void listele()
        {
            gridControl1.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TBLNOTLARIM.Where(y => y.DURUM == true).ToList();
        }

        void temizle()
        {
            TxtNotId.Text = "";
            TxtNotBaslik.Text = "";
            TxtNotIcerik.Text = "";
            TxtTarih.Text = "";
            CheckOkundu.Checked = false;
        }

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtNotBaslik.Text != "" && TxtNotIcerik.Text != "" && TxtTarih.Text != "")
            {
                if (TxtNotBaslik.Text.Length <= 50 && TxtNotIcerik.Text.Length <= 250)
                {
                    TBLNOTLARIM t = new TBLNOTLARIM();
                    t.BASLIK = TxtNotBaslik.Text;
                    t.ICERIK = TxtNotIcerik.Text;
                    t.DURUM = false;
                    t.TARIH = DateTime.Parse(TxtTarih.Text);
                    db.TBLNOTLARIM.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Not sisteme kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Not bilgilerini hatalı girdiniz! Girdiğiniz karakter sayısını lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Not bilgileri eksik girdiniz! Lütfen kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TBLNOTLARIM.Where(y => y.DURUM == true).ToList();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Not kaydını güncellemek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                if (CheckOkundu.Checked == true)
                {
                    int id = int.Parse(TxtNotId.Text);
                    var deger = db.TBLNOTLARIM.Find(id);
                    deger.BASLIK = TxtNotBaslik.Text;
                    deger.ICERIK = TxtNotIcerik.Text;
                    if (CheckOkundu.Checked == true)
                    {
                        deger.DURUM = true;
                    }
                    else
                    {
                        deger.DURUM = false;
                    }
                    db.SaveChanges();
                    MessageBox.Show("Not kaydı güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizle();
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtNotId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtNotBaslik.Text = gridView1.GetFocusedRowCellValue("BASLIK").ToString();
            TxtNotIcerik.Text = gridView1.GetFocusedRowCellValue("ICERIK").ToString();
            TxtTarih.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            CheckOkundu.Checked = false;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtNotId.Text = gridView2.GetFocusedRowCellValue("ID").ToString();
            TxtNotBaslik.Text = gridView2.GetFocusedRowCellValue("BASLIK").ToString();
            TxtNotIcerik.Text = gridView2.GetFocusedRowCellValue("ICERIK").ToString();
            TxtTarih.Text = gridView2.GetFocusedRowCellValue("TARIH").ToString();
            CheckOkundu.Checked = true;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Not kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                int id = int.Parse(TxtNotId.Text);
                var deger = db.TBLNOTLARIM.Find(id);
                db.TBLNOTLARIM.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Not kaydı sistemden silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }
    }
}

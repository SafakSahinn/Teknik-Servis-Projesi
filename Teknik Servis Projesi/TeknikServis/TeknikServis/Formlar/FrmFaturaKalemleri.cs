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
    public partial class FrmFaturaKalemleri : Form
    {
        public FrmFaturaKalemleri()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        private void BtnAra_Click(object sender, EventArgs e)
        {
            //Sadece fatura id'ye göre arama
            if (TxtFaturaId.Text != "" && TxtSeriNo.Text == "" && TxtSiraNo.Text == "")
            {
                int id = Convert.ToInt32(TxtFaturaId.Text);
                var degerler = (from u in db.TBLFATURADETAY
                                select new
                                {
                                    u.FATURADETAYID,
                                    u.URUN,
                                    u.ADET,
                                    u.FIYAT,
                                    u.TUTAR,
                                    u.FATURAID,
                                    u.TBLFATURABILGI.SERI
                                }).Where(x => x.FATURAID == id);
                gridControl1.DataSource = degerler.ToList();
            }
            //Sadece seri noya göre arama
            if (TxtSeriNo.Text != "" && TxtFaturaId.Text == "" && TxtSiraNo.Text == "")
            {
                var degerler3 = from x in db.TBLFATURADETAY.Where(x => x.TBLFATURABILGI.SERI == TxtSeriNo.Text)
                                select new
                                {
                                    x.URUN,
                                    x.TBLFATURABILGI.SIRANO,
                                    x.TBLFATURABILGI.SERI,
                                    x.ADET,
                                    x.FIYAT,
                                    x.TUTAR,
                                    x.FATURAID
                                };
                gridControl1.DataSource = degerler3.ToList();
            }
            //Sadece sıra noya göre arama
            if (TxtSiraNo.Text != "" && TxtFaturaId.Text == "" && TxtSeriNo.Text == "")
            {
                var degerler3 = from x in db.TBLFATURADETAY.Where(x => x.TBLFATURABILGI.SIRANO == TxtSiraNo.Text)
                                select new
                                {
                                    x.URUN,
                                    x.TBLFATURABILGI.SIRANO,
                                    x.TBLFATURABILGI.SERI,
                                    x.ADET,
                                    x.FIYAT,
                                    x.TUTAR,
                                    x.FATURAID
                                };
                gridControl1.DataSource = degerler3.ToList();
            }
            //Hem fatura id hemde seri numarasına göre arama
            if (TxtFaturaId.Text != "" && TxtSeriNo.Text != "" && TxtSiraNo.Text == "")
            {
                int id = Convert.ToInt32(TxtFaturaId.Text);
                var degerler2 = (from x in db.TBLFATURADETAY.Where(x => x.TBLFATURABILGI.SERI == TxtSeriNo.Text)
                                 select new
                                 {
                                     x.URUN,
                                     x.ADET,
                                     x.FIYAT,
                                     x.TUTAR,
                                     x.FATURAID,
                                     x.TBLFATURABILGI.SIRANO,
                                     x.TBLFATURABILGI.SERI
                                 }).Where(x => x.FATURAID == id);
                gridControl1.DataSource = degerler2.ToList();
            }
            //Hem fatura id hemde sıra numarasına göre arama
            if (TxtFaturaId.Text != "" && TxtSiraNo.Text != "" && TxtSeriNo.Text == "")
            {
                int id = Convert.ToInt32(TxtFaturaId.Text);
                var degerler2 = (from x in db.TBLFATURADETAY.Where(x => x.TBLFATURABILGI.SIRANO == TxtSiraNo.Text)
                                 select new
                                 {
                                     x.URUN,
                                     x.ADET,
                                     x.FIYAT,
                                     x.TUTAR,
                                     x.FATURAID,
                                     x.TBLFATURABILGI.SIRANO,
                                     x.TBLFATURABILGI.SERI
                                 }).Where(x => x.FATURAID == id);
                gridControl1.DataSource = degerler2.ToList();
            }
            //Hem seri numarasına göre hemde sıra numarasına gore arama
            if (TxtSeriNo.Text != "" && TxtSiraNo.Text != "" && TxtFaturaId.Text == "")
            {
                var degerler3 = from x in db.TBLFATURADETAY.Where(x => x.TBLFATURABILGI.SERI == TxtSeriNo.Text && x.TBLFATURABILGI.SIRANO == TxtSiraNo.Text)
                                select new
                                {
                                    x.URUN,
                                    x.TBLFATURABILGI.SIRANO,
                                    x.TBLFATURABILGI.SERI,
                                    x.ADET,
                                    x.FIYAT,
                                    x.TUTAR,
                                    x.FATURAID
                                };
                gridControl1.DataSource = degerler3.ToList();
            }
            //Hem ID'ye göre hem seri numarasına göre hem de sıra numarasına göre arama 
            if (TxtFaturaId.Text != "" && TxtSeriNo.Text != "" && TxtSiraNo.Text != "")
            {
                int id = Convert.ToInt32(TxtFaturaId.Text);
                var degerler3 = (from x in db.TBLFATURADETAY.Where(x => x.TBLFATURABILGI.SERI == TxtSeriNo.Text && x.TBLFATURABILGI.SIRANO == TxtSiraNo.Text)
                                select new
                                {
                                    x.URUN,
                                    x.TBLFATURABILGI.SIRANO,
                                    x.TBLFATURABILGI.SERI,
                                    x.ADET,
                                    x.FIYAT,
                                    x.TUTAR,
                                    x.FATURAID
                                }).Where(x => x.FATURAID == id);
                gridControl1.DataSource = degerler3.ToList();
            }
        }
    }
}

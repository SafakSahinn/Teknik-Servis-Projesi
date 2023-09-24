using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeknikServis.Formlar
{
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-S866UD2;Initial Catalog=DBTeknikServis;Integrated Security=True");

        void listele()
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               CARİ = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                               x.GELISTARIH,
                               x.CIKISTARIH,
                               x.URUNSERINO,
                               x.DURUMDETAY
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            listele();
            LblMevcutArizaliUrunSayisi.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == true).ToString();
            LblTamiriBitmisUrunSayisi.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == false).ToString();
            LblToplamUrunSayisi.Text = db.TBLURUN.Count().ToString();
            LblParcaBekleyenUrunSayisi.Text = db.TBLURUNKABUL.Count(x => x.DURUMDETAY == "Parça bekliyor.").ToString();
            LblMesajBekleyenMusteriSayisi.Text = db.TBLURUNKABUL.Count(x => x.DURUMDETAY == "Mesaj bekliyor.").ToString();
            LblIptalEdilenIslemler.Text = db.TBLURUNKABUL.Count(x => x.DURUMDETAY == "İptal bekliyor.").ToString();

            //grafik verilerini çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT DURUMDETAY,COUNT(*) FROM TBLURUNKABUL GROUP BY DURUMDETAY", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmArizaDetaylar fr = new FrmArizaDetaylar();
            fr.id = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            fr.serino = gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
            fr.durumbilgisi = gridView1.GetFocusedRowCellValue("DURUMDETAY").ToString();
            fr.Show();
        }
    }
}

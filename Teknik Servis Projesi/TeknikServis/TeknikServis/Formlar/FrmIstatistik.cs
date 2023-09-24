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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            LblToplamUrunSayisi.Text = db.TBLURUN.Count().ToString();
            LblToplamKategoriSayisi.Text = db.TBLKATEGORI.Count().ToString();
            LblToplamStokSayisi.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            LblKritikSeviye.Text = "10";
            LblEnFazlaStokluUrun.Text = (from x in db.TBLURUN
                                         orderby x.STOK descending
                                         select x.AD).FirstOrDefault();
            LblEnAzStokluUrun.Text = (from x in db.TBLURUN
                                      orderby x.STOK ascending
                                      select x.AD).FirstOrDefault();
            LblEnYuksekFiyatliUrun.Text = (from x in db.TBLURUN
                                           orderby x.SATISFIYAT descending
                                           select x.AD).FirstOrDefault();
            LblEnDusukFiyatliUrun.Text = (from x in db.TBLURUN
                                          orderby x.SATISFIYAT ascending
                                          select x.AD).FirstOrDefault();
            LblBeyazEsyaStokSayisi.Text = db.TBLURUN.Count(x => x.KATEGORI == 4).ToString();
            LblBilgisayarStokSayisi.Text = db.TBLURUN.Count(x => x.KATEGORI ==1).ToString();
            LblKucukEvAletiStokSayisi.Text = db.TBLURUN.Count(x => x.KATEGORI ==3).ToString();
            LblToplamMarkaSayisi.Text = (from x in db.TBLURUN
                                         select x.MARKA).Distinct().Count().ToString();
            LblArizaliUrunSayisi.Text = db.TBLURUNKABUL.Count().ToString();
            LblEnFazlaUrunKategorisi.Text = db.makskategoriurun().FirstOrDefault();
        }
    }
}

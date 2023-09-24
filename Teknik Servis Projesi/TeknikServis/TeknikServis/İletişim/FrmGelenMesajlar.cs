using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.İletişim
{
    public partial class FrmGelenMesajlar : Form
    {
        public FrmGelenMesajlar()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        void listele()
        {
            gridControl1.DataSource = (from x in db.TBLILETISIM
                                       select new
                                       {
                                           x.ID,
                                           x.ADSOYAD,
                                           x.KONU,
                                           x.MAIL,
                                           x.MESAJ
                                       }).ToList();
        }

        private void FrmGelenMesajlar_Load(object sender, EventArgs e)
        {
            listele();

            LblToplamMesajSayisi.Text = db.TBLILETISIM.Count().ToString();
            LblTesekkurMesajSayisi.Text = db.TBLILETISIM.Where(x => x.KONU == "Teşekkür").Count().ToString();
            LblRicaMesajSayisi.Text = db.TBLILETISIM.Where(x => x.KONU == "Rica").Count().ToString();
            LblSikayetMesajSayisi.Text = db.TBLILETISIM.Where(x => x.KONU == "Şikayet").Count().ToString();
            LblToplamPersonelSayisi.Text = db.TBLPERSONEL.Count().ToString();
            LblToplamCariSayisi.Text = db.TBLCARI.Count().ToString();
            LblToplamKategoriSayisi.Text = db.TBLKATEGORI.Count().ToString();
            LblToplamUrunSayisi.Text = db.TBLURUN.Count().ToString();
            LblToplamMarkaSayisi.Text = (from x in db.TBLURUN
                                         select x.MARKA).Distinct().Count().ToString();
        }
    }
}

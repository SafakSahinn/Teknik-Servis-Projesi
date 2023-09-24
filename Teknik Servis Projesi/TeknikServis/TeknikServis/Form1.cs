using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Formlar.FrmUrunListesi frUrunListesi;
        private void BtnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frUrunListesi == null || frUrunListesi.IsDisposed)
            {
                frUrunListesi = new Formlar.FrmUrunListesi();
                frUrunListesi.MdiParent = this;
                frUrunListesi.Show();
            }
        }

        Formlar.FrmYeniUrun frYeniUrun;
        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frYeniUrun == null || frYeniUrun.IsDisposed)
            {
                frYeniUrun = new Formlar.FrmYeniUrun();
                frYeniUrun.Show();
            }
        }

        Formlar.FrmKategori frKategori;
        private void BtnKategoriListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frKategori == null || frKategori.IsDisposed)
            {
                frKategori = new Formlar.FrmKategori();
                frKategori.MdiParent = this;
                frKategori.Show();
            }
        }

        Formlar.FrmYeniKategori frYeniKategori;
        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frYeniKategori == null || frYeniKategori.IsDisposed)
            {
                frYeniKategori = new Formlar.FrmYeniKategori();
                frYeniKategori.Show();
            }
        }

        Formlar.FrmIstatistik frIstatistik;
        private void BtnUrunIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frIstatistik == null || frIstatistik.IsDisposed)
            {
                frIstatistik = new Formlar.FrmIstatistik();
                frIstatistik.MdiParent = this;
                frIstatistik.Show();
            }
        }

        Formlar.FrmMarkalar frMarkaIstatıstıklerı;
        private void BtnMarkaIstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frMarkaIstatıstıklerı == null || frMarkaIstatıstıklerı.IsDisposed)
            {
                frMarkaIstatıstıklerı = new Formlar.FrmMarkalar();
                frMarkaIstatıstıklerı.MdiParent = this;
                frMarkaIstatıstıklerı.Show();
            }
        }

        Formlar.FrmCariListesi frCariListesi;
        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frCariListesi == null || frCariListesi.IsDisposed)
            {
                frCariListesi = new Formlar.FrmCariListesi();
                frCariListesi.MdiParent = this;
                frCariListesi.Show();
            }
        }

        Formlar.FrmCariIller frCariIller;
        private void BtnCariIstatistigi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frCariIller == null || frCariIller.IsDisposed)
            {
                frCariIller = new Formlar.FrmCariIller();
                frCariIller.MdiParent = this;
                frCariIller.Show();
            }
        }

        Formlar.FrmCariEkle frCariEkle;
        private void BtnYeniCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frCariEkle == null || frCariEkle.IsDisposed)
            {
                frCariEkle = new Formlar.FrmCariEkle();
                frCariEkle.Show();
            }
        }

        Formlar.FrmDepartman frDepartman;
        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frDepartman == null || frDepartman.IsDisposed)
            {
                frDepartman = new Formlar.FrmDepartman();
                frDepartman.MdiParent = this;
                frDepartman.Show();
            }
        }

        Formlar.FrmYeniDepartman frYeniDepartman;
        private void BtnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frYeniDepartman == null || frYeniDepartman.IsDisposed)
            {
                frYeniDepartman = new Formlar.FrmYeniDepartman();
                frYeniDepartman.Show();
            }
        }

        Formlar.FrmPersonel frPersonelListesi;
        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frPersonelListesi == null || frPersonelListesi.IsDisposed)
            {
                frPersonelListesi = new Formlar.FrmPersonel();
                frPersonelListesi.MdiParent = this;
                frPersonelListesi.Show();
            }
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        Formlar.FrmKurlar frKurlar;
        private void BtnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frKurlar == null || frKurlar.IsDisposed)
            {
                frKurlar = new Formlar.FrmKurlar();
                frKurlar.MdiParent = this;
                frKurlar.Show();
            }
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        Formlar.FrmYoutube frYoutube;
        private void BtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frYoutube == null || frYoutube.IsDisposed)
            {
                frYoutube = new Formlar.FrmYoutube();
                frYoutube.MdiParent = this;
                frYoutube.Show();
            }
        }

        Formlar.FrmNotlar frNotlar;
        private void BtnNotListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frNotlar == null || frNotlar.IsDisposed)
            {
                frNotlar = new Formlar.FrmNotlar();
                frNotlar.MdiParent = this;
                frNotlar.Show();
            }
        }

        Formlar.FrmArizaListesi frArizaliUrunListesi;
        private void BtnArizaliUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frArizaliUrunListesi == null || frArizaliUrunListesi.IsDisposed)
            {
                frArizaliUrunListesi = new Formlar.FrmArizaListesi();
                frArizaliUrunListesi.MdiParent = this;
                frArizaliUrunListesi.Show();
            }
        }

        Formlar.FrmUrunSatis frUrunSatis;
        private void BtnYeniUrunSatisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frUrunSatis == null || frUrunSatis.IsDisposed)
            {
                frUrunSatis = new Formlar.FrmUrunSatis();
                frUrunSatis.Show();
            }
        }

        Formlar.FrmSatislar frSatislar;
        private void BtnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frSatislar == null || frSatislar.IsDisposed)
            {
                frSatislar = new Formlar.FrmSatislar();
                frSatislar.MdiParent = this;
                frSatislar.Show();
            }
        }

        Formlar.FrmArizaliUrunKaydi frArizaliUrunKaydi;
        private void BtnYeniArizaliUrunKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frArizaliUrunKaydi == null || frArizaliUrunKaydi.IsDisposed)
            {
                frArizaliUrunKaydi = new Formlar.FrmArizaliUrunKaydi();
                frArizaliUrunKaydi.Show();
            }
        }

        Formlar.FrmArizaDetaylar frArizaDetaylar;
        private void BtnArizaliUrunAciklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frArizaDetaylar == null || frArizaDetaylar.IsDisposed)
            {
                frArizaDetaylar = new Formlar.FrmArizaDetaylar();
                frArizaDetaylar.Show();
            }
        }

        Formlar.FrmArizaliUrunDetayListesi frArizaliUrunDetayListesi;
        private void BtnArizaliUrunDetaylari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frArizaliUrunDetayListesi == null || frArizaliUrunDetayListesi.IsDisposed)
            {
                frArizaliUrunDetayListesi = new Formlar.FrmArizaliUrunDetayListesi();
                frArizaliUrunDetayListesi.MdiParent = this;
                frArizaliUrunDetayListesi.Show();
            }
        }

        Formlar.FrmQRKod frQRKod;
        private void BtnQRKodOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frQRKod == null || frQRKod.IsDisposed)
            {
                frQRKod = new Formlar.FrmQRKod();
                frQRKod.Show();
            }
        }

        Formlar.FrmFaturaListesi frFaturaListesi;
        private void BtnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frFaturaListesi == null || frFaturaListesi.IsDisposed)
            {
                frFaturaListesi = new Formlar.FrmFaturaListesi();
                frFaturaListesi.MdiParent = this;
                frFaturaListesi.Show();
            }
        }

        Formlar.FrmFaturaKalem frFaturaKalem;
        private void BtnFaturayaKalemGirisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frFaturaKalem == null || frFaturaKalem.IsDisposed)
            {
                frFaturaKalem = new Formlar.FrmFaturaKalem();
                frFaturaKalem.MdiParent = this;
                frFaturaKalem.Show();
            }
        }

        Formlar.FrmFaturaKalemleri frFaturaKalemleri;
        private void BtnDetayliFaturaSorgulama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frFaturaKalemleri == null || frFaturaKalemleri.IsDisposed)
            {
                frFaturaKalemleri = new Formlar.FrmFaturaKalemleri();
                frFaturaKalemleri.MdiParent = this;
                frFaturaKalemleri.Show();
            }
        }

        Formlar.FrmHakkimizda frHakkimizda;
        private void BtnHakkimizda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frHakkimizda == null || frHakkimizda.IsDisposed)
            {
                frHakkimizda = new Formlar.FrmHakkimizda();
                frHakkimizda.Show();
            }
        }

        Formlar.FrmHarita frHarita;
        private void BtnHaritalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frHarita == null || frHarita.IsDisposed)
            {
                frHarita = new Formlar.FrmHarita();
                frHarita.MdiParent = this;
                frHarita.Show();
            }
        }

        Formlar.FrmRapor frRapor;
        private void BtnRaporSihirbazi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frRapor == null || frRapor.IsDisposed)
            {
                frRapor = new Formlar.FrmRapor();
                frRapor.Show();
            }
        }

        Formlar.FrmAnaSayfa fr;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfa();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfa();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        İletişim.FrmRehber frRehber;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frRehber == null || frRehber.IsDisposed)
            {
                frRehber = new İletişim.FrmRehber();
                frRehber.MdiParent = this;
                frRehber.Show();
            }
        }

        İletişim.FrmGelenMesajlar frGelenMesajlar;
        private void BtnGelenMesajlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frGelenMesajlar == null || frGelenMesajlar.IsDisposed)
            {
                frGelenMesajlar = new İletişim.FrmGelenMesajlar();
                frGelenMesajlar.MdiParent = this;
                frGelenMesajlar.Show();
            }
        }

        İletişim.FrmMail frYeniMail;
        private void BtnYeniMail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frYeniMail == null || frYeniMail.IsDisposed)
            {
                frYeniMail = new İletişim.FrmMail();
                frYeniMail.Show();
            }
        }

        Formlar.FrmBarkod frBarkod;
        private void BtnBarkodOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frBarkod == null || frBarkod.IsDisposed)
            {
                frBarkod = new Formlar.FrmBarkod();
                frBarkod.Show();
            }
        }
    }
}

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
    public partial class FrmBarkod : Form
    {
        public FrmBarkod()
        {
            InitializeComponent();
        }

        private void BtnBarkodOlustur_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcod = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            PictureBarkod.Image = barcod.Draw(TxtSeriNo.Text, 200);
        }

        private void PictureCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            sfd.Title = "Kayıt";
            sfd.FileName = "resim";
            DialogResult sonuc = sfd.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                PictureBarkod.Image.Save(sfd.FileName);
            }
        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            if (TxtSeriNo.Text == "SeriN")
            {
                TxtSeriNo.Text = "";
            }
        }
    }
}

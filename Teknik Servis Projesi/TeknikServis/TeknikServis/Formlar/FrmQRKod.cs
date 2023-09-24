using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using System.IO;

namespace TeknikServis.Formlar
{
    public partial class FrmQRKod : Form
    {
        public FrmQRKod()
        {
            InitializeComponent();
        }

        private void BtnQROlustur_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            PictureQR.Image = enc.Encode(TxtSeriNo.Text);
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
                PictureQR.Image.Save(sfd.FileName);
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

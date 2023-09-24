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
    public partial class FrmHakkimizda : Form
    {
        public FrmHakkimizda()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S866UD2;Initial Catalog=DBTeknikServis;Integrated Security=True");

        void listele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT METIN FROM TBLHAKKIMIZDA", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                RchHakkimizda.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Hakkımızda bilgisini güncellemek istediğinize emin misniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE TBLHAKKIMIZDA SET METIN=@P1", baglanti);
                komut.Parameters.AddWithValue("@P1", RchHakkimizda.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Hakkımızda bilgisi güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmHakkimizda_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void PictureCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            RchHakkimizda.Text = "";
        }
    }
}

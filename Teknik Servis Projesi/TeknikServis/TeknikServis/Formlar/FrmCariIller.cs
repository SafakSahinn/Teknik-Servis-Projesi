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
    public partial class FrmCariIller : Form
    {
        public FrmCariIller()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-S866UD2;Initial Catalog=DBTeknikServis;Integrated Security=True");

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        private void FrmCariIller_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLCARI.OrderBy(x => x.IL).GroupBy(y => y.IL).Select(z => new { İL = z.Key, TOPLAM = z.Count() }).ToList();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT IL,COUNT(*) FROM TBLCARI GROUP BY IL", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }
    }
}

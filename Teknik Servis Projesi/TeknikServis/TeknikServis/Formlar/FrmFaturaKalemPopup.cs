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
    public partial class FrmFaturaKalemPopup : Form
    {
        public int id;

        DBTeknikServisEntities db = new DBTeknikServisEntities();

        public FrmFaturaKalemPopup()
        {
            InitializeComponent();
        }

        private void FrmFaturaKalemPopup_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLFATURADETAY.Where(x => x.FATURAID == id).ToList();
            gridControl2.DataSource = db.TBLFATURABILGI.Where(x => x.ID == id).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewFakeData
{
    public partial class SecilenMusteriForm : Form
    {
        Musteri mdata;
        public SecilenMusteriForm(Musteri musteri)
        {
            InitializeComponent();
            mdata = musteri;
        }

        private void SecilenMusteriForm_Load(object sender, EventArgs e)
        {
            txt_isim.Text = mdata.isim;
            txt_soyisim.Text = mdata.soyisim;
            txt_email.Text = mdata.emailAdres;
            txt_il.Text = mdata.il;
            txt_ilce.Text = mdata.ilce;
            txt_adres.Text = mdata.adres;
            txt_telefon.Text = mdata.telefon;
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        database db = new database();
        private void Form1_Load(object sender, EventArgs e)
        {           
         
            dgw_musteriler.DataSource = db.musteriListele();
            //dgw_musteriler.Columns[0].Visible = false;
            //dgw_musteriler.Columns["Id"].Visible = false;

            dgw_musteriler.Columns[1].HeaderText = "Müşteri Adı";
            dgw_musteriler.Columns[2].HeaderText = "Müşteri Soyadı";
            dgw_musteriler.Columns[3].Width = 200;
            dgw_musteriler.Columns["adres"].Width = 200;
            dgw_musteriler.Columns["il"].Width = 200;
        }

        private void dgw_musteriler_DoubleClick(object sender, EventArgs e)
        {
            int id =(int)dgw_musteriler[0, dgw_musteriler.CurrentCell.RowIndex].Value;

            Musteri bulunanmusteri =db.musteriListele().FindAll(i => i.Id == id).FirstOrDefault();

            SecilenMusteriForm sf = new SecilenMusteriForm(bulunanmusteri);
            sf.Show();
        }
    }
}

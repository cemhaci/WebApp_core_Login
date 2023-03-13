using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridWiev_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            List<Urun> liste=new List<Urun>();
            liste.Add(new Urun() { id = 1, UrunTanim = "kitap", ResimYol = @"C:\\Users\HAFTAİCİ YAZILIM\seker.png" });
            liste.Add(new Urun() { id = 2, UrunTanim = "yeni kitap", ResimYol = @"C:\\Users\HAFTAİCİ YAZILIM\seker.png" });
            liste.Add(new Urun() { id = 3, UrunTanim = "deneme" });

            dataGridView1.DataSource = liste;

        }
    }
}

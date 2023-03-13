using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosyalamaVeKlasorleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo DI = Directory.CreateDirectory(@"C:\Users\pc\Desktop\elif\Test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           bool klasorvar=Directory.Exists(@"C:\Users\pc\Desktop\elif\Test");//klasör varmı?
            
           if(klasorvar)
               Directory.Delete(@"C:\Users\pc\Desktop\elif\Test",true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //herhangi bir klasörde yeni klasör oluşturun. Oluştururken bu klasör var mı diye baksın. varsa mesaj versin.Bu klasör var silmek ve yeniden oluşturmak istermisiniz?
            //cevap=Evet klasörü sil ve yeniden oluştur.

            bool klasorvarmi = Directory.Exists(@"C:\Users\pc\Desktop\elif\Test");
            if (klasorvarmi)
            {
              DialogResult cevap= MessageBox.Show("Oluşturmak istediğiniz klasör sistemde mevcut. Silip yeniden oluşturmak ister misiniz?", "Dosya Mevcut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(cevap==DialogResult.Yes)
                {
                    Directory.Delete(@"C:\Users\pc\Desktop\elif\Test");
                    System.Threading.Thread.Sleep(2000);                  
                    Directory.CreateDirectory(@"C:\Users\pc\Desktop\elif\Test");
                    MessageBox.Show("Klasör oluşturuldu");
                }
            }
            else
            {
               DirectoryInfo DI=Directory.CreateDirectory(@"C:\Users\pc\Desktop\elif\Test");
               if(DI.Exists)    
                 MessageBox.Show("Klasör oluşturuldu");
            }
                

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Directory.Move(@"C:\Users\pc\Desktop\elif\Test", @"C:\Users\pc\source\repos\Test");//Klasör taşınır.(kaynak,hedef)
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream fs = File.Create(@"C:\Users\pc\Desktop\elif\test\\elif.txt");
            fs.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
           bool dosyavar=File.Exists(@"C:\Users\pc\Desktop\elif\test\\elif.txt");//Dosya var mı?

           if(dosyavar)
             File.Delete(@"C:\Users\pc\Desktop\elif\test\elif.txt");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            File.Move(@"C:\Users\pc\Desktop\elif\test\elif.txt", @"C:\Users\pc\source\repos\Test\xx.txt");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string metin = File.ReadAllText(@"C:\Users\pc\source\repos\Test\xx.txt");
            lbl_metin.Text = metin;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            File.AppendAllText(@"C:\Users\pc\source\repos\Test\xx.txt", " deneme deneme deneme ");
        }
    }
}

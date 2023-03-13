using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOrnek_01112022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach (Control item in this.Controls)
            // {
            //     MessageBox.Show(item.Name);
            // }
        }

        private void formindextemizle()
        {
            //txt_email.Text = string.Empty;
            this.Controls["txt_email"].Text = string.Empty;
            this.Controls["txt_isim"].Text = string.Empty;
            this.Controls["txt_soyisim"].Text = string.Empty;
            this.Controls["txt_telefon"].Text = string.Empty;
        }

        private void formtemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }
        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Form elemanlarını temizlemek istediğinize emin misiniz?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                //formindextemizle();
                formtemizle();
            }

        }

        private void btn_onizleme_Click(object sender, EventArgs e)
        {
            OnizlemeForm frmonizleme=new OnizlemeForm();

            frmonizleme.Controls["txt_isim"].Text = txt_isim.Text;
            frmonizleme.Controls["txt_soyisim"].Text = txt_soyisim.Text;
            frmonizleme.Controls["txt_email"].Text = txt_email.Text;
            frmonizleme.Controls["txt_telefon"].Text = txt_telefon.Text;

            frmonizleme.ShowDialog();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            int sonuc=sanalDatabase.KisiEkle(new Kisi() { email = txt_email.Text, isim = txt_isim.Text, soyisim = txt_soyisim.Text, telefon = txt_telefon.Text });

            if (sonuc > 0)
            {
                DialogResult cevap = MessageBox.Show("Kayıt ekleme işlemi başarılı. Devam etmek ister misiniz?", "Kayıt Sonuç", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    bildirimcubugu = new NotifyIcon();
                    bildirimcubugu.BalloonTipText = "Toplam kayıt sayısı:" + sanalDatabase.liste.Count();
                    bildirimcubugu.BalloonTipTitle = "Kayıt sayısı";
                    bildirimcubugu.Visible = true;
                    bildirimcubugu.Icon = SystemIcons.Information;
                    bildirimcubugu.ShowBalloonTip(2000);
                }
            }
        }
    }
}

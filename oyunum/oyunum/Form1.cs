using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyunum
{
    public partial class Form1 : Form
    {
        private string username;
        private int score;
        public Form1(string username=null, int score=0,bool kazanma_durumu=false)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            if (username != null)
            {
                this.username = username;
                this.score = score;
                if (kazanma_durumu)
                {
                    Kazanmak.Text = "Tebrikler";
                    Sonuc.Text = char.ToUpper(username[0]) + username.Substring(1).ToLower() + " \n Skorun : " + score.ToString();
                }
                else
                {
                    Kazanmak.Text = "Kaybettiniz";
                    Sonuc.Text = char.ToUpper(username[0]) + username.Substring(1).ToLower() + " \n Skorun : " + score.ToString();
                }
                NameText.MaxLength = 12;
                NameText.Text = username;
                Sonuc.Visible = true;
            }
            else
            {
                Sonuc.Text = string.Empty;
                Sonuc.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Basla_Click(object sender, EventArgs e)
        {
            string toplammetin = string.Empty;
            int mayin_sayisi = 0;
            string isim = NameText.Text;
            if (string.IsNullOrEmpty(isim))
            {
                MessageBox.Show("Lütfen isim alanını doldurun.");
            }
            else {
                if (SecimKolay.Checked || SecimOrta.Checked || SecimZor.Checked)
                {
                    string zorlukSeviyesi;
                    if (SecimKolay.Checked)
                    {
                        zorlukSeviyesi = "Zorluk Kolay";
                        mayin_sayisi = 10;
                        toplammetin += zorlukSeviyesi;
                        MessageBox.Show(toplammetin);

                        Gamescreen1 oyun = new Gamescreen1(isim, mayin_sayisi, new Size(500, 400), new Size(800, 600));
                        oyun.Show();
                        this.Hide();
                    }
                    else if (SecimOrta.Checked)
                    {
                        zorlukSeviyesi = "Zorluk Orta";
                        mayin_sayisi = 50; 
                        toplammetin += zorlukSeviyesi;
                        MessageBox.Show(toplammetin);

                        Gamescreen1 oyun = new Gamescreen1(isim, mayin_sayisi, new Size(600, 400), new Size(900, 600));
                        oyun.Show();
                        this.Hide();
                    }
                    else
                    {
                        zorlukSeviyesi = "Zorluk Zor";
                        mayin_sayisi = 300;
                        toplammetin += zorlukSeviyesi;
                        MessageBox.Show(toplammetin);

                        Gamescreen1 oyun = new Gamescreen1(isim, mayin_sayisi, new Size(900, 600), new Size(1000, 700));
                        oyun.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Zorluk seviyesini seçiniz. ");

                }
            }
        }
        
        private void SecimZor_Click(object sender, EventArgs e)
        {
            string isim = NameText.Text;
            if (string.IsNullOrEmpty(isim))
            {
                MessageBox.Show("Lütfen isim alanını doldurun.");
            }
            else
            {
                Sonuc.Visible = true;
                Sonuc.Text = "Selam "+ NameText.Text;
            }
           
        }

        private void SecimOrta_Click(object sender, EventArgs e)
        {
            string isim = NameText.Text;
            if (string.IsNullOrEmpty(isim))
            {
                MessageBox.Show("Lütfen isim alanını doldurun.");
            }
            else
            {
                Sonuc.Visible = true;
                Sonuc.Text = "Selam " + NameText.Text;
            }
        }

        private void SecimKolay_Click(object sender, EventArgs e)
        {
            string isim = NameText.Text;
            if (string.IsNullOrEmpty(isim))
            {
                MessageBox.Show("Lütfen isim alanını doldurun.");
            }
            else
            {
                Sonuc.Visible = true;
                Sonuc.Text = "Selam " + NameText.Text;
            }
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecimOrta_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

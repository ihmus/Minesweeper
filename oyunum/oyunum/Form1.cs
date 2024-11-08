using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oyunum
{
    public partial class Form1 : Form
    {
        private string username;
        private int score;
        private const int MaxLength = 2;
        private int tarlaboyutu;


        public Form1(string username = null, int score = 0, bool kazanma_durumu = false)
        {
            InitializeComponent();
            this.textBox1.KeyDown += new KeyEventHandler(textBox1_KeyDown);
            this.textBox1.GotFocus += new EventHandler(textBoxValue_GotFocus);
            this.textBox2.KeyDown += new KeyEventHandler(textBox2_KeyDown); // textBox2 için KeyDown olayı eklendi
            this.MaximizeBox = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Text = "Demirhan Adıgüzel";

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
            else
            {
                // Zorluk seviyesi seçim ve oyun başlatma kodları burada olacak
            }
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecimOrta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            string isim = NameText.Text;
            if (string.IsNullOrEmpty(isim))
            {
                MessageBox.Show("Lütfen isim alanını doldurun.");
                NameText.Focus();
            }
            else
            {
                Sonuc.Visible = true;
                Sonuc.Text = "Selam " + NameText.Text;
            }
        }

        private void textBoxValue_GotFocus(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > MaxLength)
            {
                textBox1.Clear();
                MessageBox.Show("Metin çok uzun olduğu için temizlendi.");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter tuşuna basıldığında yapılacak işlemler
                int minValue = 10;  // Minimum sınır
                int maxValue = 30;  // Maksimum sınır

                int userInput;
                bool isValid = int.TryParse(textBox1.Text, out userInput);

                if (isValid && userInput >= minValue && userInput <= maxValue)
                {
                    tarlaboyutu = userInput * userInput;
                    textBox2.Focus();
                }
                else
                {
                    MessageBox.Show($"Lütfen {minValue} ile {maxValue} arasında bir değer giriniz.");
                    textBox1.Clear();
                    textBox1.Focus();
                }

                e.Handled = true;  // Enter tuşunun varsayılan işlevini devre dışı bırakır
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter tuşuna basıldığında yapılacak işlemler
                int minValue = 10;  // Minimum sınır

                // Önce tarlaboyutu'nu textBox1'den al
                bool isTarlaboyutuValid = int.TryParse(textBox1.Text, out tarlaboyutu);

                if (!isTarlaboyutuValid)
                {
                    MessageBox.Show("Lütfen geçerli bir tarla boyutu girin.");
                    textBox1.Clear();
                    textBox1.Focus();
                    return;
                }

                int maxValue = tarlaboyutu;  // Maksimum sınır

                int userInput;
                bool isValid = int.TryParse(textBox2.Text, out userInput);  // Burada textBox2 kullanılmalı

                if (isValid && userInput >= minValue && userInput < maxValue*maxValue)
                {
                    string toplammetin = string.Empty;
                    string isim = NameText.Text;
                    if (string.IsNullOrEmpty(isim))
                    {
                        MessageBox.Show("Lütfen isim alanını doldurun.");
                    }
                    int boyut = (int)Math.Sqrt(tarlaboyutu);
                    Gamescreen1 oyun = new Gamescreen1(isim, userInput, new Size(tarlaboyutu*20,tarlaboyutu*20), new Size(800, 600));
                    oyun.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Lütfen {minValue} ile {maxValue*maxValue-1} arasında bir değer giriniz.");
                    textBox2.Clear();
                    textBox2.Focus();
                }

                e.Handled = true;  // Enter tuşunun varsayılan işlevini devre dışı bırakır
                e.SuppressKeyPress = true;
            }
        }

        private void skorpagebutton_Click(object sender, EventArgs e)
        {
            skorboard skor = new skorboard();
            skor.Show();
        }
    }
}

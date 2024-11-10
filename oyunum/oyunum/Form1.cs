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
        private const int MaxLength = 2;
        private const int mintarlaboyutu = 10; // Minimum sınır
        private const int maxtarlaboyutu = 30; // Maksimum sınır
        private bool gameStarted = false; // Oyun başladı mı kontrolü için bir bayrak
        private skorboard SkorSayfasi; private bool sonucsayfasiaktiflik = false;

        public Form1(string username = null, int score = 0, bool kazanma_durumu = false)
        {
            InitializeComponent();
            this.textBox1.KeyDown += new KeyEventHandler(textBox1_KeyDown);
            this.textBox1.GotFocus += new EventHandler(textBoxValue_GotFocus);
            this.textBox2.KeyDown += new KeyEventHandler(textBox2_KeyDown);
            this.MaximizeBox = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            this.Text = "Demirhan Adıgüzel";

            if (!string.IsNullOrEmpty(username))
            {
                // Kullanıcı adı ve skor ayarlamaları
                this.username = username;
                this.score = score;
                Kazanmak.Text = kazanma_durumu ? "Tebrikler" : "Kaybettiniz";
                Sonuc.Text = $"{char.ToUpper(username[0])}{username.Substring(1).ToLower()} \n Skorun : {score}";
                NameText.MaxLength = 12;
                NameText.Text = username;
                Sonuc.Visible = true;
            }
            else
            {
                // Sonuç mesajını gizler
                Sonuc.Text = string.Empty;
                Sonuc.Visible = false;
            }
        }

        private void Basla_Click(object sender, EventArgs e)
        {
            StartGame(); // Oyunu başlatma işlevi çağrılır
        }

        private void StartGame()
        {
            if (gameStarted) return; // Eğer oyun zaten başladıysa işlemi durdurur

            if (string.IsNullOrEmpty(NameText.Text))
            {
                MessageBox.Show("Lütfen isim alanını doldurun.");
                return;
            }
            bool isInteger = int.TryParse(NameText.Text, out int result);
            if (isInteger)
            {
                MessageBox.Show("Lütfen isim alanına integer değer girmeyin");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int tarlaboyutu) || !int.TryParse(textBox2.Text, out int mayinmiktari))
            {
                MessageBox.Show("Lütfen geçerli sayılar girin.");
                return;
            }

            if (tarlaboyutu < mintarlaboyutu || tarlaboyutu > maxtarlaboyutu || mayinmiktari < 10 || mayinmiktari >= tarlaboyutu * tarlaboyutu)
            {
                MessageBox.Show($"Lütfen {mintarlaboyutu} ile {maxtarlaboyutu} arasında bir tarla boyutu ve geçerli bir mayın miktarı giriniz.");
                return;
            }

            // Oyun ekranını oluştur ve göster
            Gamescreen1 oyun = new Gamescreen1(NameText.Text, mayinmiktari, new Size(tarlaboyutu * 20, tarlaboyutu * 20), new Size(1000, 800));
            oyun.Show();
            this.Hide(); // Ana formu gizle
            gameStarted = true; // Oyun başladığını işaretle
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameText.Text))
            {
                MessageBox.Show("Lütfen isim alanını doldurun.");
                NameText.Focus();
            }
            bool isInteger = int.TryParse(NameText.Text, out int result);
            if (isInteger)
            {
                MessageBox.Show("Lütfen isim alanına integer değer girmeyin");
                NameText.Clear();
                NameText.Focus();
                return;
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
                if (int.TryParse(textBox1.Text, out int userInput) && userInput >= mintarlaboyutu && userInput <= maxtarlaboyutu)
                {
                    textBox2.Focus(); // Geçerli giriş ise textBox2'ye odaklan
                }
                else
                {
                    MessageBox.Show($"Lütfen {mintarlaboyutu} ile {maxtarlaboyutu} arasında bir değer giriniz.");
                    textBox1.Clear();
                    textBox1.Focus();
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartGame(); // Oyunu başlatma işlevi çağrılır

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void skorpagebutton_Click(object sender, EventArgs e)
        {

            if (sonucsayfasiaktiflik)
            {
                SkorSayfasi.Close();
                SkorSayfasi.Dispose(); // Nesneyi tamamen imha et
                SkorSayfasi = null; // Referansı temizle
                sonucsayfasiaktiflik = false;
                skorpagebutton.Text = "Skorlar";
            }
            else
            {
                if (SkorSayfasi == null || SkorSayfasi.IsDisposed) // Nesnenin durumu kontrol ediliyor
                {
                    SkorSayfasi = new skorboard();
                    SkorSayfasi.StartPosition = FormStartPosition.Manual;
                    SkorSayfasi.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                }

                SkorSayfasi.Show(); // Skor ekranını göster
                sonucsayfasiaktiflik = true;
                skorpagebutton.Text = "Kapat";
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Uygulamayı kapat
        }

        private void NameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(NameText.Text))
                {
                    MessageBox.Show("Lütfen isim alanını doldurun.");
                }
                bool isInteger = int.TryParse(NameText.Text, out int result);
                if (isInteger)
                {
                    MessageBox.Show("Lütfen isim alanına integer değer girmeyin");
                    NameText.Clear();
                    NameText.Focus();
                    return;
                }
                else
                {
                    textBox1.Focus(); // Geçerli giriş ise textBox1'e odaklan
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        
    }
}

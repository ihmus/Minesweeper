﻿using System;
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
    public partial class Gamescreen1 : Form
    {
        private string username;
        private int number_of_mine;
        private Mayin_tarlasi mayin_tarlamiz;
        private Image mayinresmi = global::oyunum.Resources.naval_mine;
        private List<Mayin> mayinlarimiz;
        private int skor;
        private int toplamButonSayisi = 0;
        private int basilanButonSayisi = 0;
        private Size TarlaBoyutu;
        public Gamescreen1(string isim,int numberofmine,Size tarlaboyutu,Size Pencere)
        {
            username = isim;
            number_of_mine=numberofmine;
            TarlaBoyutu = tarlaboyutu;
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            this.Size = new Size(Pencere.Width, Pencere.Height);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gamescreen1_FormClosing);
            location_of_button(Pencere.Width - 70, 10);

        }

        private void Gamescreen1_Load(object sender, EventArgs e)
        {
            mayin_tarlamiz = new Mayin_tarlasi(new Size(TarlaBoyutu.Width, TarlaBoyutu.Height), number_of_mine);
            toplamButonSayisi = (int)(Math.Floor((double)mayin_tarlamiz.buyuklugu.Width / 20) * Math.Floor((double)mayin_tarlamiz.buyuklugu.Height / 20));
            panel1.Size = mayin_tarlamiz.buyuklugu;
            Mayin_ekle();
            //Showed_allbomb();
        }
        private void location_of_button(int x, int y)
        {

            backbutton.Size = new Size(50, 20);

            backbutton.Location = new Point(x, y);
        }
        public void Mayin_ekle()
        {
            for (int x = 0; x < panel1.Width; x = x + 20)
            {
                for (int y = 0; y < panel1.Height; y = y + 20)
                {
                    Point button_location = new Point(x, y);
                    add_button(button_location);
                }
            }
        }
        private void skor_ekle()
        {
            if (number_of_mine < 50)
            {
                skor += 10;
            }
            else if (number_of_mine < 70)
            {
                skor += 20;
            }
            else
            {
                skor += 30;
            }
        }

        public void add_button(Point button_location)
        {
            Button btn = new Button();
            btn.Name =  button_location.X + "" + button_location.Y;
            btn.Size = new Size(20, 20);
            btn.MouseDown += btn_MouseDown;
            btn.Location = button_location;
            btn.Click += new EventHandler(btn_Click);
            panel1.Controls.Add(btn);
        }

        public void btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            Mayin myn = mayin_tarlamiz.mayin_al_loc(btn.Location);
            mayinlarimiz = new List<Mayin>();
            if (myn.istherebomb)
            {
                Showed_allbomb();
                MessageBox.Show($"Kaybettiniz \n {toplamButonSayisi } - {basilanButonSayisi}={toplamButonSayisi-basilanButonSayisi}");
                Form1 oyunsonu = new Form1(username, skor,false) ;
                oyunsonu.Show();
                this.Hide();

            }
            else {
                int s= etrafta_kac_mayin_var(myn);
                if (s == 0) {
                    basilanButonSayisi++;
                    skor_ekle();
                    mayinlarimiz.Add(myn);
                    for (int i = 0; i < mayinlarimiz.Count; i++)
                    {
                        Mayin item = mayinlarimiz[i];
                        if (!item.bakildi_)
                        {
                            Button btnx = (Button)panel1.Controls.Find(item.get_Bomblocation.X + "" + item.get_Bomblocation.Y, false)[0];
                            if (etrafta_kac_mayin_var(mayinlarimiz[i]) == 0)
                            {
                                btnx.Enabled = false;
                                item.bakildi_ = true;
                                add_arround_emty_button(item);
                            }
                            else
                            {
                                btnx.Text=etrafta_kac_mayin_var(item).ToString();
                                btnx.Enabled = false;
                                btnx.Focus();
                            }
                        }
                    }
                }
                else
                {
                    btn.Text = s.ToString();
                    btn.Enabled = false;
                    skor_ekle();
                    basilanButonSayisi++;
                    btn.Focus();
                    if (toplamButonSayisi - number_of_mine == basilanButonSayisi)
                    {
                        MessageBox.Show($"Tebrikler, kazandınız! Skorunuz: {skor}");
                        Form1 oyunsonu = new Form1(username, skor,true);
                        oyunsonu.Show();
                        this.Hide();

                    }
                }
            }

        }
        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (e.Button == MouseButtons.Right)
            {
                if (btn.Text == "🚩")
                {
                    btn.Text = string.Empty;
                    btn.Click += btn_Click;
                }
                else
                {
                    btn.Text = "🚩";
                    btn.Click -= btn_Click;
                }
            }
        }


        public void add_arround_emty_button(Mayin m)
        {
            List<Point> offsets = new List<Point>
            {
                new Point(-20, 0),  
                new Point(20, 0),
                new Point(0, -20),
                new Point(0, 20)
            };

            foreach (var offset in offsets)
            {
                Point newPoint = new Point(m.get_Bomblocation.X + offset.X, m.get_Bomblocation.Y + offset.Y);
     
                if (newPoint.X >= 0 && newPoint.X <= panel1.Width - 20 && newPoint.Y >= 0 && newPoint.Y <= panel1.Height - 20)
                {
                    Mayin yeniMayin = mayin_tarlamiz.mayin_al_loc(newPoint);
                    if (!yeniMayin.istherebomb && !mayinlarimiz.Contains(yeniMayin))
                    {
                        mayinlarimiz.Add(yeniMayin);

                        Button btn = (Button)panel1.Controls.Find(newPoint.X + "" + newPoint.Y, false)[0];
                        if (btn.Enabled) 
                        {
                            int etraftakiMayinSayisi = etrafta_kac_mayin_var(yeniMayin);
                            if (etraftakiMayinSayisi > 0)
                            {
                                btn.Text = etraftakiMayinSayisi.ToString();
                                btn.Enabled = false;  
                            }
                            skor_ekle();
                            basilanButonSayisi++;
                            if (toplamButonSayisi - number_of_mine == basilanButonSayisi)
                            {
                                MessageBox.Show($"Tebrikler, kazandınız! Skorunuz: {skor}");
                                Form1 oyunsonu = new Form1(username, skor,true);
                                oyunsonu.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }
        }


        public int etrafta_kac_mayin_var(Mayin b)
        {
            int etraftakiBombaSayisi = 0;
            List<Point> offsets = new List<Point>
            {
                new Point(-20, -20),
                new Point(-20, 0),
                new Point(20, 0),
                new Point(-20, 20),
                new Point(0, -20),
                new Point(20, -20),
                new Point(0, 20),
                new Point(20, 20)
            };

            foreach (var offset in offsets)
            {
                Point newPoint = new Point(b.get_Bomblocation.X + offset.X, b.get_Bomblocation.Y + offset.Y);
                // Panel sınırlarının içinde mi
                if (newPoint.X >= 0 && newPoint.X < panel1.Width && newPoint.Y >= 0 && newPoint.Y < panel1.Height)
                {
                    if (mayin_tarlamiz.mayin_al_loc(newPoint).istherebomb)
                    {
                        etraftakiBombaSayisi++;
                    }
                }
            }

            return etraftakiBombaSayisi;

        }
        public void Showed_allbomb()
        {
            foreach (Mayin item in mayin_tarlamiz.getallbomb)
            {
                if (item.istherebomb)
                {
                    Button btn = (Button) panel1.Controls.Find(item.get_Bomblocation.X + "" + item.get_Bomblocation.Y,false)[0];
                    btn.Image = mayinresmi;
                    btn.BackgroundImageLayout=ImageLayout.Stretch;
                }

            }
        }
        private void Gamescreen1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 oyunsonu = new Form1();
            oyunsonu.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
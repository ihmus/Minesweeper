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
    public partial class Loadingscreen : Form
    {
        public Loadingscreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; 
            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = global::oyunum.Resources.Giris;
            pictureBox.Size = this.ClientSize;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BackColor = Color.Transparent;

            this.Controls.Add(pictureBox);
        }
        int loadingcounter = 0;
        private void Loadingscreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loadingcounter != 75)
            {
                loadingcounter++;
            }
            else
            {
                Form1 startscreen = new Form1();
                timer1.Stop();
                startscreen.Show();
                this.Hide();
            }
        }
    }
}

namespace oyunum
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.Sonuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Basla = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Kazanmak = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.skorpagebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(57, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tarla Boyutu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(45, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Adınız :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.MidnightBlue;
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameText.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.NameText.Location = new System.Drawing.Point(61, 239);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(251, 22);
            this.NameText.TabIndex = 10;
            this.NameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameText_KeyDown);
            // 
            // Sonuc
            // 
            this.Sonuc.BackColor = System.Drawing.Color.Transparent;
            this.Sonuc.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sonuc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sonuc.Location = new System.Drawing.Point(64, 89);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(251, 56);
            this.Sonuc.TabIndex = 13;
            this.Sonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 47);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mayın Tarlası";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Basla
            // 
            this.Basla.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Basla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Basla.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Basla.Location = new System.Drawing.Point(103, 412);
            this.Basla.Name = "Basla";
            this.Basla.Size = new System.Drawing.Size(171, 33);
            this.Basla.TabIndex = 11;
            this.Basla.Text = "Başla";
            this.Basla.UseVisualStyleBackColor = false;
            this.Basla.Click += new System.EventHandler(this.Basla_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Kazanmak
            // 
            this.Kazanmak.BackColor = System.Drawing.Color.Transparent;
            this.Kazanmak.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kazanmak.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Kazanmak.Location = new System.Drawing.Point(61, 145);
            this.Kazanmak.Name = "Kazanmak";
            this.Kazanmak.Size = new System.Drawing.Size(251, 39);
            this.Kazanmak.TabIndex = 20;
            this.Kazanmak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(61, 327);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 22);
            this.textBox1.TabIndex = 21;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(205, 327);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 22);
            this.textBox2.TabIndex = 23;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(201, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mayın Sayısı:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skorpagebutton
            // 
            this.skorpagebutton.BackColor = System.Drawing.Color.MidnightBlue;
            this.skorpagebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skorpagebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skorpagebutton.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorpagebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skorpagebutton.Location = new System.Drawing.Point(306, -1);
            this.skorpagebutton.Name = "skorpagebutton";
            this.skorpagebutton.Size = new System.Drawing.Size(75, 29);
            this.skorpagebutton.TabIndex = 24;
            this.skorpagebutton.Text = "Skorlar";
            this.skorpagebutton.UseVisualStyleBackColor = false;
            this.skorpagebutton.Click += new System.EventHandler(this.skorpagebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oyunum.Resources.MD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 460);
            this.Controls.Add(this.skorpagebutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Kazanmak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Basla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label Sonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Basla;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Kazanmak;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button skorpagebutton;
    }
}


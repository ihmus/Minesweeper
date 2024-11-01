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
            this.SecimZor = new System.Windows.Forms.RadioButton();
            this.SecimOrta = new System.Windows.Forms.RadioButton();
            this.SecimKolay = new System.Windows.Forms.RadioButton();
            this.NameText = new System.Windows.Forms.TextBox();
            this.Sonuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Basla = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Kazanmak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(60, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Zorluk :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(60, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Adınız :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecimZor
            // 
            this.SecimZor.AutoSize = true;
            this.SecimZor.BackColor = System.Drawing.Color.Transparent;
            this.SecimZor.ForeColor = System.Drawing.SystemColors.Control;
            this.SecimZor.Location = new System.Drawing.Point(64, 317);
            this.SecimZor.Name = "SecimZor";
            this.SecimZor.Size = new System.Drawing.Size(48, 20);
            this.SecimZor.TabIndex = 16;
            this.SecimZor.TabStop = true;
            this.SecimZor.Text = "Zor";
            this.SecimZor.UseVisualStyleBackColor = false;
            this.SecimZor.Click += new System.EventHandler(this.SecimZor_Click);
            // 
            // SecimOrta
            // 
            this.SecimOrta.AutoSize = true;
            this.SecimOrta.BackColor = System.Drawing.Color.Transparent;
            this.SecimOrta.ForeColor = System.Drawing.SystemColors.Control;
            this.SecimOrta.Location = new System.Drawing.Point(158, 317);
            this.SecimOrta.Name = "SecimOrta";
            this.SecimOrta.Size = new System.Drawing.Size(53, 20);
            this.SecimOrta.TabIndex = 15;
            this.SecimOrta.TabStop = true;
            this.SecimOrta.Text = "Orta";
            this.SecimOrta.UseVisualStyleBackColor = false;
            this.SecimOrta.CheckedChanged += new System.EventHandler(this.SecimOrta_CheckedChanged);
            this.SecimOrta.Click += new System.EventHandler(this.SecimOrta_Click);
            // 
            // SecimKolay
            // 
            this.SecimKolay.AutoSize = true;
            this.SecimKolay.BackColor = System.Drawing.Color.Transparent;
            this.SecimKolay.ForeColor = System.Drawing.SystemColors.Control;
            this.SecimKolay.Location = new System.Drawing.Point(253, 317);
            this.SecimKolay.Name = "SecimKolay";
            this.SecimKolay.Size = new System.Drawing.Size(62, 20);
            this.SecimKolay.TabIndex = 14;
            this.SecimKolay.TabStop = true;
            this.SecimKolay.Text = "Kolay";
            this.SecimKolay.UseVisualStyleBackColor = false;
            this.SecimKolay.Click += new System.EventHandler(this.SecimKolay_Click);
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.MidnightBlue;
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameText.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.NameText.Location = new System.Drawing.Point(64, 250);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(251, 22);
            this.NameText.TabIndex = 10;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // Sonuc
            // 
            this.Sonuc.BackColor = System.Drawing.Color.Transparent;
            this.Sonuc.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sonuc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sonuc.Location = new System.Drawing.Point(64, 134);
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
            this.label1.Location = new System.Drawing.Point(64, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 47);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mayın Tarlası";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Basla
            // 
            this.Basla.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Basla.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Basla.Location = new System.Drawing.Point(104, 359);
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
            this.Kazanmak.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kazanmak.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Kazanmak.Location = new System.Drawing.Point(64, 88);
            this.Kazanmak.Name = "Kazanmak";
            this.Kazanmak.Size = new System.Drawing.Size(251, 39);
            this.Kazanmak.TabIndex = 20;
            this.Kazanmak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oyunum.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.Kazanmak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SecimZor);
            this.Controls.Add(this.SecimOrta);
            this.Controls.Add(this.SecimKolay);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Basla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayın Tarlası";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton SecimZor;
        private System.Windows.Forms.RadioButton SecimOrta;
        private System.Windows.Forms.RadioButton SecimKolay;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label Sonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Basla;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Kazanmak;
    }
}


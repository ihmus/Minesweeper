namespace oyunum
{
    partial class Gamescreen1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.MineCountLabel = new System.Windows.Forms.Label();
            this.SayacLabel = new System.Windows.Forms.Label();
            this.MayinsayisiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Transparent;
            this.backbutton.BackgroundImage = global::oyunum.Resources.Gamebackground;
            this.backbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbutton.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backbutton.Location = new System.Drawing.Point(680, 12);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(76, 23);
            this.backbutton.TabIndex = 0;
            this.backbutton.Text = "Geri";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 260);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.TimerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimerLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TimerLabel.Location = new System.Drawing.Point(334, 14);
            this.TimerLabel.MinimumSize = new System.Drawing.Size(35, 35);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(35, 35);
            this.TimerLabel.TabIndex = 2;
            // 
            // MineCountLabel
            // 
            this.MineCountLabel.AutoSize = true;
            this.MineCountLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.MineCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MineCountLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.MineCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MineCountLabel.Location = new System.Drawing.Point(572, 12);
            this.MineCountLabel.MinimumSize = new System.Drawing.Size(35, 35);
            this.MineCountLabel.Name = "MineCountLabel";
            this.MineCountLabel.Size = new System.Drawing.Size(35, 35);
            this.MineCountLabel.TabIndex = 3;
            // 
            // SayacLabel
            // 
            this.SayacLabel.BackColor = System.Drawing.Color.Transparent;
            this.SayacLabel.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SayacLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SayacLabel.Location = new System.Drawing.Point(252, 25);
            this.SayacLabel.Name = "SayacLabel";
            this.SayacLabel.Size = new System.Drawing.Size(78, 20);
            this.SayacLabel.TabIndex = 18;
            this.SayacLabel.Text = "Sayaç :";
            this.SayacLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MayinsayisiLabel
            // 
            this.MayinsayisiLabel.BackColor = System.Drawing.Color.Transparent;
            this.MayinsayisiLabel.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayinsayisiLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MayinsayisiLabel.Location = new System.Drawing.Point(404, 23);
            this.MayinsayisiLabel.Name = "MayinsayisiLabel";
            this.MayinsayisiLabel.Size = new System.Drawing.Size(164, 20);
            this.MayinsayisiLabel.TabIndex = 19;
            this.MayinsayisiLabel.Text = "Kalan Adımlar :";
            this.MayinsayisiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gamescreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oyunum.Resources.Gamebackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 549);
            this.Controls.Add(this.MayinsayisiLabel);
            this.Controls.Add(this.SayacLabel);
            this.Controls.Add(this.MineCountLabel);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backbutton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Gamescreen1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gamescreen1";
            this.Load += new System.EventHandler(this.Gamescreen1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label MineCountLabel;
        private System.Windows.Forms.Label SayacLabel;
        private System.Windows.Forms.Label MayinsayisiLabel;
    }
}
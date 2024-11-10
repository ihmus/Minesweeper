using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace oyunum
{
    public partial class skorboard : Form
    {
        private List<PlayerScore> playerScores;
        private string csvFilePath;

        public skorboard()
        {
            InitializeComponent();
            InitializePlayerScores();
            DisplayPlayerScores();

            // Üst kenar çubuğunu kaldır
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Formun boyutunu sabitle
            this.Size = new Size(200, 300);
        }

        private void InitializePlayerScores()
        {
            playerScores = new List<PlayerScore>();
            csvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "skorlar.csv");

            try
            {
                if (!File.Exists(csvFilePath))
                {
                    MessageBox.Show("Skor dosyası bulunamadı.");
                    return;
                }

                var lines = File.ReadAllLines(csvFilePath);

                if (lines.Length == 0)
                {
                    MessageBox.Show("Skor dosyası boş.");
                    return;
                }

                foreach (var line in lines.Skip(1))  // İlk satır başlık olduğu için atlanıyor
                {
                    var values = line.Split(',');

                    if (values.Length < 2)
                    {
                        MessageBox.Show("Geçersiz veri formatı: " + line);
                        continue;
                    }

                    if (int.TryParse(values[1], out int score))
                    {
                        playerScores.Add(new PlayerScore(values[0], score));
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz skor verisi: " + values[1]);
                    }
                }

                // En yüksek 10 skoru al
                playerScores = playerScores.OrderByDescending(s => s.Score).Take(10).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void DisplayPlayerScores()
        {
            // Create and configure the label
            Label label = new Label
            {
                Text = "10 İyi Oyuncu",
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };

            this.Controls.Add(label);
            label.Dock = DockStyle.Top;
            // Create and configure the panel
            Panel panel = new Panel
            {
                Dock = DockStyle.Fill, // Fill the remaining space below the label
                Padding = new Padding(0, 35, 0, 0) // Add a top padding to ensure some space between the label and the panel
            };

            this.Controls.Add(panel);

            // Create and configure the DataGridView
            DataGridView dataGridView = new DataGridView
            {
                DataSource = playerScores,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Dock = DockStyle.Fill,
                ScrollBars = ScrollBars.Vertical
            };

            // Add the DataGridView to the panel
            panel.Controls.Add(dataGridView);

            // Adjust row heights to fit the panel
            AdjustRowHeights(dataGridView);
        }

        private void AdjustRowHeights(DataGridView dataGridView)
        {
            int totalHeight = this.ClientSize.Height;
            int rowCount = dataGridView.RowCount;

            if (rowCount > 0)
            {
                int rowHeight = totalHeight / rowCount;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    row.Height = rowHeight;
                }
            }
        }
    }

    public class PlayerScore
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public PlayerScore(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}

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
        }

        private void InitializePlayerScores()
        {
            playerScores = new List<PlayerScore>();
            csvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "skorlar.csv");
            

            try
            {
                var lines = File.ReadAllLines(csvFilePath);

                foreach (var line in lines.Skip(1))  // İlk satır başlık olduğu için atlanıyor
                {
                    var values = line.Split(',');
                    playerScores.Add(new PlayerScore(values[0], Convert.ToInt32(values[1])));
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
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.DataSource = playerScores;
            this.Controls.Add(dataGridView);

            this.Text = "Son 10 Oyuncunun Skorları";
            this.Size = new Size(400, 300);
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

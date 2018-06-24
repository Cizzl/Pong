using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Pong
{
    public partial class StartSite : Form
    {
        public StartSite()
        {
            InitializeComponent();
            ReadStats();
            if (HighscoreList.Count != 0)
            {
                foreach (string item in HighscoreList)
                {
                    highscoreList.Items.Add(item);
                }
            }
        }

        private void ReadStats()
        {
            if (File.Exists("stats.json") && HighscoreList.Count == 0)
            {
                HighscoreList.AddRange(JsonConvert.DeserializeObject<string[]>(File.ReadAllText("stats.json", Encoding.UTF8)));
            }
        }

        public static int ChooseRoundsValue { get; set; }
        public static string P1NameText { get; set; }
        public static string P2NameText { get; set; }
        public static bool IsP1Name { get; set; }
        public static bool IsP2Name { get; set; }
        public static List<string> HighscoreList { get; set; } = new List<string>();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(P1Name.Text))
            {
                P1NameText = P1Name.Text;
                IsP1Name = true;
            }

            if (!string.IsNullOrWhiteSpace(P2Name.Text))
            {
                P2NameText = P2Name.Text;
                IsP2Name = true;
            }

            ChooseRoundsValue = (int)ChooseRounds.Value;
            GamePong p = new GamePong();
            p.Show();
            Visible = false;
        }
    }
}
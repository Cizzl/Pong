using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Pong
{
    public partial class GameOverSite : Form
    {
        public GameOverSite()
        {
            InitializeComponent();

            StartSite.P1NameText = StartSite.IsP1Name ? StartSite.P1NameText :"Spieler 1";
            StartSite.P2NameText = StartSite.IsP2Name ? StartSite.P2NameText : "Spieler 2";

            if (GamePong.LastGoalBy.ToString() == GamePong.LastGoal.PlayerOne.ToString())
            {
                WonText.Text = $"{StartSite.P2NameText} hat das Spiel gewonnen!";
            }
            else
            {
                WonText.Text = $"{StartSite.P1NameText} hat das Spiel gewonnen!";
            }

            PlayerOne.Text = GamePong.P1ScoreInt.ToString();
            PlayerTwo.Text = GamePong.P2ScoreInt.ToString();

            AddToHighscoreList();
        }

        private void AddToHighscoreList()
        {
            StartSite.HighscoreList.Add($"{StartSite.P1NameText} {PlayerTwo.Text}:{PlayerOne.Text} {StartSite.P2NameText}");

            SaveStats();
        }

        private void SaveStats() => File.WriteAllText("stats.json", JsonConvert.SerializeObject(StartSite.HighscoreList, Formatting.Indented), Encoding.UTF8);
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GamePong.P1ScoreInt = 0;
            GamePong.P2ScoreInt = 0;
            StartSite s = new StartSite();
            s.Show();
            Visible = false;
        }
    }
}
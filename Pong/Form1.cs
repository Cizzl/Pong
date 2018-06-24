using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pong
{
    public partial class GamePong : Form
    {
        private int PlayerSpeed = 5;

        private int p1Vel;
        private int p2Vel;

        private int BVelX = 5;
        private int BVelY = 5;

        public static int P1ScoreInt { get; set; }
        public static int P2ScoreInt { get; set; }

        private bool IsPause = false;
        private bool IsScored = false;

        public enum LastGoal
        {
            None,
            PlayerOne,
            PlayerTwo
        }

        public static LastGoal LastGoalBy = LastGoal.None;

        public GamePong()
        {
            InitializeComponent();

            Rectangle ballR = new Rectangle(Width / 2, Height / 2, 20, 20);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                p1Vel = 0;
                if (IsScored && LastGoalBy.HasFlag(LastGoal.PlayerTwo))
                {
                    IsPause = !IsPause;
                    IsScored = false;
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                p1Vel = 0;
                if (IsScored && LastGoalBy.HasFlag(LastGoal.PlayerTwo))
                {
                    IsPause = !IsPause;
                    IsScored = false;
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                p2Vel = 0;
                if (IsScored && LastGoalBy.HasFlag(LastGoal.PlayerOne))
                {
                    IsPause = !IsPause;
                    IsScored = false;
                }
            }
            else if (e.KeyCode == Keys.A)
            {
                p2Vel = 0;
                if (IsScored && LastGoalBy.HasFlag(LastGoal.PlayerOne))
                {
                    IsPause = !IsPause;
                    IsScored = false;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                IsPause = !IsPause;
                PauseBox.Visible = IsPause;
                BackColor = IsPause ? Color.LightGray : Color.White;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                p1Vel = PlayerSpeed;
            }
            else if (e.KeyCode == Keys.Left)
            {
                p1Vel = -PlayerSpeed;
            }
            else if (e.KeyCode == Keys.D)
            {
                p2Vel = PlayerSpeed;
            }
            else if (e.KeyCode == Keys.A)
            {
                p2Vel = -PlayerSpeed;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ball.Location.Y < 0)
            {
                P1ScoreInt++;
                LastGoalBy = LastGoal.PlayerOne;
                p1.Location = new Point((Width / 2) - (p1.Width / 2), p1.Location.Y);
                p2.Location = new Point((Width / 2) - (p2.Width / 2), p2.Location.Y);
                ball.Location = new Point((Width / 2) - (ball.Width / 2), p2.Location.Y + ball.Height);
                IsScored = true;
            }

            if (ball.Location.Y > Height - p2.Height)
            {
                P2ScoreInt++;
                LastGoalBy = LastGoal.PlayerTwo;
                p1.Location = new Point((Width / 2) - (p1.Width / 2), p1.Location.Y);
                p2.Location = new Point((Width / 2) - (p2.Width / 2), p2.Location.Y);
                ball.Location = new Point((Width / 2) - (ball.Width / 2), p1.Location.Y - ball.Height - 3);
                IsScored = true;
            }

            if (ball.Location.X > p1.Location.X && ball.Location.X + ball.Width < p1.Location.X + p1.Width && ball.Location.Y + ball.Height > p1.Location.Y || ball.Location.X > p2.Location.X && ball.Location.X + ball.Width < p2.Location.X + p2.Width && ball.Location.Y < p2.Location.Y + p2.Height)
                BVelY *= -1;

            if (p1.Location.X < 0)
                p1.Location = new Point(0, p1.Location.Y);

            if (p2.Location.X < 0)
                p2.Location = new Point(0, p2.Location.Y);

            if (p1.Location.X + p1.Width > Width)
                p1.Location = new Point(Width - p1.Width, p1.Location.Y);

            if (p2.Location.X + p1.Width > Width)
                p2.Location = new Point(Width - p2.Width, p2.Location.Y);

            if (ball.Location.X < 0)
                BVelX *= -1;

            if (ball.Location.X + ball.Width > Width)
                BVelX *= -1;

            if (!IsPause)
            {
                ball.Location = new Point(ball.Location.X + BVelX, ball.Location.Y + BVelY);
                p1.Location = new Point(p1.Location.X + p1Vel, p1.Location.Y);
                p2.Location = new Point(p2.Location.X + p2Vel, p2.Location.Y);
            }

            if (IsScored)
            {
                p1Score.Text = P1ScoreInt.ToString();
                p2Score.Text = P2ScoreInt.ToString();
                IsPause = true;

                if (P1ScoreInt == StartSite.ChooseRoundsValue || P2ScoreInt == StartSite.ChooseRoundsValue)
                {
                    GameOverSite go = new GameOverSite();
                    go.Show();
                    Visible = false;
                    IsScored = false;
                }
            }
        }
    }
}
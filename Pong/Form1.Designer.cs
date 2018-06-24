namespace Pong
{
    partial class GamePong
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.p1Score = new System.Windows.Forms.Label();
            this.p2Score = new System.Windows.Forms.Label();
            this.PauseBox = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PauseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            this.SuspendLayout();
            // 
            // p1Score
            // 
            this.p1Score.AutoSize = true;
            this.p1Score.Font = new System.Drawing.Font("Pixel Calculon", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Score.Location = new System.Drawing.Point(12, 600);
            this.p1Score.Name = "p1Score";
            this.p1Score.Size = new System.Drawing.Size(26, 24);
            this.p1Score.TabIndex = 4;
            this.p1Score.Text = "0";
            // 
            // p2Score
            // 
            this.p2Score.AutoSize = true;
            this.p2Score.Font = new System.Drawing.Font("Pixel Calculon", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Score.Location = new System.Drawing.Point(12, 40);
            this.p2Score.Name = "p2Score";
            this.p2Score.Size = new System.Drawing.Size(26, 24);
            this.p2Score.TabIndex = 5;
            this.p2Score.Text = "0";
            // 
            // PauseBox
            // 
            this.PauseBox.BackColor = System.Drawing.Color.Transparent;
            this.PauseBox.BackgroundImage = global::Pong.Properties.Resources.baseline_pause_black_48dp;
            this.PauseBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PauseBox.Location = new System.Drawing.Point(125, 250);
            this.PauseBox.Name = "PauseBox";
            this.PauseBox.Size = new System.Drawing.Size(120, 124);
            this.PauseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PauseBox.TabIndex = 8;
            this.PauseBox.TabStop = false;
            this.PauseBox.Visible = false;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.DimGray;
            this.p1.Location = new System.Drawing.Point(150, 635);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(75, 15);
            this.p1.TabIndex = 2;
            this.p1.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.Location = new System.Drawing.Point(175, 300);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.DimGray;
            this.p2.Location = new System.Drawing.Point(150, 15);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(75, 15);
            this.p2.TabIndex = 0;
            this.p2.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // GamePong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.PauseBox);
            this.Controls.Add(this.p2Score);
            this.Controls.Add(this.p1Score);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.p2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GamePong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PauseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label p1Score;
        private System.Windows.Forms.Label p2Score;
        private System.Windows.Forms.PictureBox PauseBox;
        private System.Windows.Forms.Timer Timer;
    }
}


namespace Pong
{
    partial class GameOverSite
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
            this.WonText = new System.Windows.Forms.Label();
            this.PlayerOne = new System.Windows.Forms.Label();
            this.PlayerTwo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WonText
            // 
            this.WonText.Font = new System.Drawing.Font("Pixel Calculon", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WonText.Location = new System.Drawing.Point(12, 9);
            this.WonText.Name = "WonText";
            this.WonText.Size = new System.Drawing.Size(360, 96);
            this.WonText.TabIndex = 0;
            this.WonText.Text = "S";
            // 
            // PlayerOne
            // 
            this.PlayerOne.Font = new System.Drawing.Font("Pixel Calculon", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerOne.Location = new System.Drawing.Point(208, 171);
            this.PlayerOne.Name = "PlayerOne";
            this.PlayerOne.Size = new System.Drawing.Size(80, 80);
            this.PlayerOne.TabIndex = 2;
            this.PlayerOne.Text = "S";
            // 
            // PlayerTwo
            // 
            this.PlayerTwo.Font = new System.Drawing.Font("Pixel Calculon", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTwo.Location = new System.Drawing.Point(74, 171);
            this.PlayerTwo.Name = "PlayerTwo";
            this.PlayerTwo.Size = new System.Drawing.Size(80, 80);
            this.PlayerTwo.TabIndex = 3;
            this.PlayerTwo.Text = "S";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Pixel Calculon", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 80);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pong.Properties.Resources.baseline_home_black_48dp;
            this.pictureBox1.Location = new System.Drawing.Point(12, 553);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GameOverSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlayerTwo);
            this.Controls.Add(this.PlayerOne);
            this.Controls.Add(this.WonText);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Pixel Calculon", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameOverSite";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WonText;
        private System.Windows.Forms.Label PlayerOne;
        private System.Windows.Forms.Label PlayerTwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
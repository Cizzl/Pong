namespace Pong
{
    partial class StartSite
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChooseRounds = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.P1Name = new System.Windows.Forms.TextBox();
            this.P2Name = new System.Windows.Forms.TextBox();
            this.P1Label = new System.Windows.Forms.Label();
            this.P2Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.highscoreList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseRounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pixel Calculon", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "PONG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pixel Calculon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ziel:";
            // 
            // ChooseRounds
            // 
            this.ChooseRounds.Location = new System.Drawing.Point(283, 32);
            this.ChooseRounds.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.ChooseRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChooseRounds.Name = "ChooseRounds";
            this.ChooseRounds.Size = new System.Drawing.Size(73, 20);
            this.ChooseRounds.TabIndex = 2;
            this.ChooseRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pong.Properties.Resources.baseline_play_arrow_black_48dp;
            this.pictureBox1.Location = new System.Drawing.Point(138, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // P1Name
            // 
            this.P1Name.Location = new System.Drawing.Point(111, 211);
            this.P1Name.Name = "P1Name";
            this.P1Name.Size = new System.Drawing.Size(247, 20);
            this.P1Name.TabIndex = 4;
            // 
            // P2Name
            // 
            this.P2Name.Location = new System.Drawing.Point(111, 245);
            this.P2Name.Name = "P2Name";
            this.P2Name.Size = new System.Drawing.Size(247, 20);
            this.P2Name.TabIndex = 5;
            // 
            // P1Label
            // 
            this.P1Label.AutoSize = true;
            this.P1Label.Location = new System.Drawing.Point(12, 214);
            this.P1Label.Name = "P1Label";
            this.P1Label.Size = new System.Drawing.Size(82, 13);
            this.P1Label.TabIndex = 6;
            this.P1Label.Text = "Spieler 1 Name:";
            // 
            // P2Label
            // 
            this.P2Label.AutoSize = true;
            this.P2Label.Location = new System.Drawing.Point(12, 248);
            this.P2Label.Name = "P2Label";
            this.P2Label.Size = new System.Drawing.Size(82, 13);
            this.P2Label.TabIndex = 7;
            this.P2Label.Text = "Spieler 2 Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Spieler 2 spielt unten!";
            // 
            // highscoreList
            // 
            this.highscoreList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.highscoreList.Font = new System.Drawing.Font("Pixel Calculon", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreList.FormattingEnabled = true;
            this.highscoreList.ItemHeight = 19;
            this.highscoreList.Location = new System.Drawing.Point(0, 334);
            this.highscoreList.Name = "highscoreList";
            this.highscoreList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.highscoreList.Size = new System.Drawing.Size(384, 327);
            this.highscoreList.Sorted = true;
            this.highscoreList.TabIndex = 9;
            // 
            // StartSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.highscoreList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.P2Label);
            this.Controls.Add(this.P1Label);
            this.Controls.Add(this.P2Name);
            this.Controls.Add(this.P1Name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ChooseRounds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            ((System.ComponentModel.ISupportInitialize)(this.ChooseRounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ChooseRounds;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox P1Name;
        private System.Windows.Forms.TextBox P2Name;
        private System.Windows.Forms.Label P1Label;
        private System.Windows.Forms.Label P2Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox highscoreList;
    }
}
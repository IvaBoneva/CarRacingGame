namespace CarRacingGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            line1 = new PictureBox();
            line2 = new PictureBox();
            line3 = new PictureBox();
            line4 = new PictureBox();
            line5 = new PictureBox();
            line6 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            car = new PictureBox();
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            enemy3 = new PictureBox();
            over = new Label();
            coin1 = new PictureBox();
            coin2 = new PictureBox();
            coin3 = new PictureBox();
            coin4 = new PictureBox();
            score = new Label();
            ((System.ComponentModel.ISupportInitialize)line1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)line2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)line3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)line4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)line5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)line6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin4).BeginInit();
            SuspendLayout();
            // 
            // line1
            // 
            line1.BackColor = Color.White;
            line1.Location = new Point(185, -1);
            line1.Name = "line1";
            line1.Size = new Size(12, 95);
            line1.TabIndex = 0;
            line1.TabStop = false;
            // 
            // line2
            // 
            line2.BackColor = Color.White;
            line2.Location = new Point(185, 115);
            line2.Name = "line2";
            line2.Size = new Size(12, 95);
            line2.TabIndex = 1;
            line2.TabStop = false;
            // 
            // line3
            // 
            line3.BackColor = Color.White;
            line3.Location = new Point(185, 241);
            line3.Name = "line3";
            line3.Size = new Size(12, 95);
            line3.TabIndex = 2;
            line3.TabStop = false;
            // 
            // line4
            // 
            line4.BackColor = Color.White;
            line4.Location = new Point(185, 372);
            line4.Name = "line4";
            line4.Size = new Size(12, 95);
            line4.TabIndex = 3;
            line4.TabStop = false;
            // 
            // line5
            // 
            line5.BackColor = Color.White;
            line5.Location = new Point(-1, -5);
            line5.Name = "line5";
            line5.Size = new Size(10, 472);
            line5.TabIndex = 4;
            line5.TabStop = false;
            // 
            // line6
            // 
            line6.BackColor = Color.White;
            line6.Location = new Point(374, -5);
            line6.Name = "line6";
            line6.Size = new Size(10, 472);
            line6.TabIndex = 5;
            line6.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // car
            // 
            car.BackColor = Color.Transparent;
            car.Image = (Image)resources.GetObject("car.Image");
            car.Location = new Point(46, 281);
            car.Name = "car";
            car.Size = new Size(46, 71);
            car.SizeMode = PictureBoxSizeMode.StretchImage;
            car.TabIndex = 6;
            car.TabStop = false;
            car.Click += car_Click;
            // 
            // enemy1
            // 
            enemy1.BackColor = Color.Transparent;
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(28, 89);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(45, 65);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 7;
            enemy1.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.BackColor = Color.Transparent;
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(238, 46);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(45, 65);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 8;
            enemy2.TabStop = false;
            // 
            // enemy3
            // 
            enemy3.BackColor = Color.Transparent;
            enemy3.Image = (Image)resources.GetObject("enemy3.Image");
            enemy3.Location = new Point(312, 171);
            enemy3.Name = "enemy3";
            enemy3.Size = new Size(45, 65);
            enemy3.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy3.TabIndex = 9;
            enemy3.TabStop = false;
            // 
            // over
            // 
            over.AutoSize = true;
            over.BackColor = Color.Yellow;
            over.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            over.ForeColor = Color.Red;
            over.Location = new Point(95, 115);
            over.Name = "over";
            over.Size = new Size(200, 39);
            over.TabIndex = 10;
            over.Text = "Game Over";
            // 
            // coin1
            // 
            coin1.BackColor = Color.Transparent;
            coin1.Image = (Image)resources.GetObject("coin1.Image");
            coin1.Location = new Point(95, 204);
            coin1.Name = "coin1";
            coin1.Size = new Size(20, 20);
            coin1.SizeMode = PictureBoxSizeMode.StretchImage;
            coin1.TabIndex = 11;
            coin1.TabStop = false;
            // 
            // coin2
            // 
            coin2.BackColor = Color.Transparent;
            coin2.Image = (Image)resources.GetObject("coin2.Image");
            coin2.Location = new Point(95, 32);
            coin2.Name = "coin2";
            coin2.Size = new Size(20, 20);
            coin2.SizeMode = PictureBoxSizeMode.StretchImage;
            coin2.TabIndex = 12;
            coin2.TabStop = false;
            // 
            // coin3
            // 
            coin3.BackColor = Color.Transparent;
            coin3.Image = (Image)resources.GetObject("coin3.Image");
            coin3.Location = new Point(321, 268);
            coin3.Name = "coin3";
            coin3.Size = new Size(20, 20);
            coin3.SizeMode = PictureBoxSizeMode.StretchImage;
            coin3.TabIndex = 13;
            coin3.TabStop = false;
            // 
            // coin4
            // 
            coin4.BackColor = Color.Transparent;
            coin4.Image = (Image)resources.GetObject("coin4.Image");
            coin4.Location = new Point(312, 74);
            coin4.Name = "coin4";
            coin4.Size = new Size(20, 20);
            coin4.SizeMode = PictureBoxSizeMode.StretchImage;
            coin4.TabIndex = 14;
            coin4.TabStop = false;
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            score.ForeColor = Color.Yellow;
            score.Location = new Point(10, -1);
            score.Name = "score";
            score.Size = new Size(105, 25);
            score.TabIndex = 15;
            score.Text = "Coins = 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(382, 453);
            Controls.Add(score);
            Controls.Add(coin4);
            Controls.Add(coin3);
            Controls.Add(coin2);
            Controls.Add(coin1);
            Controls.Add(over);
            Controls.Add(enemy3);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(car);
            Controls.Add(line6);
            Controls.Add(line5);
            Controls.Add(line4);
            Controls.Add(line3);
            Controls.Add(line2);
            Controls.Add(line1);
            Name = "Form1";
            Text = "Car Racing Game";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)line1).EndInit();
            ((System.ComponentModel.ISupportInitialize)line2).EndInit();
            ((System.ComponentModel.ISupportInitialize)line3).EndInit();
            ((System.ComponentModel.ISupportInitialize)line4).EndInit();
            ((System.ComponentModel.ISupportInitialize)line5).EndInit();
            ((System.ComponentModel.ISupportInitialize)line6).EndInit();
            ((System.ComponentModel.ISupportInitialize)car).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox line1;
        private PictureBox line2;
        private PictureBox line3;
        private PictureBox line4;
        private PictureBox line5;
        private PictureBox line6;
        private System.Windows.Forms.Timer timer1;
        private PictureBox car;
        private PictureBox enemy1;
        private PictureBox enemy2;
        private PictureBox enemy3;
        private Label over;
        private PictureBox coin1;
        private PictureBox coin2;
        private PictureBox coin3;
        private PictureBox coin4;
        private Label score;
    }
}

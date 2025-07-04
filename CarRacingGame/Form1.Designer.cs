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
            ((System.ComponentModel.ISupportInitialize)line1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)line2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)line3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)line4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)line5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)line6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car).BeginInit();
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
            car.Image = (Image)resources.GetObject("car.Image");
            car.Location = new Point(46, 281);
            car.Name = "car";
            car.Size = new Size(84, 78);
            car.SizeMode = PictureBoxSizeMode.StretchImage;
            car.TabIndex = 6;
            car.TabStop = false;
            car.Click += car_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(382, 453);
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
            ResumeLayout(false);
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
    }
}

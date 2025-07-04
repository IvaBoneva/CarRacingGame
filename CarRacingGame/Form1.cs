namespace CarRacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLines(gameSpeed);
            moveEnemies(gameSpeed);
        }

        void moveEnemies(int speed)
        {
            PictureBox[] enemies = { enemy1, enemy2, enemy3};


            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i].Top >= 500) enemies[i].Top = 0;
                else enemies[i].Top += speed;
            }
        }

        void moveLines(int speed)
        {
            PictureBox[] lines = { line1, line2, line3, line4, line5, line6 };


            for (int i = 0; i < lines.Length - 2; i++)
            {
                if (lines[i].Top >= 500) lines[i].Top = 0;
                else lines[i].Top += speed;
            }
        }

        private void car_Click(object sender, EventArgs e)
        {

        }

        int gameSpeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if (car.Left > 20) car.Left += - gameSpeed;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (car.Left < 320) car.Left += gameSpeed;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (gameSpeed < 21) gameSpeed++;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (gameSpeed > 0) gameSpeed--;
            }
        }
    }
}

namespace CarRacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLines(gameSpeed);
            moveEnemies(gameSpeed);
            gameOver();
        }

        Random r = new Random();
        int x, y;
        void moveEnemies(int speed)
        {
            PictureBox[] enemies = { enemy1, enemy2, enemy3 };

            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i].Top >= 500)
                {
                    if (i == 0)
                    {
                        x = r.Next(20, 100);
                    }
                    else {
                        x = r.Next(200, 320);
                    }
                    enemies[i].Location = new Point(x, 0);
                }
                else enemies[i].Top += speed;
            }
        }

        void gameOver()
        {
            PictureBox[] enemies = { enemy1, enemy2, enemy3 };

            for (int i = 0; i < enemies.Length; i++)
            {
                if (car.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    timer1.Enabled = false;
                    over.Visible = true;
                }
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
                if (e.KeyCode == Keys.Left)
                {
                    if (car.Left > 20) car.Left += -gameSpeed;
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

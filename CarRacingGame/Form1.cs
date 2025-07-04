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
            moveLines(5);
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                car.Left += 8;
            }
        }
    }
}

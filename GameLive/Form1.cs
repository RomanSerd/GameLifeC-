using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameLive
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        private bool[,] field;
        private bool pause = true;
        int rows;
        int cols;
        public Form1()
        {
            InitializeComponent();
        }
        private void StartGame()
        {
            if (timer1.Enabled)
                return;

            nResolution.Enabled = false;
            nDensity.Enabled = false;

            resolution = (int)nResolution.Value;

            rows = pictureBox1.Height / resolution;
            cols = pictureBox1.Width / resolution;

            field = new bool[cols, rows];
            Random rand = new Random();
            for(int x = 0; x < cols; x++)
            {
                for(int y = 0; y < rows; y++)
                {
                    field[x, y] = rand.Next((int)nDensity.Value) == 0;
                }
            }

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
        }
        private void StopGame()
        {
            if (!timer1.Enabled)
                return;
            timer1.Stop();
            pause = true;
            nResolution.Enabled = true;
            nDensity.Enabled = true;
        }
        private void PauseGame()
        {
            if (!timer1.Enabled && pause)
                return;

            pause = !pause;
            timer1.Enabled = !timer1.Enabled;
        }
        private void NextGeneration()
        {

            bool[,] newField = new bool[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    int neighboursCount = CountNeighbours(x, y);
                    bool HasLive = field[x, y];

                    if (!HasLive && neighboursCount == 3)
                        newField[x, y] = true;
                    else if(HasLive && (neighboursCount <2 || neighboursCount>3))
                        newField[x, y] = false;
                    else
                        newField[x, y] = field[x, y];
                }
            }
            field = newField;
            DrawField();
            
        }
        private void DrawField()
        {
            graphics.Clear(Color.Black);
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if(field[x,y])
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution - 1, resolution - 1);
                }
            }
            pictureBox1.Refresh();
        }
        private int CountNeighbours(int x, int y)
        {
            int Count = 0;
            for(int k = -1; k <2; k++)
            {
                for(int j = -1; j<2; j++)
                {
                    bool isSelfChecking = x+k == x && y+j == y;
                    bool hasLive = field[(cols + x + j)%cols, (rows + y + k) %rows];
                    if (hasLive&& !isSelfChecking)
                        Count++;
                }
            }
            return Count;
        }
        private bool ValidateMousePosition(int x, int y)
        {
            return x > 0 && y > 0 & x < cols && y < rows;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled && pause)
                return;

            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                if (!ValidateMousePosition(x, y))
                    return;
                field[x, y] = true;
            }
            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                if (!ValidateMousePosition(x, y))
                    return;
                field[x, y] = false;
            }
            DrawField();
        }

        private void bPause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }
        private void bStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void bStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }
    }
}

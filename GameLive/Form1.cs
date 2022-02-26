using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameLive
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        private bool pause = true;

        EngineGameLive engine;
        public Form1()
        {
            InitializeComponent();
        }
        private void StartGame()
        {
            if (timer1.Enabled)
                return;

            resolution = (int)nResolution.Value;
            engine = new EngineGameLive(pictureBox1.Height / resolution, pictureBox1.Width / resolution);

            if (cDensity.Checked)
                engine.CreateField((int)nDensity.Value);
            else
                engine.CreateNullField();

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();


            nResolution.Enabled = false;
            nDensity.Enabled = false;
            cDensity.Enabled = false;
        }
        private void StopGame()
        {
            if (!timer1.Enabled)
                return;
            timer1.Stop();
            pause = true;
            nResolution.Enabled = true;
            nDensity.Enabled = true;
            cDensity.Enabled = true;
        }
        private void PauseGame()
        {
            if (!timer1.Enabled && pause)
                return;

            pause = !pause;
            timer1.Enabled = !timer1.Enabled;
        }
        private void DrawField()
        {
            graphics.Clear(Color.Black);
            bool[,] field = engine.GetField();
   
            for (int x = 0; x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    if(field[x,y])
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution - 1, resolution - 1);
                }
            }
            pictureBox1.Refresh();
        }
        private bool ValidateMousePosition(int x, int y)
        {
            return x > 0 && y > 0 & x < pictureBox1.Width / resolution && y < pictureBox1.Height / resolution;
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
                engine.ChangeCell(x, y, true);
            }
            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                if (!ValidateMousePosition(x, y))
                    return;
                engine.ChangeCell(x, y, false);
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
            engine.NextGeneration();
            DrawField();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            engine.CreateNullField();
            DrawField();
        }
        private void cDensity_CheckedChanged(object sender, EventArgs e)
        {
            nDensity.Enabled = cDensity.Checked;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = ParseDecimalOfSecond(numericUpDown3.Value);
        }
        private int ParseDecimalOfSecond(decimal D)
        {
            return (int)(D * 1000);
        }
    }
}

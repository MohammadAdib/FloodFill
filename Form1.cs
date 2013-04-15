using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Flood_Fill
{
    public partial class Form1 : Form
    {
        Bitmap image;
        int x, y, count;
        Color[,] pixels = new Color[232,232];
        bool slowMo; int limit = 200;
        bool A, B, C, D, TERMINATE;

        public Form1()
        {
            InitializeComponent();
            slowMo = SmCheckBox.Checked;
            image = (Bitmap)Panel.BackgroundImage;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    pixels[i,j] = image.GetPixel(i,j);
                }
            }
        }

        private void MousePressed(object sender, MouseEventArgs e)
        {
            PixelOn(x=e.X, y=e.Y);
            // Begin fill by checking in any direction to get into the recursive loop
            try
            {
                CheckDown();
                Draw();
            }
            catch (StackOverflowException)
            {
                MessageBox.Show("Uh Oh! Stack Overflow :P");
            }
        }

        private void CheckUp()
        {
            PixelOn(x, --y);
            ValidateNextMove();
            while (!TERMINATE)
            {
                if (!C)
                {
                    CheckRight();
                }
                if (!D)
                {
                    CheckLeft();
                }
                if (!A)
                {
                    CheckUp();
                }
                if (!B)
                {
                    CheckDown();
                }
                ValidateNextMove();
            }
            ++y;
        }

        private void CheckDown()
        {            
            PixelOn(x, ++y);
            ValidateNextMove();
            while (!TERMINATE)
            {
                if (!C)
                {
                    CheckRight();
                }
                if (!D)
                {
                    CheckLeft();
                }
                if (!B)
                {
                    CheckDown();
                }
                if (!A)
                {
                    CheckUp();
                }
                ValidateNextMove();
            }
            --y;
        }

        private void CheckLeft()
        {
            PixelOn(--x, y);
            ValidateNextMove();
            while (!TERMINATE)
            {
                if (!A)
                {
                    CheckUp();
                }
                if (!B)
                {
                    CheckDown();
                }                
                if (!D)
                {
                    CheckLeft();
                }
                if (!C)
                {
                    CheckRight();
                }
                ValidateNextMove();
            }
            ++x;
        }

        private void CheckRight()
        {
            PixelOn(++x, y);
            ValidateNextMove();
            while (!TERMINATE)
            {
                if (!B)
                {
                    CheckDown();
                }
                if (!A)
                {
                    CheckUp();
                }                
                if (!C)
                {
                    CheckRight();
                }
                if (!D)
                {
                    CheckLeft();
                }
                ValidateNextMove();
            }
            --x;
        }

        private void ValidateNextMove()
        {
            count++;
            Color a, b, c, d;
            a = pixels[x, y - 1];
            b = pixels[x, y + 1];
            c = pixels[x + 1, y];
            d = pixels[x - 1, y];
            A = (a.R < 200);
            B = (b.R < 200);
            C = (c.R < 200);
            D = (d.R < 200);
            TERMINATE = (A && B && C && D);            
            if (count == limit)
            {
                Draw();
                count = 0;
            }
        }

        private void PixelOn(int X, int Y)
        {
            pixels[X, Y] = Color.Black;            
        }

        private void Draw()
        {
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    if (pixels[i, j].R == 0)
                    {
                        image.SetPixel(i, j, Color.Black);
                    }
                }
            }
            Graphics g = Panel.CreateGraphics();
            g.DrawImage(image, new Point(0,0));
            g.Dispose();
        }

        private void SmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            slowMo = SmCheckBox.Checked;
            if (slowMo) limit = 200; else limit = 0;
        }
    }
}

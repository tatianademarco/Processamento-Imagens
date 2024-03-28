using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessamentodeImagemAula18._03
{
    public partial class Form1 : Form
    {
        private Bitmap originalBitmap;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap contrasteBitmap = AumentarContraste(originalBitmap);

            pictureBox2.Image = contrasteBitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Todos os arquivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                originalBitmap = new Bitmap(imagePath);

                pictureBox1.Image = originalBitmap;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap negativeBitmap = TransformarNegativo(originalBitmap);

            pictureBox2.Image = negativeBitmap;
        }

        private Bitmap TransformarNegativo(Bitmap originalBitmap)
        {
            int width = originalBitmap.Width;
            int height = originalBitmap.Height;

            Bitmap negativeBitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);

                    int invertedR = 255 - originalColor.R;
                    int invertedG = 255 - originalColor.G;
                    int invertedB = 255 - originalColor.B;

                    Color negativeColor = Color.FromArgb(invertedR, invertedG, invertedB);

                    negativeBitmap.SetPixel(x, y, negativeColor);
                }
            }

            return negativeBitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap brilhoBitmap = AumentarBrilho(originalBitmap);

            pictureBox2.Image = brilhoBitmap;
        }

        private Bitmap AumentarBrilho(Bitmap originalBitmap)
        {
            int width = originalBitmap.Width;
            int height = originalBitmap.Height;

            Bitmap brilhoBitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);

                    int brilhoR = originalColor.R + 50;
                    if (brilhoR > 255)
                    {
                        brilhoR = 255;
                    }

                    int brilhoG = originalColor.G + 50;
                    if (brilhoG > 255)
                    {
                        brilhoG = 255;
                    }

                    int brilhoB = originalColor.B + 50;
                    if (brilhoB > 255)
                    {
                        brilhoB = 255;
                    }


                    Color brilhoColor = Color.FromArgb(brilhoR, brilhoG, brilhoB);

                    brilhoBitmap.SetPixel(x, y, brilhoColor);
                }
            }

            return brilhoBitmap;
        }

        private Bitmap AumentarContraste(Bitmap originalBitmap)
        {
            int width = originalBitmap.Width;
            int height = originalBitmap.Height;

            Bitmap brilhoBitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);

                    int brilhoR = originalColor.R - 50;
                    if (brilhoR < 0)
                    {
                        brilhoR = 0;
                    }

                    int brilhoG = originalColor.G - 50;
                    if (brilhoG < 0)
                    {
                        brilhoG = 0;
                    }

                    int brilhoB = originalColor.B - 50;
                    if (brilhoB < 0)
                    {
                        brilhoB = 0;
                    }


                    Color brilhoColor = Color.FromArgb(brilhoR, brilhoG, brilhoB);

                    brilhoBitmap.SetPixel(x, y, brilhoColor);
                }
            }

            return brilhoBitmap;
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace ProcessamentodeImagem
{
    internal class ImagemEditada : Imagem
    {
        public Imagem imagemOriginal1 { get; set; }
        public Imagem imagemOriginal2 { get; set; }

        public ImagemEditada()
        {
        }

        public void SalvarImagem(System.Drawing.Image pictureBoxEditada)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos de imagem|*.png;*.bmp;*.jpg";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;

                pictureBoxEditada.Save(savePath);
            }
        }

        public Bitmap TransformarNegativo()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);

                    int invertedR = 255 - originalColor.R;
                    int invertedG = 255 - originalColor.G;
                    int invertedB = 255 - originalColor.B;

                    Color negativeColor = Color.FromArgb(invertedR, invertedG, invertedB);

                    bitmap.SetPixel(x, y, negativeColor);
                }
            }
            return bitmap;
        }

        public Bitmap AumentarBrilho(int valorBrilho)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);

                    int brilhoR = originalColor.R + valorBrilho;
                    if (brilhoR > 255)
                    {
                        brilhoR = 255;
                    }

                    int brilhoG = originalColor.G + valorBrilho;
                    if (brilhoG > 255)
                    {
                        brilhoG = 255;
                    }

                    int brilhoB = originalColor.B + valorBrilho;
                    if (brilhoB > 255)
                    {
                        brilhoB = 255;
                    }

                    Color brilhoColor = Color.FromArgb(brilhoR, brilhoG, brilhoB);

                    bitmap.SetPixel(x, y, brilhoColor);
                }
            }
            return bitmap;
        }

        public Bitmap AumentarContraste(int valorContraste)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);

                    int contrasteR = originalColor.R - valorContraste;
                    if (contrasteR < 0)
                    {
                        contrasteR = 0;
                    }

                    int contrasteG = originalColor.G - valorContraste;
                    if (contrasteG < 0)
                    {
                        contrasteG = 0;
                    }

                    int contrasteB = originalColor.B - valorContraste;
                    if (contrasteB < 0)
                    {
                        contrasteB = 0;
                    }

                    Color contrasteColor = Color.FromArgb(contrasteR, contrasteG, contrasteB);

                    bitmap.SetPixel(x, y, contrasteColor);
                }
            }

            return bitmap;
        }

        public Bitmap Multiplicar(int valorMultiplicacao)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);

                    int red = originalColor.R * valorMultiplicacao;
                    if (red > 255)
                    {
                        red = 255;
                    }

                    int green = originalColor.G * valorMultiplicacao;
                    if (green > 255)
                    {
                        green = 255;
                    }

                    int blue = originalColor.B * valorMultiplicacao;
                    if (blue > 255)
                    {
                        blue = 255;
                    }

                    Color newColor = Color.FromArgb(red, green, blue);

                    bitmap.SetPixel(x, y, newColor);
                }
            }
            return bitmap;
        }

        public Bitmap Dividir(int valorDivisao)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);

                    int red = originalColor.R / valorDivisao;

                    int green = originalColor.G / valorDivisao;

                    int blue = originalColor.B / valorDivisao;

                    Color newColor = Color.FromArgb(red, green, blue);

                    bitmap.SetPixel(x, y, newColor);
                }
            }
            return bitmap;
        }

        public Bitmap TransformarBinario(Bitmap imagem, int Limiar)
        {
            Bitmap binario = new Bitmap(imagem.Width, imagem.Height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagem.GetPixel(x, y);

                    int escala = (originalColor.R + originalColor.G + originalColor.B) / 3;

                    int binarioR, binarioG, binarioB;

                    if (escala >= Limiar)
                    {
                        escala = 255;
                    }
                    else
                    {
                        escala = 0;
                    }

                    Color binarioColor = Color.FromArgb(escala, escala, escala);

                    binario.SetPixel(x, y, binarioColor);
                }
            }
            return binario;
        }

        public Bitmap FlipImageLR()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);

                    int newX = width - x - 1;

                    bitmap.SetPixel(newX, y, originalColor);
                }
            }
            return bitmap;
        }

        public Bitmap FlipImageUD()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);

                    int newY = height - y - 1;

                    bitmap.SetPixel(x, newY, originalColor);
                }
            }
            return bitmap;
        }

        public Bitmap ConverterCinza()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);

                    int escala = (originalColor.R + originalColor.G + originalColor.B) / 3;

                    Color grayColor = Color.FromArgb(escala, escala, escala);

                    bitmap.SetPixel(x, y, grayColor);
                }
            }
            return bitmap;
        }

        public Bitmap Recortar(int width, int height, int x1, int y1)
        {
            Bitmap recorteBitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x + x1, y + y1);
                    recorteBitmap.SetPixel(x, y, originalColor);
                }
            }
            return recorteBitmap;
        }

        public Bitmap Redimensionar()
        {
            int novaAltura = height;

            float escala = (float)height / imagemOriginal2.height;

            int novaLargura = (int)(imagemOriginal2.width * escala);

            Bitmap bitmapRedimensionado = new Bitmap(novaLargura, novaAltura);

            float escalaX = (float)imagemOriginal2.width / novaLargura;
            float escalaY = (float)imagemOriginal2.height / novaAltura;

            for (int y = 0; y < novaAltura; y++)
            {
                for (int x = 0; x < novaLargura; x++)
                {
                    int originalX = (int)(x * escalaX);
                    int originalY = (int)(y * escalaY);

                    Color originalColor = imagemOriginal2.bitmap.GetPixel(originalX, originalY);

                    bitmapRedimensionado.SetPixel(x, y, originalColor);
                }
            }

            return bitmapRedimensionado;
        }

        public Bitmap Redimensionar2()
        {
            int newWidth = width;
            int newHeight = height;

            Bitmap bitmapRedimensionado = new Bitmap(newWidth, newHeight);

            float escalaX = (float)imagemOriginal2.width / newWidth;
            float escalaY = (float)imagemOriginal2.height / newHeight;

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    int originalX = (int)(x * escalaX);
                    int originalY = (int)(y * escalaY);

                    Color originalColor = imagemOriginal2.bitmap.GetPixel(originalX, originalY);

                    bitmapRedimensionado.SetPixel(x, y, originalColor);
                }
            }

            return bitmapRedimensionado;
        }

        public Bitmap Concatenar()
        {
            Bitmap redimensionado = Redimensionar();

            int newWidth = width + redimensionado.Width;

            Bitmap bitmapConcatenado = new Bitmap(newWidth, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    if (x < width)
                    {
                        Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);
                        bitmapConcatenado.SetPixel(x, y, originalColor);
                    }
                    if (x >= width)
                    {
                        Color originalColor = redimensionado.GetPixel(x - width, y);
                        bitmapConcatenado.SetPixel(x, y, originalColor);
                    }
                }
            }
            return bitmapConcatenado;
        }

        public Bitmap AplicarMedia()
        {
            Bitmap redimensionado = Redimensionar2();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);
                    Color originalColor2 = redimensionado.GetPixel(x, y);

                    int somaR = (originalColor.R + originalColor2.R) / 2;
                    int somaG = (originalColor.G + originalColor2.G) / 2;
                    int somaB = (originalColor.B + originalColor2.B) / 2;

                    Color somaColor = Color.FromArgb(somaR, somaG, somaB);

                    bitmap.SetPixel(x, y, somaColor);
                }
            }
            return bitmap;
        }

        public Bitmap SomarImagens()
        {
            Bitmap redimensionado = Redimensionar2();

            int maiorPixelRed = 0, maiorPixelGreen = 0, maiorPixelBlue = 0;
            int menorPixelRed = 255, menorPixelGreen = 255, menorPixelBlue = 255;
            int somaR = 0, somaG = 0, somaB = 0;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);
                    Color originalColor2 = redimensionado.GetPixel(x, y);

                    somaR = originalColor.R + originalColor2.R;

                    if (somaR > maiorPixelRed)
                    {
                        maiorPixelRed = somaR;
                    } else if (somaR < menorPixelRed)
                    {
                        menorPixelRed = somaR;
                    }

                    somaG = originalColor.G + originalColor2.G;

                    if (somaG > maiorPixelGreen)
                    {
                        maiorPixelGreen = somaG;
                    } else if (somaG < menorPixelGreen)
                    {
                        menorPixelGreen = somaG;
                    }

                    somaB = originalColor.B + originalColor2.B;

                    if (somaB > maiorPixelBlue)
                    {
                        maiorPixelBlue = somaB;
                    } else if (somaB < menorPixelBlue)
                    {
                        menorPixelBlue = somaB;
                    }
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);
                    Color originalColor2 = redimensionado.GetPixel(x, y);

                    somaR = originalColor.R + originalColor2.R;
                    double equacaoR = 255 / ((double)(maiorPixelRed - menorPixelRed)) * (somaR - menorPixelRed);

                    somaG = originalColor.G + originalColor2.G;
                    double equacaoG = 255 / ((double)(maiorPixelGreen - menorPixelGreen)) * (somaG - menorPixelGreen);

                    somaB = originalColor.B + originalColor2.B;
                    double equacaoB = 255 / ((double)(maiorPixelBlue - menorPixelBlue)) * (somaB - menorPixelBlue);

                    int newRed = (int)Math.Floor(equacaoR);
                    int newGreen = (int)Math.Floor(equacaoG);
                    int newBlue = (int)Math.Floor(equacaoB);

                    Color somaColor = Color.FromArgb(newRed, newGreen, newBlue);

                    bitmap.SetPixel(x, y, somaColor);
                }
            }
            return bitmap;
        }

        public Bitmap SubtrairImagens()
        {
            Bitmap redimensionado = Redimensionar2();

            int maiorPixelRed = 0, maiorPixelGreen = 0, maiorPixelBlue = 0;
            int menorPixelRed = 255, menorPixelGreen = 255, menorPixelBlue = 255;
            int subR = 0, subG = 0, subB = 0;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);
                    Color originalColor2 = redimensionado.GetPixel(x, y);

                    subR = originalColor.R - originalColor2.R;

                    if (subR > maiorPixelRed)
                    {
                        maiorPixelRed = subR;
                    }
                    else if (subR < menorPixelRed)
                    {
                        menorPixelRed = subR;
                    }

                    subG = originalColor.G - originalColor2.G;

                    if (subG > maiorPixelGreen)
                    {
                        maiorPixelGreen = subG;
                    }
                    else if (subG < menorPixelGreen)
                    {
                        menorPixelGreen = subG;
                    }

                    subB = originalColor.B - originalColor2.B;

                    if (subB > maiorPixelBlue)
                    {
                        maiorPixelBlue = subB;
                    }
                    else if (subB < menorPixelBlue)
                    {
                        menorPixelBlue = subB;
                    }
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);
                    Color originalColor2 = redimensionado.GetPixel(x, y);

                    subR = originalColor.R - originalColor2.R;
                    double equacaoR = 255 / ((double)(maiorPixelRed - menorPixelRed)) * (subR - menorPixelRed);

                    subG = originalColor.G - originalColor2.G;
                    double equacaoG = 255 / ((double)(maiorPixelGreen - menorPixelGreen)) * (subG - menorPixelGreen);

                    subB = originalColor.B - originalColor2.B;
                    double equacaoB = 255 / ((double)(maiorPixelBlue - menorPixelBlue)) * (subB - menorPixelBlue);

                    int newRed = (int)Math.Floor(equacaoR);
                    int newGreen = (int)Math.Floor(equacaoG);
                    int newBlue = (int)Math.Floor(equacaoB);

                    Color subColor = Color.FromArgb(newRed, newGreen, newBlue);

                    bitmap.SetPixel(x, y, subColor);
                }
            }
            return bitmap;
        }

        public Bitmap AplicarBlending(int taxaMistura)
        {
            Bitmap redimensionado = Redimensionar2();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);
                    Color originalColor2 = redimensionado.GetPixel(x, y);

                    double equacaoR = (double)(taxaMistura) / 100 * originalColor.R + (1 - ((double)(taxaMistura) / 100)) * originalColor2.R;

                    double equacaoG = (double)(taxaMistura) / 100 * originalColor.G + (1 - (double)(taxaMistura) / 100) * originalColor2.G;

                    double equacaoB = (double)(taxaMistura) / 100 * originalColor.B + (1 - (double)(taxaMistura) / 100) * originalColor2.B;

                    int blendingR = (int)Math.Floor(equacaoR);
                    int blendingG = (int)Math.Floor(equacaoG);
                    int blendingB = (int)Math.Floor(equacaoB);

                    Color subColor = Color.FromArgb(blendingR, blendingG, blendingB);

                    bitmap.SetPixel(x, y, subColor);
                }
            }
            return bitmap;
        }

        public (int[], int[], int[]) GerarHistogramaOriginal()
        {
            int[] pixelsR = new int[256];
            int[] pixelsG = new int[256];
            int[] pixelsB = new int[256];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);

                    pixelsR[originalColor.R]++;
                    pixelsG[originalColor.G]++;
                    pixelsB[originalColor.B]++;
                }
            }
            return (pixelsR, pixelsG, pixelsB);
        }

        public Bitmap Equalizar()
        {
            (int[] pixelsR, int[] pixelsG, int[] pixelsB) = this.GerarHistogramaOriginal();
            int[] cfdR = new int[256];
            int[] cfdG = new int[256];
            int[] cfdB = new int[256];

            for (int i = 0; i <= 255; i++)
            {
                if (i == 0)
                {
                    cfdR[i] = pixelsR[i];
                    cfdG[i] = pixelsG[i];
                    cfdB[i] = pixelsB[i];
                } else
                {
                    cfdR[i] = pixelsR[i] + cfdR[i - 1];
                    cfdG[i] = pixelsG[i] + cfdG[i - 1];
                    cfdB[i] = pixelsB[i] + cfdB[i - 1];
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);

                    double equacaoR = (cfdR[originalColor.R] - cfdR[0]) / ((double)(height * width) - cfdR[0]) * (255);
                    double equacaoG = (cfdG[originalColor.G] - cfdG[0]) / ((double)(height * width) - cfdG[0]) * (255);
                    double equacaoB = (cfdB[originalColor.B] - cfdB[0]) / ((double)(height * width) - cfdB[0]) * (255);

                    int equalizadoR = (int)Math.Floor(equacaoR);
                    int equalizadoG = (int)Math.Floor(equacaoG);
                    int equalizadoB = (int)Math.Floor(equacaoB);

                    Color equalizadoColor = Color.FromArgb(equalizadoR, equalizadoG, equalizadoB);

                    bitmap.SetPixel(x, y, equalizadoColor);
                }
            }
            return bitmap;
        }

        public (int[], int[], int[]) GerarHistogramaEqualizado(Bitmap equalizado)
        {
            int[] pixelsR = new int[256];
            int[] pixelsG = new int[256];
            int[] pixelsB = new int[256];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = equalizado.GetPixel(x, y);

                    pixelsR[originalColor.R]++;
                    pixelsG[originalColor.G]++;
                    pixelsB[originalColor.B]++;
                }
            }
            return (pixelsR, pixelsG, pixelsB);
        }

        public Bitmap AplicarAnd() {
            Bitmap binario1 = this.TransformarBinario(imagemOriginal1.bitmap, 128);
            Bitmap redimensionado = Redimensionar2();
            Bitmap binario2 = this.TransformarBinario(redimensionado, 128);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor1 = binario1.GetPixel(x, y);
                    Color originalColor2 = binario2.GetPixel(x, y);
                    int binarioR, binarioG, binarioB;

                    binarioR = (originalColor1.R == 255 && originalColor2.R == 255) ? 255 : 0;
                    binarioG = (originalColor1.G == 255 && originalColor2.G == 255) ? 255 : 0;
                    binarioB = (originalColor1.B == 255 && originalColor2.B == 255) ? 255 : 0;

                    Color binarioColor = Color.FromArgb(binarioR, binarioG, binarioB);

                    bitmap.SetPixel(x, y, binarioColor);
                }
            }
            return bitmap;
        }

        public Bitmap AplicarOr()
        {
            Bitmap binario1 = this.TransformarBinario(imagemOriginal1.bitmap, 128);
            Bitmap redimensionado = Redimensionar2();
            Bitmap binario2 = this.TransformarBinario(redimensionado, 128);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor1 = binario1.GetPixel(x, y);
                    Color originalColor2 = binario2.GetPixel(x, y);
                    int binarioR, binarioG, binarioB;

                    binarioR = (originalColor1.R == 255 || originalColor2.R == 255) ? 255 : 0;
                    binarioG = (originalColor1.G == 255 || originalColor2.G == 255) ? 255 : 0;
                    binarioB = (originalColor1.B == 255 || originalColor2.B == 255) ? 255 : 0;

                    Color binarioColor = Color.FromArgb(binarioR, binarioG, binarioB);

                    bitmap.SetPixel(x, y, binarioColor);
                }
            }
           return bitmap;
        }

        public Bitmap AplicarNot()
        {
            Bitmap binario1 = this.TransformarBinario(imagemOriginal1.bitmap, 128);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor1 = binario1.GetPixel(x, y);

                    int binarioR, binarioG, binarioB;

                    if (originalColor1.R == 255)
                    {
                        binarioR = 0;
                    }
                    else
                    {
                        binarioR = 255;
                    }

                    if (originalColor1.G == 255)
                    {
                        binarioG = 0;
                    }
                    else
                    {
                        binarioG = 255;
                    }

                    if (originalColor1.B == 255)
                    {
                        binarioB = 0;
                    }
                    else
                    {
                        binarioB = 255;
                    }

                    Color binarioColor = Color.FromArgb(binarioR, binarioG, binarioB);

                    bitmap.SetPixel(x, y, binarioColor);
                }
            }
            return bitmap;
        }

        public Bitmap AplicarXor()
        {
            Bitmap binario1 = this.TransformarBinario(imagemOriginal1.bitmap, 128);
            Bitmap redimensionado = Redimensionar2();
            Bitmap binario2 = this.TransformarBinario(redimensionado, 128);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor1 = binario1.GetPixel(x, y);
                    Color originalColor2 = binario2.GetPixel(x, y);
                    int binarioR, binarioG, binarioB;

                    if (originalColor1.R == originalColor2.R)
                    {
                        binarioR = 0;
                    }
                    else
                    {
                        binarioR = 255;
                    }

                    if (originalColor1.G == originalColor2.G)
                    {
                        binarioG = 0;
                    }
                    else
                    {
                        binarioG = 255;
                    }

                    if (originalColor1.B == originalColor2.B)
                    {
                        binarioB = 0;
                    }
                    else
                    {
                        binarioB = 255;
                    }

                    Color binarioColor = Color.FromArgb(binarioR, binarioG, binarioB);

                    bitmap.SetPixel(x, y, binarioColor);
                }
            }
            return bitmap;
        }

        public Bitmap FiltrarMaximo(int sizeKernel)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int maxPixelR = 0;
                    int maxPixelG = 0;
                    int maxPixelB = 0;

                    for (int j = y - (sizeKernel/2); j <= y + (sizeKernel / 2); j++)
                    {
                        for (int i = x - (sizeKernel / 2); i <= x + (sizeKernel / 2); i++)
                        {
                            if (i >= 0 && j >= 0 && j < height && i < width){
                                Color colorPixel = imagemOriginal1.bitmap.GetPixel(i, j);

                                maxPixelR = (colorPixel.R > maxPixelR) ? colorPixel.R : maxPixelR;
                                maxPixelG = (colorPixel.G > maxPixelG) ? colorPixel.G : maxPixelG;
                                maxPixelB = (colorPixel.B > maxPixelB) ? colorPixel.B : maxPixelB;
                            }
                        }
                    }

                    Color maximoColor = Color.FromArgb(maxPixelR, maxPixelG, maxPixelB);

                    bitmap.SetPixel(x, y, maximoColor);
                }
            }
            return bitmap;
        }

        public Bitmap FiltrarMinimo(int sizeKernel)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int minPixelR = 255;
                    int minPixelG = 255;
                    int minPixelB = 255;

                    for (int j = y - (sizeKernel/2); j <= y + sizeKernel/2; j++)
                    {
                        for (int i = x - sizeKernel/2; i <= x + sizeKernel/2; i++)
                        {
                            if (i >= 0 && j >= 0 && j < height && i < width)
                            {
                                Color colorPixel = imagemOriginal1.bitmap.GetPixel(i, j);

                                minPixelR = (colorPixel.R < minPixelR) ? colorPixel.R : minPixelR;
                                minPixelG = (colorPixel.G < minPixelG) ? colorPixel.G : minPixelG;
                                minPixelB = (colorPixel.B < minPixelB) ? colorPixel.B : minPixelB;
                            }
                        }
                    }

                    Color minimoColor = Color.FromArgb(minPixelR, minPixelG, minPixelB);

                    bitmap.SetPixel(x, y, minimoColor);
                }
            }
            return bitmap;
        }

        public Bitmap FiltrarMedia(int sizeKernel)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int meanPixelR, meanPixelG, meanPixelB, somaPixelR=0, somaPixelG=0, somaPixelB=0, totalPixels=0;

                    for (int j = y - sizeKernel/2; j <= y + sizeKernel/2; j++)
                    {
                        for (int i = x - sizeKernel/2; i <= x + sizeKernel/2; i++)
                        {
                            if (i >= 0 && j >= 0 && j < height && i < width)
                            {
                                Color colorPixel = imagemOriginal1.bitmap.GetPixel(i, j);

                                totalPixels++;

                                somaPixelR += colorPixel.R;
                                somaPixelG += +colorPixel.G;
                                somaPixelB += colorPixel.B;
                            }
                        }
                    }
                    meanPixelR = somaPixelR / totalPixels;
                    meanPixelB = somaPixelB / totalPixels;
                    meanPixelG = somaPixelG / totalPixels;

                    Color meanColor = Color.FromArgb(meanPixelR, meanPixelG, meanPixelB);

                    bitmap.SetPixel(x, y, meanColor);
                }
            }
            return bitmap;
        }

        public Bitmap FiltrarMediana(int sizeKernel)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    List<int> pixelsR = new List<int>();
                    List<int> pixelsG = new List<int>();
                    List<int> pixelsB = new List<int>();
                    int medianaR, medianaG, medianaB;

                    for (int j = y - sizeKernel/2; j <= y + sizeKernel/2; j++)
                    {
                        for (int i = x - sizeKernel/2; i <= x + sizeKernel/2; i++)
                        {
                            if (i >= 0 && j >= 0 && j < height && i < width)
                            {
                                Color colorPixel = imagemOriginal1.bitmap.GetPixel(i, j);

                                pixelsR.Add(colorPixel.R);
                                pixelsG.Add(colorPixel.G);
                                pixelsB.Add(colorPixel.B);
                            }
                        }
                    }
                    pixelsR.Sort();
                    pixelsG.Sort();
                    pixelsB.Sort();

                    if (pixelsR.Count % 2 == 1)
                    {
                        medianaR = pixelsR[pixelsR.Count / 2];
                        medianaG = pixelsG[pixelsR.Count / 2];
                        medianaB = pixelsB[pixelsR.Count / 2];
                    }
                    else
                    {
                        medianaR = (pixelsR[pixelsR.Count / 2] + pixelsR[(pixelsR.Count / 2) - 1]) / 2;
                        medianaG = (pixelsG[pixelsR.Count / 2] + pixelsG[(pixelsR.Count / 2) - 1]) / 2;
                        medianaB = (pixelsB[pixelsR.Count / 2] + pixelsB[(pixelsR.Count / 2) - 1]) / 2;
                    }

                    Color medianaColor = Color.FromArgb(medianaR, medianaG, medianaB);

                    bitmap.SetPixel(x, y, medianaColor);
                }
            }
            return bitmap;
        }

        public Bitmap FiltrarOrdem(int ordem, int sizeKernel)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    List<int> pixelsR = new List<int>();
                    List<int> pixelsG = new List<int>();
                    List<int> pixelsB = new List<int>();

                    for (int j = y - sizeKernel/2; j <= y + sizeKernel/2; j++)
                    {
                        for (int i = x - sizeKernel/2; i <= x + sizeKernel/2; i++)
                        {
                            if (i >= 0 && j >= 0 && j < height && i < width)
                            {
                                Color colorPixel = imagemOriginal1.bitmap.GetPixel(i, j);

                                pixelsR.Add(colorPixel.R);
                                pixelsG.Add(colorPixel.G);
                                pixelsB.Add(colorPixel.B);
                            }
                        }
                    }
                    pixelsR.Sort();
                    pixelsG.Sort();
                    pixelsB.Sort();

                    Color ordemColor = Color.FromArgb(pixelsR[(int)(ordem * (double)(pixelsR.Count / (double)(sizeKernel * sizeKernel) - 0.001))], pixelsR[(int)(ordem * (double)(pixelsR.Count / (double)(sizeKernel * sizeKernel) - 0.001))], pixelsR[(int)(ordem * (double)(pixelsR.Count / (double)(sizeKernel * sizeKernel) - 0.001))]);                

                    bitmap.SetPixel(x, y, ordemColor);
                }
            }
            return bitmap;
        }

        public Bitmap FiltrarSuavizacaoConservativa(int sizeKernel)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    List<int> pixelsR = new List<int>();
                    List<int> pixelsG = new List<int>();
                    List<int> pixelsB = new List<int>();

                    for (int j = y - sizeKernel/2; j <= y + sizeKernel/2; j++)
                    {
                        for (int i = x - sizeKernel/2; i <= x + sizeKernel/2; i++)
                        {
                            if (i >= 0 && j >= 0 && j < height && i < width)
                            {
                                Color colorPixel = imagemOriginal1.bitmap.GetPixel(i, j);

                                pixelsR.Add(colorPixel.R);
                                pixelsG.Add(colorPixel.G);
                                pixelsB.Add(colorPixel.B);
                            }
                        }
                    }
                    pixelsR.Sort();
                    pixelsG.Sort();
                    pixelsB.Sort();

                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);

                    int colorR, colorG, colorB;

                    if (pixelsR.Last() == originalColor.R)
                    {
                        colorR = pixelsR[pixelsR.Count - 2];
                    }
                    else if (pixelsR[0] == originalColor.R)
                    {
                        colorR = pixelsR[1];
                    }
                    else
                    {
                        colorR = originalColor.R;
                    }

                    if (pixelsG.Last() == originalColor.G)
                    {
                        colorG = pixelsG[pixelsG.Count - 2];
                    }
                    else if (pixelsG[0] == originalColor.G)
                    {
                        colorG = pixelsG[1];
                    }
                    else
                    {
                        colorG = originalColor.G;
                    }

                    if (pixelsB.Last() == originalColor.B)
                    {
                        colorB = pixelsB[pixelsB.Count - 2];
                    }
                    else if (pixelsB[0] == originalColor.B)
                    {
                        colorB = pixelsB[1];
                    }
                    else
                    {
                        colorB = originalColor.B;
                    }

                    Color suavizadoColor = Color.FromArgb (colorB, colorG, colorB);

                    bitmap.SetPixel(x, y, suavizadoColor);
                }
            }
            return bitmap;
        }

        public double[,] CriarKernelGaussiano(double sigma, int sizeKernel)
        {
            double[,] kernel = new double[sizeKernel, sizeKernel];
            double somaKernel = 0;

            for (int j = 0; j < sizeKernel; j++)
            {
                for (int i = 0; i < sizeKernel; i++)
                {
                    kernel[i, j] = (1.0 / (2.0 * Math.PI * sigma * sigma)) *
                    Math.Exp(-((i - sizeKernel/2) * (i - sizeKernel / 2) + (j - sizeKernel / 2) * (j - sizeKernel / 2)) / (2.0 * sigma * sigma));
                            
                    somaKernel += kernel[i, j];
                }
            }

            for (int i = 0; i < sizeKernel; i++)
            {
                for (int j = 0; j < sizeKernel; j++)
                {
                    kernel[i, j] /= somaKernel;
                }
            }
            return kernel;
        }

        public Bitmap GerarImagemKernelGaussiano(double[,] kernel, int sizeKernel)
        {
            double valorMax = 0;

            for (int j = 0; j < sizeKernel; j++)
            {
                for (int i = 0; i < sizeKernel; i++)
                {
                    valorMax = (kernel[j,i] > valorMax) ? kernel[j, i]: valorMax;
                }
            }

            Bitmap newKernel = new Bitmap(sizeKernel, sizeKernel);

            for (int x = 0; x < sizeKernel; x++)
            {
                for (int y = 0; y < sizeKernel; y++)
                {
                    newKernel.SetPixel(x, y, Color.FromArgb((int)(kernel[x,y]*255/valorMax), (int)(kernel[x, y] * 255 / valorMax), (int)(kernel[x, y] * 255 / valorMax)));
                }
            }

            int newWidth = 100;
            int newHeight = 100;

            Bitmap bitmapRedimensionado = new Bitmap(newWidth, newHeight);

            float escalaX = (float)sizeKernel / newWidth;
            float escalaY = (float)sizeKernel / newHeight;

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    int originalX = (int)(x * escalaX);
                    int originalY = (int)(y * escalaY);

                    Color originalColor = newKernel.GetPixel(originalX, originalY);

                    bitmapRedimensionado.SetPixel(x, y, originalColor);
                }
            }

            return bitmapRedimensionado;
        }

        public Bitmap AplicarFiltroGaussiano(double sigma, int sizeKernel)
        {
            double[,] kernel = this.CriarKernelGaussiano(sigma, sizeKernel);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    double red = 0, green = 0, blue = 0, soma = 0;

                    for (int j = y - (sizeKernel/2); j <= y + (sizeKernel / 2); j++)
                    {
                        for (int i = x - (sizeKernel / 2); i <= x + (sizeKernel / 2); i++)
                        {
                            if (i >= 0 && j >= 0 && j < height && i < width)
                            {
                                Color pixelColor = imagemOriginal1.bitmap.GetPixel(i, j);

                                red += pixelColor.R * kernel[x - i + (sizeKernel / 2), y - j + (sizeKernel / 2)];
                                green += pixelColor.G * kernel[x - i + (sizeKernel / 2), y - j + (sizeKernel / 2)];
                                blue += pixelColor.B * kernel[x - i + (sizeKernel / 2), y - j + (sizeKernel / 2)];
                                soma += kernel[x - i + (sizeKernel / 2), y - j + (sizeKernel / 2)];
                            }
                        }
                    }
                    int newRed = Math.Min(Math.Max((int)(red), 0), 255);
                    int newGreen = Math.Min(Math.Max((int)(green), 0), 255);
                    int newBlue = Math.Min(Math.Max((int)(blue), 0), 255);

                    bitmap.SetPixel(x, y, Color.FromArgb(newRed, newGreen, newBlue));
                }
            }
            return bitmap;
        }

        public Bitmap AplicarFiltroDeteccaoDeBordas(String mascara)
        {
            int[,] filtroX = new int[3, 3];
            int[,] filtroY = new int[3, 3];

            if (mascara == "Prewitt")
            {
                filtroX = new int[,] { { 1, 0, -1 },
                                     { 1, 0, -1 },
                                     { 1, 0, -1 } };

                filtroY = new int[,] { { 1, 1, 1 },
                                     { 0, 0, 0 },
                                     { -1, -1, -1 } };

            } else if (mascara == "Sobel")
            {
                filtroX = new int[,] { { 1, 0, -1 },
                                       { 2, 0, -2 },
                                       { 1, 0, -1 } };

                filtroY = new int[,] { { 1, 2, 1 },
                                       { 0, 0, 0 },
                                       { -1, -2, -1 } };

            } else if (mascara == "Laplaciano")
            {
                filtroX = new int[,] { { 0, 1, 0 },
                                       { 1, -4, 1 },
                                       { 0, 1, 0 } };

                filtroY = new int[,] { { 0, -1, 0 },
                                       { -1, 4, -1 },
                                       { 0, -1, 0 } };
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int gX = 0, gY = 0;

                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        for (int i = x - 1; i <= x + 1; i++)
                        {
                            if (i >= 0 && j >= 0 && j < height && i < width)
                            {
                                Color colorPixel = imagemOriginal1.bitmap.GetPixel(i, j);

                                int escalaCinza = (colorPixel.R + colorPixel.G + colorPixel.B) / 3;

                                gX += escalaCinza * filtroX[i - x + 1, j - y + 1];
                                gY += escalaCinza * filtroY[i - x + 1, j - y + 1];
                            }
                        }
                    }
                    int magnitude = (int)Math.Sqrt(gX * gX + gY * gY);
                    magnitude = Math.Min(Math.Max(magnitude, 0), 255);
                    bitmap.SetPixel(x, y, Color.FromArgb(magnitude, magnitude, magnitude));
                }
            }
            return bitmap;
        }

        public Bitmap AplicarDilatacao(Bitmap imagem)
        {
            Bitmap binario = this.TransformarBinario(imagem, 128);

            int[,] elementoEstruturante = new int[,] { { 0, 1, 0 },
                                                       { 1, 1, 1 },
                                                       { 0, 1, 0 } };

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int newPixel = 0;

                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (newPixel == 255) break;

                        for (int i = x - 1; i <= x + 1; i++)
                        {
                            if (i >= 0 && j >= 0 && j < height && i < width)
                            {
                                Color colorPixel = binario.GetPixel(i, j);

                                if (elementoEstruturante[i - x + 1, j - y + 1] == 1 && colorPixel.R == 255)
                                {
                                    newPixel = 255;

                                    break;

                                } else
                                {
                                    newPixel = 0;
                                }
                            }
                        }
                    }
                    bitmap.SetPixel(x, y, Color.FromArgb(newPixel, newPixel, newPixel));
                }
            }
            return bitmap;
        }

        public Bitmap AplicarErosao(Bitmap imagem)
        {
            Bitmap binario = this.TransformarBinario(imagem, 128);

            Bitmap bitmap2 = new Bitmap(width, height);

            int[,] elementoEstruturante = new int[,] { { 0, 1, 0 },
                                                       { 1, 1, 1 },
                                                       { 0, 1, 0 } };

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int newPixel = 1;

                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (newPixel == 0) break;

                        for (int i = x - 1; i <= x + 1; i++)
                        {
                            if (i >= 0 && j >= 0 && j < height && i < width)
                            {
                                Color colorPixel = binario.GetPixel(i, j);

                                if (elementoEstruturante[i - x + 1, j - y + 1] == 1 && colorPixel.R == 0)
                                {
                                    newPixel = 0;

                                    break;
                                }
                                else
                                {
                                    newPixel = 255;
                                }
                            }
                        }
                    }
                    bitmap2.SetPixel(x, y, Color.FromArgb(newPixel, newPixel, newPixel));
                }
            }
            return bitmap2;
        }

        public Bitmap AplicarAbertura()
        {
            Bitmap bitmapOpen = this.AplicarErosao(imagemOriginal1.bitmap);

            bitmapOpen = this.AplicarDilatacao(bitmapOpen);

            return bitmapOpen;
        }

        public Bitmap AplicarFechamento()
        {
            Bitmap bitmapClosing = this.AplicarDilatacao(imagemOriginal1.bitmap);

            bitmapClosing = this.AplicarErosao(bitmapClosing);

            return bitmapClosing;
        }

        public Bitmap AplicarContorno()
        {
            Bitmap bitmapContorno = this.AplicarErosao(imagemOriginal1.bitmap);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = imagemOriginal1.bitmap.GetPixel(x, y);
                    Color originalColor2 = bitmapContorno.GetPixel(x, y);

                    int subtR = originalColor.R - originalColor2.R;
                    subtR = (subtR < 0) ? 0 : subtR;

                    int subtG = originalColor.G - originalColor2.G;
                    subtG = (subtG < 0) ? 0 : subtG;

                    int subtB = originalColor.B - originalColor2.B;
                    subtB = (subtB < 0) ? 0 : subtB;

                    Color subColor = Color.FromArgb(subtR, subtG, subtB);

                    bitmapContorno.SetPixel(x, y, subColor);
                }
            }
            return bitmapContorno;
        }
    }
}
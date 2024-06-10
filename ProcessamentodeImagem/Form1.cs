using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProcessamentodeImagem
{
    public partial class Form1 : Form
    {
        Imagem imagemOriginal1 = new Imagem();
        Imagem imagemOriginal2 = new Imagem();
        ImagemEditada imagemEditada = new ImagemEditada();

        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarImagemEditada(Bitmap imagemSaida)
        {
            pictureBoxEditada.Image = imagemSaida;
            labelImagemEditada.Text = imagemSaida.Width.ToString() + "x" + imagemSaida.Height.ToString();
            labelImagemEditada.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (imagemOriginal1.CarregarImagem() != null)
            {
                pictureBoxOriginal.Image = imagemOriginal1.bitmap;
                imagemEditada.imagemOriginal1 = imagemOriginal1;
                
                chartOriginal.Series["Red"].Points.Clear();
                chartOriginal.Series["Green"].Points.Clear();
                chartOriginal.Series["Blue"].Points.Clear();
                chartEqual.Series["Red"].Points.Clear();
                chartEqual.Series["Green"].Points.Clear();
                chartEqual.Series["Blue"].Points.Clear();

                pictureBoxEditada.Image = null;
            }

            if (pictureBoxOriginal.Image != null)
            {
                imagemEditada.bitmap = new Bitmap(imagemOriginal1.width, imagemOriginal1.height);
                imagemEditada.width = imagemOriginal1.width;
                imagemEditada.height = imagemOriginal1.height;

                labelTamanhoImagem1.Text = imagemOriginal1.width.ToString() + "x" + imagemOriginal1.height.ToString();
                labelTamanhoImagem1.Visible = true;

                numHorizRecort2.Maximum = imagemOriginal1.width;
                numVertRecorte2.Maximum = imagemOriginal1.height;

                (int[] pixelsR, int[] pixelsG, int[] pixelsB) = imagemEditada.GerarHistogramaOriginal();

                AtualizarGraficoHistograma(chartOriginal, pixelsR, pixelsG, pixelsB);
            }
        }

        private void btnCarregar2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = imagemOriginal2.CarregarImagem();
            imagemEditada.imagemOriginal2 = imagemOriginal2;

            labelTamanhoImagem2.Text = imagemOriginal2.width.ToString() + "x" + imagemOriginal2.height.ToString();
            labelTamanhoImagem2.Visible = true;
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            if (pictureBoxEditada != null)
            {
                imagemEditada.SalvarImagem(pictureBoxEditada.Image);
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.TransformarNegativo());
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AumentarBrilho((int)(numericUDBrilho.Value)));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AumentarContraste((int)(numericUDcontraste.Value)));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bMultiplicacao_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.Multiplicar((int)(nUDMultiplicacao.Value)));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bDivisao_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.Dividir((int)(numUpDDiv.Value)));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.TransformarBinario(imagemOriginal1.bitmap, (int)(numericUpDownLimiar.Value)));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFlipLR_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.FlipImageLR());
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFlipUD_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.FlipImageUD());
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCinza_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.ConverterCinza());
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                int x1 = (int)numHorizRecort1.Value;
                int x2 = (int)numHorizRecort2.Value;
                int y1 = (int)numVertRecorte1.Value;
                int y2 = (int)numVertRecorte2.Value;

                int width = x2 - x1;
                int height = y2 - y1;

                if (width > 0 && height > 0 && imagemOriginal1.width >= x2 && imagemOriginal1.height >= y2)
                {
                    CarregarImagemEditada(imagemEditada.Recortar(width, height, x1, y1));
                }
                else
                {
                    MessageBox.Show("Informe um tamanho válido para recortar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null && imagemOriginal2.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.Concatenar());
            }
            else
            {
                MessageBox.Show("Carregue duas imagens primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null && imagemOriginal2.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.SomarImagens());
            }
            else
            {
                MessageBox.Show("Carregue duas imagens primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubtrairImagens_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null && imagemOriginal2.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.SubtrairImagens());
            }
            else
            {
                MessageBox.Show("Carregue duas imagens primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBlending_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null && imagemOriginal2.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AplicarBlending((int)(nUDBlending.Value)));
            }
            else
            {
                MessageBox.Show("Carregue duas imagens primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEqualizar_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                Bitmap equalizada = imagemEditada.Equalizar();
                CarregarImagemEditada(equalizada);
                
                (int[] pixelsR, int[] pixelsG, int[] pixelsB) = imagemEditada.GerarHistogramaEqualizado(equalizada);

                AtualizarGraficoHistograma(chartEqual, pixelsR, pixelsG, pixelsB);
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AtualizarGraficoHistograma(Chart chart, int[] pixelsR, int[] pixelsG, int[] pixelsB)
        {
            chart.Series["Red"].Points.Clear();
            chart.Series["Green"].Points.Clear();
            chart.Series["Blue"].Points.Clear();
            chart.Series["Red"].Color = Color.FromArgb(128, Color.Red);
            chart.Series["Green"].Color = Color.FromArgb(128, Color.Green);
            chart.Series["Blue"].Color = Color.FromArgb(128, Color.Blue);
            chart.ChartAreas[0].AxisX.Minimum = -1;
            chart.ChartAreas[0].AxisX.Maximum = 255;
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.LabelStyle.IntervalOffset = 1;
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 51;

            for (int i = 0; i <= 255; i++)
            {
                chart.Series["Red"].Points.AddXY(i, pixelsR[i]);
                chart.Series["Green"].Points.AddXY(i, pixelsG[i]);
                chart.Series["Blue"].Points.AddXY(i, pixelsB[i]);
            }
        }

        private void buttonAND_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null && imagemOriginal2.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AplicarAnd());
            }
            else
            {
                MessageBox.Show("Carregue duas imagens primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonOR_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null && imagemOriginal2.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AplicarOr());
            }
            else
            {
                MessageBox.Show("Carregue duas imagens primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonNOT_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null && imagemOriginal2.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AplicarNot());
            }
            else
            {
                MessageBox.Show("Carregue duas imagens primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonXOR_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null && imagemOriginal2.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AplicarXor());
            }
            else
            {
                MessageBox.Show("Carregue duas imagens primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null && imagemOriginal2.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AplicarMedia());
            }
            else
            {
                MessageBox.Show("Carregue duas imagens primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btConMax_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.FiltrarMaximo(trackBarKernel.Value));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btConMin_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.FiltrarMinimo(trackBarKernel.Value));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btConMed_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.FiltrarMedia(trackBarKernel.Value));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMediana_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.FiltrarMediana(trackBarKernel.Value));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOrdem_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.FiltrarOrdem((int)numOrdem.Value, trackBarKernel.Value));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuavConser_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.FiltrarSuavizacaoConservativa(trackBarKernel.Value));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGaussiana_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AplicarFiltroGaussiano((int)desvioPadrao.Value, trackBarKernel.Value));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void trackBarKernel_Scroll(object sender, EventArgs e)
        {
            if (trackBarKernel.Value % 2 == 0) trackBarKernel.Value++;

            numOrdem.Maximum = trackBarKernel.Value * trackBarKernel.Value;

            pBoxKernelGaussiano.Image = imagemEditada.GerarImagemKernelGaussiano(imagemEditada.CriarKernelGaussiano((int)desvioPadrao.Value, trackBarKernel.Value), trackBarKernel.Value);
        }

        private void desvioPadrao_ValueChanged(object sender, EventArgs e)
        {
            pBoxKernelGaussiano.Image = imagemEditada.GerarImagemKernelGaussiano(imagemEditada.CriarKernelGaussiano((int)desvioPadrao.Value, trackBarKernel.Value), trackBarKernel.Value);
        }

        private void bPrewitt_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AplicarFiltroDeteccaoDeBordas(bPrewitt.Text));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bSobel_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AplicarFiltroDeteccaoDeBordas(bSobel.Text));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bLaplaciano_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AplicarFiltroDeteccaoDeBordas(bLaplaciano.Text));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bDilatacao_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AplicarDilatacao(imagemOriginal1.bitmap));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bErosao_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AplicarErosao(imagemOriginal1.bitmap));
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bAbertura_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AplicarAbertura());
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bFechamento_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AplicarFechamento());
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bContorno_Click(object sender, EventArgs e)
        {
            if (imagemOriginal1.bitmap != null)
            {
                CarregarImagemEditada(imagemEditada.AplicarContorno());
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
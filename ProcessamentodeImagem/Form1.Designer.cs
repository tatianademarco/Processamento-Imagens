namespace ProcessamentodeImagem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNegativo = new System.Windows.Forms.Button();
            this.btnBrilho = new System.Windows.Forms.Button();
            this.btnContraste = new System.Windows.Forms.Button();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxEditada = new System.Windows.Forms.PictureBox();
            this.groupBoxOpcoes = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.bPrewitt = new System.Windows.Forms.Button();
            this.bLaplaciano = new System.Windows.Forms.Button();
            this.bSobel = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnCinza = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.btnEqualizar = new System.Windows.Forms.Button();
            this.numericUpDownLimiar = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.bContorno = new System.Windows.Forms.Button();
            this.bFechamento = new System.Windows.Forms.Button();
            this.bErosao = new System.Windows.Forms.Button();
            this.bDilatacao = new System.Windows.Forms.Button();
            this.bAbertura = new System.Windows.Forms.Button();
            this.chartOriginal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbconvolucao = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pBoxKernelGaussiano = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarKernel = new System.Windows.Forms.TrackBar();
            this.desvioPadrao = new System.Windows.Forms.NumericUpDown();
            this.btnSuavConser = new System.Windows.Forms.Button();
            this.numOrdem = new System.Windows.Forms.NumericUpDown();
            this.btnGaussiana = new System.Windows.Forms.Button();
            this.btnOrdem = new System.Windows.Forms.Button();
            this.btnMediana = new System.Windows.Forms.Button();
            this.btConMed = new System.Windows.Forms.Button();
            this.btConMin = new System.Windows.Forms.Button();
            this.btConMax = new System.Windows.Forms.Button();
            this.chartEqual = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupRecorte = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numVertRecorte2 = new System.Windows.Forms.NumericUpDown();
            this.numHorizRecort2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numVertRecorte1 = new System.Windows.Forms.NumericUpDown();
            this.numHorizRecort1 = new System.Windows.Forms.NumericUpDown();
            this.buttonRecorte = new System.Windows.Forms.Button();
            this.gbEfeitos = new System.Windows.Forms.GroupBox();
            this.nUDMultiplicacao = new System.Windows.Forms.NumericUpDown();
            this.bDivisao = new System.Windows.Forms.Button();
            this.numUpDDiv = new System.Windows.Forms.NumericUpDown();
            this.bMultiplicacao = new System.Windows.Forms.Button();
            this.numericUDcontraste = new System.Windows.Forms.NumericUpDown();
            this.numericUDBrilho = new System.Windows.Forms.NumericUpDown();
            this.groupInverter = new System.Windows.Forms.GroupBox();
            this.btnFlipUD = new System.Windows.Forms.Button();
            this.btnFlipLR = new System.Windows.Forms.Button();
            this.groupBoxImg2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonXOR = new System.Windows.Forms.Button();
            this.buttonNOT = new System.Windows.Forms.Button();
            this.buttonOR = new System.Windows.Forms.Button();
            this.buttonAND = new System.Windows.Forms.Button();
            this.btnConcatenar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nUDBlending = new System.Windows.Forms.NumericUpDown();
            this.btnBlending = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnSubtrairImagens = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTamanhoImagem1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelImagemEditada = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelTamanhoImagem2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCarregar2 = new System.Windows.Forms.Button();
            this.SaveImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditada)).BeginInit();
            this.groupBoxOpcoes.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimiar)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOriginal)).BeginInit();
            this.gbconvolucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKernelGaussiano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKernel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desvioPadrao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrdem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEqual)).BeginInit();
            this.groupRecorte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVertRecorte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizRecort2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVertRecorte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizRecort1)).BeginInit();
            this.gbEfeitos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMultiplicacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDcontraste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDBrilho)).BeginInit();
            this.groupInverter.SuspendLayout();
            this.groupBoxImg2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBlending)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(435, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Carregar imagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNegativo
            // 
            this.btnNegativo.Location = new System.Drawing.Point(18, 112);
            this.btnNegativo.Name = "btnNegativo";
            this.btnNegativo.Size = new System.Drawing.Size(125, 44);
            this.btnNegativo.TabIndex = 1;
            this.btnNegativo.Text = "Negativo";
            this.btnNegativo.UseVisualStyleBackColor = true;
            this.btnNegativo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBrilho
            // 
            this.btnBrilho.Location = new System.Drawing.Point(12, 79);
            this.btnBrilho.Name = "btnBrilho";
            this.btnBrilho.Size = new System.Drawing.Size(125, 44);
            this.btnBrilho.TabIndex = 2;
            this.btnBrilho.Text = "Adição";
            this.btnBrilho.UseVisualStyleBackColor = true;
            this.btnBrilho.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnContraste
            // 
            this.btnContraste.Location = new System.Drawing.Point(12, 179);
            this.btnContraste.Name = "btnContraste";
            this.btnContraste.Size = new System.Drawing.Size(125, 44);
            this.btnContraste.TabIndex = 3;
            this.btnContraste.Text = "Subtração";
            this.btnContraste.UseVisualStyleBackColor = true;
            this.btnContraste.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(16, 28);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(574, 335);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 4;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxEditada
            // 
            this.pictureBoxEditada.Location = new System.Drawing.Point(19, 28);
            this.pictureBoxEditada.Name = "pictureBoxEditada";
            this.pictureBoxEditada.Size = new System.Drawing.Size(574, 335);
            this.pictureBoxEditada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEditada.TabIndex = 5;
            this.pictureBoxEditada.TabStop = false;
            // 
            // groupBoxOpcoes
            // 
            this.groupBoxOpcoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxOpcoes.Controls.Add(this.groupBox6);
            this.groupBoxOpcoes.Controls.Add(this.groupBox8);
            this.groupBoxOpcoes.Controls.Add(this.groupBox7);
            this.groupBoxOpcoes.Controls.Add(this.chartOriginal);
            this.groupBoxOpcoes.Controls.Add(this.gbconvolucao);
            this.groupBoxOpcoes.Controls.Add(this.chartEqual);
            this.groupBoxOpcoes.Controls.Add(this.groupRecorte);
            this.groupBoxOpcoes.Controls.Add(this.gbEfeitos);
            this.groupBoxOpcoes.Controls.Add(this.groupInverter);
            this.groupBoxOpcoes.Controls.Add(this.groupBoxImg2);
            this.groupBoxOpcoes.Location = new System.Drawing.Point(-5, 458);
            this.groupBoxOpcoes.Name = "groupBoxOpcoes";
            this.groupBoxOpcoes.Size = new System.Drawing.Size(1926, 495);
            this.groupBoxOpcoes.TabIndex = 6;
            this.groupBoxOpcoes.TabStop = false;
            this.groupBoxOpcoes.Text = "Opções";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bPrewitt);
            this.groupBox6.Controls.Add(this.bLaplaciano);
            this.groupBox6.Controls.Add(this.bSobel);
            this.groupBox6.Location = new System.Drawing.Point(1629, 31);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(277, 145);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Detecção de Bordas";
            // 
            // bPrewitt
            // 
            this.bPrewitt.Location = new System.Drawing.Point(10, 26);
            this.bPrewitt.Name = "bPrewitt";
            this.bPrewitt.Size = new System.Drawing.Size(125, 44);
            this.bPrewitt.TabIndex = 17;
            this.bPrewitt.Text = "Prewitt";
            this.bPrewitt.UseVisualStyleBackColor = true;
            this.bPrewitt.Click += new System.EventHandler(this.bPrewitt_Click);
            // 
            // bLaplaciano
            // 
            this.bLaplaciano.Location = new System.Drawing.Point(10, 84);
            this.bLaplaciano.Name = "bLaplaciano";
            this.bLaplaciano.Size = new System.Drawing.Size(125, 44);
            this.bLaplaciano.TabIndex = 14;
            this.bLaplaciano.Text = "Laplaciano";
            this.bLaplaciano.UseVisualStyleBackColor = true;
            this.bLaplaciano.Click += new System.EventHandler(this.bLaplaciano_Click);
            // 
            // bSobel
            // 
            this.bSobel.Location = new System.Drawing.Point(141, 26);
            this.bSobel.Name = "bSobel";
            this.bSobel.Size = new System.Drawing.Size(125, 44);
            this.bSobel.TabIndex = 19;
            this.bSobel.Text = "Sobel";
            this.bSobel.UseVisualStyleBackColor = true;
            this.bSobel.Click += new System.EventHandler(this.bSobel_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnCinza);
            this.groupBox8.Controls.Add(this.btnBinario);
            this.groupBox8.Controls.Add(this.btnEqualizar);
            this.groupBox8.Controls.Add(this.btnNegativo);
            this.groupBox8.Controls.Add(this.numericUpDownLimiar);
            this.groupBox8.Location = new System.Drawing.Point(182, 31);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(294, 166);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Efeitos";
            // 
            // btnCinza
            // 
            this.btnCinza.Location = new System.Drawing.Point(149, 59);
            this.btnCinza.Name = "btnCinza";
            this.btnCinza.Size = new System.Drawing.Size(125, 44);
            this.btnCinza.TabIndex = 6;
            this.btnCinza.Text = "Cinza";
            this.btnCinza.UseVisualStyleBackColor = true;
            this.btnCinza.Click += new System.EventHandler(this.btnCinza_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(18, 59);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(125, 44);
            this.btnBinario.TabIndex = 10;
            this.btnBinario.Text = "Binário";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // btnEqualizar
            // 
            this.btnEqualizar.Location = new System.Drawing.Point(149, 109);
            this.btnEqualizar.Name = "btnEqualizar";
            this.btnEqualizar.Size = new System.Drawing.Size(125, 44);
            this.btnEqualizar.TabIndex = 11;
            this.btnEqualizar.Text = "Equalizar";
            this.btnEqualizar.UseVisualStyleBackColor = true;
            this.btnEqualizar.Click += new System.EventHandler(this.btnEqualizar_Click);
            // 
            // numericUpDownLimiar
            // 
            this.numericUpDownLimiar.Location = new System.Drawing.Point(29, 33);
            this.numericUpDownLimiar.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownLimiar.Name = "numericUpDownLimiar";
            this.numericUpDownLimiar.Size = new System.Drawing.Size(67, 22);
            this.numericUpDownLimiar.TabIndex = 10;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.bContorno);
            this.groupBox7.Controls.Add(this.bFechamento);
            this.groupBox7.Controls.Add(this.bErosao);
            this.groupBox7.Controls.Add(this.bDilatacao);
            this.groupBox7.Controls.Add(this.bAbertura);
            this.groupBox7.Location = new System.Drawing.Point(1629, 182);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(277, 290);
            this.groupBox7.TabIndex = 26;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Operações Morfológicas";
            // 
            // bContorno
            // 
            this.bContorno.Location = new System.Drawing.Point(80, 228);
            this.bContorno.Name = "bContorno";
            this.bContorno.Size = new System.Drawing.Size(125, 44);
            this.bContorno.TabIndex = 21;
            this.bContorno.Text = "Contorno";
            this.bContorno.UseVisualStyleBackColor = true;
            this.bContorno.Click += new System.EventHandler(this.bContorno_Click);
            // 
            // bFechamento
            // 
            this.bFechamento.Location = new System.Drawing.Point(80, 178);
            this.bFechamento.Name = "bFechamento";
            this.bFechamento.Size = new System.Drawing.Size(125, 44);
            this.bFechamento.TabIndex = 20;
            this.bFechamento.Text = "Fechamento";
            this.bFechamento.UseVisualStyleBackColor = true;
            this.bFechamento.Click += new System.EventHandler(this.bFechamento_Click);
            // 
            // bErosao
            // 
            this.bErosao.Location = new System.Drawing.Point(80, 78);
            this.bErosao.Name = "bErosao";
            this.bErosao.Size = new System.Drawing.Size(125, 44);
            this.bErosao.TabIndex = 19;
            this.bErosao.Text = "Erosão";
            this.bErosao.UseVisualStyleBackColor = true;
            this.bErosao.Click += new System.EventHandler(this.bErosao_Click);
            // 
            // bDilatacao
            // 
            this.bDilatacao.Location = new System.Drawing.Point(80, 28);
            this.bDilatacao.Name = "bDilatacao";
            this.bDilatacao.Size = new System.Drawing.Size(125, 44);
            this.bDilatacao.TabIndex = 17;
            this.bDilatacao.Text = "Dilatação";
            this.bDilatacao.UseVisualStyleBackColor = true;
            this.bDilatacao.Click += new System.EventHandler(this.bDilatacao_Click);
            // 
            // bAbertura
            // 
            this.bAbertura.Location = new System.Drawing.Point(80, 128);
            this.bAbertura.Name = "bAbertura";
            this.bAbertura.Size = new System.Drawing.Size(125, 44);
            this.bAbertura.TabIndex = 14;
            this.bAbertura.Text = "Abertura";
            this.bAbertura.UseVisualStyleBackColor = true;
            this.bAbertura.Click += new System.EventHandler(this.bAbertura_Click);
            // 
            // chartOriginal
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOriginal.ChartAreas.Add(chartArea1);
            this.chartOriginal.Location = new System.Drawing.Point(182, 215);
            this.chartOriginal.Name = "chartOriginal";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Red";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Lime;
            series2.Legend = "Legend1";
            series2.Name = "Green";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Blue";
            this.chartOriginal.Series.Add(series1);
            this.chartOriginal.Series.Add(series2);
            this.chartOriginal.Series.Add(series3);
            this.chartOriginal.Size = new System.Drawing.Size(365, 257);
            this.chartOriginal.TabIndex = 6;
            this.chartOriginal.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Histograma Imagem Original";
            this.chartOriginal.Titles.Add(title1);
            // 
            // gbconvolucao
            // 
            this.gbconvolucao.Controls.Add(this.label9);
            this.gbconvolucao.Controls.Add(this.pBoxKernelGaussiano);
            this.gbconvolucao.Controls.Add(this.label8);
            this.gbconvolucao.Controls.Add(this.label7);
            this.gbconvolucao.Controls.Add(this.label6);
            this.gbconvolucao.Controls.Add(this.label5);
            this.gbconvolucao.Controls.Add(this.trackBarKernel);
            this.gbconvolucao.Controls.Add(this.desvioPadrao);
            this.gbconvolucao.Controls.Add(this.btnSuavConser);
            this.gbconvolucao.Controls.Add(this.numOrdem);
            this.gbconvolucao.Controls.Add(this.btnGaussiana);
            this.gbconvolucao.Controls.Add(this.btnOrdem);
            this.gbconvolucao.Controls.Add(this.btnMediana);
            this.gbconvolucao.Controls.Add(this.btConMed);
            this.gbconvolucao.Controls.Add(this.btConMin);
            this.gbconvolucao.Controls.Add(this.btConMax);
            this.gbconvolucao.Location = new System.Drawing.Point(1284, 31);
            this.gbconvolucao.Name = "gbconvolucao";
            this.gbconvolucao.Size = new System.Drawing.Size(330, 441);
            this.gbconvolucao.TabIndex = 12;
            this.gbconvolucao.TabStop = false;
            this.gbconvolucao.Text = "Convolução";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Kernel Gaussiano:";
            // 
            // pBoxKernelGaussiano
            // 
            this.pBoxKernelGaussiano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxKernelGaussiano.Location = new System.Drawing.Point(171, 169);
            this.pBoxKernelGaussiano.Name = "pBoxKernelGaussiano";
            this.pBoxKernelGaussiano.Size = new System.Drawing.Size(110, 100);
            this.pBoxKernelGaussiano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBoxKernelGaussiano.TabIndex = 25;
            this.pBoxKernelGaussiano.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Tamanho do Kernel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "7x7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "5x5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "3x3";
            // 
            // trackBarKernel
            // 
            this.trackBarKernel.LargeChange = 2;
            this.trackBarKernel.Location = new System.Drawing.Point(37, 70);
            this.trackBarKernel.Maximum = 7;
            this.trackBarKernel.Minimum = 3;
            this.trackBarKernel.Name = "trackBarKernel";
            this.trackBarKernel.Size = new System.Drawing.Size(266, 56);
            this.trackBarKernel.SmallChange = 2;
            this.trackBarKernel.TabIndex = 21;
            this.trackBarKernel.Tag = "";
            this.trackBarKernel.TickFrequency = 2;
            this.trackBarKernel.Value = 3;
            this.trackBarKernel.Scroll += new System.EventHandler(this.trackBarKernel_Scroll);
            // 
            // desvioPadrao
            // 
            this.desvioPadrao.Location = new System.Drawing.Point(214, 301);
            this.desvioPadrao.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.desvioPadrao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.desvioPadrao.Name = "desvioPadrao";
            this.desvioPadrao.Size = new System.Drawing.Size(67, 22);
            this.desvioPadrao.TabIndex = 20;
            this.desvioPadrao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.desvioPadrao.ValueChanged += new System.EventHandler(this.desvioPadrao_ValueChanged);
            // 
            // btnSuavConser
            // 
            this.btnSuavConser.Location = new System.Drawing.Point(188, 379);
            this.btnSuavConser.Name = "btnSuavConser";
            this.btnSuavConser.Size = new System.Drawing.Size(125, 44);
            this.btnSuavConser.TabIndex = 18;
            this.btnSuavConser.Text = "Suavização Conservativa";
            this.btnSuavConser.UseVisualStyleBackColor = true;
            this.btnSuavConser.Click += new System.EventHandler(this.btnSuavConser_Click);
            // 
            // numOrdem
            // 
            this.numOrdem.Location = new System.Drawing.Point(37, 151);
            this.numOrdem.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numOrdem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOrdem.Name = "numOrdem";
            this.numOrdem.Size = new System.Drawing.Size(67, 22);
            this.numOrdem.TabIndex = 13;
            this.numOrdem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGaussiana
            // 
            this.btnGaussiana.Location = new System.Drawing.Point(188, 329);
            this.btnGaussiana.Name = "btnGaussiana";
            this.btnGaussiana.Size = new System.Drawing.Size(125, 44);
            this.btnGaussiana.TabIndex = 19;
            this.btnGaussiana.Text = "Gaussiano";
            this.btnGaussiana.UseVisualStyleBackColor = true;
            this.btnGaussiana.Click += new System.EventHandler(this.btnGaussiana_Click);
            // 
            // btnOrdem
            // 
            this.btnOrdem.Location = new System.Drawing.Point(22, 179);
            this.btnOrdem.Name = "btnOrdem";
            this.btnOrdem.Size = new System.Drawing.Size(125, 44);
            this.btnOrdem.TabIndex = 17;
            this.btnOrdem.Text = "Ordem";
            this.btnOrdem.UseVisualStyleBackColor = true;
            this.btnOrdem.Click += new System.EventHandler(this.btnOrdem_Click);
            // 
            // btnMediana
            // 
            this.btnMediana.Location = new System.Drawing.Point(22, 379);
            this.btnMediana.Name = "btnMediana";
            this.btnMediana.Size = new System.Drawing.Size(125, 44);
            this.btnMediana.TabIndex = 16;
            this.btnMediana.Text = "Mediana";
            this.btnMediana.UseVisualStyleBackColor = true;
            this.btnMediana.Click += new System.EventHandler(this.btnMediana_Click);
            // 
            // btConMed
            // 
            this.btConMed.Location = new System.Drawing.Point(22, 329);
            this.btConMed.Name = "btConMed";
            this.btConMed.Size = new System.Drawing.Size(125, 44);
            this.btConMed.TabIndex = 15;
            this.btConMed.Text = "Média";
            this.btConMed.UseVisualStyleBackColor = true;
            this.btConMed.Click += new System.EventHandler(this.btConMed_Click);
            // 
            // btConMin
            // 
            this.btConMin.Location = new System.Drawing.Point(22, 279);
            this.btConMin.Name = "btConMin";
            this.btConMin.Size = new System.Drawing.Size(125, 44);
            this.btConMin.TabIndex = 14;
            this.btConMin.Text = "Mínimo";
            this.btConMin.UseVisualStyleBackColor = true;
            this.btConMin.Click += new System.EventHandler(this.btConMin_Click);
            // 
            // btConMax
            // 
            this.btConMax.Location = new System.Drawing.Point(22, 229);
            this.btConMax.Name = "btConMax";
            this.btConMax.Size = new System.Drawing.Size(125, 44);
            this.btConMax.TabIndex = 14;
            this.btConMax.Text = "Máximo";
            this.btConMax.UseVisualStyleBackColor = true;
            this.btConMax.Click += new System.EventHandler(this.btConMax_Click);
            // 
            // chartEqual
            // 
            chartArea2.Name = "ChartArea1";
            this.chartEqual.ChartAreas.Add(chartArea2);
            this.chartEqual.Location = new System.Drawing.Point(555, 215);
            this.chartEqual.Name = "chartEqual";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Red";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Lime;
            series5.Legend = "Legend1";
            series5.Name = "Green";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.Name = "Blue";
            this.chartEqual.Series.Add(series4);
            this.chartEqual.Series.Add(series5);
            this.chartEqual.Series.Add(series6);
            this.chartEqual.Size = new System.Drawing.Size(365, 257);
            this.chartEqual.TabIndex = 12;
            this.chartEqual.Text = "chartEqual";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Histograma Imagem Equalizada";
            this.chartEqual.Titles.Add(title2);
            // 
            // groupRecorte
            // 
            this.groupRecorte.Controls.Add(this.label4);
            this.groupRecorte.Controls.Add(this.label3);
            this.groupRecorte.Controls.Add(this.numVertRecorte2);
            this.groupRecorte.Controls.Add(this.numHorizRecort2);
            this.groupRecorte.Controls.Add(this.label2);
            this.groupRecorte.Controls.Add(this.label1);
            this.groupRecorte.Controls.Add(this.numVertRecorte1);
            this.groupRecorte.Controls.Add(this.numHorizRecort1);
            this.groupRecorte.Controls.Add(this.buttonRecorte);
            this.groupRecorte.Location = new System.Drawing.Point(686, 30);
            this.groupRecorte.Name = "groupRecorte";
            this.groupRecorte.Size = new System.Drawing.Size(234, 167);
            this.groupRecorte.TabIndex = 9;
            this.groupRecorte.TabStop = false;
            this.groupRecorte.Text = "Recorte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "à";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "à";
            // 
            // numVertRecorte2
            // 
            this.numVertRecorte2.Location = new System.Drawing.Point(137, 71);
            this.numVertRecorte2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numVertRecorte2.Name = "numVertRecorte2";
            this.numVertRecorte2.Size = new System.Drawing.Size(67, 22);
            this.numVertRecorte2.TabIndex = 14;
            // 
            // numHorizRecort2
            // 
            this.numHorizRecort2.Location = new System.Drawing.Point(137, 32);
            this.numHorizRecort2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numHorizRecort2.Name = "numHorizRecort2";
            this.numHorizRecort2.Size = new System.Drawing.Size(67, 22);
            this.numHorizRecort2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "X:";
            // 
            // numVertRecorte1
            // 
            this.numVertRecorte1.Location = new System.Drawing.Point(43, 71);
            this.numVertRecorte1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numVertRecorte1.Name = "numVertRecorte1";
            this.numVertRecorte1.Size = new System.Drawing.Size(67, 22);
            this.numVertRecorte1.TabIndex = 10;
            // 
            // numHorizRecort1
            // 
            this.numHorizRecort1.Location = new System.Drawing.Point(43, 32);
            this.numHorizRecort1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numHorizRecort1.Name = "numHorizRecort1";
            this.numHorizRecort1.Size = new System.Drawing.Size(67, 22);
            this.numHorizRecort1.TabIndex = 10;
            // 
            // buttonRecorte
            // 
            this.buttonRecorte.Location = new System.Drawing.Point(52, 109);
            this.buttonRecorte.Name = "buttonRecorte";
            this.buttonRecorte.Size = new System.Drawing.Size(125, 44);
            this.buttonRecorte.TabIndex = 6;
            this.buttonRecorte.Text = "Recortar";
            this.buttonRecorte.UseVisualStyleBackColor = true;
            this.buttonRecorte.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // gbEfeitos
            // 
            this.gbEfeitos.Controls.Add(this.nUDMultiplicacao);
            this.gbEfeitos.Controls.Add(this.bDivisao);
            this.gbEfeitos.Controls.Add(this.numUpDDiv);
            this.gbEfeitos.Controls.Add(this.bMultiplicacao);
            this.gbEfeitos.Controls.Add(this.numericUDcontraste);
            this.gbEfeitos.Controls.Add(this.numericUDBrilho);
            this.gbEfeitos.Controls.Add(this.btnBrilho);
            this.gbEfeitos.Controls.Add(this.btnContraste);
            this.gbEfeitos.Location = new System.Drawing.Point(16, 31);
            this.gbEfeitos.Name = "gbEfeitos";
            this.gbEfeitos.Size = new System.Drawing.Size(151, 442);
            this.gbEfeitos.TabIndex = 7;
            this.gbEfeitos.TabStop = false;
            this.gbEfeitos.Text = "Operações Aritméticas";
            // 
            // nUDMultiplicacao
            // 
            this.nUDMultiplicacao.Location = new System.Drawing.Point(18, 251);
            this.nUDMultiplicacao.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nUDMultiplicacao.Name = "nUDMultiplicacao";
            this.nUDMultiplicacao.Size = new System.Drawing.Size(67, 22);
            this.nUDMultiplicacao.TabIndex = 14;
            // 
            // bDivisao
            // 
            this.bDivisao.Location = new System.Drawing.Point(12, 379);
            this.bDivisao.Name = "bDivisao";
            this.bDivisao.Size = new System.Drawing.Size(125, 44);
            this.bDivisao.TabIndex = 13;
            this.bDivisao.Text = "Divisão";
            this.bDivisao.UseVisualStyleBackColor = true;
            this.bDivisao.Click += new System.EventHandler(this.bDivisao_Click);
            // 
            // numUpDDiv
            // 
            this.numUpDDiv.Location = new System.Drawing.Point(18, 351);
            this.numUpDDiv.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDDiv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDDiv.Name = "numUpDDiv";
            this.numUpDDiv.Size = new System.Drawing.Size(67, 22);
            this.numUpDDiv.TabIndex = 13;
            this.numUpDDiv.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bMultiplicacao
            // 
            this.bMultiplicacao.Location = new System.Drawing.Point(12, 279);
            this.bMultiplicacao.Name = "bMultiplicacao";
            this.bMultiplicacao.Size = new System.Drawing.Size(125, 44);
            this.bMultiplicacao.TabIndex = 12;
            this.bMultiplicacao.Text = "Multiplicação";
            this.bMultiplicacao.UseVisualStyleBackColor = true;
            this.bMultiplicacao.Click += new System.EventHandler(this.bMultiplicacao_Click);
            // 
            // numericUDcontraste
            // 
            this.numericUDcontraste.Location = new System.Drawing.Point(18, 151);
            this.numericUDcontraste.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUDcontraste.Name = "numericUDcontraste";
            this.numericUDcontraste.Size = new System.Drawing.Size(67, 22);
            this.numericUDcontraste.TabIndex = 9;
            // 
            // numericUDBrilho
            // 
            this.numericUDBrilho.Location = new System.Drawing.Point(18, 51);
            this.numericUDBrilho.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUDBrilho.Name = "numericUDBrilho";
            this.numericUDBrilho.Size = new System.Drawing.Size(67, 22);
            this.numericUDBrilho.TabIndex = 8;
            // 
            // groupInverter
            // 
            this.groupInverter.Controls.Add(this.btnFlipUD);
            this.groupInverter.Controls.Add(this.btnFlipLR);
            this.groupInverter.Location = new System.Drawing.Point(491, 31);
            this.groupInverter.Name = "groupInverter";
            this.groupInverter.Size = new System.Drawing.Size(180, 167);
            this.groupInverter.TabIndex = 8;
            this.groupInverter.TabStop = false;
            this.groupInverter.Text = "Inverter";
            // 
            // btnFlipUD
            // 
            this.btnFlipUD.Location = new System.Drawing.Point(26, 108);
            this.btnFlipUD.Name = "btnFlipUD";
            this.btnFlipUD.Size = new System.Drawing.Size(125, 44);
            this.btnFlipUD.TabIndex = 5;
            this.btnFlipUD.Text = "Vertical";
            this.btnFlipUD.UseVisualStyleBackColor = true;
            this.btnFlipUD.Click += new System.EventHandler(this.btnFlipUD_Click);
            // 
            // btnFlipLR
            // 
            this.btnFlipLR.Location = new System.Drawing.Point(26, 49);
            this.btnFlipLR.Name = "btnFlipLR";
            this.btnFlipLR.Size = new System.Drawing.Size(125, 44);
            this.btnFlipLR.TabIndex = 4;
            this.btnFlipLR.Text = "Horizontal";
            this.btnFlipLR.UseVisualStyleBackColor = true;
            this.btnFlipLR.Click += new System.EventHandler(this.btnFlipLR_Click);
            // 
            // groupBoxImg2
            // 
            this.groupBoxImg2.Controls.Add(this.groupBox5);
            this.groupBoxImg2.Controls.Add(this.btnConcatenar);
            this.groupBoxImg2.Controls.Add(this.groupBox1);
            this.groupBoxImg2.Location = new System.Drawing.Point(935, 31);
            this.groupBoxImg2.Name = "groupBoxImg2";
            this.groupBoxImg2.Size = new System.Drawing.Size(334, 442);
            this.groupBoxImg2.TabIndex = 10;
            this.groupBoxImg2.TabStop = false;
            this.groupBoxImg2.Text = "Segunda imagem";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonXOR);
            this.groupBox5.Controls.Add(this.buttonNOT);
            this.groupBox5.Controls.Add(this.buttonOR);
            this.groupBox5.Controls.Add(this.buttonAND);
            this.groupBox5.Location = new System.Drawing.Point(19, 279);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(298, 157);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Operações Lógicas";
            // 
            // buttonXOR
            // 
            this.buttonXOR.Location = new System.Drawing.Point(152, 91);
            this.buttonXOR.Name = "buttonXOR";
            this.buttonXOR.Size = new System.Drawing.Size(125, 44);
            this.buttonXOR.TabIndex = 13;
            this.buttonXOR.Text = "XOR";
            this.buttonXOR.UseVisualStyleBackColor = true;
            this.buttonXOR.Click += new System.EventHandler(this.buttonXOR_Click);
            // 
            // buttonNOT
            // 
            this.buttonNOT.Location = new System.Drawing.Point(21, 91);
            this.buttonNOT.Name = "buttonNOT";
            this.buttonNOT.Size = new System.Drawing.Size(125, 44);
            this.buttonNOT.TabIndex = 12;
            this.buttonNOT.Text = "NOT";
            this.buttonNOT.UseVisualStyleBackColor = true;
            this.buttonNOT.Click += new System.EventHandler(this.buttonNOT_Click);
            // 
            // buttonOR
            // 
            this.buttonOR.Location = new System.Drawing.Point(152, 41);
            this.buttonOR.Name = "buttonOR";
            this.buttonOR.Size = new System.Drawing.Size(125, 44);
            this.buttonOR.TabIndex = 11;
            this.buttonOR.Text = "OR";
            this.buttonOR.UseVisualStyleBackColor = true;
            this.buttonOR.Click += new System.EventHandler(this.buttonOR_Click);
            // 
            // buttonAND
            // 
            this.buttonAND.Location = new System.Drawing.Point(21, 41);
            this.buttonAND.Name = "buttonAND";
            this.buttonAND.Size = new System.Drawing.Size(125, 44);
            this.buttonAND.TabIndex = 10;
            this.buttonAND.Text = "AND";
            this.buttonAND.UseVisualStyleBackColor = true;
            this.buttonAND.Click += new System.EventHandler(this.buttonAND_Click);
            // 
            // btnConcatenar
            // 
            this.btnConcatenar.Location = new System.Drawing.Point(44, 36);
            this.btnConcatenar.Name = "btnConcatenar";
            this.btnConcatenar.Size = new System.Drawing.Size(125, 44);
            this.btnConcatenar.TabIndex = 6;
            this.btnConcatenar.Text = "Concatenar";
            this.btnConcatenar.UseVisualStyleBackColor = true;
            this.btnConcatenar.Click += new System.EventHandler(this.btnConcatenar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nUDBlending);
            this.groupBox1.Controls.Add(this.btnBlending);
            this.groupBox1.Controls.Add(this.btnMedia);
            this.groupBox1.Controls.Add(this.btnSubtrairImagens);
            this.groupBox1.Controls.Add(this.btnSomar);
            this.groupBox1.Location = new System.Drawing.Point(19, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 176);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações Aritméticas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(108, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "%";
            // 
            // nUDBlending
            // 
            this.nUDBlending.Location = new System.Drawing.Point(35, 36);
            this.nUDBlending.Name = "nUDBlending";
            this.nUDBlending.Size = new System.Drawing.Size(67, 22);
            this.nUDBlending.TabIndex = 12;
            // 
            // btnBlending
            // 
            this.btnBlending.Location = new System.Drawing.Point(21, 64);
            this.btnBlending.Name = "btnBlending";
            this.btnBlending.Size = new System.Drawing.Size(125, 44);
            this.btnBlending.TabIndex = 10;
            this.btnBlending.Text = "Blending";
            this.btnBlending.UseVisualStyleBackColor = true;
            this.btnBlending.Click += new System.EventHandler(this.btnBlending_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(152, 64);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(125, 44);
            this.btnMedia.TabIndex = 9;
            this.btnMedia.Text = "Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnSubtrairImagens
            // 
            this.btnSubtrairImagens.Location = new System.Drawing.Point(152, 114);
            this.btnSubtrairImagens.Name = "btnSubtrairImagens";
            this.btnSubtrairImagens.Size = new System.Drawing.Size(125, 44);
            this.btnSubtrairImagens.TabIndex = 8;
            this.btnSubtrairImagens.Text = "Subtrair";
            this.btnSubtrairImagens.UseVisualStyleBackColor = true;
            this.btnSubtrairImagens.Click += new System.EventHandler(this.btnSubtrairImagens_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(21, 114);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(125, 44);
            this.btnSomar.TabIndex = 7;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.labelTamanhoImagem1);
            this.groupBox2.Controls.Add(this.pictureBoxOriginal);
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 385);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Primeira Imagem";
            // 
            // labelTamanhoImagem1
            // 
            this.labelTamanhoImagem1.AutoSize = true;
            this.labelTamanhoImagem1.Location = new System.Drawing.Point(525, 366);
            this.labelTamanhoImagem1.Name = "labelTamanhoImagem1";
            this.labelTamanhoImagem1.Size = new System.Drawing.Size(27, 16);
            this.labelTamanhoImagem1.TabIndex = 28;
            this.labelTamanhoImagem1.Text = "3x3";
            this.labelTamanhoImagem1.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.labelImagemEditada);
            this.groupBox3.Controls.Add(this.pictureBoxEditada);
            this.groupBox3.Location = new System.Drawing.Point(1301, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(608, 385);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Editada";
            // 
            // labelImagemEditada
            // 
            this.labelImagemEditada.AutoSize = true;
            this.labelImagemEditada.Location = new System.Drawing.Point(528, 366);
            this.labelImagemEditada.Name = "labelImagemEditada";
            this.labelImagemEditada.Size = new System.Drawing.Size(27, 16);
            this.labelImagemEditada.TabIndex = 30;
            this.labelImagemEditada.Text = "3x3";
            this.labelImagemEditada.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.labelTamanhoImagem2);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Location = new System.Drawing.Point(656, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(608, 385);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Segunda Imagem";
            // 
            // labelTamanhoImagem2
            // 
            this.labelTamanhoImagem2.AutoSize = true;
            this.labelTamanhoImagem2.Location = new System.Drawing.Point(521, 366);
            this.labelTamanhoImagem2.Name = "labelTamanhoImagem2";
            this.labelTamanhoImagem2.Size = new System.Drawing.Size(27, 16);
            this.labelTamanhoImagem2.TabIndex = 29;
            this.labelTamanhoImagem2.Text = "3x3";
            this.labelTamanhoImagem2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(17, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(574, 335);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnCarregar2
            // 
            this.btnCarregar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCarregar2.Location = new System.Drawing.Point(1083, 22);
            this.btnCarregar2.Name = "btnCarregar2";
            this.btnCarregar2.Size = new System.Drawing.Size(164, 39);
            this.btnCarregar2.TabIndex = 10;
            this.btnCarregar2.Text = "Carregar outra imagem";
            this.btnCarregar2.UseVisualStyleBackColor = true;
            this.btnCarregar2.Click += new System.EventHandler(this.btnCarregar2_Click);
            // 
            // SaveImage
            // 
            this.SaveImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveImage.Location = new System.Drawing.Point(1736, 22);
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.Size = new System.Drawing.Size(154, 39);
            this.SaveImage.TabIndex = 11;
            this.SaveImage.Text = "Salvar";
            this.SaveImage.UseVisualStyleBackColor = true;
            this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.SaveImage);
            this.Controls.Add(this.btnCarregar2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxOpcoes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditada)).EndInit();
            this.groupBoxOpcoes.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimiar)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOriginal)).EndInit();
            this.gbconvolucao.ResumeLayout(false);
            this.gbconvolucao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKernelGaussiano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKernel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desvioPadrao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrdem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEqual)).EndInit();
            this.groupRecorte.ResumeLayout(false);
            this.groupRecorte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVertRecorte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizRecort2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVertRecorte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizRecort1)).EndInit();
            this.gbEfeitos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUDMultiplicacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDcontraste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDBrilho)).EndInit();
            this.groupInverter.ResumeLayout(false);
            this.groupBoxImg2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBlending)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNegativo;
        private System.Windows.Forms.Button btnBrilho;
        private System.Windows.Forms.Button btnContraste;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxEditada;
        private System.Windows.Forms.GroupBox groupBoxOpcoes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFlipUD;
        private System.Windows.Forms.Button btnFlipLR;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCarregar2;
        private System.Windows.Forms.Button SaveImage;
        private System.Windows.Forms.Button btnCinza;
        private System.Windows.Forms.GroupBox gbEfeitos;
        private System.Windows.Forms.NumericUpDown numericUDcontraste;
        private System.Windows.Forms.NumericUpDown numericUDBrilho;
        private System.Windows.Forms.GroupBox groupInverter;
        private System.Windows.Forms.GroupBox groupRecorte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numVertRecorte1;
        private System.Windows.Forms.NumericUpDown numHorizRecort1;
        private System.Windows.Forms.Button buttonRecorte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numVertRecorte2;
        private System.Windows.Forms.NumericUpDown numHorizRecort2;
        private System.Windows.Forms.Button btnConcatenar;
        private System.Windows.Forms.GroupBox groupBoxImg2;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Button btnSubtrairImagens;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOriginal;
        private System.Windows.Forms.Button btnEqualizar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEqual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonXOR;
        private System.Windows.Forms.Button buttonNOT;
        private System.Windows.Forms.Button buttonOR;
        private System.Windows.Forms.Button buttonAND;
        private System.Windows.Forms.GroupBox gbconvolucao;
        private System.Windows.Forms.Button btConMed;
        private System.Windows.Forms.Button btConMin;
        private System.Windows.Forms.Button btConMax;
        private System.Windows.Forms.Button btnBlending;
        private System.Windows.Forms.NumericUpDown nUDBlending;
        private System.Windows.Forms.Button btnMediana;
        private System.Windows.Forms.NumericUpDown numOrdem;
        private System.Windows.Forms.Button btnOrdem;
        private System.Windows.Forms.Button btnSuavConser;
        private System.Windows.Forms.NumericUpDown desvioPadrao;
        private System.Windows.Forms.Button btnGaussiana;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarKernel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button bSobel;
        private System.Windows.Forms.Button bPrewitt;
        private System.Windows.Forms.Button bLaplaciano;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button bErosao;
        private System.Windows.Forms.Button bDilatacao;
        private System.Windows.Forms.Button bAbertura;
        private System.Windows.Forms.Button bFechamento;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown numericUpDownLimiar;
        private System.Windows.Forms.NumericUpDown nUDMultiplicacao;
        private System.Windows.Forms.Button bDivisao;
        private System.Windows.Forms.NumericUpDown numUpDDiv;
        private System.Windows.Forms.Button bMultiplicacao;
        private System.Windows.Forms.PictureBox pBoxKernelGaussiano;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bContorno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTamanhoImagem1;
        private System.Windows.Forms.Label labelImagemEditada;
        private System.Windows.Forms.Label labelTamanhoImagem2;
    }
}


namespace ComputerVision
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSource = new System.Windows.Forms.Panel();
            this.panelDestination = new System.Windows.Forms.Panel();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonNegativation = new System.Windows.Forms.Button();
            this.buttonGrayscale = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.pseudoMedian = new System.Windows.Forms.Button();
            this.median = new System.Windows.Forms.Button();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonFTS3 = new System.Windows.Forms.Button();
            this.buttonFTS2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonFTS1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonGabor = new System.Windows.Forms.Button();
            this.buttonFreiChen = new System.Windows.Forms.Button();
            this.buttonSobel = new System.Windows.Forms.Button();
            this.buttonPrewit = new System.Windows.Forms.Button();
            this.buttonRoberts = new System.Windows.Forms.Button();
            this.buttonLaplace2 = new System.Windows.Forms.Button();
            this.buttonLaplace = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnHue = new System.Windows.Forms.Button();
            this.panelContour = new System.Windows.Forms.Panel();
            this.btnContour = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.minRadiustxt = new System.Windows.Forms.TextBox();
            this.maxRadiustxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.radiusSteptxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSource
            // 
            this.panelSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSource.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelSource.Location = new System.Drawing.Point(12, 12);
            this.panelSource.Name = "panelSource";
            this.panelSource.Size = new System.Drawing.Size(320, 240);
            this.panelSource.TabIndex = 0;
            this.panelSource.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSource_Paint);
            this.panelSource.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSource_MouseUp);
            // 
            // panelDestination
            // 
            this.panelDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDestination.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDestination.Location = new System.Drawing.Point(419, 12);
            this.panelDestination.Name = "panelDestination";
            this.panelDestination.Size = new System.Drawing.Size(320, 240);
            this.panelDestination.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(338, 121);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.buttonNegativation);
            this.panel1.Controls.Add(this.buttonGrayscale);
            this.panel1.Location = new System.Drawing.Point(367, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 206);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Zoom";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(202, 44);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown3.TabIndex = 27;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "DY";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(89, 44);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown2.TabIndex = 25;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "DX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Translate";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(89, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Rotate";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(291, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Oglindire";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Equalize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(6, 62);
            this.trackBar2.Maximum = 355;
            this.trackBar2.Minimum = -110;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(360, 45);
            this.trackBar2.TabIndex = 16;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 110);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Minimum = -255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(360, 45);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // buttonNegativation
            // 
            this.buttonNegativation.Location = new System.Drawing.Point(99, 161);
            this.buttonNegativation.Name = "buttonNegativation";
            this.buttonNegativation.Size = new System.Drawing.Size(69, 23);
            this.buttonNegativation.TabIndex = 14;
            this.buttonNegativation.Text = "Negativtion";
            this.buttonNegativation.UseVisualStyleBackColor = true;
            this.buttonNegativation.Click += new System.EventHandler(this.buttonNegativation_Click);
            // 
            // buttonGrayscale
            // 
            this.buttonGrayscale.Location = new System.Drawing.Point(6, 161);
            this.buttonGrayscale.Name = "buttonGrayscale";
            this.buttonGrayscale.Size = new System.Drawing.Size(63, 23);
            this.buttonGrayscale.TabIndex = 13;
            this.buttonGrayscale.Text = "Grayscale";
            this.buttonGrayscale.UseVisualStyleBackColor = true;
            this.buttonGrayscale.Click += new System.EventHandler(this.buttonGrayscale_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.pseudoMedian);
            this.panel2.Controls.Add(this.median);
            this.panel2.Controls.Add(this.numericUpDown5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.numericUpDown4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(12, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 102);
            this.panel2.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(82, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 22);
            this.button5.TabIndex = 8;
            this.button5.Text = "Sorted";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pseudoMedian
            // 
            this.pseudoMedian.Location = new System.Drawing.Point(208, 41);
            this.pseudoMedian.Name = "pseudoMedian";
            this.pseudoMedian.Size = new System.Drawing.Size(136, 22);
            this.pseudoMedian.TabIndex = 7;
            this.pseudoMedian.Text = "Pseudo median filter";
            this.pseudoMedian.UseVisualStyleBackColor = true;
            this.pseudoMedian.Click += new System.EventHandler(this.pseudoMedian_Click);
            // 
            // median
            // 
            this.median.Location = new System.Drawing.Point(208, 8);
            this.median.Name = "median";
            this.median.Size = new System.Drawing.Size(136, 22);
            this.median.TabIndex = 6;
            this.median.Text = "Median filter";
            this.median.UseVisualStyleBackColor = true;
            this.median.Click += new System.EventHandler(this.median_Click);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(82, 43);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown5.TabIndex = 5;
            this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Outlier prag:";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(82, 10);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 3;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "FTJ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonFTS3);
            this.panel3.Controls.Add(this.buttonFTS2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.buttonFTS1);
            this.panel3.Location = new System.Drawing.Point(12, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 98);
            this.panel3.TabIndex = 5;
            // 
            // buttonFTS3
            // 
            this.buttonFTS3.Location = new System.Drawing.Point(28, 67);
            this.buttonFTS3.Name = "buttonFTS3";
            this.buttonFTS3.Size = new System.Drawing.Size(117, 26);
            this.buttonFTS3.TabIndex = 5;
            this.buttonFTS3.Text = "FTS3 Contur";
            this.buttonFTS3.UseVisualStyleBackColor = true;
            this.buttonFTS3.Click += new System.EventHandler(this.buttonFTS3_Click);
            // 
            // buttonFTS2
            // 
            this.buttonFTS2.Location = new System.Drawing.Point(28, 35);
            this.buttonFTS2.Name = "buttonFTS2";
            this.buttonFTS2.Size = new System.Drawing.Size(117, 26);
            this.buttonFTS2.TabIndex = 4;
            this.buttonFTS2.Text = "FTS2 Contur";
            this.buttonFTS2.UseVisualStyleBackColor = true;
            this.buttonFTS2.Click += new System.EventHandler(this.buttonFTS2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "c = ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0,3";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(168, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 29);
            this.button7.TabIndex = 1;
            this.button7.Text = "Unsharp masking";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonUnsharpMasking_Click);
            // 
            // buttonFTS1
            // 
            this.buttonFTS1.Location = new System.Drawing.Point(28, 3);
            this.buttonFTS1.Name = "buttonFTS1";
            this.buttonFTS1.Size = new System.Drawing.Size(117, 26);
            this.buttonFTS1.TabIndex = 0;
            this.buttonFTS1.Text = "FTS1 Contur";
            this.buttonFTS1.UseVisualStyleBackColor = true;
            this.buttonFTS1.Click += new System.EventHandler(this.buttonFTS1_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.buttonGabor);
            this.panel4.Controls.Add(this.buttonFreiChen);
            this.panel4.Controls.Add(this.buttonSobel);
            this.panel4.Controls.Add(this.buttonPrewit);
            this.panel4.Controls.Add(this.buttonRoberts);
            this.panel4.Controls.Add(this.buttonLaplace2);
            this.panel4.Controls.Add(this.buttonLaplace);
            this.panel4.Location = new System.Drawing.Point(12, 479);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 127);
            this.panel4.TabIndex = 6;
            // 
            // buttonGabor
            // 
            this.buttonGabor.Location = new System.Drawing.Point(28, 90);
            this.buttonGabor.Name = "buttonGabor";
            this.buttonGabor.Size = new System.Drawing.Size(271, 23);
            this.buttonGabor.TabIndex = 7;
            this.buttonGabor.Text = "Gabor a.k.a. politzai";
            this.buttonGabor.UseVisualStyleBackColor = true;
            this.buttonGabor.Click += new System.EventHandler(this.buttonGabor_Click);
            // 
            // buttonFreiChen
            // 
            this.buttonFreiChen.Location = new System.Drawing.Point(28, 61);
            this.buttonFreiChen.Name = "buttonFreiChen";
            this.buttonFreiChen.Size = new System.Drawing.Size(271, 23);
            this.buttonFreiChen.TabIndex = 6;
            this.buttonFreiChen.Text = "Frei-Chen";
            this.buttonFreiChen.UseVisualStyleBackColor = true;
            this.buttonFreiChen.Click += new System.EventHandler(this.buttonFreiChen_Click);
            // 
            // buttonSobel
            // 
            this.buttonSobel.Location = new System.Drawing.Point(190, 32);
            this.buttonSobel.Name = "buttonSobel";
            this.buttonSobel.Size = new System.Drawing.Size(109, 23);
            this.buttonSobel.TabIndex = 5;
            this.buttonSobel.Text = "Sobel";
            this.buttonSobel.UseVisualStyleBackColor = true;
            this.buttonSobel.Click += new System.EventHandler(this.buttonSobel_Click);
            // 
            // buttonPrewit
            // 
            this.buttonPrewit.Location = new System.Drawing.Point(109, 32);
            this.buttonPrewit.Name = "buttonPrewit";
            this.buttonPrewit.Size = new System.Drawing.Size(75, 23);
            this.buttonPrewit.TabIndex = 4;
            this.buttonPrewit.Text = "Prewitt";
            this.buttonPrewit.UseVisualStyleBackColor = true;
            this.buttonPrewit.Click += new System.EventHandler(this.buttonPrewit_Click);
            // 
            // buttonRoberts
            // 
            this.buttonRoberts.Location = new System.Drawing.Point(28, 32);
            this.buttonRoberts.Name = "buttonRoberts";
            this.buttonRoberts.Size = new System.Drawing.Size(75, 23);
            this.buttonRoberts.TabIndex = 3;
            this.buttonRoberts.Text = "Roberts";
            this.buttonRoberts.UseVisualStyleBackColor = true;
            this.buttonRoberts.Click += new System.EventHandler(this.buttonRoberts_Click);
            // 
            // buttonLaplace2
            // 
            this.buttonLaplace2.Location = new System.Drawing.Point(190, 3);
            this.buttonLaplace2.Name = "buttonLaplace2";
            this.buttonLaplace2.Size = new System.Drawing.Size(109, 23);
            this.buttonLaplace2.TabIndex = 2;
            this.buttonLaplace2.Text = "Laplace (Prewit)";
            this.buttonLaplace2.UseVisualStyleBackColor = true;
            this.buttonLaplace2.Click += new System.EventHandler(this.buttonLaplace2_Click);
            // 
            // buttonLaplace
            // 
            this.buttonLaplace.Location = new System.Drawing.Point(107, 3);
            this.buttonLaplace.Name = "buttonLaplace";
            this.buttonLaplace.Size = new System.Drawing.Size(75, 23);
            this.buttonLaplace.TabIndex = 1;
            this.buttonLaplace.Text = "Laplace";
            this.buttonLaplace.UseVisualStyleBackColor = true;
            this.buttonLaplace.Click += new System.EventHandler(this.buttonLaplace_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.button9);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(367, 479);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(372, 127);
            this.panel5.TabIndex = 7;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(134, 65);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(140, 23);
            this.button10.TabIndex = 16;
            this.button10.Text = "Block Matching";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(134, 36);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(140, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "Corelation";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonCorelation_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(134, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Load";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonLoadSecondary_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel6.Location = new System.Drawing.Point(10, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(118, 106);
            this.panel6.TabIndex = 2;
            // 
            // btnHue
            // 
            this.btnHue.Location = new System.Drawing.Point(338, 162);
            this.btnHue.Name = "btnHue";
            this.btnHue.Size = new System.Drawing.Size(75, 23);
            this.btnHue.TabIndex = 8;
            this.btnHue.Text = "Hue Filter";
            this.btnHue.UseVisualStyleBackColor = true;
            this.btnHue.Click += new System.EventHandler(this.btnHue_Click);
            // 
            // panelContour
            // 
            this.panelContour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContour.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelContour.Location = new System.Drawing.Point(848, 12);
            this.panelContour.Name = "panelContour";
            this.panelContour.Size = new System.Drawing.Size(320, 240);
            this.panelContour.TabIndex = 9;
            // 
            // btnContour
            // 
            this.btnContour.Location = new System.Drawing.Point(767, 145);
            this.btnContour.Name = "btnContour";
            this.btnContour.Size = new System.Drawing.Size(75, 23);
            this.btnContour.TabIndex = 10;
            this.btnContour.Text = "Contour following";
            this.btnContour.UseVisualStyleBackColor = true;
            this.btnContour.Click += new System.EventHandler(this.btnContour_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(767, 175);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(75, 23);
            this.btnCircle.TabIndex = 11;
            this.btnCircle.Text = "Detect Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(767, 205);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(764, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "label9";
            // 
            // minRadiustxt
            // 
            this.minRadiustxt.Location = new System.Drawing.Point(838, 271);
            this.minRadiustxt.Name = "minRadiustxt";
            this.minRadiustxt.Size = new System.Drawing.Size(110, 20);
            this.minRadiustxt.TabIndex = 14;
            this.minRadiustxt.Text = "30";
            // 
            // maxRadiustxt
            // 
            this.maxRadiustxt.Location = new System.Drawing.Point(1097, 271);
            this.maxRadiustxt.Name = "maxRadiustxt";
            this.maxRadiustxt.Size = new System.Drawing.Size(122, 20);
            this.maxRadiustxt.TabIndex = 15;
            this.maxRadiustxt.Text = "31";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(748, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Minimum Radius";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1005, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Maximum Radius";
            // 
            // radiusSteptxt
            // 
            this.radiusSteptxt.Location = new System.Drawing.Point(940, 311);
            this.radiusSteptxt.Name = "radiusSteptxt";
            this.radiusSteptxt.Size = new System.Drawing.Size(100, 20);
            this.radiusSteptxt.TabIndex = 18;
            this.radiusSteptxt.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(871, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Radius step";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 618);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.radiusSteptxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.maxRadiustxt);
            this.Controls.Add(this.minRadiustxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnContour);
            this.Controls.Add(this.panelContour);
            this.Controls.Add(this.btnHue);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.panelDestination);
            this.Controls.Add(this.panelSource);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSource;
        private System.Windows.Forms.Panel panelDestination;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGrayscale;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonNegativation;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Button median;
        private System.Windows.Forms.Button pseudoMedian;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonFTS1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonFTS3;
        private System.Windows.Forms.Button buttonFTS2;
        private System.Windows.Forms.Button buttonLaplace2;
        private System.Windows.Forms.Button buttonLaplace;
        private System.Windows.Forms.Button buttonRoberts;
        private System.Windows.Forms.Button buttonPrewit;
        private System.Windows.Forms.Button buttonSobel;
        private System.Windows.Forms.Button buttonFreiChen;
        private System.Windows.Forms.Button buttonGabor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnHue;
        private System.Windows.Forms.Panel panelContour;
        private System.Windows.Forms.Button btnContour;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox minRadiustxt;
        private System.Windows.Forms.TextBox maxRadiustxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox radiusSteptxt;
        private System.Windows.Forms.Label label12;
    }
}


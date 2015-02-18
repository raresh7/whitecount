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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonFTS3 = new System.Windows.Forms.Button();
            this.buttonFTS2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonFTS1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonSobel = new System.Windows.Forms.Button();
            this.buttonPrewit = new System.Windows.Forms.Button();
            this.buttonRoberts = new System.Windows.Forms.Button();
            this.buttonLaplace2 = new System.Windows.Forms.Button();
            this.buttonLaplace = new System.Windows.Forms.Button();
            this.btnContour = new System.Windows.Forms.Button();
            this.btnHue = new System.Windows.Forms.Button();
            this.panelContour = new System.Windows.Forms.Panel();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRegions = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.minRadiustxt = new System.Windows.Forms.TextBox();
            this.maxRadiustxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.radiusSteptxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.countTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panelCircles = new System.Windows.Forms.Panel();
            this.circleTxt = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSource
            // 
            this.panelSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSource.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelSource.Location = new System.Drawing.Point(12, 61);
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
            this.panelDestination.Location = new System.Drawing.Point(388, 172);
            this.panelDestination.Name = "panelDestination";
            this.panelDestination.Size = new System.Drawing.Size(320, 240);
            this.panelDestination.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 327);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
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
            this.panel3.Location = new System.Drawing.Point(12, 473);
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
            this.panel4.Controls.Add(this.buttonSobel);
            this.panel4.Controls.Add(this.buttonPrewit);
            this.panel4.Controls.Add(this.buttonRoberts);
            this.panel4.Controls.Add(this.buttonLaplace2);
            this.panel4.Controls.Add(this.buttonLaplace);
            this.panel4.Controls.Add(this.btnContour);
            this.panel4.Location = new System.Drawing.Point(367, 473);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 98);
            this.panel4.TabIndex = 6;
            // 
            // buttonSobel
            // 
            this.buttonSobel.Location = new System.Drawing.Point(190, 54);
            this.buttonSobel.Name = "buttonSobel";
            this.buttonSobel.Size = new System.Drawing.Size(109, 23);
            this.buttonSobel.TabIndex = 5;
            this.buttonSobel.Text = "Sobel";
            this.buttonSobel.UseVisualStyleBackColor = true;
            this.buttonSobel.Click += new System.EventHandler(this.buttonSobel_Click);
            // 
            // buttonPrewit
            // 
            this.buttonPrewit.Location = new System.Drawing.Point(109, 54);
            this.buttonPrewit.Name = "buttonPrewit";
            this.buttonPrewit.Size = new System.Drawing.Size(75, 23);
            this.buttonPrewit.TabIndex = 4;
            this.buttonPrewit.Text = "Prewitt";
            this.buttonPrewit.UseVisualStyleBackColor = true;
            this.buttonPrewit.Click += new System.EventHandler(this.buttonPrewit_Click);
            // 
            // buttonRoberts
            // 
            this.buttonRoberts.Location = new System.Drawing.Point(28, 54);
            this.buttonRoberts.Name = "buttonRoberts";
            this.buttonRoberts.Size = new System.Drawing.Size(75, 23);
            this.buttonRoberts.TabIndex = 3;
            this.buttonRoberts.Text = "Roberts";
            this.buttonRoberts.UseVisualStyleBackColor = true;
            this.buttonRoberts.Click += new System.EventHandler(this.buttonRoberts_Click);
            // 
            // buttonLaplace2
            // 
            this.buttonLaplace2.Location = new System.Drawing.Point(190, 13);
            this.buttonLaplace2.Name = "buttonLaplace2";
            this.buttonLaplace2.Size = new System.Drawing.Size(109, 23);
            this.buttonLaplace2.TabIndex = 2;
            this.buttonLaplace2.Text = "Laplace (Prewit)";
            this.buttonLaplace2.UseVisualStyleBackColor = true;
            this.buttonLaplace2.Click += new System.EventHandler(this.buttonLaplace2_Click);
            // 
            // buttonLaplace
            // 
            this.buttonLaplace.Location = new System.Drawing.Point(107, 13);
            this.buttonLaplace.Name = "buttonLaplace";
            this.buttonLaplace.Size = new System.Drawing.Size(75, 23);
            this.buttonLaplace.TabIndex = 1;
            this.buttonLaplace.Text = "Laplace";
            this.buttonLaplace.UseVisualStyleBackColor = true;
            this.buttonLaplace.Click += new System.EventHandler(this.buttonLaplace_Click);
            // 
            // btnContour
            // 
            this.btnContour.Location = new System.Drawing.Point(28, 13);
            this.btnContour.Name = "btnContour";
            this.btnContour.Size = new System.Drawing.Size(75, 23);
            this.btnContour.TabIndex = 10;
            this.btnContour.Text = "Contour following";
            this.btnContour.UseVisualStyleBackColor = true;
            this.btnContour.Click += new System.EventHandler(this.btnContour_Click);
            // 
            // btnHue
            // 
            this.btnHue.Location = new System.Drawing.Point(286, 327);
            this.btnHue.Name = "btnHue";
            this.btnHue.Size = new System.Drawing.Size(96, 23);
            this.btnHue.TabIndex = 8;
            this.btnHue.Text = "Foreground Filter";
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
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(736, 435);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(109, 23);
            this.btnCircle.TabIndex = 11;
            this.btnCircle.Text = "Detect Circles";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRegions
            // 
            this.btnRegions.Location = new System.Drawing.Point(657, 123);
            this.btnRegions.Name = "btnRegions";
            this.btnRegions.Size = new System.Drawing.Size(188, 23);
            this.btnRegions.TabIndex = 12;
            this.btnRegions.Text = "Obtain and show regions";
            this.btnRegions.UseVisualStyleBackColor = true;
            this.btnRegions.Click += new System.EventHandler(this.btnRegions_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1177, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Round Cells Detected:";
            // 
            // minRadiustxt
            // 
            this.minRadiustxt.Location = new System.Drawing.Point(940, 258);
            this.minRadiustxt.Name = "minRadiustxt";
            this.minRadiustxt.Size = new System.Drawing.Size(110, 20);
            this.minRadiustxt.TabIndex = 14;
            this.minRadiustxt.Text = "30";
            // 
            // maxRadiustxt
            // 
            this.maxRadiustxt.Location = new System.Drawing.Point(940, 281);
            this.maxRadiustxt.Name = "maxRadiustxt";
            this.maxRadiustxt.Size = new System.Drawing.Size(122, 20);
            this.maxRadiustxt.TabIndex = 15;
            this.maxRadiustxt.Text = "31";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(848, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Minimum Radius";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(848, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Maximum Radius";
            // 
            // radiusSteptxt
            // 
            this.radiusSteptxt.Location = new System.Drawing.Point(940, 307);
            this.radiusSteptxt.Name = "radiusSteptxt";
            this.radiusSteptxt.Size = new System.Drawing.Size(100, 20);
            this.radiusSteptxt.TabIndex = 18;
            this.radiusSteptxt.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(848, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Radius step";
            // 
            // countTxt
            // 
            this.countTxt.Location = new System.Drawing.Point(1299, 164);
            this.countTxt.Name = "countTxt";
            this.countTxt.Size = new System.Drawing.Size(51, 20);
            this.countTxt.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1174, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "White Blood Cell Count:";
            // 
            // panelCircles
            // 
            this.panelCircles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCircles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCircles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelCircles.Location = new System.Drawing.Point(851, 341);
            this.panelCircles.Name = "panelCircles";
            this.panelCircles.Size = new System.Drawing.Size(320, 240);
            this.panelCircles.TabIndex = 22;
            // 
            // circleTxt
            // 
            this.circleTxt.Location = new System.Drawing.Point(1294, 451);
            this.circleTxt.Name = "circleTxt";
            this.circleTxt.Size = new System.Drawing.Size(56, 20);
            this.circleTxt.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 618);
            this.Controls.Add(this.circleTxt);
            this.Controls.Add(this.panelCircles);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.countTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.radiusSteptxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.maxRadiustxt);
            this.Controls.Add(this.minRadiustxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRegions);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.panelContour);
            this.Controls.Add(this.btnHue);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.panelDestination);
            this.Controls.Add(this.panelSource);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSource;
        private System.Windows.Forms.Panel panelDestination;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
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
        private System.Windows.Forms.Button btnHue;
        private System.Windows.Forms.Panel panelContour;
        private System.Windows.Forms.Button btnContour;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnRegions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox minRadiustxt;
        private System.Windows.Forms.TextBox maxRadiustxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox radiusSteptxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox countTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelCircles;
        private System.Windows.Forms.TextBox circleTxt;
    }
}


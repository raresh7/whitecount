using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ComputerVision
{
    public partial class MainForm : Form
    {
        private string sSourceFileName = "";
        private FastImage workImage;
        private FastImage workImage1;
        private FastImage workImageSecondary;
        private Bitmap secondaryImage;
        private Bitmap image = null;
        private int TranslateX = 0;
        private int TranslateY = 1;
        Color[,] pixels;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            sSourceFileName = openFileDialog.FileName;
            panelSource.BackgroundImage = new Bitmap(sSourceFileName);
            image = new Bitmap(sSourceFileName);
            workImage = new FastImage(image);
            workImage1 = new FastImage(image);

            pixels = new Color[workImage1.Width, workImage1.Height];
        }

        private void buttonGrayscale_Click(object sender, EventArgs e)
        {
            Color color;

            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    byte average = (byte)((0.299 * R + 0.587 * G + 0.114 * B));

                    color = Color.FromArgb(average, average, average);

                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            
        }

        private void buttonNegativation_Click(object sender, EventArgs e)
        {
            Color color;

            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    //byte average = (byte)((0.299 * R + 0.587 * G + 0.114 * B));

                    color = Color.FromArgb(255 - R, 255 - G, 255 - B);

                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int value = trackBar1.Value;
            Color color;

            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    //byte average = (byte)((0.299 * R + 0.587 * G + 0.114 * B));

                    R = (int)R + value > 255 ? (byte)255 : (int)R + value < 0 ? (byte)0 : (byte)((int)R + value);
                    G = (int)G + value > 255 ? (byte)255 : (int)G + value < 0 ? (byte)0 : (byte)((int)G + value);
                    B = (int)B + value > 255 ? (byte)255 : (int)B + value < 0 ? (byte)0 : (byte)((int)B + value);

                    color = Color.FromArgb(R, G, B);

                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int value = trackBar2.Value;
            Color color;

            int Rmin = Int32.MaxValue, Rmax = Int32.MinValue, Gmin = Int32.MaxValue, Gmax = Int32.MinValue, Bmin = Int32.MaxValue, Bmax = Int32.MinValue;

            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    if (R < Rmin)
                        Rmin = R;
                    if (R > Rmax)
                        Rmax = R;

                    if (G < Gmin)
                        Gmin = G;
                    if (G > Gmax)
                        Gmax = G;

                    if (B < Bmin)
                        Bmin = B;
                    if (B > Bmax)
                        Bmax = B;
                    //R = (int)R + value > 255 ? (byte)255 : (int)R + value < 0 ? (byte)0 : (byte)((int)R + value);
                    //G = (int)G + value > 255 ? (byte)255 : (int)G + value < 0 ? (byte)0 : (byte)((int)G + value);
                    //B = (int)B + value > 255 ? (byte)255 : (int)B + value < 0 ? (byte)0 : (byte)((int)B + value);

                    //color = Color.FromArgb(R, G, B);

                    //workImage.SetPixel(i, j, color);
                }
            }

            int aR = Rmin - value; //< 0 ? 0 : Rmin - value;
            int bR = Rmax + value; // > 255 ? 255 : Rmax + value;

            int aG = Gmin - value; // < 0 ? 0 : Gmin - value;
            int bG = Gmax + value; // > 255 ? 255 : Gmax + value;

            int aB = Bmin - value; // < 0 ? 0 : Bmin - value;
            int bB = Bmax + value; // > 255 ? 255 : Bmax + value;

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    int iR = (R - Rmin) * (bR - aR) / (Rmax - Rmin) + aR;
                    int iG = (G - Gmin) * (bG - aG) / (Gmax - Gmin) + aG;
                    int iB = (B - Bmin) * (bB - aB) / (Bmax - Bmin) + aB;

                    if (iR < 0)
                        iR = 0;
                    if (iR > 255)
                        iR = 255;

                    if (iG < 0)
                        iG = 0;
                    if (iG > 255)
                        iG = 255;

                    if (iB < 0)
                        iB = 0;
                    if (iB > 255)
                        iB = 255;

                    color = Color.FromArgb(iR, iG, iB);

                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color color;
            int[] hist = new int[256];
            int[] histc = new int[256];
            int[] transf = new int[256];

            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;
                    int x = ((int)R + (int)G + (int)B) / 3;
                    hist[x] += 1;
                }
            }
            histc[0] = hist[0];
            for (int i = 1; i < 256; i++)
            {
                histc[i] = histc[i - 1] + hist[i];
            }

            for (int i = 0; i < 256; i++)
            {
                transf[i] = (histc[i] * 255) / (workImage.Width * workImage.Height);
            }

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    color = workImage.GetPixel(i, j);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;
                    int x = ((int)R + (int)G + (int)B) / 3;
                    color = Color.FromArgb(transf[x], transf[x], transf[x]);
                    workImage.SetPixel(i, j, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // zoom out
            Color color;

            workImage1.Lock();
            for (int i = 0; i <= workImage1.Width - 2; i += 2)
            {
                for (int j = 0; j <= workImage1.Height - 2; j += 2)
                {
                    color = workImage1.GetPixel(i, j);
                    int R = color.R;
                    int G = color.G;
                    int B = color.B;

                    color = workImage1.GetPixel(i, j + 1);
                    R = R + color.R;
                    G = G + color.G;
                    B = B + color.B;

                    color = workImage1.GetPixel(i + 1, j);
                    R = R + color.R;
                    G = G + color.G;
                    B = B + color.B;

                    color = workImage1.GetPixel(i + 1, j + 1);
                    R = R + color.R;
                    G = G + color.G;
                    B = B + color.B;

                    R /= 4;
                    G /= 4;
                    B /= 4;

                    color = Color.FromArgb(R, G, B);
                    workImage1.SetPixel(i/2, j/2, color);
                }
            }
            for (int i = workImage1.Width / 2; i < workImage1.Width; i++)
                for (int j = 0; j < workImage1.Height; j++)
                {
                    color = Color.FromArgb(255, 255, 255);
                    workImage1.SetPixel(i, j, color);
                }

            for (int i = 0; i < workImage1.Width; i++)
                for (int j = workImage1.Height / 2; j < workImage1.Height; j++)
                {
                    color = Color.FromArgb(255, 255, 255);
                    workImage1.SetPixel(i, j, color);
                }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage1.GetBitMap();
            workImage1.Unlock();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // zoom in
            Color color;

            workImage1.Lock();

            for (int i = workImage1.Width / 2 - 1; i >= 0; i--)
            {
                for (int j = workImage1.Height / 2 - 1; j >= 0; j--)
                {
                    color = workImage1.GetPixel(i, j);
                    workImage1.SetPixel(i * 2, j * 2, color);
                    workImage1.SetPixel(i * 2, j * 2 + 1, color);
                    workImage1.SetPixel(i * 2 + 1, j * 2, color);
                    workImage1.SetPixel(i * 2 + 1, j * 2 + 1, color);
                }
            }


            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage1.GetBitMap();
            workImage1.Unlock();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color color, color1;

            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height / 2; j++)
                {
                    color = workImage.GetPixel(i, j);
                    color1 = workImage.GetPixel(i, workImage.Height - j - 1);
                    workImage.SetPixel(i, j, color1);
                    workImage.SetPixel(i, workImage.Height - j - 1, color);
                }
            }
            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Color color;

            workImage1 = new FastImage((Bitmap)image.Clone());
            
            int x0 = workImage1.Width / 2;
            int y0 = workImage1.Height / 2;
            double x2, y2;

            bool[,] points = new bool[workImage1.Width, workImage1.Height];
            workImage.Lock();
            for (int i = 0; i < workImage1.Width; i++)
                for (int j = 0; j < workImage1.Height; j++)
                {
                    points[i, j] = false;
                    pixels[i, j] = workImage.GetPixel(i, j);
                }
            workImage.Unlock();
            workImage1.Lock();

            for (int i = 0; i < workImage1.Width; i++)
            {
                for (int j = 0; j < workImage1.Height; j++)
                {
                    workImage1.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                }
            }

            for (int i = 0; i < workImage1.Width; i++)
            {
                for (int j = 0; j < workImage1.Height; j++)
                {

                    x2 = Math.Cos(((double)numericUpDown1.Value * Math.PI) / 180) * (i - x0) -
                        Math.Sin(((double)numericUpDown1.Value * Math.PI) / 180) * (j - y0) + x0;

                    y2 = Math.Sin(((double)numericUpDown1.Value * Math.PI) / 180) * (i - x0) +
                        Math.Cos(((double)numericUpDown1.Value * Math.PI) / 180) * (j - y0) + y0;

                    if ((x2 > 0) && (x2 < workImage.Width) && (y2 > 0) && (y2 < workImage1.Height))
                    {
                        points[(int)x2, (int)y2] = true;

                        workImage1.SetPixel((int)x2, (int)y2, pixels[i,j]);
                    }
                }
            }

            for (int i = 1; i < workImage1.Width - 1; i++)
            {
                for (int j = 1; j < workImage1.Height - 1; j++)
                {
                    if (points[i, j] == false)
                    {
                        color = workImage1.GetPixel(i - 1, j);
                        int R = color.R;
                        int G = color.G;
                        int B = color.B;
                        color = workImage1.GetPixel(i + 1, j);
                        R += color.R;
                        G += color.G;
                        B += color.B;
                        color = workImage1.GetPixel(i, j - 1);
                        R += color.R;
                        G += color.G;
                        B += color.B; 
                        color = workImage1.GetPixel(i, j + 1);
                        R += color.R;
                        G += color.G;
                        B += color.B;
                        workImage1.SetPixel(i, j, Color.FromArgb(R/4, G/4, B/4));
                    }
                }
            }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage1.GetBitMap();
            workImage1.Unlock();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            TranslateX = (int)numericUpDown2.Value;
            Translate();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            TranslateY = (int)numericUpDown3.Value;
            Translate();
        }

        private void Translate()
        {
            Color color;

            workImage = new FastImage((Bitmap)image.Clone());

            workImage.Lock();
            for (int i = 0; i < workImage.Width; i++)
                for (int j = 0; j < workImage.Height; j++)
                {
                    pixels[i, j] = workImage.GetPixel(i, j);
                    workImage.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                }

            for (int i = 0; i < workImage.Width; i++)
                for (int j = 0; j < workImage.Height; j++)
                {
                    if ((i + TranslateX > 0) && (i + TranslateX < workImage.Width) &&
                        (j + TranslateY > 0) && (j + TranslateY < workImage.Height))
                    {
                        workImage.SetPixel(i + TranslateX, j + TranslateY, pixels[i, j]);
                    }
                }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)numericUpDown4.Value;

            Color color;
            int R = 0;
            int G = 0;
            int B = 0;
            workImage = new FastImage((Bitmap)image.Clone());

            workImage.Lock();

            for (int i = 1; i < workImage.Width - 1; i++)
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    R = 0;
                    B = 0;
                    G = 0;

                    color = workImage.GetPixel(i - 1, j - 1);
                    R += color.R;
                    G += color.G;
                    B += color.B;

                    color = workImage.GetPixel(i - 1, j);
                    R += n * color.R;
                    G += n * color.G;
                    B += n * color.B;

                    color = workImage.GetPixel(i - 1, j + 1);
                    R += color.R;
                    G += color.G;
                    B += color.B;

                    color = workImage.GetPixel(i, j - 1);
                    R += n * color.R;
                    G += n * color.G;
                    B += n * color.B;

                    color = workImage.GetPixel(i, j);
                    R += n * n * color.R;
                    G += n * n * color.G;
                    B += n * n * color.B;

                    color = workImage.GetPixel(i, j + 1);
                    R += n * color.R;
                    G += n * color.G;
                    B += n * color.B;

                    color = workImage.GetPixel(i + 1, j - 1);
                    R += color.R;
                    G += color.G;
                    B += color.B;

                    color = workImage.GetPixel(i + 1, j);
                    R += n * color.R;
                    G += n * color.G;
                    B += n * color.B;

                    color = workImage.GetPixel(i + 1, j + 1);
                    R += color.R;
                    G += color.G;
                    B += color.B;

                    R /= (n + 2) * (n + 2);
                    G /= (n + 2) * (n + 2);
                    B /= (n + 2) * (n + 2);

                    workImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

            int prag = (int)numericUpDown4.Value;

            Color color;
            int R = 0;
            int G = 0;
            int B = 0;
            workImage = new FastImage((Bitmap)image.Clone());

            workImage.Lock();

            for (int i = 1; i < workImage.Width - 1; i++)
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    R = 0;
                    B = 0;
                    G = 0;

                    color = workImage.GetPixel(i - 1, j - 1);
                    R += color.R;
                    G += color.G;
                    B += color.B;

                    color = workImage.GetPixel(i - 1, j);
                    R += color.R;
                    G += color.G;
                    B += color.B;

                    color = workImage.GetPixel(i - 1, j + 1);
                    R += color.R;
                    G += color.G;
                    B += color.B;

                    color = workImage.GetPixel(i, j - 1);
                    R += color.R;
                    G += color.G;
                    B += color.B;

                    color = workImage.GetPixel(i, j + 1);
                    R += color.R;
                    G += color.G;
                    B += color.B;

                    color = workImage.GetPixel(i + 1, j - 1);
                    R += color.R;
                    G += color.G;
                    B += color.B;

                    color = workImage.GetPixel(i + 1, j);
                    R += color.R;
                    G += color.G;
                    B += color.B;

                    color = workImage.GetPixel(i + 1, j + 1);
                    R += color.R;
                    G += color.G;
                    B += color.B;

                    R /= 8;
                    G /= 8;
                    B /= 8;

                    color = workImage.GetPixel(i, j);

                    if(Math.Abs(R - color.R) > prag )
                        workImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                    if (Math.Abs(G - color.G) > prag)
                        workImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                    if (Math.Abs(B - color.B) > prag)
                        workImage.SetPixel(i, j, Color.FromArgb(R, G, B));


                }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void median_Click(object sender, EventArgs e)
        {
            Color color;
            int R = 0;
            int G = 0;
            int B = 0;
            workImage = new FastImage((Bitmap)image.Clone());

            workImage.Lock();

            for (int i = 1; i < workImage.Width - 1; i++)
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    color = workImage.GetPixel(i - 1, j);
                    int R1 = color.R;
                    int G1 = color.G;
                    int B1 = color.B;

                    color = workImage.GetPixel(i, j - 1);
                    int R2 = color.R;
                    int G2 = color.G;
                    int B2 = color.B;

                    color = workImage.GetPixel(i, j);
                    int R3 = color.R;
                    int G3 = color.G;
                    int B3 = color.B;

                    color = workImage.GetPixel(i, j + 1);
                    int R4 = color.R;
                    int G4 = color.G;
                    int B4 = color.B;

                    color = workImage.GetPixel(i + 1, j);
                    int R5 = color.R;
                    int G5 = color.G;
                    int B5 = color.B;

                    R =  Max( Min(R1, R2, R3),  Min(R1, R2, R4),  Min(R1, R2, R5),
                         Min(R1, R3, R4),  Min(R1, R3, R5),  Min(R1, R4, R5),
                         Min(R2, R3, R4),  Min(R2, R3, R5),  Min(R2, R4, R5),  Min(R3, R4, R5));

                    B =  Max( Min(B1, B2, B3),  Min(B1, B2, B4),  Min(B1, B2, B5),
                         Min(B1, B3, B4),  Min(B1, B3, B5),  Min(B1, B4, B5),
                         Min(B2, B3, B4),  Min(B2, B3, B5),  Min(B2, B4, B5),  Min(B3, B4, B5));

                    G =  Max( Min(G1, G2, G3),  Min(G1, G2, G4),  Min(G1, G2, G5),
                         Min(G1, G3, G4),  Min(G1, G3, G5),  Min(G1, G4, G5),
                         Min(G2, G3, G4),  Min(G2, G3, G5),  Min(G2, G4, G5),  Min(G3, G4, G5));

                    workImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        public int Min(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }

        public int Max(int a , int b , int c , int d , int e , int f , int g , int h , int i , int j )
        { 
            //Math.Max(Math.Max(Math.Max(Math.Max(a, b), Math.Max(b,c)), Math.Max(Math.Max(d, e), Math.Max(Math.Max(f,g),Math.Max(Math.Max(h,i),j)))));
            int max = Math.Max(a,b);
            max = Math.Max(max, c);
            max = Math.Max(max, d);
            max = Math.Max(max, e);
            max = Math.Max(max, f);
            max = Math.Max(max, g);
            max = Math.Max(max, h);
            max = Math.Max(max, i);
            max = Math.Max(max, j);
            return max;
        }

        public int Max(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        public Color MatrixMul(int[,] matrix, int i, int j)
        {
            int R = 0;
            int G = 0;
            int B = 0;
            for (int k = i - 1; k < i + 2; k++)
                for (int l = j - 1; l < j + 2; l++ )
                {
                    R += matrix[k - i + 1, l - j + 1] * pixels[k, l].R;
                    G += matrix[k - i + 1, l - j + 1] * pixels[k, l].G;
                    B += matrix[k - i + 1, l - j + 1] * pixels[k, l].B;
                }
            R = R / 9;
            G = G / 9;
            B = B / 9;

            return Color.FromArgb(R, G, B);
        }

        public int[] MatrixMul2(int[,] matrix, int i, int j)
        {
            int R = 0;
            int G = 0;
            int B = 0;
            for (int k = i - 1; k < i + 2; k++)
                for (int l = j - 1; l < j + 2; l++)
                {
                    R += matrix[k - i + 1, l - j + 1] * pixels[k, l].R;
                    G += matrix[k - i + 1, l - j + 1] * pixels[k, l].G;
                    B += matrix[k - i + 1, l - j + 1] * pixels[k, l].B;
                }
            return new int[] { R, G, B };
        }

        private FastImage FTJ(double[,] H, FastImage image)
        {
            FastImage newImage = new FastImage((Bitmap)this.image.Clone());
            newImage.Lock();

            for (int i = 1; i < newImage.Width - 1; ++i)
                for (int j = 1; j < newImage.Height - 1; ++j)
                {
                    newImage.SetPixel(i, j, Convolution(image, i, j, H));
                }

            newImage.Unlock();
            return newImage;
        }

        private Color Convolution(FastImage image, int x, int y, double[,] H)
        {
            double r = 0, g = 0, b = 0;
            for (int i = -1; i <= 1; ++i)
                for (int j = -1; j <= 1; ++j)
                {
                    Color c = image.GetPixel(x + i, y + j);
                    r += H[i + 1, j + 1] * c.R;
                    g += H[i + 1, j + 1] * c.G;
                    b += H[i + 1, j + 1] * c.B;
                }
            return Color.FromArgb(Clamp(0, 255, (int)r), Clamp(0, 255, (int)g), Clamp(0, 255, (int)b));
        }

        private Color Convolution1(FastImage image, int x, int y, double[,] H)
        {
            double r = 0, g = 0, b = 0;
            for (int i = 0; i <= 1; ++i)
                for (int j = 0; j <= 1; ++j)
                {
                    Color c = image.GetPixel(x + i, y + j);
                    r += H[i, j] * c.R;
                    g += H[i, j] * c.G;
                    b += H[i, j] * c.B;
                }
            return Color.FromArgb(Clamp(0, 255, (int)r), Clamp(0, 255, (int)g), Clamp(0, 255, (int)b));
        }


        public int Clamp(int min, int max, int x)
        {
            return Math.Max(min, Math.Min(max, x));
        }

        private void pseudoMedian_Click(object sender, EventArgs e)
        {

            Color color;
            int R = 0;
            int G = 0;
            int B = 0;
            workImage = new FastImage((Bitmap)image.Clone());

            workImage.Lock();

            for (int i = 1; i < workImage.Width - 1; i++)
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    color = workImage.GetPixel(i - 1, j);
                    int R1 = color.R;
                    int G1 = color.G;
                    int B1 = color.B;

                    color = workImage.GetPixel(i, j - 1);
                    int R2 = color.R;
                    int G2 = color.G;
                    int B2 = color.B;

                    color = workImage.GetPixel(i, j);
                    int R3 = color.R;
                    int G3 = color.G;
                    int B3 = color.B;

                    color = workImage.GetPixel(i, j + 1);
                    int R4 = color.R;
                    int G4 = color.G;
                    int B4 = color.B;

                    color = workImage.GetPixel(i + 1, j);
                    int R5 = color.R;
                    int G5 = color.G;
                    int B5 = color.B;

                    R = Max(Min(R1, R2, R3), Min(R2, R3, R4),Min(R3, R4, R5)) / 2 + 
                        Min(Max(R1, R2, R3), Max(R2, R3, R4),Max(R3, R4, R5)) / 2;

                    G = Max(Min(G1, G2, G3), Min(G2, G3, G4),Min(G3, G4, G5)) / 2 + 
                        Min(Max(G1, G2, G3), Max(G2, G3, G4),Max(G3, G4, G5)) / 2;

                    B = Max(Min(B1, B2, B3), Min(B2, B3, B4),Min(B3, B4, B5)) / 2 + 
                        Min(Max(B1, B2, B3), Max(B2, B3, B4),Max(B3, B4, B5)) / 2;
                    
                    workImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Color color;
            int[] R = new int[10];
            int[] G = new int[10];
            int[] B = new int[10];
            workImage = new FastImage((Bitmap)image.Clone());

            workImage.Lock();

            for (int i = 1; i < workImage.Width - 1; i++)
                for (int j = 1; j < workImage.Height - 1; j++)
                {
                    color = workImage.GetPixel(i - 1, j);
                    R[1] = color.R;
                    G[1] = color.G;
                    B[1] = color.B;

                    color = workImage.GetPixel(i, j - 1);
                    R[2] = color.R;
                    G[2] = color.G;
                    B[2] = color.B;

                    color = workImage.GetPixel(i, j);
                    R[3] = color.R;
                    G[3] = color.G;
                    B[3] = color.B;

                    color = workImage.GetPixel(i, j + 1);
                    R[4] = color.R;
                    G[4] = color.G;
                    B[4] = color.B;

                    color = workImage.GetPixel(i + 1, j);
                    R[0] = color.R;
                    G[0] = color.G;
                    B[0] = color.B;



                    for (int z = 0; z < 4; z++)
                        for (int q = z + 1; q < 5; q++)
                        {
                            if (R[z] > R[q])
                            {
                                int t = R[z];
                                R[z] = R[q];
                                R[q] = t;
                            }
                        }

                    for (int z = 0; z < 4; z++)
                        for (int q = z + 1; q < 5; q++)
                        {
                            if (B[z] > B[q])
                            {
                                int t = B[z];
                                B[z] = B[q];
                                B[q] = t;
                            }
                        }

                    for (int z = 0; z < 4; z++)
                        for (int q = z + 1; q < 5; q++)
                        {
                            if (G[z] > G[q])
                            {
                                int t = G[z];
                                G[z] = G[q];
                                G[q] = t;
                            }
                        }

                    workImage.SetPixel(i, j, Color.FromArgb(R[2], G[2], B[2]));
                }

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
        }

        private void buttonFTS1_Click(object sender, EventArgs e)
        {
            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();

            FastImage newImage = FTJ(new double[3, 3] { 
                { 0, -1, 0 },
                { -1, 5, -1 },
                { 0, -1, 0 } },
                workImage);

            workImage.Unlock();

            workImage = newImage;
            workImage.Lock();

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
        }

        private void buttonFTS2_Click(object sender, EventArgs e)
        {
            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();

            FastImage newImage = FTJ(new double[3, 3] { 
                { -1, -1, -1 },
                { -1, 9, -1 },
                { -1, -1, -1 } },
                workImage);

            workImage.Unlock();

            workImage = newImage;
            workImage.Lock();

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
        }

        private void buttonFTS3_Click(object sender, EventArgs e)
        {
            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();

            FastImage newImage = FTJ(new double[3, 3] { 
                { 1, -2, 1 },
                { -2, 5, -2 },
                { 1, -2, 1 } },
                workImage);

            workImage.Unlock();

            workImage = newImage;
            workImage.Lock();

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
        }

        private FastImage Unsharp(double c, FastImage image)
        {
            FastImage newImage = new FastImage((Bitmap)this.image.Clone());
            newImage.Lock();

            double[,] H = new double[3, 3] { 
                { 1.0 / 9.0, 1.0 / 9.0, 1.0 / 9.0 },
                { 1.0 / 9.0, 1.0 / 9.0, 1.0 / 9.0 },
                { 1.0 / 9.0, 1.0 / 9.0, 1.0 / 9.0} };

            for (int i = 1; i < newImage.Width - 1; ++i)
                for (int j = 1; j < newImage.Height - 1; ++j)
                {
                    double cc = 1.0 ;
                    Color col = image.GetPixel(i, j);
                    Color colL = Convolution(image, i, j, H);
                    int r = Clamp(0, 255, Convert.ToInt32(c * col.R / (2 * c - 1) - (1 - c) * colL.R / (2 * c - 1)));
                    int g = Clamp(0, 255, Convert.ToInt32(c * col.G / (2 * c - 1) - (1 - c) * colL.G / (2 * c - 1)));
                    int b = Clamp(0, 255, Convert.ToInt32(c * col.B / (2 * c - 1) - (1 - c) * colL.B / (2 * c - 1)));
                    newImage.SetPixel(i, j, Color.FromArgb(r, g, b));
                }

            newImage.Unlock();
            return newImage;
        }

        private void buttonUnsharpMasking_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox1.Text);
            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();

            FastImage newImage = Unsharp(c, workImage);

            workImage.Unlock();

            workImage = newImage;
            workImage.Lock();

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
        }

        private FastImage Kirsch(FastImage image)
        {

            FastImage grayImage = new FastImage((Bitmap)this.image.Clone());
            grayImage.Lock();
            FastImage newImage = new FastImage((Bitmap)this.image.Clone());
            newImage.Lock();

            for (int i = 0; i < grayImage.Width; ++i)
                for (int j = 0; j < grayImage.Height; ++j)
                {
                    Color c = grayImage.GetPixel(i, j);
                    int gr = (c.R + c.G + c.B) / 3;
                    grayImage.SetPixel(i, j, Color.FromArgb(gr, gr, gr));
                }

            double[,] H1 = new double[3, 3] { 
                { -1.0, 0, 1.0 },
                { -1.0, 0, 1.0 },
                { -1.0, 0, 1.0 } };

            double[,] H2 = new double[3, 3] { 
                { 1.0, 1.0, 1.0 },
                { 0, 0, 0 },
                { -1.0, -1.0, -1.0 } };

            double[,] H3 = new double[3, 3] { 
                { 0, 1.0, 1.0 },
                { -1.0, 0, 1.0 },
                { -1.0, -1.0, 0 } };

            double[,] H4 = new double[3, 3] { 
                { 1.0, 1.0, 0 },
                { 1.0, 0, -1.0 },
                { 0, -1.0, -1.0 } };

            for (int i = 1; i < newImage.Width - 1; ++i)
                for (int j = 1; j < newImage.Height - 1; ++j)
                {
                    Color col1 = Convolution(grayImage, i, j, H1);
                    Color col2 = Convolution(grayImage, i, j, H2);
                    Color col3 = Convolution(grayImage, i, j, H3);
                    Color col4 = Convolution(grayImage, i, j, H4);
                    int r = (int)Math.Max(col1.R, Math.Max(col2.R, Math.Max(col3.R, col4.R)));
                    int g = (int)Math.Max(col1.G, Math.Max(col2.G, Math.Max(col3.G, col4.G)));
                    int b = (int)Math.Max(col1.B, Math.Max(col2.B, Math.Max(col3.B, col4.B)));
                    newImage.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            for (int j = 0; j < newImage.Height; ++j)
                newImage.SetPixel(0, j, newImage.GetPixel(1, j));
            for (int i = 0; i < newImage.Width; ++i)
                newImage.SetPixel(i, 0, newImage.GetPixel(i, 1));

            grayImage.Unlock();
            newImage.Unlock();
            return newImage;
        }

        private void buttonKirch_Click(object sender, EventArgs e)
        {
            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();

            FastImage newImage = Kirsch(workImage);

            workImage.Unlock();

            workImage = newImage;
            workImage.Lock();

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
        }

        private FastImage Laplace(FastImage image , double[,] H)
        {

            FastImage grayImage = new FastImage((Bitmap)this.image.Clone());
            grayImage.Lock();
            FastImage newImage = new FastImage((Bitmap)this.image.Clone());
            newImage.Lock();

            for (int i = 0; i < grayImage.Width; ++i)
                for (int j = 0; j < grayImage.Height; ++j)
                {
                    Color c = grayImage.GetPixel(i, j);
                    int gr = (c.R + c.G + c.B) / 3;
                    grayImage.SetPixel(i, j, Color.FromArgb(gr, gr, gr));
                }

            

            for (int i = 1; i < newImage.Width - 1; ++i)
                for (int j = 1; j < newImage.Height - 1; ++j)
                {
                    Color col = Convolution(grayImage, i, j, H);
                    newImage.SetPixel(i, j, Color.FromArgb(col.R, col.G, col.B));
                }
            for (int j = 0; j < newImage.Height; ++j)
                newImage.SetPixel(0, j, newImage.GetPixel(1, j));
            for (int i = 0; i < newImage.Width; ++i)
                newImage.SetPixel(i, 0, newImage.GetPixel(i, 1));

            grayImage.Unlock();
            newImage.Unlock();
            return newImage;
        }

        private void buttonLaplace_Click(object sender, EventArgs e)
        {
            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();

            double[,] H = new double[3, 3]{
                {0, 1, 0},
                {1, -4, 1},
                {0, 1, 0}
            };

            FastImage newImage = Laplace(workImage, H);

            workImage.Unlock();

            workImage = newImage;
            workImage.Lock();

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
        }

        private void buttonLaplace2_Click(object sender, EventArgs e)
        {
            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();

            double[,] H = new double[3, 3]{
                {-1, -1, -1},
                {-1, 8, -1},
                {-1, -1, -1}
            };

            FastImage newImage = Laplace(workImage, H);

            workImage.Unlock();

            workImage = newImage;
            workImage.Lock();

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
        }

        private FastImage Roberts(FastImage image)
        {
            FastImage grayImage = new FastImage((Bitmap)this.image.Clone());
            grayImage.Lock();
            FastImage newImage = new FastImage((Bitmap)this.image.Clone());
            newImage.Lock();

            for (int i = 0; i < grayImage.Width; ++i)
                for (int j = 0; j < grayImage.Height; ++j)
                {
                    Color c = grayImage.GetPixel(i, j);
                    int gr = (c.R + c.G + c.B) / 3;
                    grayImage.SetPixel(i, j, Color.FromArgb(gr, gr, gr));
                }

            double[,] H1 = new double[2,2] { 
                { -1, 0 },
                { 0, 1  } };

            double[,] H2 = new double[2, 2] { 
                { 0, 1 },
                { -1, 0} };

            for (int i = 0; i < newImage.Width - 1; ++i)
                for (int j = 0; j < newImage.Height - 1; ++j)
                {
                    Color col1 = Convolution1(grayImage, i, j, H1);
                    Color col2 = Convolution1(grayImage, i, j, H2);
                    int R = (int)Math.Sqrt(col1.R * col1.R + col2.R * col2.R);
                    int G = (int)Math.Sqrt(col1.G * col1.G + col2.G * col2.G);
                    int B = (int)Math.Sqrt(col1.B * col1.B + col2.B * col2.B);
                    newImage.SetPixel(i, j, Color.FromArgb(
                        Clamp(0, 255, 7 * R), Clamp(0, 255, 7 * G), Clamp(0, 255, 7 *B)));
                }
            for (int j = 0; j < newImage.Height; ++j)
                newImage.SetPixel(0, j, newImage.GetPixel(1, j));
            for (int i = 0; i < newImage.Width; ++i)
                newImage.SetPixel(i, 0, newImage.GetPixel(i, 1));

            grayImage.Unlock();
            newImage.Unlock();
            return newImage;
        }

        private void buttonRoberts_Click(object sender, EventArgs e)
        {
            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();

            FastImage newImage = Roberts(workImage);

            workImage.Unlock();

            workImage = newImage;
            workImage.Lock();

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
        }

        private FastImage Prewit(FastImage image)
        {
            FastImage grayImage = new FastImage((Bitmap)this.image.Clone());
            grayImage.Lock();
            FastImage newImage = new FastImage((Bitmap)this.image.Clone());
            newImage.Lock();

            for (int i = 0; i < grayImage.Width; ++i)
                for (int j = 0; j < grayImage.Height; ++j)
                {
                    Color c = grayImage.GetPixel(i, j);
                    int gr = (c.R + c.G + c.B) / 3;
                    grayImage.SetPixel(i, j, Color.FromArgb(gr, gr, gr));
                }

            double[,] H2 = new double[3, 3] { 
                { -1.0, 0, 1.0 },
                { -1.0, 0, 1.0 },
                { -1.0, 0, 1.0 } };

            double[,] H1 = new double[3, 3] { 
                { -1.0, -1.0, -1.0 },
                { 0, 0, 0 },
                { 1.0, 1.0, 1.0 } };

            for (int i = 1; i < newImage.Width - 1; ++i)
                for (int j = 1; j < newImage.Height - 1; ++j)
                {
                    Color col1 = Convolution(grayImage, i, j, H1);
                    Color col2 = Convolution(grayImage, i, j, H2);
                    int R = (int)Math.Sqrt(col1.R * col1.R + col2.R * col2.R);
                    int G = (int)Math.Sqrt(col1.G * col1.G + col2.G * col2.G);
                    int B = (int)Math.Sqrt(col1.B * col1.B + col2.B * col2.B);
                    newImage.SetPixel(i, j, Color.FromArgb(
                        Clamp(0, 255, R), Clamp(0, 255, G), Clamp(0, 255, B)));
                }
            for (int j = 0; j < newImage.Height; ++j)
                newImage.SetPixel(0, j, newImage.GetPixel(1, j));
            for (int i = 0; i < newImage.Width; ++i)
                newImage.SetPixel(i, 0, newImage.GetPixel(i, 1));

            grayImage.Unlock();
            newImage.Unlock();
            return newImage;
        }

        private void buttonPrewit_Click(object sender, EventArgs e)
        {
            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();

            FastImage newImage = Prewit(workImage);

            workImage.Unlock();

            workImage = newImage;
            workImage.Lock();

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
        }

        private FastImage Sobel(FastImage image)
        {
            FastImage grayImage = new FastImage((Bitmap)this.image.Clone());
            grayImage.Lock();
            FastImage newImage = new FastImage((Bitmap)this.image.Clone());
            newImage.Lock();

            for (int i = 0; i < grayImage.Width; ++i)
                for (int j = 0; j < grayImage.Height; ++j)
                {
                    Color c = grayImage.GetPixel(i, j);
                    int gr = (c.R + c.G + c.B) / 3;
                    grayImage.SetPixel(i, j, Color.FromArgb(gr, gr, gr));
                }

            double[,] H2 = new double[3, 3] { 
                { -1.0, 0, 1.0 },
                { -2.0, 0, 2.0 },
                { -1.0, 0, 1.0 } };

            double[,] H1 = new double[3, 3] { 
                { -1.0, -2.0, -1.0 },
                { 0, 0, 0 },
                { 1.0, 2.0, 1.0 } };

            for (int i = 1; i < newImage.Width - 1; ++i)
                for (int j = 1; j < newImage.Height - 1; ++j)
                {
                    Color col1 = Convolution(grayImage, i, j, H1);
                    Color col2 = Convolution(grayImage, i, j, H2);
                    int R = (int)Math.Sqrt(col1.R * col1.R + col2.R * col2.R);
                    int G = (int)Math.Sqrt(col1.G * col1.G + col2.G * col2.G);
                    int B = (int)Math.Sqrt(col1.B * col1.B + col2.B * col2.B);
                    newImage.SetPixel(i, j, Color.FromArgb(
                        Clamp(0, 255, R), Clamp(0, 255, G), Clamp(0, 255, B)));
                }
            for (int j = 0; j < newImage.Height; ++j)
                newImage.SetPixel(0, j, newImage.GetPixel(1, j));
            for (int i = 0; i < newImage.Width; ++i)
                newImage.SetPixel(i, 0, newImage.GetPixel(i, 1));

            grayImage.Unlock();
            newImage.Unlock();
            return newImage;
        }

        private void buttonSobel_Click(object sender, EventArgs e)
        {
            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();

            FastImage newImage = Sobel(workImage);

            workImage.Unlock();

            workImage = newImage;
            workImage.Lock();

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
        }

        private FastImage FreiChen(FastImage image)
        {
            FastImage grayImage = new FastImage((Bitmap)this.image.Clone());
            grayImage.Lock();
            FastImage newImage = new FastImage((Bitmap)this.image.Clone());
            newImage.Lock();

            for (int i = 0; i < grayImage.Width; ++i)
                for (int j = 0; j < grayImage.Height; ++j)
                {
                    Color c = grayImage.GetPixel(i, j);
                    int gr = (c.R + c.G + c.B) / 3;
                    grayImage.SetPixel(i, j, Color.FromArgb(gr, gr, gr));
                }

            double[,] H1 = new double[3, 3] { 
                { 1.0, Math.Sqrt(2), 1.0 },
                { 0, 0, 0 },
                { -1.0, -Math.Sqrt(2), -1.0 } };

            double[,] H2 = new double[3, 3] { 
                { 1.0, 0, -1.0 },
                { Math.Sqrt(2), 0, -Math.Sqrt(2) },
                { 1.0, 0, -1.0 } };

            double[,] H3 = new double[3, 3] { 
                { 0, 1, -Math.Sqrt(2) },
                { 1, 0, -1 },
                { -Math.Sqrt(2), 1 , 0 } };

            double[,] H4 = new double[3, 3] { 
                { Math.Sqrt(2), -1, 0 },
                { -1, 0, 1 },
                { 0, 1, -Math.Sqrt(2) } };

            double[,] H5 = new double[3, 3] { 
                { 0, 1, 0 },
                { -1, 0, -1 },
                { 0, 1, 0 } };

            double[,] H6 = new double[3, 3] { 
                { -1, 0, 1 },
                { 0, 0, 0 },
                { 1, 0, -1 } };

            double[,] H7 = new double[3, 3] { 
                { 1, -2, 1 },
                { -2, 4, -2 },
                { 1, -2, 1 } };

            double[,] H8 = new double[3, 3] { 
                { -2, 1, -2 },
                { 1, 4, 1 },
                { -2, 1, -2 } };

            double[,] H9 = new double[3, 3] { 
                { 1.0/9.0, 1.0/9.0, 1.0/9.0 },
                { 1.0/9.0, 1.0/9.0, 1.0/9.0 },
                { 1.0/9.0, 1.0/9.0, 1.0/9.0 } };

            for (int i = 1; i < newImage.Width - 1; ++i)
                for (int j = 1; j < newImage.Height - 1; ++j)
                {
                    Color col1 = Convolution(grayImage, i, j, H1);
                    Color col2 = Convolution(grayImage, i, j, H2);
                    Color col3 = Convolution(grayImage, i, j, H3);
                    Color col4 = Convolution(grayImage, i, j, H4);
                    Color col5 = Convolution(grayImage, i, j, H5);
                    Color col6 = Convolution(grayImage, i, j, H6);
                    Color col7 = Convolution(grayImage, i, j, H7);
                    Color col8 = Convolution(grayImage, i, j, H8);
                    Color col9 = Convolution(grayImage, i, j, H9);
                    double Rsus = (col1.R * col1.R + col2.R * col2.R + col3.R * col3.R + col4.R * col4.R);
                    double Gsus = (col1.G * col1.G + col2.G * col2.G + col3.G * col3.G + col4.G * col4.G);
                    double Bsus = (col1.B * col1.B + col2.B * col2.B + col3.B * col3.B + col4.B * col4.B);

                    double Rjos = Rsus + col5.R * col5.R + col6.R * col6.R + col7.R * col7.R + col8.R * col8.R + col9.R * col9.R;
                    double R = Math.Sqrt(Rsus / Rjos) * 255;
                    newImage.SetPixel(i, j, Color.FromArgb((int)R,(int)R,(int)R));
                }
            for (int j = 0; j < newImage.Height; ++j)
                newImage.SetPixel(0, j, newImage.GetPixel(1, j));
            for (int i = 0; i < newImage.Width; ++i)
                newImage.SetPixel(i, 0, newImage.GetPixel(i, 1));

            grayImage.Unlock();
            newImage.Unlock();
            return newImage;
        }

        private void buttonFreiChen_Click(object sender, EventArgs e)
        {
            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();

            FastImage newImage = FreiChen(workImage);

            workImage.Unlock();

            workImage = newImage;
            workImage.Lock();

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
        }

        private FastImage Gabor(FastImage image)
        {
            FastImage grayImage = new FastImage((Bitmap)this.image.Clone());
            grayImage.Lock();
            FastImage newImage = new FastImage((Bitmap)this.image.Clone());
            newImage.Lock();

            double[,] P = new double[3, 3] { 
                { 1.0, 1.0, 1.0 },
                { 0, 0, 0 },
                { -1.0, -1.0, -1.0 } };

            double[,] Q = new double[3, 3] { 
                { -1.0, 0, 1.0 },
                { -1.0, 0, 1.0 },
                { -1.0, 0, 1.0 } };

            for (int i = 0; i < grayImage.Width; ++i)
                for (int j = 0; j < grayImage.Height; ++j)
                {
                    Color c = grayImage.GetPixel(i, j);
                    int gr = (c.R + c.G + c.B) / 3;
                    grayImage.SetPixel(i, j, Color.FromArgb(gr, gr, gr));
                }

            double[,] pixs = new double[grayImage.Height, grayImage.Width];
            double min = Double.PositiveInfinity;
            double max = Double.NegativeInfinity;

            for (int i = 1; i < newImage.Width - 1; ++i)
                for (int j = 1; j < newImage.Height - 1; ++j)
                {
                    double p = 0;
                    double q = 0;
                    for (int ii = -1; ii <= 1; ++ii)
                        for (int jj = -1; jj <= 1; ++jj)
                        {
                            p += P[ii + 1, jj + 1] * grayImage.GetPixel(i + ii, j + jj).R;
                            q += Q[ii + 1, jj + 1] * grayImage.GetPixel(i + ii, j + jj).R;
                        }
                    double u = 0;
                    if (q == 0)
                    {
                        if (p >= 0)
                            u = Math.PI / 2;
                        else
                            u = -Math.PI / 2;
                    }
                    else
                    {
                        u = Math.Atan(p / q);
                        if (q < 0)
                            u += Math.PI;
                    }
                    u += Math.PI / 2;
                    double suma = 0;
                    double sigma = 0.66;
                    double omega = 1.5;
                    double[,] H = new double[3, 3];
                    for (int ii = -1; ii <= 1; ++ii)
                        for (int jj = -1; jj <= 1; ++jj)
                        {
                            double r = jj;
                            double c = ii;
                            double scalee = Math.Exp(-(r * r + c * c) / (2 * sigma * sigma));
                            double scalesin = Math.Sin(omega * (r * Math.Cos(u) + c * Math.Sin(u)));
                            H[(int)c+1, (int)r+1] = scalee * scalesin;
                            suma += (scalee * scalesin) * grayImage.GetPixel(i + ii, j + jj).R;
                        }
                    //newImage.SetPixel(i, j, Color.FromArgb((int)suma, (int)suma, (int)suma));
                    pixs[j, i] = suma;
                    if (suma > max)
                        max = suma;
                    if (suma < min)
                        min = suma;
                }
            for (int i = 1; i < grayImage.Width - 1; ++i)
                for (int j = 1; j < grayImage.Height - 1; ++j)
                {
                    pixs[j, i] = (pixs[j, i] - min) / (max - min) * 255;
                    newImage.SetPixel(i, j, Color.FromArgb((int)pixs[j, i], (int)pixs[j, i], (int)pixs[j, i]));
                }

            for (int j = 0; j < newImage.Height; ++j)
                newImage.SetPixel(0, j, newImage.GetPixel(1, j));
            for (int i = 0; i < newImage.Width; ++i)
                newImage.SetPixel(i, 0, newImage.GetPixel(i, 1));

            grayImage.Unlock();
            newImage.Unlock();
            return newImage;
        }

        private void buttonGabor_Click(object sender, EventArgs e)
        {
            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();

            FastImage newImage = Gabor(workImage);

            workImage.Unlock();

            workImage = newImage;
            workImage.Lock();

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
        }

        public class Point
        {
            public int x, y;
            public Point(int x1, int y1)
            {
                x = x1;
                y = y1;
            }
        }

        private bool Condition(int color, double mean, int prag)
        { 
            if((color <= mean + prag) && (color >= mean - prag))
                return true;
            return false;
        }

        private FastImage RegionGrowing(FastImage image, int x, int y)
        {

            FastImage grayImage = new FastImage((Bitmap)this.image.Clone());
            grayImage.Lock();
            FastImage newImage = new FastImage((Bitmap)this.image.Clone());
            newImage.Lock();

            for (int i = 0; i < grayImage.Width; ++i)
                for (int j = 0; j < grayImage.Height; ++j)
                {
                    Color c = grayImage.GetPixel(i, j);
                    int gr = (c.R + c.G + c.B) / 3;
                    grayImage.SetPixel(i, j, Color.FromArgb(gr, gr, gr));
                }

            for(int i = 0 ; i < newImage.Width; ++i)
                for (int j = 0; j < newImage.Height; ++j)
                {
                    newImage.SetPixel(i, j, Color.Black);
                }

            bool[,] check = new bool[newImage.Width, newImage.Height];

            for (int i = 0; i < newImage.Width; ++i)
                for (int j = 0; j < newImage.Height; ++j)
                {
                    check[i, j] = false;
                }

            
            double mean = grayImage.GetPixel(x, y).R;
            int numberOfMean = 1;
            int prag = 10;
            List<Point> stack = new List<Point>();
            stack.Add(new Point(x, y));

            while (stack.Count != 0)
            {
                Point p = stack[0];
                stack.Remove(p);
                x = p.x;
                y = p.y + 1;
                if (y < newImage.Height)
                {
                    if (Condition(grayImage.GetPixel(p.x, p.y + 1).R, mean, prag))
                    {
                        if (check[p.x, p.y + 1] == false)
                        {
                            check[p.x, p.y + 1] = true;
                            newImage.SetPixel(p.x, p.y + 1, Color.White);
                            stack.Add(new Point(p.x, p.y + 1));
                            mean *= numberOfMean;
                            mean += grayImage.GetPixel(p.x, p.y + 1).R;
                            numberOfMean++;
                            mean /= numberOfMean;
                        }
                    }
                }
                x = p.x;
                y = p.y - 1;
                if (y >= 0)
                {
                    if (Condition(grayImage.GetPixel(p.x, p.y - 1).R, mean, prag))
                    {
                        if (check[p.x, p.y - 1] == false)
                        {
                            check[p.x, p.y - 1] = true;
                            newImage.SetPixel(p.x, p.y - 1, Color.White);
                            stack.Add(new Point(p.x, p.y - 1));
                            mean *= numberOfMean;
                            mean += grayImage.GetPixel(p.x, p.y - 1).R;
                            numberOfMean++;
                            mean /= numberOfMean;
                        }
                    }
                }
                x = p.x + 1;
                y = p.y;
                if (x < newImage.Width)
                {
                    if (Condition(grayImage.GetPixel(p.x + 1, p.y).R, mean, prag))
                    {
                        if (check[p.x + 1, p.y] == false)
                        {
                            check[p.x + 1, p.y] = true;
                            newImage.SetPixel(p.x + 1, p.y, Color.White);
                            stack.Add(new Point(p.x + 1, p.y));
                            mean *= numberOfMean;
                            mean += grayImage.GetPixel(p.x + 1, p.y).R;
                            numberOfMean++;
                            mean /= numberOfMean;
                        }
                    }
                }
                x = p.x - 1;
                y = p.y;
                if (x >= 0)
                {
                    if (Condition(grayImage.GetPixel(p.x - 1, p.y).R, mean, prag))
                    {
                        if (check[p.x - 1, p.y] == false)
                        {
                            check[p.x - 1, p.y] = true;
                            newImage.SetPixel(p.x - 1, p.y, Color.White);
                            stack.Add(new Point(p.x - 1, p.y));
                            mean *= numberOfMean;
                            mean += grayImage.GetPixel(p.x - 1, p.y).R;
                            numberOfMean++;
                            mean /= numberOfMean;
                        }
                    }
                }
            }

            grayImage.Unlock();
            newImage.Unlock();
            return newImage;
        }

        private void panelSource_MouseUp(object sender, MouseEventArgs e)
        {
            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();

            int x = (int)((double)e.X / panelSource.Width * workImage.Width);
            int y = (int)((double)e.Y / panelSource.Height * workImage.Height);

            FastImage newImage = RegionGrowing(workImage, x, y);

            workImage.Unlock();

            workImage = newImage;
            workImage.Lock();

            panelDestination.BackgroundImage = null;
            panelDestination.BackgroundImage = workImage.GetBitMap();

            workImage.Unlock();
        }

        private void panelSource_Paint(object sender, PaintEventArgs e)
        {

        }

        private double Grayscale(Color c)
        {
            return (double)(c.R + c.G + c.B) / 3;
        }

        private void buttonCorelation_Click(object sender, EventArgs e)
        {
            int template_size = workImageSecondary.Width * workImageSecondary.Height;
            double sum = 0;
            double sqrsum = 0;
            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();
            workImageSecondary.Lock();
            for (int i = 0; i < workImageSecondary.Width; ++i)
                for (int j = 0; j < workImageSecondary.Height; ++j)
                {
                    double template = Grayscale(workImageSecondary.GetPixel(i, j));
                    sum += template;
                    sqrsum += template * template;
                }
            double mean_template = sum / template_size;
            double var2template = sqrsum - (sum * sum) / template_size;
            double var2image = 0;
            double prodsum = 0;
            double[,] corr_coeff = new double[workImage.Width, workImage.Height];
            for (int i = 0; i < workImage.Width - workImageSecondary.Width; ++i)
                for (int j = 0; j < workImage.Height - workImageSecondary.Height; ++j)
                {
                    sum = 0;
                    sqrsum = 0;
                    prodsum = 0;
                    for (int k = 0; k < workImageSecondary.Width; ++k)
                        for (int m = 0; m < workImageSecondary.Height; ++m)
                        {
                            double img = Grayscale(workImage.GetPixel(i + k, j + m));
                            double template = Grayscale(workImageSecondary.GetPixel(k, m));
                            sum += img;
                            sqrsum += img * img;
                            prodsum += img * template;
                        }
                    var2image = sqrsum - (sum * sum) / template_size;
                    corr_coeff[i, j] = ((prodsum - (mean_template * sum)) / Math.Sqrt(var2image * var2template));
                }
            double max = Double.NegativeInfinity;
            int imax = 0, jmax = 0;
            for (int i = 0; i < workImage.Width - workImageSecondary.Width; ++i)
                for (int j = 0; j < workImage.Height - workImageSecondary.Height; ++j)
                    if (max < corr_coeff[i, j])
                    {
                        max = corr_coeff[i, j];
                        imax = i;
                        jmax = j;
                    }
            for (int i = 0; i < workImageSecondary.Width; ++i)
            {
                workImage.SetPixel(imax + i, jmax, Color.Green);
                workImage.SetPixel(imax + i, jmax + workImageSecondary.Height -1, Color.Green);
            }
            for (int j = 0; j < workImageSecondary.Height; ++j)
            {
                workImage.SetPixel(imax, jmax + j, Color.Green);
                workImage.SetPixel(imax + workImageSecondary.Width -1, jmax + j, Color.Green);
            }
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            workImageSecondary.Unlock();
        }

        private void buttonLoadSecondary_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            sSourceFileName = openFileDialog.FileName;
            panel6.BackgroundImage = new Bitmap(sSourceFileName);
            secondaryImage = new Bitmap(sSourceFileName);
            workImageSecondary = new FastImage(secondaryImage);
        }


        double SAD(FastImage first, int i, int j, FastImage second, int k, int l, int N)
        {
            double sad = 0;
            for (int ii = 0; ii < N; ++ii)
            {
                for (int jj = 0; jj < N; jj++)
                {
                    double c1 = Grayscale(first.GetPixel(i + ii, j + jj));
                    double c2 = Grayscale(second.GetPixel(k + ii, l + jj));
                    sad += Math.Abs(c1 - c2);
                }
            }
            return sad;
        }

        private double Distance123(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        private void DrawLine(int x1, int y1, int x2, int y2, FastImage img)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            if (dx == 0 && dy == 0)
                return;
            double dist = Distance123(x1, y1, x2, y2);
            double m = (double)dy / dx;
            if (Math.Abs(dx) > Math.Abs(dy))
            {
                if (dx > 0)
                {
                    for (int x = 0; x <= dx; ++x)
                    {
                        double y = m * x;
                        double t = Distance123(x1, y1, x + x1, y + y1) / dist;
                        img.SetPixel(x + x1, (int)y + y1, Color.Black);
                    }
                }
                else
                {
                    for (int x = 0; x >= dx; --x)
                    {
                        double y = m * x;
                        double t = Distance123(x1, y1, x + x1, y + y1) / dist;
                        img.SetPixel(x + x1, (int)y + y1, Color.Black);
                    }
                }
            }
            else
            {
                if (dy > 0)
                {
                    for (int y = 0; y <= dy; ++y)
                    {
                        double x = y / m;
                        double t = Distance123(x1, y1, x + x1, y + y1) / dist;
                        img.SetPixel((int)x + x1, y + y1, Color.Black);
                    }
                }
                else
                {
                    for (int y = 0; y >= dy; --y)
                    {
                        double x = y / m;
                        double t = Distance123(x1, y1, x + x1, y + y1) / dist;
                        img.SetPixel((int)x + x1, y + y1, Color.Black);
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int BLOCK_SIZE = 9;
            int WINDOW_SIZE = 7;

            FastImage workImageFirst = new FastImage((Bitmap)image.Clone());
            workImage = new FastImage((Bitmap)image.Clone());
            workImage.Lock();
            workImageSecondary.Lock();
            workImageFirst.Lock();

            for (int i = 0; i < workImage.Width; i++)
            {
                for (int j = 0; j < workImage.Height; j++)
                {
                    workImage.SetPixel(i, j, Color.White);
                }
            }

            for (int i = 0; i < workImage.Width; i += BLOCK_SIZE)
            {
                for (int j = 0; j < workImage.Height; j += BLOCK_SIZE)
                {
                    double min = double.PositiveInfinity;
                    int u = 0, v = 0;
                    for (int k = -WINDOW_SIZE; k <= WINDOW_SIZE; k++)
                    {
                        for (int l = -WINDOW_SIZE; l <= WINDOW_SIZE; l++)
                        {
                            if (i + k < 0 || j + l < 0)
                                continue;
                            if (i + k + BLOCK_SIZE >= workImage.Width)
                                continue;
                            if (j + l + BLOCK_SIZE >= workImage.Height)
                                continue;

                            double val = SAD(workImageFirst, i, j,
                                workImageSecondary, i + k, j + l, BLOCK_SIZE);
                            if (val < min)
                            {
                                u = k;
                                v = l;
                                min = val;
                            }
                        }
                    }
                    DrawLine(i, j, i + u, j + v, workImage);
                }
            }
            panelDestination.BackgroundImage = workImage.GetBitMap();
            workImage.Unlock();
            workImageSecondary.Unlock();
            workImageFirst.Unlock();
        }



    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;



namespace GymnasiearbeteWindowsForms
{
    public partial class Form1 : Form
    {
        private readonly int offset = 40;
        int decimalersNorganhet = 2; 
        int nIterationer=1000;
        private Color undersöktFärg;
        private string filnamn = "ifylldElipse.png";
        private Bitmap bmp;
        private Dictionary<double, int> data = new Dictionary<double, int>();
        private PictureBox bilden = new PictureBox();
        private bool eyeDroperAktiverad = false;
        static ThreadLocal<Random> ThreadLocalRandom = new ThreadLocal<Random>(() => new Random(Guid.NewGuid().GetHashCode()));
        public Form1()
        {
            bmp = new Bitmap(filnamn);
            bilden.Image = Image.FromFile(filnamn);
            
            bilden.SizeMode = PictureBoxSizeMode.AutoSize; // Automatisk storlek
            bilden.Location = new Point(500, 50);
            this.Controls.Add(bilden);
            bilden.Visible = true;
            InitializeComponent();
            btnBeräkna.BringToFront();
            groupBox1.BringToFront(); 
            groupBox2.BringToFront();

        }

        

        public void RitaOm(Dictionary<double, int> nyData)
        {
            data = nyData;              // spara datan
            pictureBoxGraf.Invalidate();   // trigga omritning
        }

        static bool UndersäkaOmPunktInnanför(int x_värde, int y_värde, Bitmap bmp)
        {
            int nKorsningar = 0;
            bool påLinje = false;
            for (int x = x_värde; x < bmp.Width; x++)
            {
                Color pixel = bmp.GetPixel(x, y_värde);
                bool svart = pixel.R < 128;
                if (svart && !påLinje)
                {
                    nKorsningar++;
                    påLinje = true;
                }
                else if (!svart)
                {
                    påLinje = false;
                }
            }
            if (nKorsningar % 2 == 0)
            {
                return false;
            }
            return true;
        }
        static bool UndersäkaOmPixelHarFärg(int x_värde, int y_värde, Bitmap bmp, Color färg)
        {
            if (bmp.GetPixel(x_värde, y_värde) == färg)
            {
                return false;
            }
            return true;

        }
        static void RitaPunkt(int x_värde, int y_värde, Graphics g, Brush brush)
        {
            int px = x_värde;
            int py = y_värde;

            Rectangle r = new Rectangle(px - 4, py - 4, 8, 8);
            g.FillEllipse(brush, r);
            g.DrawEllipse(Pens.Black, r);
        }
        static void BeräknaGrafiskt()
        {

        }

        private void Bilden_Click(object sender, EventArgs e)
        {

        }
        private void Bilden_MouseMove(object sender, MouseEventArgs e)
        {
            btnUndersöktFärg.BackColor = bmp.GetPixel(e.X, e.Y);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
        }


        private void lblIntAntalPunkter_Click(object sender, EventArgs e)
        {

        }

        private void lblTextPunkterInnanför_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBeräkna_Click(object sender, EventArgs e)
        {
            bilden.Image = Image.FromFile(filnamn);
            using (Graphics g = Graphics.FromImage(bilden.Image))
            {
                Stopwatch sw = new Stopwatch();
                int nPunkter = 1000;
                int nPunkterInanför = 0;
                lblDecimalAndelInnanför.Visible = true;
                sw.Start();

                Random random = new Random();

                for (int i = 0; i < nPunkter; i++)
                {
                    int x_värde = random.Next(bmp.Width);
                    int y_värde = random.Next(bmp.Height);
                    if (UndersäkaOmPixelHarFärg(x_värde, y_värde, bmp, undersöktFärg))
                    {
                        RitaPunkt(x_värde, y_värde, g, Brushes.Red);
                        nPunkterInanför++;
                    }
                    else
                    {
                        RitaPunkt(x_värde, y_värde, g, Brushes.Blue);
                    }
                    bilden.Refresh();
                }
                lblDecimalAndelInnanför.Text = ((double)nPunkterInanför / nPunkter).ToString("F2");
                lblIntPunkterInnanför.Text = nPunkterInanför.ToString();
                lblIntAntalPunkter.Text = nPunkter.ToString();
            }
            File.WriteAllText("data.txt", "");
            Dictionary<double, int> värden = new Dictionary<double, int>();
            btnBeräkna.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            //
            int pixelHöjd = bmp.Height;
            int pixelBred = bmp.Width;
            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bildData = bmp.LockBits(rect, ImageLockMode.ReadOnly, bmp.PixelFormat);
            int stride = bildData.Stride;
            IntPtr scan0 = bildData.Scan0;
            using (StreamWriter writer = new StreamWriter(@"C:\Users\SamuelSyl\source\repos\GymnasiearbeteWindowsForms\GymnasiearbeteWindowsForms\data.txt", false)) //Tömmer data
            {
                writer.Write("");
            }
            try
            {
                for (int nPunkter = 100; nPunkter <= 100; nPunkter = nPunkter * 10)
                {
                    for (int ii = 0; ii < nIterationer; ii++)
                    {
                        Stopwatch sw = new Stopwatch();
                        
                        int nPunkterInanför = 0;
                        lblDecimalAndelInnanför.Visible = true;
                        sw.Start();

                        Random random = new Random();

                        Parallel.For(
                            0,
                            nPunkter,
                            () => 0,
                            (i, state, localCount) =>
                            {

                                var rnd = ThreadLocalRandom.Value;
                                int x_värde = rnd.Next(pixelBred);
                                int y_värde = rnd.Next(pixelHöjd);
                                unsafe
                                {
                                    byte* row = (byte*)scan0 + y_värde * stride;
                                    byte* pixel = row + x_värde * 4; // 32bpp ARGB

                                byte b = pixel[0];
                                    byte g = pixel[1];
                                    byte r = pixel[2];
                                    byte a = pixel[3];
                                    Color färgValdPixel = Color.FromArgb(a, r, g, b);
                                    if (färgValdPixel == undersöktFärg)
                                    {
                                        localCount++;
                                    }
                                }

                                return localCount;
                            },
                            localCount =>
                            {
                                Interlocked.Add(ref nPunkterInanför, localCount);
                            });
                        double andelInanför=Math.Round((double)nPunkterInanför / nPunkter, decimalersNorganhet);
                        try
                        {
                            värden[andelInanför]++;
                        }
                        catch (Exception)
                        {
                            värden.Add(andelInanför, 1);
                        }
                        sw.Stop();
                    }
                    double summaAndelarInanför = 0;
                    double summaKvadreradeDiferanser = 0;
                    double summaArea = 0;
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\SamuelSyl\source\repos\GymnasiearbeteWindowsForms\GymnasiearbeteWindowsForms\data.txt", false))
                    {
                        writer.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
                        foreach (KeyValuePair<double, int> item in värden)
                        {
                            summaAndelarInanför += item.Key* item.Value;
                            double höjd = ((double)item.Value / nIterationer) / Math.Pow(10, decimalersNorganhet * -1);
                            summaArea += höjd * Math.Pow(10, decimalersNorganhet * -1);
                            writer.WriteLine($"{Math.Round(item.Key,decimalersNorganhet).ToString().Replace(",", ".")},{(höjd).ToString().Replace(",", ".")}");
                        }
                        double summaAndelAvIterationer = 0;
                        double medelvärdeAndelInnanför = summaAndelarInanför / nIterationer; 
                        foreach (KeyValuePair<double, int> item in värden)
                        {
                            summaAndelAvIterationer += (double)item.Value / nIterationer;
                            summaKvadreradeDiferanser += Math.Pow(((double)item.Key * item.Value)/nPunkter - medelvärdeAndelInnanför, 2);
                        }
                        double standardavikelse = Math.Sqrt(summaKvadreradeDiferanser / (nIterationer - 1));
                        writer.WriteLine($"STANDARDAVIKELSE {standardavikelse} ");
                        writer.WriteLine($"MEDELVÄRDE {medelvärdeAndelInnanför}");
                        writer.WriteLine($"AREA {summaArea}");
                        writer.WriteLine($"SUMMA ANDELAR Innanför {summaAndelarInanför}");
                        writer.WriteLine($"SUMMA ANDELAR {summaAndelAvIterationer}");
                    }
                }
            }
            finally
            {
                bmp.UnlockBits(bildData);
            }
            RitaOm(värden);
            this.Cursor = Cursors.Default;
            btnBeräkna.Enabled = true;
            /*
            Dictionary<int, int> värden = new Dictionary<int, int>();
            btnBeräkna.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            bilden.Image = Image.FromFile(filnamn);
            for (int ii = 0; ii < 100; ii++)
            {
                
            btnBeräkna.Enabled = true;
            */
            //_______________________________________________________________
            //base.OnPaint(e);
            //Graphics g = e.Graphics;

            // --- rita axlar ---
            //Pen axisPen = new Pen(Color.Black, 2);
            //g.DrawLine(axisPen, offset, image.Height + offset, image.Width + offset, image.Height + offset);
            //g.DrawLine(axisPen, offset, offset, offset, image.Height + offset);

        }

        private void btnVäljFärg_Click(object sender, EventArgs e)
        {
            if (eyeDroperAktiverad)
            {
                this.Cursor = Cursors.Default;
                btnBeräkna.Enabled = true;
                btnSvart.Enabled = true;
                btnVit.Enabled = true;
                bilden.MouseEnter -= Bilden_MouseEnter;
                bilden.MouseMove -= Bilden_MouseMove;
                bilden.MouseLeave -= Bilden_MouseLeave;
                bilden.MouseClick -= Bilden_MouseClick;
                btnVäljFärg.Text = "Välj färg";
            }
            else
            {
                this.Cursor = Cursors.Cross;
                bilden.MouseEnter += Bilden_MouseEnter;
                bilden.MouseMove += Bilden_MouseMove;
                bilden.MouseLeave += Bilden_MouseLeave;
                bilden.MouseClick += Bilden_MouseClick;
                btnVäljFärg.Text = "Avbryt";
                btnBeräkna.Enabled = false;
                btnSvart.Enabled = false;
                btnVit.Enabled = false;
            }
            eyeDroperAktiverad = !eyeDroperAktiverad;
        }

        private void BtnVäljFärg_MouseClickAvbryt(object sender, MouseEventArgs e)
        {
            
        }

        private void Bilden_MouseClick(object sender, MouseEventArgs e)
        {
            undersöktFärg = bmp.GetPixel(e.X, e.Y);
            btnUndersöktFärg.BackColor = undersöktFärg;
            this.Cursor = Cursors.Default;
            bilden.MouseEnter -= Bilden_MouseEnter;
            bilden.MouseMove -= Bilden_MouseMove;
            bilden.MouseLeave -= Bilden_MouseLeave;
            bilden.MouseClick -= Bilden_MouseClick;
            btnVäljFärg.Text = "Välj färg";
            btnBeräkna.Enabled = true;
            btnBeräkna.Enabled = true;
            btnSvart.Enabled = true;
            btnVit.Enabled = true;
            eyeDroperAktiverad = false;
        }

        private void Bilden_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void Bilden_MouseEnter(object sender, EventArgs e)
        {
            var eyeDropperCursor = new Cursor("eyedropper.cur");
            this.Cursor = eyeDropperCursor;
        }

        private void btnSvart_Click(object sender, EventArgs e)
        {
            btnUndersöktFärg.BackColor = Color.Black;
            undersöktFärg = Color.Black;
        }

        private void btnVit_Click(object sender, EventArgs e)
        {
            //btnUndersöktFärg.BackColor = Color.White;
            //undersöktFärg = Color.White;
            
            /*
             * 
             * using (StreamWriter writer = new StreamWriter("data.txt"))
            {
                
            }Stopwatch sw = new Stopwatch();
            int nPunkter = 10;
            int nPunkterInanför = 0;
            lblDecimalAndelInnanför.Visible = true;
            sw.Start();
            Dictionary<int, int> värden = new Dictionary<int, int>();
            Random random = new Random();
            for (int i = 0; i < 1; i++)
            {
                for (int ii = 0; ii < nPunkter; i++)
                {
                    int x_värde = random.Next(bmp.Width);
                    int y_värde = random.Next(bmp.Height);
                    if (UndersäkaOmPixelHarFärg(x_värde, y_värde, bmp, undersöktFärg))
                    {
                        nPunkterInanför++;
                    }
                    
                }
            }
            
            
            
            sw.Stop();
            */
        }

        private void pictureBoxGraf_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxGraf_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int margin = 10;

            int width = pictureBoxGraf.Width - 2 * margin;
            int height = pictureBoxGraf.Height - 2 * margin;

            int originX = margin;
            int originY = pictureBoxGraf.Height - margin;

            Pen pen = new Pen(Color.Black);

            // Axlar
            g.DrawLine(pen, originX, originY, originX + width, originY); // X
            g.DrawLine(pen, originX, originY, originX, originY - height); // Y

            foreach (var pair in data)
            {
                double xVal = pair.Key;   // 0 → 1
                double yVal = pair.Value; // 0 → 100

                // 🔥 Skalning
                int x = originX + (int)(xVal * width);
                int y = originY - (int)((yVal / 100.0) * height);

                g.FillEllipse(Brushes.Blue, x - 3, y - 3, 6, 6);
            }
        }
    }
}


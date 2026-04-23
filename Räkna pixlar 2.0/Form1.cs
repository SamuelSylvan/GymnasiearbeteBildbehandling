using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Räkna_pixlar_2._0
{
    public partial class Form1 : Form
    {
        private readonly int offset = 40;
        int decimalersNorganhet = 2;
        int nIterationer = 10000;
        private Color undersöktFärg;
        private string filnamn = "ifylldElipse.png";
        private Bitmap bmp;
        
        public Form1()
        {
            bmp = new Bitmap(filnamn);
            


        }
     
        static bool UndersäkaOmPixelHarFärg(int x_värde, int y_värde, Bitmap bmp, Color färg)
        {
            if (bmp.GetPixel(x_värde, y_värde) == färg)
            {
                return false;
            }
            return true;

        }
      
        private void Bilden_MouseMove(object sender, MouseEventArgs e)
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
            File.WriteAllText("data.txt", "");
            btnBeräkna.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            bilden.Image = Image.FromFile(filnamn);
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
                for (int nPunkter = 10; nPunkter <= 10000; nPunkter = nPunkter * 10)
                {
                    Dictionary<double, int> värden = new Dictionary<double, int>();
                    List<double> listaVärden = new List<double>();
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
                        double andelInanför = (double)nPunkterInanför / nPunkter;
                        try
                        {
                            värden[andelInanför]++;
                        }
                        catch (Exception)
                        {
                            värden.Add(andelInanför, 1);
                        }
                        sw.Stop();
                        lblDecimalAndelInnanför.Text = ((double)nPunkterInanför / nPunkter).ToString("F2");
                        lblIntPunkterInnanför.Text = nPunkterInanför.ToString();
                        lblIntAntalPunkter.Text = nPunkter.ToString();
                    }
                    double delta_x = Math.Pow(10, decimalersNorganhet * -1);
                    if (delta_x < (1 / nPunkter))
                    {
                        delta_x = (1 / nPunkter);
                    }
                    double summaAndelarInanför = 0;
                    double summaKvadreradeDiferanser = 0;
                    double summaArea = 0;
                    int antalAvTypvärde = 0;
                    int antaletGenomgångnaTal = 0;
                    double median = 0;
                    List<double> typvärden = new List<double>();
                    // 2. Skapa serien för punkter (Scatter Plot)
                    /*Series pointSeries = new Series("DataPoints");
                    pointSeries.ChartType = SeriesChartType.Point;
                    pointSeries.Color = Color.Blue;
                    pointSeries.MarkerSize = 4;
                    kordinatsytem1.Series.Add(pointSeries);
                    Series normalfördelning = new Series("Kurva");
                    normalfördelning.ChartType = SeriesChartType.Point;
                    normalfördelning.Color = Color.Red;
                    normalfördelning.MarkerSize = 2;
                    kordinatsytem1.Series.Add(normalfördelning);
                    */
                    for (int i = 0; i < bmp; i++)
                    {

                    }
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\SamuelSyl\source\repos\GymnasiearbeteWindowsForms\GymnasiearbeteWindowsForms\data.txt", true))
                    {
                        writer.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
                        foreach (KeyValuePair<double, int> item in värden)
                        {
                            if (antaletGenomgångnaTal == -1)
                            {
                                median = (median + item.Key) / 2;
                                antaletGenomgångnaTal = nIterationer * -1;
                            }
                            antaletGenomgångnaTal += item.Value;
                            if (antaletGenomgångnaTal > nIterationer / 2)
                            {
                                median = item.Key;
                                antaletGenomgångnaTal = nIterationer * -1;
                            }
                            else
                            {
                                if (antaletGenomgångnaTal == nIterationer / 2)
                                {
                                    median = item.Key;
                                    antaletGenomgångnaTal = -1;
                                }
                            }
                            if (item.Value == antalAvTypvärde)
                            {
                                typvärden.Add(item.Key);
                            }
                            else
                            {
                                if (item.Value > antalAvTypvärde)
                                {
                                    typvärden.Clear();
                                    typvärden.Add(item.Key);
                                    antalAvTypvärde = item.Value;
                                }
                            }
                            if (true)
                            {

                            }
                            summaAndelarInanför += item.Key * item.Value;
                            //double höjd = item.Value / (nIterationer * delta_x);
                            //summaArea += höjd * delta_x;
                            writer.WriteLine($"{(item.Key).ToString().Replace(",", ".")},{(item.Value).ToString().Replace(",", ".")}");
                            for (int i = 0; i < item.Value; i++)
                            {
                                listaVärden.Add(item.Key);
                            }
                            //pointSeries.Points.AddXY(item.Key, item.Value);
                        }
                        double summaAndelAvIterationer = 0;
                        double medelvärdeAndelInnanför = summaAndelarInanför / nIterationer;
                        foreach (KeyValuePair<double, int> item in värden)
                        {
                            summaAndelAvIterationer += (double)item.Value / nIterationer;
                            summaKvadreradeDiferanser += item.Value * Math.Pow(item.Key - medelvärdeAndelInnanför, 2);
                        }


                        double standardavikelse = Math.Sqrt(summaKvadreradeDiferanser / (nIterationer - 1));
                        writer.WriteLine($"ANTAL PUNKTER {nPunkter}");
                        writer.WriteLine($"Antal iterationer {nIterationer}");
                        writer.WriteLine($"STANDARDAVIKELSE {standardavikelse.ToString().Replace(",", ".")} ");
                        writer.WriteLine($"MEDELVÄRDE {medelvärdeAndelInnanför.ToString().Replace(",", ".")}");
                        writer.Write($"Typvärde(n): ");
                        foreach (double typvärde in typvärden)
                        {
                            writer.Write($"{typvärde.ToString().Replace(",", ".")},  ");
                        }
                        writer.WriteLine();
                        writer.WriteLine($"AREA {summaArea}");
                        writer.WriteLine($"SUMMA ANDELAR {summaAndelAvIterationer}");
                        writer.WriteLine($"Normalfördelning({medelvärdeAndelInnanför.ToString().Replace(",", ".")},{standardavikelse.ToString().Replace(",", ".")},x,false)*{(nIterationer * delta_x).ToString().Replace(",", ".")}");
                        double minX = medelvärdeAndelInnanför - (4 * standardavikelse);
                        double maxX = medelvärdeAndelInnanför + (4 * standardavikelse);
                        double step = 0.01;
                        /*
                        for (double x = minX; x <= maxX; x += step)
                        {
                            double y = BerräknaNormafördelning(x, medelvärdeAndelInnanför, standardavikelse);
                            normalfördelning.Points.AddXY(x, y);
                        }
                        */
                    }
                    using (StreamWriter writer = new StreamWriter($@"C:\Users\SamuelSyl\source\repos\GymnasiearbeteWindowsForms\GymnasiearbeteWindowsForms\qqplot{nPunkter}punkter.txt", true))
                    {
                        listaVärden.Sort();
                        int n = listaVärden.Count;
                        double my = listaVärden.Average();
                        double sigma = Math.Sqrt(listaVärden.Select(x => (x - my) * (x - my)).Average());
                        double[] theoretical = new double[n];
                        for (int i = 0; i < n; i++)
                        {
                            double p = (i + 0.5) / n;
                            theoretical[i] = Normal.InvCDF(my, sigma, p);
                        }


                        for (int i = 0; i < n; i++)
                        {
                            writer.WriteLine($"{ theoretical[i].ToString()}\t{listaVärden[i].ToString()}");
                        }
                    }
                }
            }
            finally
            {
                bmp.UnlockBits(bildData);
            }
            this.Cursor = Cursors.Default;
            btnBeräkna.Enabled = true;
            /*
            Dictionary<int, int> värden = new Dictionary<int, int>();
            btnBeräkna.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            bilden.Image = Image.FromFile(filnamn);
            for (int ii = 0; ii < 100; ii++)
            {
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
                    try
                    {
                        värden[nPunkterInanför]++;
                    }
                    catch (Exception)
                    {
                        värden.Add(nPunkterInanför, 1);
                    }
                    sw.Stop();
                    lblDecimalAndelInnanför.Text = ((double)nPunkterInanför / nPunkter).ToString("F2");
                    lblIntPunkterInnanför.Text = nPunkterInanför.ToString();
                    lblIntAntalPunkter.Text = nPunkter.ToString();
                }
                this.Cursor = Cursors.Default;
            }
            using (StreamWriter writer = new StreamWriter(@"C:\Users\SamuelSyl\source\repos\GymnasiearbeteWindowsForms\GymnasiearbeteWindowsForms\data.txt", true))
            {


                foreach (KeyValuePair<int, int> item in värden)
                {
                    writer.WriteLine($"{item.Key},{item.Value}");
                }

            }
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
            var eyeDropperCursor = new System.Windows.Forms.Cursor("eyedropper.cur");
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
    }
}

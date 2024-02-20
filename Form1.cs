using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace mandi_practice
{
    public partial class Mandelprog : Form
    {
        private double Real;
        private double Imaginary;
        double[]  set = { -2, 2, -1.5, 1.5 };
        double [] set_float = new double[4];
        int scrolcount = 1;
        int MaxIter, MaxMagni, SetWidth, SetHeight;
        long zoom_value = 1;
        long RunTime = 0;

        byte[,] ColorMatrix = {
            {255,255,255 }, // fehér
            {255, 2, 34},      
            {0, 0, 168},    // kék
            {0, 168, 0},    // zöld
            {0, 168, 168},  // cián
            {168, 0, 0},    // piros
            {168, 0, 168},  // lila
            {168, 84, 0},   // barna
            {168, 168, 168},// világosszürke
            {84, 84, 84},   // sötétszürke
            {84, 84, 252},  // világoskék
            {84, 252, 84},  // világoszöld
            {84, 252, 252}, // világoscián
            {252, 84, 84},  // világospiros
            {252, 84, 252}, // világoslila
            {252, 252, 84}  // világosbarna
            };

    public Mandelprog()
    {
            InitializeComponent();

            Display.MouseMove  += MouseMoveonDisplay;
            Display.MouseWheel += MouseWheelonDisplay;
    }

        private void MandelbrotSet(int magnitude, int iterations ,int width, int height, double minX, double maxX, double minY, double maxY)
        { 
            Stopwatch   sw = Stopwatch.StartNew();
            sw.Start();

            Bitmap MandelbrotImage = new Bitmap(width, height);
            BitmapData BMap = MandelbrotImage.LockBits(new Rectangle(0, 0, MandelbrotImage.Width, MandelbrotImage.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int[,] M = new int[height, width];
            if (Paralel.Checked == true)
            {
                Task[] Tasks = new Task[height - 1];

                for (int y = 0; y < height - 1; y++)
                {
                    int paralelY = y;
                    Tasks[y] = Task.Run(() =>
                    {
                        for (int x = 0; x < width - 1; x++)
                        {
                            double a = Map(x, width, minX, maxX);
                            double b = Map(paralelY, height, minY, maxY);
                            //double a = Map(x, 0, width, minX, maxX);
                            //double b = Map(y, 0, height, minY, maxY);

                            double realPart = a;
                            double imaginaryPart = b;

                            int iteration = MandelbrotCalc(realPart, imaginaryPart, iterations, magnitude);
                            float normIterations = (iteration * 100 / iterations);
                            switch (normIterations)

                            {
                                case float n when (n >= 1 && n <= 6):
                                    M[paralelY, x] = 0;
                                    break;
                                case float n when (n >= 7 && n <= 12):
                                    M[paralelY, x] = 1;
                                    break;
                                case float n when (n >= 13 && n <= 18):
                                    M[paralelY, x] = 2;
                                    break;
                                case float n when (n >= 19 && n <= 24):
                                    M[paralelY, x] = 3;
                                    break;
                                case float n when (n >= 25 && n <= 30):
                                    M[paralelY, x] = 4;
                                    break;
                                case float n when (n >= 31 && n <= 36):
                                    M[paralelY, x] = 5;
                                    break;
                                case float n when (n >= 37 && n <= 42):
                                    M[paralelY, x] = 6;
                                    break;
                                case float n when (n >= 43 && n <= 48):
                                    M[paralelY, x] = 7;
                                    break;
                                case float n when (n >= 49 && n <= 54):
                                    M[paralelY, x] = 8;
                                    break;
                                case float n when (n >= 55 && n <= 60):
                                    M[paralelY, x] = 9;
                                    break;
                                case float n when (n >= 61 && n <= 66):
                                    M[paralelY, x] = 10;
                                    break;
                                case float n when (n >= 67 && n <= 72):
                                    M[paralelY, x] = 11;
                                    break;
                                case float n when (n >= 73 && n <= 78):
                                    M[paralelY, x] = 12;
                                    break;
                                case float n when (n >= 79 && n <= 84):
                                    M[paralelY, x] = 13;
                                    break;
                                case float n when (n >= 85 && n <= 92):
                                    M[paralelY, x] = 14;
                                    break;
                                case float n when (n >= 93 && n <= 100):
                                    M[paralelY, x] = 15;
                                    break;
                                default:

                                    break;
                            }
                        }
                    });



                }
                Task.WaitAll(Tasks);

            }
            else {
                for (int y = 0; y < height - 1; y++)
                {

                    for (int x = 0; x < width - 1; x++)
                    {
                        double a = Map(x, width, minX, maxX);
                        double b = Map(y, height, minY, maxY);
                        //double a = Map(x, 0, width, minX, maxX);
                        //double b = Map(y, 0, height, minY, maxY);

                        double realPart = a;
                        double imaginaryPart = b;

                        int iteration = MandelbrotCalc(realPart, imaginaryPart, iterations, magnitude);
                        float normIterations = (iteration * 100 / iterations);
                        switch (normIterations)

                        {
                            case float n when (n >= 1 && n <= 6):
                                M[y, x] = 0;
                                break;
                            case float n when (n >= 7 && n <= 12):
                                M[y, x] = 1;
                                break;
                            case float n when (n >= 13 && n <= 18):
                                M[y, x] = 2;
                                break;
                            case float n when (n >= 19 && n <= 24):
                                M[y, x] = 3;
                                break;
                            case float n when (n >= 25 && n <= 30):
                                M[y, x] = 4;
                                break;
                            case float n when (n >= 31 && n <= 36):
                                M[y, x] = 5;
                                break;
                            case float n when (n >= 37 && n <= 42):
                                M[y, x] = 6;
                                break;
                            case float n when (n >= 43 && n <= 48):
                                M[y, x] = 7;
                                break;
                            case float n when (n >= 49 && n <= 54):
                                M[y, x] = 8;
                                break;
                            case float n when (n >= 55 && n <= 60):
                                M[y, x] = 9;
                                break;
                            case float n when (n >= 61 && n <= 66):
                                M[y, x] = 10;
                                break;
                            case float n when (n >= 67 && n <= 72):
                                M[y, x] = 11;
                                break;
                            case float n when (n >= 73 && n <= 78):
                                M[y, x] = 12;
                                break;
                            case float n when (n >= 79 && n <= 84):
                                M[y, x] = 13;
                                break;
                            case float n when (n >= 85 && n <= 92):
                                M[y, x] = 14;
                                break;
                            case float n when (n >= 93 && n <= 100):
                                M[y, x] = 15;
                                break;
                            default:

                                break;
                        }
                    }
                }
            }

            if (Paralel.Checked==true)
            {


                copyParalel(M, BMap);
                
                
            }
            else
            {
                copySequental(M, 0, height, BMap);
            }

            MandelbrotImage.UnlockBits(BMap);
            Display.Image = MandelbrotImage;

            sw.Stop();
            RunTime=sw.ElapsedMilliseconds;
            
        }
        private int MandelbrotCalc(double RealPart, double ImaginaryPart, int maxIteration, int maxMagnitude )
        {
            int iteration_number = 0;
            double a, b;
            a = RealPart;
            b=ImaginaryPart;
           
            double magnitude = 0;

            while ( iteration_number < maxIteration && (magnitude < maxMagnitude)) 
            
            {
                double temp = a * a - b * b + RealPart;
                b = 2 * a * b + ImaginaryPart;
                a = temp;

                magnitude = a * a + b * b;
                iteration_number++;
                
            }

            //Z= Z+C^2


            return iteration_number;
        }

        private void MouseMoveonDisplay(object sender, MouseEventArgs e )
        { 
            int x = e.X;
            int y = e.Y;
            Real      = Map(x, Display.Width,  set_float[0], set_float[1]);
            Imaginary = Map(y, Display.Height, set_float[2], set_float[3]);

        }
        private void MouseWheelonDisplay(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0 && scrolcount > 1)
            {
                scrolcount--;
            }
            else if (e.Delta > 0) 
            {
                scrolcount++;
            }
            
            if (scrolcount == 1)
            {
                set_float[0] = set[0];
                set_float[1] = set[1];
                set_float[2] = set[2];
                set_float[3] = set[3];
                zoom.Text = scrolcount.ToString();
                //MandelbrotSet(Magnitudo.Value, Iterations.Value, int.Parse(Width.Text), int.Parse(Height.Text), set[0], set[1], set[2], set[3]);
                if (!backGroundWorker.IsBusy)
                {
                    MaxIter = Iterations.Value;
                    MaxMagni = Magnitudo.Value;
                    SetWidth = int.Parse(Width.Text);
                    SetHeight = int.Parse(Height.Text);
                    backGroundWorker.RunWorkerAsync();
                }
            }
            else if (scrolcount > 1)
            {
                zoom_value = (long)Math.Pow(2, scrolcount);
                zoom.Text = zoom_value.ToString();
                double minx = set_float[0] = Real - (set[1] - set[0]) / zoom_value;
                double maxx = set_float[1] = Real + (set[1] - set[0]) / zoom_value;
                double miny = set_float[2] = Imaginary - (set[3] - set[2]) / zoom_value;
                double maxy = set_float[3] = Imaginary + (set[3] - set[2]) / zoom_value;

                if (!backGroundWorker.IsBusy)
                {
                    MaxIter = Iterations.Value;
                    MaxMagni = Magnitudo.Value;
                    SetWidth = int.Parse(Width.Text);
                    SetHeight = int.Parse(Height.Text);

                    backGroundWorker.RunWorkerAsync();
                }

                //MandelbrotSet(Magnitudo.Value, Iterations.Value, int.Parse(Width.Text), int.Parse(Height.Text), set_float[0], set_float[1], set_float[2], set_float[3]);
            }
            time.Text=RunTime.ToString()+ " ms";
        }
        static double Map(double value, double picSize, double min, double max) 
        {
            return min + (value / picSize) * (max - min);
        }
        void copySequental(int[,] M, int start, int end, BitmapData a)
        {
            int stride = a.Stride;
            System.IntPtr Scan0 = a.Scan0;
            Scan0 = Scan0 + start * stride;
            int offset = stride - a.Width * 3;
            int width = a.Width;
            int allPixel = width * a.Height;

            unsafe
            {
                int stridecounter = 0;
                int rowcounter = start;


                byte* p = (byte*)(void*)Scan0;
                fixed (int* Mpointer = M)
                {
                    int* movingOne = Mpointer;

                    for (int i = start; i < allPixel; i++)
                    {

                        p[0] = ColorMatrix[*movingOne, 0];
                        p[1] = ColorMatrix[*movingOne, 1];
                        p[2] = ColorMatrix[*movingOne++, 2];
                        //int temp3213 = *movingOne++;
                        p += 3;

                        stridecounter++;
                        if (stridecounter >= width)
                        {
                            p += offset;
                            stridecounter = 0;
                            rowcounter++;
                        }
                    }
                    stridecounter = 0;
                }
            }

        }
        void copyParalel(int[,] M, BitmapData a)
        {
            int allocator = 10;
            

            int[] borders = new int[allocator + 1];
            int bounch = (int)(a.Height / allocator + 0.5);
            borders[0] = 0;
            if(a.Height % allocator > 0)
            {
                borders[1] = bounch + (a.Height % allocator);
            }
            else
            {
                borders[1] = bounch;
            }

            for (int i = 1; i < borders.Length; i++)
            {
                borders[i] = borders[i - 1] + bounch;
            }

            Task[] toDolist = new Task[allocator];
            int k;

            unsafe
            {
                fixed (int* pointer = borders)
                {
                    k = 0;
                    int* iterPointer = pointer;


                    while (k <= toDolist.Length - 1)
                    {
                        

                        toDolist[k] = Task.Factory.StartNew(() =>
                        {




                            copy(M, *iterPointer, *++iterPointer, a);



                        });
                        k++;
                    }

                    Task.WaitAll(toDolist);
                }
                
            }         

        }
        
        void copy(int[,] M, int start, int end, BitmapData a)
        {
            int stride = a.Stride;
            int iNumber = (end - start)*a.Width;
            System.IntPtr Scan0 = a.Scan0;
            Scan0 = Scan0 + start * stride;
            int offset = stride - a.Width * 3;

            unsafe
            {
                int stridecounter = 0;
                int rowcounter = start;


                byte* p = (byte*)(void*)Scan0;
                for (int i = 0; i < iNumber; i++)
                {

                    int debug = M[rowcounter, stridecounter];

                    p[0] = ColorMatrix[M[rowcounter, stridecounter], 0];
                    p[1] = ColorMatrix[M[rowcounter, stridecounter], 1];
                    p[2] = ColorMatrix[M[rowcounter, stridecounter], 2];

                    p += 3;

                    stridecounter++;
                    if (stridecounter >= a.Width)
                    {
                        p += offset;
                        stridecounter = 0;
                        rowcounter++;
                    }
                }
                stridecounter = 0;
            }

        }

        private void Magnitudo_ValueChanged(object sender, EventArgs e)
        {


            int i = Magnitudo.Value;
            int magnitude = (int)Magnitudo.Value;
            Task.Run(GUI_update);
        }
        

        private void Iterations_ValueChanged(object sender, EventArgs e)
        {
            int i = Magnitudo.Value;
            int magnitude = (int)Magnitudo.Value;
            Task.Run(GUI_update);
        }
        private void GUI_update()
        {

            Thread.Sleep(22);
            if (InvokeRequired)
            {
                Invoke(new Action(() => GUI_update()));
            }
            else
            {

                int t1 = Iterations.Value;
                int t2 = Magnitudo.Value;
                Iter_count.Text = t1.ToString();
                Magni_count.Text = t2.ToString();

            }

        }
        
        private void backGroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (scrolcount > 1)
            {
                MandelbrotSet(MaxMagni, MaxIter, SetWidth, SetHeight, set_float[0], set_float[1], set_float[2], set_float[3]);
            }
            else if (scrolcount == 1) 
            {
                MandelbrotSet(MaxMagni, MaxIter, SetWidth, SetHeight, set[0], set[1], set[2], set[3]);
            }
                
           
        }
    }
}

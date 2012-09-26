using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot
{
    class Mandelbrot
    {
        public static int[] screenSize = new int[2];
        public static int[] halfScreenSize = new int[2];
        public static double[] mandelOffset = new double[2];
        public static int[] colours = new int[3];
        public static double scale;
        public static int maxIterations;

        private static int calculate(double x, double y) // Uitrekenen van het mandelgetal
        {
            double a = 0;                   // Zetten van vars
            double b = 0;
            double mandel = 0;

            int iteration;
            for (iteration = 0; iteration < maxIterations; iteration++) // Loopen totdat het maximum aantal iteraties gehaald is
            {
                double newA = a * a - b * b + x;                        // Waarde in tijdelijke double zetten
                b = 2 * a * b + y;                                      // B uitrekenen met orginele A
                a = newA;                                               // A naar nieuwe waarde zetten

                mandel = a * a + b * b; 
                if (mandel > 4)
                {
                    return iteration;                           // Als de waarde groter is dan view het aantal iteraties terugsturen
                }
            }

            return 0;                                                   // Anders 0 terug voor zwart
        }

        public static void generateImage(Graphics graphics, int start, int stepSize)
        {            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Bitmap personalBitmap = new Bitmap(screenSize[0], screenSize[1]);              // Eigen bitmap zodat er niet gewacht hoeft te worden op andere threads
                                                                            // TODO kleinere bitmap voor elke thread
            for (int x = start; x < screenSize[0]; x = x + stepSize)                // X ophogen met stepSize, afhankelijk van het aantal draaiende threads
            {
                for (int y = 0; y < screenSize[1]; y++)                            // Elke thread rekent altijd een volledige baan uit
                {
                    double scaledX = (x - halfScreenSize[0]) * scale + mandelOffset[0];     // Schalen naar mandelbrot-coordinaten
                    double scaledY = (y - halfScreenSize[1]) * scale + mandelOffset[1];

                    int mandelNum = Mandelbrot.calculate(scaledX, scaledY);    // Draaien daadwerkelijke berekening

                    personalBitmap.SetPixel(x, y, GetColor(mandelNum));

                }
            }

            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.DrawImage(personalBitmap, 0, 0);                       // Elke thread heeft zijn eigen graphics object, dus er hoeft niet gewacht te worden op elkaar

            stopwatch.Stop();
            Console.Out.WriteLine("Done in " + stopwatch.ElapsedMilliseconds);
        }

        private static Color GetColor(int mandelNum)
        {
            int red = (mandelNum % colours[0]) * (255 / colours[0]);
            int green = (mandelNum % colours[1]) * (255 / colours[1]);
            int blue = (mandelNum % colours[2]) * (255 / colours[2]);

            return Color.FromArgb(red, green, blue);
        }
    }
}

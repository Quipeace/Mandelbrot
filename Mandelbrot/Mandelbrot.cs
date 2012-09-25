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
        public static Bitmap mandel;        // Bitmap waar het uiteindelijke resultaat in wordt opgeslagen

        private static int calculate(double x, double y, int maxIterations) // Uitrekenen van het mandelgetal
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
                    return iteration;                                   // Als de waarde groter is dan view het aantal iteraties terugsturen
                }
            }

            return 0;                                                   // Anders 0 terug voor zwart
        }

        public static void generateImage(Graphics graphics, int start, int stepSize, int width, int height, int halfWidth, int halfHeight, double scale, double xOffset, double yOffset, int iterations)
        {            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Bitmap personalBitmap = new Bitmap(width, height);              // Eigen bitmap zodat er niet gewacht hoeft te worden op andere threads
                                                                            // TODO kleinere bitmap voor elke thread
            for (int x = start; x < width; x = x + stepSize)                // X ophogen met stepSize, afhankelijk van het aantal draaiende threads
            {
                for (int y = 0; y < height; y++)                            // Elke thread rekent altijd een volledige baan uit
                {
                    double scaledX = (x - halfWidth) * scale + xOffset;     // Schalen naar mandelbrot-coordinaten
                    double scaledY = (y - halfHeight) * scale + yOffset;

                    int mandelNum = Mandelbrot.calculate(scaledX, scaledY, iterations);    // Draaien daadwerkelijke berekening
                    if (mandelNum % 2 != 0)
                    {
                        personalBitmap.SetPixel(x, y, Color.White);         // Getal is even, dus wit
                    }
                    else
                    {
                        personalBitmap.SetPixel(x, y, Color.Black);         // Oneven geeft zwart
                    }
                }
            }
            
            graphics.DrawImage(personalBitmap, 0, 0);                       // Elke thread heeft zijn eigen graphics object, dus er hoeft niet gewacht te worden op elkaar

            stopwatch.Stop();
            Console.Out.WriteLine("Done in " + stopwatch.ElapsedMilliseconds);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Mandelbrot, door Quint Stoffers (3990435) en William Kos (3933083).
 * 03-10-2012
*/

namespace Mandelbrot
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();       // "Eyecandy"
            Application.Run(new MandelbrotForm());  // Nieuw formpje draaien
        }
    }
}

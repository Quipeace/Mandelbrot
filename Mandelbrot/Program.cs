using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

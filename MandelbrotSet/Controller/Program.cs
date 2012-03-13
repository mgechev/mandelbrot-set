using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MandelbrotSet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new Main();
            form.Fractal = new Mandelbrot();
            Application.Run(form);
        }
    }
}

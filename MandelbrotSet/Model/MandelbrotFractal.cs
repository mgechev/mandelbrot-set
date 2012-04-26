using System;
using System.Drawing;

namespace MandelbrotSet
{
    public class MandelbrotFractal : IFractal
    {
        private int iterations;

        public int Iterations
        {
            get
            {
                return this.iterations;
            }
            set
            {
                this.iterations = value;
            }
        }

        public int GetIterations(double x, double y, Size size, double scale)
        {
            double x0 = (-x / size.Width) * scale;
            double y0 = (-y / size.Height) * scale;
            x = 0;
            y = 0;
            var i = 0;
            double tempX = 0;
            while (x * x + y * y < 4 && i < Iterations)
            {
                tempX = x * x - y * y + x0;
                y = 2 * x * y + y0;

                x = tempX;
                i += 1;
            }
            return i;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MandelbrotSet
{
    class Mandelbrot : IFractal
    {
        private Color[] colors = {
                                    Color.FromArgb(0, 0, 0),
                                     Color.FromArgb(1, 5, 0),
                                     Color.FromArgb(2, 12, 0),
                                     Color.FromArgb(3, 22, 0),
                                     Color.FromArgb(4, 32, 0),
                                     Color.FromArgb(5, 42, 0),
                                     Color.FromArgb(6, 52, 0),
                                     Color.FromArgb(6, 62, 0),
                                     Color.FromArgb(7, 72, 0),
                                     Color.FromArgb(7, 82, 0)
                                 };
        public void Draw(Bitmap area)
        {
            Size size = new Size(area.Width, area.Height);
            Color color;
            Color temp = Color.Fuchsia;
            Graphics g = Graphics.FromImage(area);
            int midHeight = size.Height / 2;
            int midWidth = size.Width / 2 - size.Width / 8;
            for (double i = 0; i < size.Width; i += 1)
            {
                for (double j = 0; j < size.Height; j += 1)
                {
                    color = this.HandlePixel(i - midWidth, j - midHeight, size);
                    g.DrawRectangle(new Pen(new SolidBrush(color)), (int)i, (int)j, 1, 1);
                    temp = color;
                }
            }
        }

        private Color HandlePixel(double x, double y, Size size)
        {
            Color color;
            double x0 = (- x / size.Width) * 4;
            double y0 = (-y / size.Height) * 4;
            x = 0;
            y = 0;
            var i = 0;
            var maxI = 100;
            double tempX = 0;
            while (x * x + y * y < 4 && i < maxI)
            {
                tempX = x * x - y * y + x0;
                y = 2 * x * y + y0;

                x = tempX;
                i += 1;
            }
            color = GetColor(i);

            if (i != 128)
            {
                var g = 0;
            }
            return color;
        }

        private Color GetColor(int iterations)
        {
            return colors[iterations % colors.Length];
        }
    }
}

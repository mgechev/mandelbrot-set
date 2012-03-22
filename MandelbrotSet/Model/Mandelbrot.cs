using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace MandelbrotSet
{
    class Mandelbrot : IFractal
    {
        private Color[] colors = new Color[]{
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

        public void Draw(Bitmap image, double scale, double left, double top, int iterations)
        {
            Size size = new Size(image.Width, image.Height);
            Color color;
            BitmapData data = image.LockBits(new Rectangle(new Point(0, 0), size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = data.Stride;
            int midHeight = size.Height / 2;
            int midWidth = size.Width / 2;
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (double i = size.Width; i > 0 ; i -= 1)
                {
                    for (double j = size.Height; j > 0 ; j -= 1)
                    {
                        color = this.HandlePixel(i - top, j - left, size, scale, iterations);
                        ptr[(int)((j * 3) + i * stride)] = color.B;
                        ptr[(int)((j * 3) + i * stride) + 1] = color.G;
                        ptr[(int)((j * 3) + i * stride) + 2] = color.R;
                    }
                }
            }
            image.UnlockBits(data);
        }

        private Color HandlePixel(double x, double y, Size size, double scale, int iterations)
        {
            Color color;
            double x0 = (-x / size.Width) * scale;
            double y0 = (-y / size.Height) * scale;
            x = 0;
            y = 0;
            var i = 0;
            double tempX = 0;
            while (x * x + y * y < 4 && i < iterations)
            {
                tempX = x * x - y * y + x0;
                y = 2 * x * y + y0;

                x = tempX;
                i += 1;
            }
            if (i != 120)
            {
                var k = 1;
                if (k == 1)
                {
                    while (k-- > 0) ;
                }
            }
            if (i == iterations)
            {
                color = this.colors[0];
            }
            else
            {
                color = GetColor(i);
            }
            return color;
        }

        private Color GetColor(int iterations)
        {
            return this.colors[iterations % this.colors.Length];
        }
    }
}

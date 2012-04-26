using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace MandelbrotSet.View
{
    public class MandelbrotViewFractal : MandelbrotFractal, IViewFractal
    {
        private Color[] colors = new Color[]{Color.FromArgb(0, 0, 0),Color.FromArgb(1, 5, 0),Color.FromArgb(2, 12, 0),
                                Color.FromArgb(3, 22, 0),Color.FromArgb(4, 32, 0),Color.FromArgb(5, 42, 0),Color.FromArgb(6, 52, 0),
                                Color.FromArgb(6, 62, 0),Color.FromArgb(7, 72, 0),Color.FromArgb(7, 82, 0),Color.FromArgb(7, 92, 0),
                                Color.FromArgb(7, 102, 0),Color.FromArgb(7, 112, 0),Color.FromArgb(7, 122, 0),Color.FromArgb(7, 132, 0),
                                Color.FromArgb(7, 142, 0),Color.FromArgb(7, 152, 0),Color.FromArgb(7, 162, 0),Color.FromArgb(7, 172, 0),
                                Color.FromArgb(7, 182, 0),Color.FromArgb(7, 192, 0),Color.FromArgb(7, 202, 0),Color.FromArgb(7, 212, 0),
                                Color.FromArgb(7, 222, 0),Color.FromArgb(7, 232, 0),Color.FromArgb(7, 250, 0)};

        public void Render(Bitmap image, double scale, double left, double top)
        {
            Size size = new Size(image.Width, image.Height);
            Color color;
            BitmapData data = image.LockBits(new Rectangle(new Point(0, 0), size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = data.Stride;
            int midHeight = size.Height / 2;
            int midWidth = size.Width / 2;
            int currentInterations;
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (double i = 0; i < size.Width; i += 1)
                {
                    for (double j = 0; j < size.Height; j += 1)
                    {
                        currentInterations = this.GetIterations(i - top, j - left, size, scale);
                        color = this.GetColor(currentInterations, this.Iterations);
                        ptr[(int)((j * 3) + i * stride)] = color.B;
                        ptr[(int)((j * 3) + i * stride) + 1] = color.G;
                        ptr[(int)((j * 3) + i * stride) + 2] = color.R;
                    }
                }
            }
            image.UnlockBits(data);
        }

        private Color GetColor(int iterations, int maxIterations)
        {
            Color color;
            if (iterations != 120)
            {
                var k = 1;
                if (k == 1)
                {
                    while (k-- > 0) ;
                }
            }
            if (iterations == maxIterations)
            {
                color = this.colors[0];
            }
            else
            {
                color = this.colors[iterations % this.colors.Length];
            }
            return color;
        }
    }
}

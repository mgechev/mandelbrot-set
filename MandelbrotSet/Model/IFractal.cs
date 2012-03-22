using System.Drawing;

namespace MandelbrotSet
{
    public interface IFractal
    {
        void Draw(Bitmap image, double scale, double left, double top, int iterations);
    }
}

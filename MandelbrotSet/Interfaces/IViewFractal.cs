using System.Drawing;

namespace MandelbrotSet.View
{
    public interface IViewFractal : IFractal
    {
        void Render(Bitmap image, double scale, double left, double top);
    }
}

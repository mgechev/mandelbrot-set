using System;
using System.Drawing;

namespace MandelbrotSet.Interfaces
{
    public interface IMainView
    {
        event EventHandler RenderButtonClicked;
        event EventHandler ClearButtonClicked;
        event EventHandler CloseButtonClicked;
        event EventHandler TopButtonClicked;
        event EventHandler BottomButtonClicked;
        event EventHandler LeftButtonClicked;
        event EventHandler RightButtonClicked;
        event EventHandler ZoomInButtonClicked;
        event EventHandler ZoomOutButtonClicked;
        event EventHandler IterationsValueChanged;

        Bitmap Canvas
        {
            get;
        }

        int Iterations
        {
            get;
        }

        void ClearCanvas();
        void Refresh();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MandelbrotSet.Interfaces;
using MandelbrotSet.View;
using System.Drawing;

namespace MandelbrotSet.MainController
{
    public class MainController
    {
        private IMainView view;
        private IViewFractal fractal;
        private double scale = 0.1;
        private double left = 0;
        private double top = 0;
        private double zoomStep = 0.1;
        private double translationStep = 10;

        public MainController(IMainView view)
        {
            this.view = view;
            this.view.ClearCanvas();
            this.fractal = new MandelbrotViewFractal();
            this.InitializeVariables();

            this.view.BottomButtonClicked += new EventHandler(ButtomButtonClicked);
            this.view.LeftButtonClicked += new EventHandler(LeftButtonClicked);
            this.view.RightButtonClicked += new EventHandler(RightButtonClicked);
            this.view.TopButtonClicked += new EventHandler(TopButtonClicked);
            this.view.ClearButtonClicked += new EventHandler(ClearButtonClicked);
            this.view.CloseButtonClicked += new EventHandler(CloseButtonClicked);
            this.view.IterationsValueChanged += new EventHandler(IterationsValueChanged);
            this.view.RenderButtonClicked += new EventHandler(RenderButtonClicked);
            this.view.ZoomInButtonClicked += new EventHandler(ZoomInButtonClicked);
            this.view.ZoomOutButtonClicked += new EventHandler(ZoomOutButtonClicked);

            this.RenderFractal();
        }

        public void InitializeVariables()
        {
            var point = new Point(this.view.Canvas.Width / 2, this.view.Canvas.Height / 2);
            this.left = point.X;
            this.top = point.Y - point.Y / 2;
            this.scale = 3;
            this.fractal.Iterations = this.view.Iterations;
        }

        void ZoomOutButtonClicked(object sender, EventArgs e)
        {
            this.scale += this.zoomStep;
            this.RenderFractal();
        }

        void ZoomInButtonClicked(object sender, EventArgs e)
        {
            this.scale -= this.zoomStep;
            this.RenderFractal();
        }

        void TopButtonClicked(object sender, EventArgs e)
        {
            this.top += this.translationStep;
            this.RenderFractal();
        }

        void RightButtonClicked(object sender, EventArgs e)
        {
            this.left -= this.translationStep;
            this.RenderFractal();
        }

        void RenderButtonClicked(object sender, EventArgs e)
        {
            this.RenderFractal();
        }

        void LeftButtonClicked(object sender, EventArgs e)
        {
            this.left += this.translationStep;
            this.RenderFractal();
        }

        void IterationsValueChanged(object sender, EventArgs e)
        {
            this.fractal.Iterations = this.view.Iterations;
            this.RenderFractal();
        }

        void CloseButtonClicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        void ClearButtonClicked(object sender, EventArgs e)
        {
            this.view.ClearCanvas();
        }

        public void ButtomButtonClicked(object sender, EventArgs e)
        {
            this.top -= this.translationStep;
            this.RenderFractal();
        }

        private void RenderFractal()
        {
            this.view.ClearCanvas();
            
            this.fractal.Render(this.view.Canvas, this.scale, this.left, this.top);
            this.view.Refresh();
        }
    }
}

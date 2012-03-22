using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MandelbrotSet
{
    public partial class Main : Form
    {
        private Bitmap image;
        private IFractal fractal;
        private double scale = 0.1;
        private double left = 0;
        private double top = 0;
        private double zoomStep = 0.1;
        private double translationStep = 10;
        private int iterations;
        
        public Bitmap Image
        {
            get
            {
                return image;
            }
        }

        public IFractal Fractal
        {
            get
            {
                return fractal;
            }
            set
            {
                if (value != null)
                {
                    fractal = value;
                }
            }
        }

        public Main()
        {
            InitializeComponent();
            this.renderButton.Select();
            this.InitializeSettings();
            this.RenderImage();
            this.fractal = new Mandelbrot();
            this.Render();
        }

        private void InitializeSettings()
        {
            var point = new Point(FractalCanvas.Width / 2, FractalCanvas.Height / 2);
            this.left = point.X;
            this.top = point.Y - point.Y / 2;
            this.scale = 3;
            this.iterations = this.iterationsInput.Value;
        }

        private void renderButtonClick(object sender, EventArgs e)
        {
            this.Render();
        }

        private void clearButtonClick(object sender, EventArgs e)
        {
            this.RenderImage();
        }

        private void Render()
        {
            fractal.Draw(this.image, this.scale, this.left, this.top, this.iterations);
            FractalCanvas.Image = this.image;
        }

        private void RenderImage()
        {
            Size size = new Size(FractalCanvas.Width, FractalCanvas.Height);
            image = new Bitmap(size.Width, size.Height);
            FractalCanvas.Image = image;
            this.InitializeSettings();
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void topButtonClick(object sender, EventArgs e)
        {
            this.top += this.translationStep;
            this.Render();
        }

        private void bottomButtonClick(object sender, EventArgs e)
        {
            this.top -= this.translationStep;
            this.Render();
        }

        private void leftButtonClick(object sender, EventArgs e)
        {
            this.left += this.translationStep;
            this.Render();
        }

        private void rightButtonClick(object sender, EventArgs e)
        {
            this.left -= this.translationStep;
            this.Render();
        }

        private void zoomInButtonClick(object sender, EventArgs e)
        {
            this.scale -= this.zoomStep;
            this.Render();
        }

        private void zoomOutButtonClick(object sender, EventArgs e)
        {
            this.scale += this.zoomStep;
            this.Render();
        }

        private void iterationsInputValueChanged(object sender, EventArgs e)
        {
            this.iterations = this.iterationsInput.Value;
            this.Render();
        }

    }
}

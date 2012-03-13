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
        }

        private void renderButtonClick(object sender, EventArgs e)
        {
            fractal.Draw(image);
            FractalCanvas.Image = image;
        }

        private void clearButtonClick(object sender, EventArgs e)
        {
            Size size = new Size(FractalCanvas.Width, FractalCanvas.Height);
            image = new Bitmap(size.Width, size.Height);
            FractalCanvas.Image = image;
        }
    }
}

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
    public partial class SettingsWindow : Form
    {
        private static SettingsWindow instance;

        private SettingsWindow()
        {
            InitializeComponent();
        }

        public int Iterations
        {
            get
            {
                return this.iterationsTrackbar.Value;
            }
        }

        public Color Color
        {
            get
            {
                KnownColor color;
                switch (this.colorsCombobox.SelectedText)
                {
                    case "Red":
                        color = KnownColor.Red;
                        break;
                    case "Green":
                        color = KnownColor.Green;
                        break;
                    default:
                        color = KnownColor.Blue;
                        break;
                }
                return Color.FromKnownColor(color);
            }
        }

        public static SettingsWindow GetWindow()
        {
            if (instance == null)
            {
                instance = new SettingsWindow();
            }
            return instance;
        }

        private void cancelButtonClick(object sender, EventArgs e)
        {
            instance.Hide();
        }

        private void okButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            instance.Hide();
        }
    }
}

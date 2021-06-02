using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hw_12._6
{
    public partial class Painter : Form
    {
        bool shouldPaint = false; // whether to paint
        GroupBox colors;
        GroupBox sizes;
        Dictionary<String, Color> colorTypes = new Dictionary<String, Color>()
        {
            { "Red", Color.Red },
            { "Blue", Color.Blue },
            { "Green", Color.Green},
            { "Black", Color.Black}
        };
        Dictionary<String, int> sizeTypes = new Dictionary<String, int>()
        {
            { "Small", 4},
            { "Medium", 8},
            { "Large", 12}
        };

        Graphics graphics;
        Color selectedColor;
        int selectedSize;

        /// creates a form as a drawing surface
        public Painter()
        {
            InitializeComponent();
            colors = gbColors;
            sizes = gbSizes;
        }

        /// The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.Run(new Painter());
        }

        // should paint after mouse button has been pressed
        private void Painter_MouseDown(object sender, MouseEventArgs e)
        {

            RadioButton checkedColor = getSelectedRadioButton(colors);
            RadioButton checkedSize = getSelectedRadioButton(sizes);
            selectedColor = colorTypes[checkedColor.Text];
            selectedSize = sizeTypes[checkedSize.Text];
            shouldPaint = true;
        }

        private RadioButton getSelectedRadioButton(GroupBox groupBox)
        {

            foreach (RadioButton rdo in groupBox.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    return rdo;
                }
            }
            throw new Exception("Radio button should be selected");
        }

        // stop painting when mouse button released
        private void Painter_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        // draw circle whenever mouse button moves (and mouse is down)
        protected void Painter_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint)
            {
                graphics = CreateGraphics();
                graphics.FillEllipse(new SolidBrush(selectedColor), e.X, e.Y, selectedSize, selectedSize);
            }

        } // end Painter_MouseMove

    } // end class Painter
}
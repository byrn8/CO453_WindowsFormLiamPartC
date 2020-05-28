using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453_WindowsFormLiamPartC.Unit_6
{
    /// <summary>
    /// This class was used for task 6.2 and will draw several different rectangles and an ellipse (Graphics2Form)
    /// </summary>
    public partial class Graphics2Form : Form
    {
        /// <summary>
        /// Constructor used for the form
        /// </summary>
        public Graphics2Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used to draw the rectangles and ellipse in the form
        /// </summary>
        private void Graphics2Form_Paint(object sender, PaintEventArgs e)
        {
            int x = 80, y = 10;
            int w = 300, h = 200;
            Graphics g = e.Graphics;

            Pen myPen = new Pen(Color.Blue, 10);

            for (int i = 0;i < 6;i++)
            {
                g.DrawRectangle(myPen, x, y, w, h);
                g.FillRectangle(Brushes.Red, x, y, w, h);

                x = x + 15;
                y = y + 10;
                w = w - 30;
                h = h - 20;
            }

            //g.DrawEllipse(myPen, x, y, w, h);
            //g.FillEllipse(Brushes.Yellow, x, y, w, h);
        }

        /// <summary>
        /// This method was used to set the background colour of the form
        /// </summary>
        private void Graphics2Form_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}

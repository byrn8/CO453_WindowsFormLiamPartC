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
    /// This form was used for task 6.3 and will display a hexagon and a string for the user (Graphic3Form)
    /// </summary>
    public partial class Graphics3Form : Form
    {
        /// <summary>
        /// Constructor used for the form
        /// </summary>
        public Graphics3Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used to set the back colour of the form
        /// </summary>
        private void Graphics3Form_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        /// <summary>
        /// This method was used to draw the hexagon and display the message beneath it
        /// </summary>
        private void Graphics3Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Red, 10);

            Point[] shape = new Point[6];
            shape[0] = new Point(100, 150);
            shape[1] = new Point(200, 250);
            shape[2] = new Point(400, 250);
            shape[3] = new Point(500, 150);
            shape[4] = new Point(400, 50);
            shape[5] = new Point(200, 50);

            Font myFont = new Font("Arial", 20);

            g.DrawPolygon(myPen, shape);
            g.FillPolygon(Brushes.Red, shape);
            g.DrawString("Liam's Hexagon", myFont, Brushes.Blue, 200, 300);
        }
    }
}

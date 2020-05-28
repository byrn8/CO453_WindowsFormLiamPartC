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
    /// This class was used for task 6.5 and will draw 10 circles inside of each other (CircleGraphicForm)
    /// </summary>
    public partial class CircleGraphicForm : Form
    {
        int red, green, blue;
        int w = 350, h = 350, x = 16, y = 10;
        
        /// <summary>
        /// Constructor used for the form
        /// </summary>
        public CircleGraphicForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used for to
        /// </summary>
        private void CircleGraphicForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Red, 10);

            Random r = new Random();
            red = r.Next(256);
            green = r.Next(256);
            blue = r.Next(256);

            for (int i = 0; i < 9; i++)
            {
                g.DrawEllipse(myPen, x, y, w, h);

                w = w - 34;
                h = h - 34;
                x = x + 17;
                y = y + 17;
            }
        }
    }
}

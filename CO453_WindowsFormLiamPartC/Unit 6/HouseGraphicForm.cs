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
    /// This class was used for task 6.9 and will draw a house when the form is launched (HouseGraphicForm)
    /// </summary>
    public partial class HouseGraphicForm : Form
    {
        /// <summary>
        /// Constructor used for the form
        /// </summary>
        public HouseGraphicForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used to draw the house usong different shapes
        /// </summary>
        private void HouseGraphicForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Cornsilk, 5);
            Pen myPen2 = new Pen(Color.MediumAquamarine, 5);
            Pen myPen3 = new Pen(Color.Firebrick, 5);
            Pen myPen4 = new Pen(Color.LightSeaGreen, 5);
            Pen myPen5 = new Pen(Color.YellowGreen, 5);

            g.DrawRectangle(myPen, 90, 130, 400, 200);

            Point[] shape1 = new Point[3];
            shape1[0] = new Point(290, 10);
            shape1[1] = new Point(495, 130);
            shape1[2] = new Point(85, 130);
            
            g.DrawPolygon(myPen2, shape1);

            g.DrawRectangle(myPen3, 269, 250, 40, 80);

            g.DrawRectangle(myPen4, 160, 180, 40, 40);

            g.DrawRectangle(myPen4, 370, 180, 40, 40);

            Point[] shape2 = new Point[4];
            shape2[0] = new Point(390, 70);
            shape2[1] = new Point(390, 30);
            shape2[2] = new Point(420, 30);
            shape2[3] = new Point(420, 87);

            g.DrawPolygon(myPen5, shape2);
        }
    }
}

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
    /// This class was used for task 6.4 and will show different shapes based on user input (PickGraphicForm)
    /// </summary>
    public partial class PickGraphicForm : Form
    {
        string inputColour;
        int ran1, ran2;

        /// <summary>
        /// Constructor used for the form
        /// </summary>
        public PickGraphicForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used to display the various different shapes
        /// </summary>
        private void PickGraphicForm_Paint(object sender, PaintEventArgs e)
        {
            ReadInputTextBox.Text = inputColour.ToString();

            Graphics g = e.Graphics;
            Pen myPen = new Pen(Brushes.Red, 10);

            Random r = new Random();

            if (inputColour == "L" || inputColour == "l")
            {

            }

            else if (inputColour == "R" || inputColour == "r")
            {
                ran1 = r.Next(300);
                ran2 = r.Next(350);

                g.DrawRectangle(myPen, 40, 100, ran2, ran1);
                g.FillRectangle(Brushes.Red, 40, 100, ran2, ran1);
            }

            else if (inputColour == "E" || inputColour == "e")
            {

            }

            else if (inputColour == "C" || inputColour == "c")
            {

            }

            else if (inputColour == "S" || inputColour == "s")
            {

            }

            else if (inputColour == "M" || inputColour == "m")
            {

            }
        }
    }
}

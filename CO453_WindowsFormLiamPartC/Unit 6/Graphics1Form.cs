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
    /// This class was used for task 6.1 and will display dialogue using draw string (Graphics1Form)
    /// </summary>
    public partial class Graphics1Form : Form
    {
        /// <summary>
        /// Constructor used for the form
        /// </summary>
        public Graphics1Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used to draw the string and display the back colour of the form using a for loop
        /// </summary>
        private void Graphics1Form_Paint(object sender, PaintEventArgs e)
        {
            int x = 50;
            int y = 20;

            Graphics g = e.Graphics;
            Font myFont = new Font("Broadway", 30);

            System.Threading.Thread.Sleep(1000);

            for (int i = 0; i < 6; i++)
            {
                this.BackColor = Color.Yellow;
                g.DrawString("Liam is texting a Window\n", myFont, Brushes.Red, x, y);
                System.Threading.Thread.Sleep(500);
                y = y + 60;
            }
        }
    }
}

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
    /// This class was used for task 6.6 and will display a bouncing ball game (BallForm)
    /// </summary>
    public partial class BallForm : Form
    {
        int x = 200, y = 50, x2 = 300, y2 = 100;
        int xmove = 10, ymove = 10, x2move = 10, y2move = 10;
        int wh = 30;

        /// <summary>
        /// Constructor used for the form
        /// </summary>
        public BallForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used to stop the first ball going out of the picture box boudary
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            x += xmove;
            y += ymove;

            Refresh();

            if (y + wh >= DisplayPictureBox.Height || y == 0)
            {
                ymove = -ymove;
            }

            else if (x + wh >= DisplayPictureBox.Width || x == 0)
            {
                xmove = -xmove;
            }
        }

        /// <summary>
        /// This method was used for the start button and will activate the timer
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            Timer2.Enabled = true;
        }

        /// <summary>
        /// This method was used for the stop button and will deactivate the timer
        /// </summary>
        private void StopButton_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
            Timer2.Enabled = false ;
        }

        /// <summary>
        /// This method was used to stop the second ball going out of the picture box boudary
        /// </summary>
        private void Timer2_Tick(object sender, EventArgs e)
        {
            x2 += x2move;
            y2 += y2move;

            Refresh();

            if (y2 + wh >= DisplayPictureBox.Height || y2 == 0)
            {
                y2move = -y2move;
            }

            else if (x2 + wh >= DisplayPictureBox.Width || x2 == 0)
            {
                x2move = -x2move;
            }
        }

        /// <summary>
        /// This method was used for the quit button and will exit the form when pressed
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 
        /// </summary>
        private void BallForm_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// This method was used to paint the ball in the picture box
        /// </summary>
        private void DisplayPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillEllipse(Brushes.Fuchsia, x, y, wh, wh);
            g.FillEllipse(Brushes.Aquamarine, x2, y2, wh, wh);
        }

        /// <summary>
        /// This method was used to recognise the key presses
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            string input;
            input = keyData.ToString();

            if (input == "Up" || input == "Down" || input == "C")
            {
                if (input == "Up")
                {
                    wh = wh + 5;
                }

                else if (input == "Down")
                {
                    wh = wh - 5;
                }

                else if (input == "C")
                {
                    DisplayPictureBox.BackColor = Color.CadetBlue;
                }

                return true;
            }

            return false;
        }
    }
}

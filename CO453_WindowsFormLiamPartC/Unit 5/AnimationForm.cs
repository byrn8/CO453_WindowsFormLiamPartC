using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453_WindowsFormLiamPartC.Unit_5
{
    /// <summary>
    /// This class is used to display an animated helicopter moving accross a background and was used for task 5.3 (AnimationForm)
    /// </summary>
    public partial class AnimationForm : Form
    {
        const int MAX = 4;
        Image[] pics = new Image[MAX];
        Image[] pics2 = new Image[MAX];
        int count = 0;
        int bgCount = 0;

        /// <summary>
        /// Constructor used for the animation form
        /// </summary>
        public AnimationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used to define the array that stores the images used in the helicopter animation when the form is loaded
        /// </summary>
        private void AnimationForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < MAX; i++)
            {
                pics[i] = Image.FromFile("copter" + i + ".gif");
                pics2[i] = Image.FromFile("pig" + i + ".gif");
            }
        }

        /// <summary>
        /// This method was used to display the images into the picture box and move the picture box. Also changes bg image in task 5.4
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            MovePictureBox.Image = pics[count];
            MovePictureBox2.Image = pics2[count];
            count++;
            if (count == MAX) count = 0;
            MovePictureBox.Left = MovePictureBox.Left + 10;
            MovePictureBox2.Left = MovePictureBox2.Left + 10;

            if (MovePictureBox2.Left >= this.Width || MovePictureBox2.Top >= this.Height)
            {
                MovePictureBox2.Left = 0;
                MovePictureBox2.Top = MovePictureBox2.Top + 10;

                if (bgCount%2 == 0)
                {
                    Bitmap bm = new Bitmap("City2.wmf");
                    this.BackgroundImage = bm;
                }
                
                else
                {
                    Bitmap bm = new Bitmap("City1.wmf");
                    this.BackgroundImage = bm;
                }

                bgCount++;
            }

            if (MovePictureBox.Left >= this.Width || MovePictureBox.Top >= this.Height)
            {
                MovePictureBox.Left = 0;
                MovePictureBox.Top = MovePictureBox.Top + 10;
            }
        }

        /// <summary>
        /// This method was used to enable the timer when the start button is checked
        /// </summary>
        private void StartRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        /// <summary>
        /// This method was used to disable the timer when the stop button is checked
        /// </summary>
        private void StopRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Timer.Enabled = false;
        }

        /// <summary>
        /// This method was used for the quit button and will exit the application when pressed
        /// </summary>
        private void ClickQuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method was used for the scroll bar that will change the speed of the helicopter animation
        /// </summary>
        private void ChangeSpeedBar_Scroll(object sender, ScrollEventArgs e)
        {
            int amount = ChangeSpeedBar.Value + 1;
            Timer.Interval = 1000 / amount;
        }
    }
}

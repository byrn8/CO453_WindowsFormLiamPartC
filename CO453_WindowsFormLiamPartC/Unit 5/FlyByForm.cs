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
    /// This class is used to display an animated horse and was used for task 5.1 and 5.2 (FlyByForm)
    /// </summary>
    public partial class FlyByForm : Form
    {
        int count = 0;
        const int MAX = 8;
        Image[] images = new Image[MAX];

        /// <summary>
        /// Constructor used for the fly by form
        /// </summary>
        public FlyByForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used to define the array that stores the images for the animation when the form is loaded
        /// </summary>
        private void FlyByForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < MAX; i++)
            {
                images[i] = Image.FromFile("horsey" + i + ".gif");
            }
        }

        /// <summary>
        /// This method was used for the quit button and will exit the application when pressed
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method was used for the start button and will activate the timer and animation when pressed
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        /// <summary>
        /// This method was used for the stop button and will stop the timer and animation when pressed
        /// </summary>
        private void StopButton_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
        }

        /// <summary>
        /// This method was used to display the images into the picture box using the ticks of the timer (100ms)
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (count > 7)
            {
                count = 0;
            }

            PictureBox.Image = images[count];
            count++;
        }

        /// <summary>
        /// This method was used to display the date and time using the second timer that was set up
        /// </summary>
        private void Timer2_Tick(object sender, EventArgs e)
        {
            DisplayDateLabel.Text = DateTime.Now.ToLongDateString();
            DisplayTimeLabel.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453_WindowsFormLiamPartC.Unit_7
{
    /// <summary>
    /// This class was used for the etchasketch project in unit 7 and will create an etchasketch for the user (EtchaSketchForm)
    /// </summary>
    public partial class EtchaSketchForm : Form
    {
        int x = 50, y = 50;
        Bitmap bm;

        /// <summary>
        /// Constructor used for the form
        /// </summary>
        public EtchaSketchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used to define the graphic used for the etchasketch
        /// </summary>
        private void EtchaSketchForm_Load(object sender, EventArgs e)
        {
            bm = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bm);
            g.FillEllipse(Brushes.Blue, x, y, 20, 20);
            this.BackgroundImage = bm;
        }

        /// <summary>
        /// This method was used to define the graphic used for the etchasketch
        /// </summary>
        private void EtchaSketchForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(bm);
            g.FillEllipse(Brushes.Blue, x, y, 20, 20);
        }

        /// <summary>
        /// This method was used for the button inputs on the etchasketch
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            string input;
            input = keyData.ToString();

            if (input == "Up" || input == "Down" || input == "Left" || input == "Right" || input == "C" || input == "Escape")
            {
                if (input == "Up")
                {
                    y = y - 10;
                    Refresh();
                }

                else if (input == "Down")
                {
                    y = y + 10;
                    Refresh();
                }

                else if (input == "Left")
                {
                    x = x - 10;
                    Refresh();
                }

                else if (input == "Right")
                {
                    x = x + 10;
                    Refresh();
                }

                else if (input == "C")
                {
                    //
                }

                else if (input == "Escape")
                {
                    DialogResult response;
                    response = MessageBox.Show("Do you want to exit?", "Check",
                    MessageBoxButtons.YesNo);
                    if (response == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }

                return true;
            }

            return false;
        }
    }
}

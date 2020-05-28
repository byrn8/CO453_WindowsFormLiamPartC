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
    /// This class was used for task 6.7 and will... (TestKeysForm)
    /// </summary>
    public partial class TestKeysForm : Form
    {
        /// <summary>
        /// Constructor used for the form
        /// </summary>
        public TestKeysForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method was used to recognise the key presses
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            string input;
            input = keyData.ToString();

            if (input == "B" || input == "Up" || input == "Down")
            {
                if (input == "B")
                {
                    MessageBox.Show("You pressed B");
                }

                else if (input == "Up")
                {
                    MessageBox.Show("You pressed Up");
                }

                else if (input == "Down")
                {
                    MessageBox.Show("You pressed Down");
                }

                return true;
            }

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CO453_WindowsFormLiamPartC.Unit_5;
using CO453_WindowsFormLiamPartC.Unit_6;
using CO453_WindowsFormLiamPartC.Unit_7;

namespace CO453_WindowsFormLiamPartC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new 
            //FlyByForm() //Used for tasks 5.1 and 5.2
            //AnimationForm() //Used for task 5.3 to 5.7
            //Graphics1Form() //Used for task 6.1
            //Graphics2Form() //Used for task 6.2
            //Graphics3Form() //Used for task 6.3
            //PickGraphicForm() //Used for task 6.4 //NOT DONE
            //CircleGraphicForm() //Used for task 6.5 //NOT DONE
            //BallForm() //Used for task 6.6, 6.7 and 6.8
            //HouseGraphicForm() //Used for task 6.9
            EtchaSketchForm() //Used for the Unit 7 Project
                );
        }
    }
}

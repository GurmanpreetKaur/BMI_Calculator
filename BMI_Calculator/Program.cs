using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name  - Gurmanpreet Kaur 
 * Student Number - 300933392
 * description - Created the form for BMI Calculator
 * version 0.1 - Created the project
 * */
namespace BMI_Calculator
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
            Application.Run(new BMIcalculator());
        }
    }
}

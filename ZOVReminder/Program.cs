using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZOVReminder.Classes;
using ZOVReminder.Forms;

namespace ZOVReminder
{
    static class Program
    {
        public static Security Security = new Security();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if DEBUG
            Application.Run(new frmLogin());
            Application.Run(new frmMainMDI());
            //Application.Run(new frmMain());
#else
            Application.Run(new frmMain());
#endif

        }
    }
}

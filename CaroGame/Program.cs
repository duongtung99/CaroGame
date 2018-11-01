using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroGame
{
    static class Program
    {
        public static Pen pen;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            pen = new Pen(Color.White);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Home());
=======
            Application.Run(new LoginCaro());
>>>>>>> 8ee82a2fabd5c0262de72ad40e5594bb67645823
        }
    }
}

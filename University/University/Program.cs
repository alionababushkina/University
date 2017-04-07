using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Autorization());
            Application.Run(new Student());
            Application.Run(new Teacher());
            Application.Run(new Administrator());
            Application.Run(new Add());
            Application.Run(new Change());
        }
    }
}

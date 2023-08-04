using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MvpActionSimple.Presenters;

namespace MvpActionSimple
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 form1 = new Form1();
            Presenter presenter = new Presenter(form1);
            Application.Run(form1);
        }
    }
}

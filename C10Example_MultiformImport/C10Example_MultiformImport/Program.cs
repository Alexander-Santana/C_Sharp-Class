//Name: Alexander Santana
//Date: 3/25/2025
//Assignment: Advanced C# Programming: Chapter-10...Importing an Existing Form

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C10Example_MultiformImport
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
            Application.Run(new ColorForm()); //for some reason, this was instanciating
                                              //DashboardForm instead of ColorForm. Took
                                              //me FOREVER to figure it out
        }
    }
}

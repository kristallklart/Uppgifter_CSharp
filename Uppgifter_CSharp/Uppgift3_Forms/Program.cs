using System;
using System.Windows.Forms;

namespace Uppgift3_Forms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Uppgift3Form());
        }
    }
}

using System;
using System.Windows.Forms;
using Common;

namespace PCSX2_Memory_Explorer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instantiate the FormFactory
            IFormFactory formFactory = new FormFactory();
            Application.Run(new MemoryManager(formFactory));
        }
    }
}
using System;
using System.Windows.Forms;
using Common;
using Ratchet___Clank;

namespace PCSX2_Memory_Explorer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instantiate the factory from the Ratchet ___ Clank project
            IFormFactory formFactory = new FormFactory();
            Application.Run(new MemoryManager(formFactory));
        }
    }
}
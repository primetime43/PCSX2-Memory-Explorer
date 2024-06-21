using System;
using System.Windows.Forms;
using Common;

namespace Ratchet___Clank
{
    public class FormFactory : IFormFactory
    {
        public Form CreateForm(string formName)
        {
            switch (formName)
            {
                case "Ratchet & Clank":
                    return new RatchetAndClankOne();
                case "Ratchet & Clank: Going Commando":
                    return new RatchetAndClankTwo();
                default:
                    throw new ArgumentException("Form not recognized", nameof(formName));
            }
        }
    }
}

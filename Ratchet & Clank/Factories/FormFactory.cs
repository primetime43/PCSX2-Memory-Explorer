using System;
using System.Windows.Forms;
using Common;
using Ratchet___Clank.Config;

namespace Ratchet___Clank
{
    public class FormFactory : IFormFactory
    {
        public Form CreateForm(string formName)
        {
            switch (formName)
            {
                case "Ratchet & Clank":
                    return new GameMemoryEditorForm(new RatchetClank1Config());
                case "Ratchet & Clank: Going Commando":
                    return new GameMemoryEditorForm(new RatchetClank2Config());
                default:
                    throw new ArgumentException("Form not recognized", nameof(formName));
            }
        }
    }
}

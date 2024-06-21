using System.Windows.Forms;

namespace Common
{
    public interface IFormFactory
    {
        Form CreateForm(string formName);
    }
}

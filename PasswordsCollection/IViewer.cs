using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordsCollection
{
    public interface IViewer
    {
        event EventHandler<EventArgs> LoadPasswords;
        event EventHandler<EventArgs> CreateNewPas;
    }
}

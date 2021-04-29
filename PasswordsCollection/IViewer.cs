using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordsCollection
{
    public interface IViewer
    {
        Panel PasswordsButtons { get; set; }

        event EventHandler<EventArgs> LoadPasswords;
        event EventHandler<EventArgs> CreateNewPas;
    }
}

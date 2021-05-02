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
        string NewPassword { get; set; }
        string NewPasswordName { get; set; }

        Panel PasswordsButtons { get; set; }
        Label LblStatus { get; set; }

        event EventHandler<EventArgs> LoadPasswords;
        event EventHandler<EventArgs> CreateNewPas;
    }
}

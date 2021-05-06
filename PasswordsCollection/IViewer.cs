using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordsCollection
{
    public interface IViewer
    {
        string NewPassword { get; }
        string NewPasswordName { get; }

        Panel PasswordsButtons { get; set; }
        Label LblStatus { get; set; }
        ComboBox ButtonNames { get; set; }

        PictureBox ForeColorButton { get; set; }
        PictureBox BackColorButton { get; set; }

        event EventHandler<EventArgs> ApplyButtonStyle;
        event EventHandler<EventArgs> LoadPasswords;
        event EventHandler<EventArgs> CreateNewPas;
        event Action<bool> OpenLogInForm;
    }
}

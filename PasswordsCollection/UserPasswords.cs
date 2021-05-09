using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordsCollection
{
    class UserPasswords
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public Button UP_Button { get; set; }

        public FormatControler FormatControler { get; set; }

        public UserPasswords(string name, string pas, string format)
        {
            Name = name;
            Password = pas;
            FormatControler = new FormatControler(format);
        }
    }
}

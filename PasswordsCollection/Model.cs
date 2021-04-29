using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordsCollection
{
    public class UserPasswords
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public UserPasswords(string name, string pas)
        {
            Name = name;
            Password = pas;
        }
    }

    public class Model
    {
        List<UserPasswords> userPasswords = new List<UserPasswords>();

        public Model()
        {

        }

        private void FillDictionary()
        {
            FileStream fs = new FileStream("data.txt", FileMode.Open);
            using (StreamReader sr = new StreamReader(fs))
            {
                string fullFile = sr.ReadToEnd();
                fullFile.Replace("\r", "");
                string[] lines = fullFile.Split('\n');

                foreach (string s in lines)
                {
                    string[] el = s.Split(':');
                    userPasswords.Add(new UserPasswords(el[0], el[1]));
                }
            }
        }

        public Button[] CreatePassButtons()
        {
            FillDictionary();
            Button[] buttons = new Button[userPasswords.Count];

            int inc = 0;
            int prevHeight = 50;
            foreach(Button b in buttons)
            {
                buttons[inc] = new Button
                {
                    Text = userPasswords[inc].Name,
                    Size = new System.Drawing.Size(100, prevHeight),
                    Location = new System.Drawing.Point(5, 5 + inc*prevHeight),
                    
                };
                buttons[inc].Click += (object sender, EventArgs e) => { MessageBox.Show("Copy!"); };
                inc++;
            }

            return buttons;
        }

    }
}

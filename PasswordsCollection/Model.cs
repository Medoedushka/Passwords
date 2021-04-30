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
            int prevHeight = 25, width = 250;
            int h0 = 5;
            foreach(Button b in buttons)
            {
                buttons[inc] = new Button
                {
                    Text = userPasswords[inc].Name,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Font = new System.Drawing.Font("Gotham Pro Medium", 9),
                    Size = new System.Drawing.Size(width, prevHeight),
                    Location = new System.Drawing.Point(5, h0 * (inc + 1) + prevHeight * inc),
                    
                };
                buttons[inc].Click += (object sender, EventArgs e) => {
                    string foundPas = "";
                    Button temp = (Button)sender;
                    foreach (UserPasswords up in userPasswords)
                    {
                        if (temp.Text == up.Name)
                            MessageBox.Show(up.Password);
                    }
                };
                inc++;
            }

            return buttons;
        }

    }
}

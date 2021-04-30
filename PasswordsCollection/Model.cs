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
        public event Action<int> CopiedToClipboard;
        List<UserPasswords> userPasswords = new List<UserPasswords>();

        //Константы параметров кнопки
        const int BUTTON_HEIGHT = 25;
        const int BUTTON_WIDTH = 250;
        const int INDENT = 5;


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
            
            
            for(int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button
                {
                    Text = userPasswords[i].Name,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    FlatStyle = FlatStyle.Flat,
                    Font = new System.Drawing.Font("Gotham Pro Medium", 9),
                    Size = new System.Drawing.Size(BUTTON_WIDTH, BUTTON_HEIGHT),
                    Location = new System.Drawing.Point(5, INDENT * (i + 1) + BUTTON_HEIGHT * i),

                };
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].Click += (object sender, EventArgs e) => {
                    Button temp = (Button)sender;
                    foreach (UserPasswords up in userPasswords)
                    {
                        if (temp.Text == up.Name)
                        {
                            Clipboard.SetData(DataFormats.Text, up.Password);
                            CopiedToClipboard?.Invoke(1);
                            break;
                        }

                    }
                };
            }

            return buttons;
        }

    }
}

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

        const string PASSWORDS_PATH = "data.txt";
        string FullPasswordsFile;

        public Model()
        {

        }

        private void FillList()
        {
            FileStream fs = new FileStream(PASSWORDS_PATH, FileMode.Open);
            using (StreamReader sr = new StreamReader(fs))
            {
                FullPasswordsFile = sr.ReadToEnd();
                FullPasswordsFile.Replace("\r", "");
                string[] lines = FullPasswordsFile.Split('\n');

                foreach (string s in lines)
                {
                    string[] el = s.Split(':');
                    userPasswords.Add(new UserPasswords(el[0], el[1]));
                }
            }
        }

        public Button[] CreatePassButtons()
        {
            FillList();
            Button[] buttons = new Button[userPasswords.Count];
            
            
            for(int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button
                {
                    Text = userPasswords[i].Name,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    FlatStyle = FlatStyle.Flat,
                    Font = new System.Drawing.Font("Gotham Pro Medium", 11),
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

        public void AddNewPassword(string name, string password)
        {
            FullPasswordsFile += "\n" + name + ":" + password;
            using (StreamWriter sw = new StreamWriter(PASSWORDS_PATH, false))
            {
                sw.Write(FullPasswordsFile);
            }
        }

    }
}

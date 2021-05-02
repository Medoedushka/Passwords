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
        public event Action PasswordDeleted;
        List<UserPasswords> userPasswords = new List<UserPasswords>();

        //Константы параметров кнопки
        const int BUTTON_HEIGHT = 25;
        const int BUTTON_WIDTH = 230;
        const int INDENT = 5;

        const string PASSWORDS_PATH = "data.txt";
        string FullPasswordsFile;

        public Model()
        {

        }

        private void FillList()
        {
            FileStream fs = new FileStream(PASSWORDS_PATH, FileMode.OpenOrCreate);
            using (StreamReader sr = new StreamReader(fs))
            {
                FullPasswordsFile = sr.ReadToEnd();
                if (string.IsNullOrEmpty(FullPasswordsFile))
                    return;
                FullPasswordsFile.Replace("\r", "");
                string[] lines = FullPasswordsFile.Split('\n');

                foreach (string s in lines)
                {
                    if (string.IsNullOrEmpty(s))
                        continue;

                    string[] el = s.Split(':');
                    userPasswords.Add(new UserPasswords(el[0], el[1]));
                }
            }
        }

        public Button[,] CreatePassButtons()
        {
            userPasswords.Clear();
            FillList();
            if (string.IsNullOrEmpty(FullPasswordsFile))
                return null;
            Button[,] buttons = new Button[userPasswords.Count, 2];
            
            
            for(int i = 0; i < userPasswords.Count; i++)
            {
                buttons[i, 0] = new Button
                {
                    Text = userPasswords[i].Name,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    FlatStyle = FlatStyle.Flat,
                    Font = new System.Drawing.Font("Gotham Pro Medium", 11),
                    Size = new System.Drawing.Size(BUTTON_WIDTH, BUTTON_HEIGHT),
                    Location = new System.Drawing.Point(5, INDENT * (i + 1) + BUTTON_HEIGHT * i),
                };
                buttons[i, 0].FlatAppearance.BorderSize = 1;
                buttons[i, 0].Click += (object sender, EventArgs e) => {
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

                buttons[i, 1] = new Button
                {
                    Text = "D",
                    FlatStyle = FlatStyle.Flat,
                    Size = new System.Drawing.Size(25, BUTTON_HEIGHT),
                    Location = new System.Drawing.Point(10 + BUTTON_WIDTH, INDENT * (i + 1) + BUTTON_HEIGHT * i),
                };
                buttons[i, 1].FlatAppearance.BorderSize = 1;
                buttons[i, 1].Click += (object sender, EventArgs e) =>
                {
                    Button temp = (Button)sender;
                    for(int k = 0; k < userPasswords.Count; k++)
                    {
                        if (buttons[k, 1] == temp)
                        {
                            foreach (UserPasswords up in userPasswords)
                            {
                                if (buttons[k, 0].Text == up.Name)
                                {
                                    string del = up.Name + ":" + up.Password + "\n";
                                    FullPasswordsFile = FullPasswordsFile.Remove(FullPasswordsFile.IndexOf(del), del.Length);
                                    using (StreamWriter sw = new StreamWriter(PASSWORDS_PATH, false))
                                    {
                                        sw.Write(FullPasswordsFile);
                                    }
                                    PasswordDeleted?.Invoke();
                                    break;
                                }

                            }
                            break;
                        }
                    }
                };
            }

            return buttons;
        }

        public void AddNewPassword(string name, string password)
        {
            if (FullPasswordsFile.Contains(name))
                throw new Exception("Пароль с таким именем уже существует!");
            FullPasswordsFile += name + ":" + password + "\n";
            using (StreamWriter sw = new StreamWriter(PASSWORDS_PATH, false))
            {
                sw.Write(FullPasswordsFile);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PasswordsCollection
{
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

                foreach (string l in lines)
                {
                    if (string.IsNullOrEmpty(l))
                        continue;

                    string[] el = l.Split(':');
                    string format = FormatControler.GetStringFormatFromLine(l);
                    el[1] = el[1].Remove(el[1].IndexOf(format), format.Length);
                    
                    userPasswords.Add(new UserPasswords(el[0], el[1], format));
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
                    ForeColor = userPasswords[i].FormatControler.ButtonForeColor,
                    BackColor = userPasswords[i].FormatControler.ButtonBackColor,
                    TextAlign = ContentAlignment.MiddleLeft,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Gotham Pro Medium", 11),
                    Size = new Size(BUTTON_WIDTH, BUTTON_HEIGHT),
                    Location = new Point(5, INDENT * (i + 1) + BUTTON_HEIGHT * i),
                };
                buttons[i, 0].FlatAppearance.BorderSize = 0;
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

                userPasswords[i].UP_Button = buttons[i, 0];

                buttons[i, 1] = new Button
                {
                    Text = "",
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(25, BUTTON_HEIGHT),
                    Location = new Point(10 + BUTTON_WIDTH, INDENT * (i + 1) + BUTTON_HEIGHT * i),
                    Image = Properties.Resources.trash_25px
                };
                buttons[i, 1].FlatAppearance.BorderSize = 0;
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
                                    string del = up.Name + ":" + up.Password + up.FormatControler.ToString() + "\n";
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
            FormatControler temp = new FormatControler("");
            if (FullPasswordsFile.Contains(name + ":"))
                throw new Exception("Пароль с таким именем уже существует!");
            FullPasswordsFile += name + ":" + password + temp.ToString() +"\n";
            using (StreamWriter sw = new StreamWriter(PASSWORDS_PATH, false))
            {
                sw.Write(FullPasswordsFile);
            }
        }

        public void ChangeButtonStyle(string ButtonName, Color ForeColor, Color BackColor)
        {
            bool found = false;
            foreach(UserPasswords up in userPasswords)
            {
                if (ButtonName == up.Name && up.UP_Button != null)
                {
                    up.UP_Button.ForeColor = ForeColor;
                    up.UP_Button.BackColor = BackColor;
                    up.FormatControler.ButtonForeColor = ForeColor;
                    up.FormatControler.ButtonBackColor = BackColor;
                    found = true;
                    FullPasswordsFile = GenerateUPStrings();
                    using (StreamWriter sw = new StreamWriter(PASSWORDS_PATH, false))
                    {
                        sw.Write(FullPasswordsFile);
                    }
                    break;
                }
            }

            if (found == false)
                throw new Exception("Искомая кнопка не найдена!");

        }

        private string GenerateUPStrings()
        {
            string result = "";
            foreach(UserPasswords up in userPasswords)
            {
                string temp = up.Name + ":" + up.Password + up.FormatControler.ToString() + "\n";
                result += temp;
            }
            return result;
        }
    }
}

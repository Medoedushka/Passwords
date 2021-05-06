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
    public class UserPasswords
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string ButtonFormat { get; set; }
        public Button UP_Button { get; set; }

        public UserPasswords(string name, string pas, string format)
        {
            Name = name;
            Password = pas;
            ButtonFormat = format;
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
                    int bracketInd = el[1].IndexOf('[');
                    string format = el[1].Substring(bracketInd, el[1].IndexOf(']') - bracketInd + 1);
                    el[1] = el[1].Remove(bracketInd, format.Length);
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
                Color ForeColorBtn, BackColorBtn;
                GetColorFromString(userPasswords[i].ButtonFormat, out ForeColorBtn, out BackColorBtn);

                buttons[i, 0] = new Button
                {
                    Text = userPasswords[i].Name,
                    ForeColor = ForeColorBtn,
                    BackColor = BackColorBtn,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    FlatStyle = FlatStyle.Flat,
                    Font = new System.Drawing.Font("Gotham Pro Medium", 11),
                    Size = new System.Drawing.Size(BUTTON_WIDTH, BUTTON_HEIGHT),
                    Location = new System.Drawing.Point(5, INDENT * (i + 1) + BUTTON_HEIGHT * i),
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
                    Size = new System.Drawing.Size(25, BUTTON_HEIGHT),
                    Location = new System.Drawing.Point(10 + BUTTON_WIDTH, INDENT * (i + 1) + BUTTON_HEIGHT * i),
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
                                    string del = up.Name + ":" + up.Password + up.ButtonFormat + "\n";
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
            if (FullPasswordsFile.Contains(name + ":"))
                throw new Exception("Пароль с таким именем уже существует!");
            FullPasswordsFile += name + ":" + password + ConvertToStringFromColor(Color.Black, Color.Gold) +"\n";
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
                    found = true;
                    up.ButtonFormat = ConvertToStringFromColor(ForeColor, BackColor);
                    FullPasswordsFile = GenerateUPString();
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

        private string GenerateUPString()
        {
            string result = "";
            foreach(UserPasswords up in userPasswords)
            {
                string temp = up.Name + ":" + up.Password + up.ButtonFormat + "\n";
                result += temp;
            }
            return result;
        }

        private string ConvertToStringFromColor(Color foreColor, Color backColor)
        {
            StringBuilder ColorFormat = new StringBuilder();
            ColorFormat.AppendFormat("[{0},{1},{2};{3},{4},{5}]", foreColor.R, foreColor.G, foreColor.B, backColor.R,
                backColor.G, backColor.B);
            return ColorFormat.ToString();
        }

        private void GetColorFromString(string format, out Color foreColor, out Color backColor)
        {
            format = format.Remove(0, 1);
            format = format.Remove(format.Length - 1, 1);
            int r, g, b;
            string[] colors = format.Split(';');
            string[] foreColorStrings = colors[0].Split(',');
            r = int.Parse(foreColorStrings[0]); g = int.Parse(foreColorStrings[1]); b = int.Parse(foreColorStrings[2]);
            foreColor = Color.FromArgb(r, g, b);

            string[] backColorStrings = colors[1].Split(',');
            r = int.Parse(backColorStrings[0]); g = int.Parse(backColorStrings[1]); b = int.Parse(backColorStrings[2]);
            backColor = Color.FromArgb(r, g, b);
        }
    }
}

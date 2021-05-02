using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordsCollection
{
    public partial class Authorization : Form
    {
        string UserAccessName = "useraccess.txt";
        string AdditionalString = "_PasswordsCollection";

        public Authorization(bool confirmAction)
        {
            InitializeComponent();
            if (confirmAction)
                btn_NewUser.Enabled = false;
            else btn_NewUser.Enabled = true;
        }

        private void btn_NewUser_Click(object sender, EventArgs e)
        {
            if (File.Exists(UserAccessName))
            {
                MessageBox.Show("Пользователь уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!string.IsNullOrEmpty(txb_Login.Text))
                {
                    using (File.Create(UserAccessName)) { }
                    string str = "Ваше ключевое слово: " + txb_Login.Text + ". Продолжить?";
                    DialogResult res = MessageBox.Show(str, "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        string CodingString = txb_Login.Text + AdditionalString;

                        //Coding Algorythm: y=x+5
                        string result = "";
                        for (int i = 0; i < CodingString.Length; i++)
                        {
                            int charIndex = (int)CodingString[i];
                            double newCharIndex = charIndex + 5;
                            char newChar = (char)newCharIndex;
                            result += newChar;
                        }
                        File.WriteAllText(UserAccessName, result);
                    }
                }
                else MessageBox.Show("Для создания нового пользователя необходимо ввести ключевое слово.",
                    "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcb_Enter_Click(object sender, EventArgs e)
        {
            if (File.Exists(UserAccessName))
            {
                string str = File.ReadAllText(UserAccessName);
                string UserWord = "";
                for (int i = 0; i < str.Length; i++)
                {
                    int charIndex = (int)str[i];
                    int newIndex = charIndex - 5;
                    char newChar = (char)newIndex;
                    UserWord += newChar;
                }
                UserWord = UserWord.Remove(UserWord.IndexOf(AdditionalString), AdditionalString.Length);
                if (UserWord == txb_Login.Text)
                    this.Close();
                else MessageBox.Show("Указано неверное ключевое слово!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Для использования приложения необходимо создать нового пользователя.", "Ошибка авторизации",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
        }
    }
}

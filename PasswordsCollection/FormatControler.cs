using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordsCollection
{
    public class FormatControler
    {
        string stringFormat;
        public Color ButtonForeColor { get; set; } = Color.Black;
        public Color ButtonBackColor { get; set; } = Color.Gold;

        public FormatControler(string buttonFormat)
        {
            stringFormat = buttonFormat;
            GetColorFromString();
        }

        public static string GetStringFormatFromLine(string line)
        {
            int bracketInd = line.IndexOf('[');
            //проверка для старых версий, где отсутствовала строка с форматом кнопки
            if (bracketInd == -1)
                return "";
            else
                return line.Substring(bracketInd, line.IndexOf(']') - bracketInd + 1);
        }

        private void GetColorFromString()
        {
            if (stringFormat == "")
                return;

            stringFormat = stringFormat.Remove(0, 1);
            stringFormat = stringFormat.Remove(stringFormat.Length - 1, 1);
            int r, g, b;
            string[] colors = stringFormat.Split(';');
            string[] foreColorStrings = colors[0].Split(',');
            r = int.Parse(foreColorStrings[0]); g = int.Parse(foreColorStrings[1]); b = int.Parse(foreColorStrings[2]);
            ButtonForeColor = Color.FromArgb(r, g, b);

            string[] backColorStrings = colors[1].Split(',');
            r = int.Parse(backColorStrings[0]); g = int.Parse(backColorStrings[1]); b = int.Parse(backColorStrings[2]);
            ButtonBackColor = Color.FromArgb(r, g, b);
        }

        public override string ToString()
        {
            var stringWithInsideValues = $"[{ButtonForeColor.R},{ButtonForeColor.G},{ButtonForeColor.B};" +
                $"{ButtonBackColor.R},{ButtonBackColor.G},{ButtonBackColor.B}]";
            return stringWithInsideValues;
        }
    }
}

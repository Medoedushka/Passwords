using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordsCollection
{
    public class Presenter
    {
        Model _model;
        IViewer viewer;

        Timer LblStatusTimer;
        int lblStatusCounter = 0;

        public Presenter(IViewer _viewer)
        {
            _model = new Model();
            _model.CopiedToClipboard += _model_CopiedToClipboard;
            _model.PasswordDeleted += _model_PasswordDeleted;

            this.viewer = _viewer;
            LblStatusTimer = new Timer();
            LblStatusTimer.Interval = 500;
            LblStatusTimer.Tick += LblStatusTimer_Tick;

            viewer.LoadPasswords += Viewer_LoadPasswords;
            viewer.CreateNewPas += Viewer_CreateNewPas;
            viewer.OpenLogInForm += Viewer_OpenLogInForm;
            viewer.ApplyButtonStyle += Viewer_ApplyButtonStyle;
        }

        private void Viewer_ApplyButtonStyle(object sender, EventArgs e)
        {
            try
            {
                _model.ChangeButtonStyle(viewer.ButtonNames.Text, viewer.ForeColorButton.BackColor, viewer.BackColorButton.BackColor);
                WriteToStatusLabel("Изменения применены!", Color.FromArgb(68, 161, 70));
            }
            catch(Exception ex)
            {
                WriteToStatusLabel(ex.Message, Color.Crimson);
            }
        }

        private void Viewer_OpenLogInForm(bool obj)
        {
            Authorization authorization = new Authorization(obj);
            authorization.ShowDialog();
        }

        private void _model_PasswordDeleted()
        {
            WriteToStatusLabel("Пароль удалён", Color.FromArgb(68, 161, 70));
            viewer.PasswordsButtons.Controls.Clear();
            Viewer_LoadPasswords(this, EventArgs.Empty);
        }

        private void Viewer_CreateNewPas(object sender, EventArgs e)
        {
            try
            {
                _model.AddNewPassword(viewer.NewPasswordName, viewer.NewPassword);
                WriteToStatusLabel("Новый пароль добавлен!", Color.FromArgb(68, 161, 70));

                viewer.PasswordsButtons.Controls.Clear();
                Viewer_LoadPasswords(this, EventArgs.Empty);
            }
            catch(Exception ex)
            {
                WriteToStatusLabel(ex.Message, Color.Crimson);
            }
        }

        private void _model_CopiedToClipboard(int obj)
        {
            if (obj == 1)
                WriteToStatusLabel("Скопированно!", Color.FromArgb(0, 40, 255));
        }

        private void Viewer_LoadPasswords(object sender, EventArgs e)
        {
            viewer.ButtonNames.Items.Clear();
            Button[,] but = _model.CreatePassButtons();
            if (but == null)
                return;
            foreach(Button b in but)
            {
                viewer.PasswordsButtons.Controls.Add(b);
                if (b.Text != "")
                    viewer.ButtonNames.Items.Add(b.Text);
            }
        }

        private void LblStatusTimer_Tick(object sender, EventArgs e)
        {
            if (lblStatusCounter < 2)
            {
                lblStatusCounter++;
                viewer.LblStatus.Visible = true;
            }
            else
            {
                lblStatusCounter = 0;
                viewer.LblStatus.Visible = false;
                LblStatusTimer.Stop();
            }
        }
        private void WriteToStatusLabel(string message, Color foreColor)
        {
            viewer.LblStatus.Text = message;
            viewer.LblStatus.ForeColor = foreColor;

            //сброс до значений по умолчанию
            viewer.LblStatus.Visible = false;
            LblStatusTimer.Stop();
            lblStatusCounter = 0;

            LblStatusTimer.Start();
            LblStatusTimer_Tick(this, EventArgs.Empty);
        }
    }
}

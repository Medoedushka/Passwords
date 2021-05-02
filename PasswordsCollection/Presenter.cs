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

            this.viewer = _viewer;
            LblStatusTimer = new Timer();
            LblStatusTimer.Interval = 500;
            LblStatusTimer.Tick += LblStatusTimer_Tick;

            viewer.LoadPasswords += Viewer_LoadPasswords;
            viewer.CreateNewPas += Viewer_CreateNewPas;
        }

        private void Viewer_CreateNewPas(object sender, EventArgs e)
        {
            try
            {
                _model.AddNewPassword(viewer.NewPasswordName, viewer.NewPassword);
            }
            catch(ArgumentException ex)
            {
                WriteToStatusLabel(ex.Message, Color.Crimson);
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

        private void _model_CopiedToClipboard(int obj)
        {
            if (obj == 1)
            {
                viewer.LblStatus.Text = "Скопированно!";
                viewer.LblStatus.ForeColor = Color.FromArgb(0, 40, 255);

                //сброс до значений по умолчанию
                viewer.LblStatus.Visible = false;
                LblStatusTimer.Stop();
                lblStatusCounter = 0;

                LblStatusTimer.Start();
                LblStatusTimer_Tick(this, EventArgs.Empty);
            }
        }

        private void Viewer_LoadPasswords(object sender, EventArgs e)
        {
            Button[] but = _model.CreatePassButtons();
            foreach(Button b in but)
            {
                viewer.PasswordsButtons.Controls.Add(b);
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

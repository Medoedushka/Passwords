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
    }
}

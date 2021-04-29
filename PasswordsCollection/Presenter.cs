using System;
using System.Collections.Generic;
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
        public Presenter(IViewer _viewer)
        {
            _model = new Model();
            this.viewer = _viewer;
            
            viewer.CreateNewPas += Viewer_CreateNewPas;
        }

        private void Viewer_CreateNewPas(object sender, EventArgs e)
        {
            Button[] but = _model.CreatePassButtons();
            foreach(Button b in but)
            {
                viewer.PasswordsButtons.Controls.Add(b);
            }
        }
    }
}

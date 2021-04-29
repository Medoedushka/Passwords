using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordsCollection
{
    public class Presenter
    {
        Model _model;
        IViewer viewer;
        public Presenter(IViewer viewer)
        {
            _model = new Model();
            this.viewer = viewer;
        }
    }
}

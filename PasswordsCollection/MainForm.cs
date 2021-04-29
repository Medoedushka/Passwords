using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordsCollection
{
    public partial class MainForm : Form, IViewer
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> CreateNewPas;
        public event EventHandler<EventArgs> LoadPasswords;

        private void btn_New_Click(object sender, EventArgs e)
        {

        }
    }
}

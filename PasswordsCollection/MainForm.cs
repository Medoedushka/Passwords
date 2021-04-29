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
        public Panel PasswordsButtons { get => pnl_PasswordsContainer; set => pnl_PasswordsContainer = value; }

        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> CreateNewPas;
        public event EventHandler<EventArgs> LoadPasswords;

        private void btn_New_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            CreateNewPas?.Invoke(this, EventArgs.Empty);
        }
    }
}

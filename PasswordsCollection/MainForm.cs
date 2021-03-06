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
        public Label LblStatus { get => lbl_Status; set => lbl_Status = value; }
        public string NewPassword
        { 
            get
            {
                if (!string.IsNullOrEmpty(txb_NewPass.Text))
                    return txb_NewPass.Text;
                else throw new ArgumentException("Не все поля были заполнены!");
            }
        }
        public string NewPasswordName
        {
            get
            {
                if (!string.IsNullOrEmpty(txb_NewPassName.Text))
                    return txb_NewPassName.Text;
                else throw new ArgumentException("Не все поля были заполнены!");
            }
        }
        public PictureBox ForeColorButton { get => pcb_ForeColor; set => pcb_ForeColor = value; }
        public PictureBox BackColorButton { get => pcb_BackColor; set => pcb_BackColor = value; }
        public ComboBox ButtonNames { get => cmb_ButtonName; set => cmb_ButtonName = value; }

        Timer NewPassTimer;
        bool PanelExpanded = false;


        public MainForm()
        {
            InitializeComponent();
            NewPassTimer = new Timer();
            NewPassTimer.Interval = 5;
            NewPassTimer.Tick += NewPassTimer_Tick;
        }
        public event EventHandler<EventArgs> CreateNewPas;
        public event EventHandler<EventArgs> LoadPasswords;
        public event Action<bool> OpenLogInForm;
        public event EventHandler<EventArgs> ApplyButtonStyle;

        private void btn_New_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenLogInForm?.Invoke(false);
            LoadPasswords?.Invoke(this, EventArgs.Empty);
        }

        private void btn_AddNewPas_Click(object sender, EventArgs e)
        {
            if (PanelExpanded == false)
            {
                btn_AddNewPas.BackColor = Color.GreenYellow;
                btn_AddNewPas.Image = Properties.Resources.checkmark_30px;
                NewPassTimer.Start();
            }
            else
            {
                CreateNewPas?.Invoke(this, EventArgs.Empty);
                btn_AddNewPas.BackColor = Color.RoyalBlue;
                btn_AddNewPas.Image = Properties.Resources.plus_math_30px;
                NewPassTimer.Start();
                txb_NewPass.Text = "";
                txb_NewPassName.Text = "";
            }

        }

        private void NewPassTimer_Tick(object sender, EventArgs e)
        {
            if (PanelExpanded == false)
            {
                pnl_NewPass.Width += 15;
                if (pnl_NewPass.Width >= 290)
                {
                    pnl_NewPass.Width = 290;
                    PanelExpanded = true;
                    NewPassTimer.Stop();
                }
            }
            else
            {
                pnl_NewPass.Width -= 15;
                if (pnl_NewPass.Width <= 0)
                {
                    pnl_NewPass.Width = 0;
                    PanelExpanded = false;
                    NewPassTimer.Stop();
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ApplyButtonStyle?.Invoke(this, EventArgs.Empty);
        }

        private void SetPcbColor(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            Color crrColor = cd.Color;
            if (temp.Name == "btn_ColorPick1")
                pcb_ForeColor.BackColor = crrColor;
            else
                pcb_BackColor.BackColor = crrColor;
        }
    }
}

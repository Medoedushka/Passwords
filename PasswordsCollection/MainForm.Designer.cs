namespace PasswordsCollection
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_PasswordsContainer = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddNewPas = new PasswordsCollection.CircularButton();
            this.pnl_NewPass = new System.Windows.Forms.Panel();
            this.txb_NewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_NewPassName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_ButtonName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pcb_ForeColor = new System.Windows.Forms.PictureBox();
            this.btn_ColorPick1 = new System.Windows.Forms.Button();
            this.pcb_BackColor = new System.Windows.Forms.PictureBox();
            this.btn_ColorPick2 = new System.Windows.Forms.Button();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnl_NewPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ForeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_BackColor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pnl_PasswordsContainer);
            this.panel1.Location = new System.Drawing.Point(9, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 317);
            this.panel1.TabIndex = 0;
            // 
            // pnl_PasswordsContainer
            // 
            this.pnl_PasswordsContainer.AutoScroll = true;
            this.pnl_PasswordsContainer.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_PasswordsContainer.Location = new System.Drawing.Point(1, 1);
            this.pnl_PasswordsContainer.Margin = new System.Windows.Forms.Padding(1);
            this.pnl_PasswordsContainer.Name = "pnl_PasswordsContainer";
            this.pnl_PasswordsContainer.Size = new System.Drawing.Size(309, 315);
            this.pnl_PasswordsContainer.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(-2, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(697, 1);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.Controls.Add(this.gunaGroupBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btn_AddNewPas);
            this.panel5.Controls.Add(this.pnl_NewPass);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.lbl_Status);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.btn_Close);
            this.panel5.Font = new System.Drawing.Font("Gotham Pro Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(679, 444);
            this.panel5.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham Pro Medium", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Created by Medoed v2.0";
            // 
            // btn_AddNewPas
            // 
            this.btn_AddNewPas.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AddNewPas.FlatAppearance.BorderSize = 0;
            this.btn_AddNewPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewPas.Font = new System.Drawing.Font("Gotham Pro Medium", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewPas.Image = global::PasswordsCollection.Properties.Resources.plus_math_30px;
            this.btn_AddNewPas.Location = new System.Drawing.Point(20, 377);
            this.btn_AddNewPas.Name = "btn_AddNewPas";
            this.btn_AddNewPas.Size = new System.Drawing.Size(50, 50);
            this.btn_AddNewPas.TabIndex = 7;
            this.btn_AddNewPas.UseVisualStyleBackColor = false;
            this.btn_AddNewPas.Click += new System.EventHandler(this.btn_AddNewPas_Click);
            // 
            // pnl_NewPass
            // 
            this.pnl_NewPass.BackColor = System.Drawing.Color.Transparent;
            this.pnl_NewPass.Controls.Add(this.txb_NewPass);
            this.pnl_NewPass.Controls.Add(this.label4);
            this.pnl_NewPass.Controls.Add(this.txb_NewPassName);
            this.pnl_NewPass.Controls.Add(this.label3);
            this.pnl_NewPass.Location = new System.Drawing.Point(76, 364);
            this.pnl_NewPass.Name = "pnl_NewPass";
            this.pnl_NewPass.Size = new System.Drawing.Size(0, 77);
            this.pnl_NewPass.TabIndex = 6;
            // 
            // txb_NewPass
            // 
            this.txb_NewPass.Location = new System.Drawing.Point(118, 43);
            this.txb_NewPass.Name = "txb_NewPass";
            this.txb_NewPass.Size = new System.Drawing.Size(164, 24);
            this.txb_NewPass.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Пароль:";
            // 
            // txb_NewPassName
            // 
            this.txb_NewPassName.Location = new System.Drawing.Point(118, 13);
            this.txb_NewPassName.Name = "txb_NewPassName";
            this.txb_NewPassName.Size = new System.Drawing.Size(164, 24);
            this.txb_NewPassName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Имя пароля:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 1);
            this.panel2.TabIndex = 5;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Gotham Pro Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(282, 7);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(86, 17);
            this.lbl_Status.TabIndex = 4;
            this.lbl_Status.Text = "lbl_Status";
            this.lbl_Status.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham Pro Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password storage";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(650, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(26, 26);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Gold;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaButton1);
            this.gunaGroupBox1.Controls.Add(this.btn_ColorPick2);
            this.gunaGroupBox1.Controls.Add(this.btn_ColorPick1);
            this.gunaGroupBox1.Controls.Add(this.pcb_BackColor);
            this.gunaGroupBox1.Controls.Add(this.pcb_ForeColor);
            this.gunaGroupBox1.Controls.Add(this.cmb_ButtonName);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(327, 39);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(344, 194);
            this.gunaGroupBox1.TabIndex = 16;
            this.gunaGroupBox1.Text = "Форматирование кнопки";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Имя кнопки:";
            // 
            // cmb_ButtonName
            // 
            this.cmb_ButtonName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ButtonName.FormattingEnabled = true;
            this.cmb_ButtonName.Location = new System.Drawing.Point(114, 41);
            this.cmb_ButtonName.Name = "cmb_ButtonName";
            this.cmb_ButtonName.Size = new System.Drawing.Size(206, 25);
            this.cmb_ButtonName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Цвет текста:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Цвет фона:";
            // 
            // pcb_ForeColor
            // 
            this.pcb_ForeColor.BackColor = System.Drawing.Color.Aquamarine;
            this.pcb_ForeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_ForeColor.Location = new System.Drawing.Point(114, 77);
            this.pcb_ForeColor.Name = "pcb_ForeColor";
            this.pcb_ForeColor.Size = new System.Drawing.Size(100, 25);
            this.pcb_ForeColor.TabIndex = 2;
            this.pcb_ForeColor.TabStop = false;
            // 
            // btn_ColorPick1
            // 
            this.btn_ColorPick1.FlatAppearance.BorderSize = 0;
            this.btn_ColorPick1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ColorPick1.Image = ((System.Drawing.Image)(resources.GetObject("btn_ColorPick1.Image")));
            this.btn_ColorPick1.Location = new System.Drawing.Point(220, 77);
            this.btn_ColorPick1.Name = "btn_ColorPick1";
            this.btn_ColorPick1.Size = new System.Drawing.Size(25, 25);
            this.btn_ColorPick1.TabIndex = 3;
            this.btn_ColorPick1.UseVisualStyleBackColor = true;
            this.btn_ColorPick1.Click += new System.EventHandler(this.SetPcbColor);
            // 
            // pcb_BackColor
            // 
            this.pcb_BackColor.BackColor = System.Drawing.Color.Violet;
            this.pcb_BackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_BackColor.Location = new System.Drawing.Point(114, 115);
            this.pcb_BackColor.Name = "pcb_BackColor";
            this.pcb_BackColor.Size = new System.Drawing.Size(100, 25);
            this.pcb_BackColor.TabIndex = 2;
            this.pcb_BackColor.TabStop = false;
            // 
            // btn_ColorPick2
            // 
            this.btn_ColorPick2.FlatAppearance.BorderSize = 0;
            this.btn_ColorPick2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ColorPick2.Image = ((System.Drawing.Image)(resources.GetObject("btn_ColorPick2.Image")));
            this.btn_ColorPick2.Location = new System.Drawing.Point(220, 115);
            this.btn_ColorPick2.Name = "btn_ColorPick2";
            this.btn_ColorPick2.Size = new System.Drawing.Size(25, 25);
            this.btn_ColorPick2.TabIndex = 3;
            this.btn_ColorPick2.UseVisualStyleBackColor = true;
            this.btn_ColorPick2.Click += new System.EventHandler(this.SetPcbColor);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.gunaButton1.BorderSize = 2;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Gotham Pro Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(6, 151);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(142)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(109, 34);
            this.gunaButton1.TabIndex = 4;
            this.gunaButton1.Text = "Применить";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnl_NewPass.ResumeLayout(false);
            this.pnl_NewPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ForeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_BackColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel pnl_PasswordsContainer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_NewPass;
        private System.Windows.Forms.TextBox txb_NewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_NewPassName;
        private System.Windows.Forms.Label label3;
        private CircularButton btn_AddNewPas;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Button btn_ColorPick2;
        private System.Windows.Forms.Button btn_ColorPick1;
        private System.Windows.Forms.PictureBox pcb_BackColor;
        private System.Windows.Forms.PictureBox pcb_ForeColor;
        private System.Windows.Forms.ComboBox cmb_ButtonName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}


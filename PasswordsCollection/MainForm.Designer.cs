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
            this.pnl_NewPass = new System.Windows.Forms.Panel();
            this.txb_NewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_NewPassName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddNewPas = new PasswordsCollection.CircularButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnl_NewPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel5.Controls.Add(this.btn_AddNewPas);
            this.panel5.Controls.Add(this.pnl_NewPass);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.lbl_Status);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btn_Close);
            this.panel5.Font = new System.Drawing.Font("Gotham Pro Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(679, 444);
            this.panel5.TabIndex = 3;
            // 
            // pnl_NewPass
            // 
            this.pnl_NewPass.BackColor = System.Drawing.Color.Transparent;
            this.pnl_NewPass.Controls.Add(this.txb_NewPass);
            this.pnl_NewPass.Controls.Add(this.label4);
            this.pnl_NewPass.Controls.Add(this.txb_NewPassName);
            this.pnl_NewPass.Controls.Add(this.label3);
            this.pnl_NewPass.Location = new System.Drawing.Point(86, 364);
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
            this.lbl_Status.Font = new System.Drawing.Font("Gotham Pro Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(377, 6);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(107, 22);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham Pro Medium", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Created by Medoed";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel pnl_PasswordsContainer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
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
    }
}


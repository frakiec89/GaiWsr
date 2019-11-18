namespace GaiWsr.Forms
{
    partial class AddChangeUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChangeUserForm));
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurName = new System.Windows.Forms.TextBox();
            this.tbPatronumic = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btAddChange = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btRunFhoto = new System.Windows.Forms.Button();
            this.btDell = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(143, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(150, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbSurName
            // 
            this.tbSurName.Location = new System.Drawing.Point(143, 63);
            this.tbSurName.Name = "tbSurName";
            this.tbSurName.Size = new System.Drawing.Size(150, 20);
            this.tbSurName.TabIndex = 1;
            // 
            // tbPatronumic
            // 
            this.tbPatronumic.Location = new System.Drawing.Point(143, 89);
            this.tbPatronumic.Name = "tbPatronumic";
            this.tbPatronumic.Size = new System.Drawing.Size(150, 20);
            this.tbPatronumic.TabIndex = 2;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(143, 115);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(150, 20);
            this.tbLogin.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(143, 141);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(150, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пароль";
            // 
            // btAddChange
            // 
            this.btAddChange.Location = new System.Drawing.Point(110, 222);
            this.btAddChange.Name = "btAddChange";
            this.btAddChange.Size = new System.Drawing.Size(75, 23);
            this.btAddChange.TabIndex = 10;
            this.btAddChange.Text = "Добавить";
            this.btAddChange.UseVisualStyleBackColor = true;
            this.btAddChange.Click += new System.EventHandler(this.btAddChange_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btRunFhoto
            // 
            this.btRunFhoto.Location = new System.Drawing.Point(638, 251);
            this.btRunFhoto.Name = "btRunFhoto";
            this.btRunFhoto.Size = new System.Drawing.Size(75, 23);
            this.btRunFhoto.TabIndex = 12;
            this.btRunFhoto.Text = "Добавить";
            this.btRunFhoto.UseVisualStyleBackColor = true;
            this.btRunFhoto.Click += new System.EventHandler(this.btRunFhoto_Click);
            // 
            // btDell
            // 
            this.btDell.Location = new System.Drawing.Point(110, 251);
            this.btDell.Name = "btDell";
            this.btDell.Size = new System.Drawing.Size(75, 23);
            this.btDell.TabIndex = 13;
            this.btDell.Text = "удалить";
            this.btDell.UseVisualStyleBackColor = true;
            this.btDell.Click += new System.EventHandler(this.BtDell_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 14;
           
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Должность";
            // 
            // AddChangeUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btDell);
            this.Controls.Add(this.btRunFhoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAddChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbPatronumic);
            this.Controls.Add(this.tbSurName);
            this.Controls.Add(this.tbName);
            this.Name = "AddChangeUserForm";
            this.Text = "AddChangeUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurName;
        private System.Windows.Forms.TextBox tbPatronumic;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAddChange;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btRunFhoto;
        private System.Windows.Forms.Button btDell;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}
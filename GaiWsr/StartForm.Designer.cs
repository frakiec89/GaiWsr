namespace GaiWsr
{
    partial class StartForm
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
            this.btFormUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btFormUser
            // 
            this.btFormUser.Location = new System.Drawing.Point(91, 105);
            this.btFormUser.Name = "btFormUser";
            this.btFormUser.Size = new System.Drawing.Size(107, 23);
            this.btFormUser.TabIndex = 0;
            this.btFormUser.Text = "Пользователи ";
            this.btFormUser.UseVisualStyleBackColor = true;
            this.btFormUser.Click += new System.EventHandler(this.btFormUser_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 422);
            this.Controls.Add(this.btFormUser);
            this.Name = "StartForm";
            this.Text = "Стартовая форма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFormUser;
    }
}


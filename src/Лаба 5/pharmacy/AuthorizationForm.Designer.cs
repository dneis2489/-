namespace pharmacy
{
    partial class AuthorizationController
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxLogin = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.authorizeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.showHideBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // txtBxLogin
            // 
            this.txtBxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxLogin.Location = new System.Drawing.Point(116, 81);
            this.txtBxLogin.Name = "txtBxLogin";
            this.txtBxLogin.Size = new System.Drawing.Size(255, 22);
            this.txtBxLogin.TabIndex = 2;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxPassword.Location = new System.Drawing.Point(116, 132);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(255, 22);
            this.txtBxPassword.TabIndex = 3;
            this.txtBxPassword.UseSystemPasswordChar = true;
            // 
            // authorizeBtn
            // 
            this.authorizeBtn.Location = new System.Drawing.Point(173, 170);
            this.authorizeBtn.Name = "authorizeBtn";
            this.authorizeBtn.Size = new System.Drawing.Size(135, 31);
            this.authorizeBtn.TabIndex = 4;
            this.authorizeBtn.Text = "Авторизоваться";
            this.authorizeBtn.UseVisualStyleBackColor = true;
            this.authorizeBtn.Click += new System.EventHandler(this.authorizeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(216, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // showHideBtn
            // 
            this.showHideBtn.Image = global::pharmacy.Properties.Resources.open_eye;
            this.showHideBtn.Location = new System.Drawing.Point(377, 132);
            this.showHideBtn.Name = "showHideBtn";
            this.showHideBtn.Size = new System.Drawing.Size(25, 25);
            this.showHideBtn.TabIndex = 6;
            this.showHideBtn.UseVisualStyleBackColor = true;
            this.showHideBtn.Click += new System.EventHandler(this.showHideBtn_Click);
            // 
            // AuthorizationController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 308);
            this.Controls.Add(this.showHideBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorizeBtn);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AuthorizationController";
            this.Text = "Модуль корпоративной информационной системы сети аптек";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorizationController_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxLogin;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Button authorizeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showHideBtn;
    }
}


namespace GasStation
{
    partial class LogIn_Form
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
            this.lbl_Header = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.bt_LogIn = new System.Windows.Forms.Button();
            this.lbl_LoginTip = new System.Windows.Forms.Label();
            this.lbl_PasswordTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Header.Location = new System.Drawing.Point(105, 20);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(590, 27);
            this.lbl_Header.TabIndex = 3;
            this.lbl_Header.Text = "Информационная система для автозаправочной станции";
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(250, 200);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(300, 29);
            this.tb_Login.TabIndex = 0;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(250, 300);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(300, 29);
            this.tb_Password.TabIndex = 1;
            // 
            // bt_LogIn
            // 
            this.bt_LogIn.Location = new System.Drawing.Point(355, 400);
            this.bt_LogIn.Name = "bt_LogIn";
            this.bt_LogIn.Size = new System.Drawing.Size(90, 35);
            this.bt_LogIn.TabIndex = 2;
            this.bt_LogIn.Text = "Вход";
            this.bt_LogIn.UseVisualStyleBackColor = true;
            this.bt_LogIn.Click += new System.EventHandler(this.bt_LogIn_Click);
            // 
            // lbl_LoginTip
            // 
            this.lbl_LoginTip.AutoSize = true;
            this.lbl_LoginTip.Location = new System.Drawing.Point(246, 176);
            this.lbl_LoginTip.Name = "lbl_LoginTip";
            this.lbl_LoginTip.Size = new System.Drawing.Size(61, 21);
            this.lbl_LoginTip.TabIndex = 4;
            this.lbl_LoginTip.Text = "Логин";
            // 
            // lbl_PasswordTip
            // 
            this.lbl_PasswordTip.AutoSize = true;
            this.lbl_PasswordTip.Location = new System.Drawing.Point(246, 276);
            this.lbl_PasswordTip.Name = "lbl_PasswordTip";
            this.lbl_PasswordTip.Size = new System.Drawing.Size(69, 21);
            this.lbl_PasswordTip.TabIndex = 5;
            this.lbl_PasswordTip.Text = "Пароль";
            // 
            // LogIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lbl_PasswordTip);
            this.Controls.Add(this.lbl_LoginTip);
            this.Controls.Add(this.bt_LogIn);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.lbl_Header);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "LogIn_Form";
            this.Text = "GasStation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button bt_LogIn;
        private System.Windows.Forms.Label lbl_LoginTip;
        private System.Windows.Forms.Label lbl_PasswordTip;
    }
}


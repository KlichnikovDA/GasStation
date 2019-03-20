namespace GasStation
{
    partial class EditUsers
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemSale = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFinishWork = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_FIO = new System.Windows.Forms.TextBox();
            this.tb_BirthDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_EmployDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_DocNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_Generate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSale,
            this.MenuItemSupply,
            this.MenuItemDataBase,
            this.MenuItemUsers,
            this.MenuItemFinishWork});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemSale
            // 
            this.MenuItemSale.BackColor = System.Drawing.SystemColors.Control;
            this.MenuItemSale.Name = "MenuItemSale";
            this.MenuItemSale.Size = new System.Drawing.Size(69, 20);
            this.MenuItemSale.Text = "Продажа";
            // 
            // MenuItemSupply
            // 
            this.MenuItemSupply.BackColor = System.Drawing.SystemColors.Control;
            this.MenuItemSupply.Name = "MenuItemSupply";
            this.MenuItemSupply.Size = new System.Drawing.Size(70, 20);
            this.MenuItemSupply.Text = "Поставка";
            // 
            // MenuItemDataBase
            // 
            this.MenuItemDataBase.BackColor = System.Drawing.SystemColors.Control;
            this.MenuItemDataBase.Name = "MenuItemDataBase";
            this.MenuItemDataBase.Size = new System.Drawing.Size(86, 20);
            this.MenuItemDataBase.Text = "База данных";
            // 
            // MenuItemUsers
            // 
            this.MenuItemUsers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuItemUsers.Name = "MenuItemUsers";
            this.MenuItemUsers.Size = new System.Drawing.Size(193, 20);
            this.MenuItemUsers.Text = "Редактирование пользователей";
            // 
            // MenuItemFinishWork
            // 
            this.MenuItemFinishWork.Margin = new System.Windows.Forms.Padding(230, 0, 0, 0);
            this.MenuItemFinishWork.Name = "MenuItemFinishWork";
            this.MenuItemFinishWork.Size = new System.Drawing.Size(117, 20);
            this.MenuItemFinishWork.Text = "Завершить смену";
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(12, 525);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(90, 25);
            this.bt_Delete.TabIndex = 5;
            this.bt_Delete.Text = "Удалить";
            this.bt_Delete.UseVisualStyleBackColor = true;
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(229, 525);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(90, 25);
            this.bt_Add.TabIndex = 6;
            this.bt_Add.Text = "Добавить";
            this.bt_Add.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColLogin,
            this.ColName,
            this.ColCategory});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(307, 492);
            this.dataGridView1.TabIndex = 7;
            // 
            // ColLogin
            // 
            this.ColLogin.Frozen = true;
            this.ColLogin.HeaderText = "Логин";
            this.ColLogin.Name = "ColLogin";
            this.ColLogin.ReadOnly = true;
            // 
            // ColName
            // 
            this.ColName.Frozen = true;
            this.ColName.HeaderText = "Сотрудник";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColCategory
            // 
            this.ColCategory.Frozen = true;
            this.ColCategory.HeaderText = "Категория";
            this.ColCategory.Name = "ColCategory";
            this.ColCategory.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Информация о новом пользователе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "ФИО";
            // 
            // tb_FIO
            // 
            this.tb_FIO.Location = new System.Drawing.Point(354, 82);
            this.tb_FIO.Name = "tb_FIO";
            this.tb_FIO.Size = new System.Drawing.Size(300, 26);
            this.tb_FIO.TabIndex = 10;
            // 
            // tb_BirthDate
            // 
            this.tb_BirthDate.Location = new System.Drawing.Point(354, 142);
            this.tb_BirthDate.Name = "tb_BirthDate";
            this.tb_BirthDate.Size = new System.Drawing.Size(300, 26);
            this.tb_BirthDate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата рождения";
            // 
            // tb_EmployDate
            // 
            this.tb_EmployDate.Location = new System.Drawing.Point(354, 202);
            this.tb_EmployDate.Name = "tb_EmployDate";
            this.tb_EmployDate.Size = new System.Drawing.Size(300, 26);
            this.tb_EmployDate.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата приема на работу";
            // 
            // tb_DocNumber
            // 
            this.tb_DocNumber.Location = new System.Drawing.Point(354, 262);
            this.tb_DocNumber.Name = "tb_DocNumber";
            this.tb_DocNumber.Size = new System.Drawing.Size(300, 26);
            this.tb_DocNumber.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Номер трудового договора";
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(354, 322);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(300, 26);
            this.tb_Login.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Логин";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(354, 382);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(300, 26);
            this.tb_Password.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Пароль";
            // 
            // bt_Generate
            // 
            this.bt_Generate.Location = new System.Drawing.Point(660, 319);
            this.bt_Generate.Name = "bt_Generate";
            this.bt_Generate.Size = new System.Drawing.Size(124, 30);
            this.bt_Generate.TabIndex = 21;
            this.bt_Generate.Text = "Сгенерировать";
            this.bt_Generate.UseVisualStyleBackColor = true;
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.bt_Generate);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_DocNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_EmployDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_BirthDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_FIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditUsers";
            this.Text = "EditUsers";
            this.Load += new System.EventHandler(this.EditUsers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSale;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSupply;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDataBase;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUsers;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFinishWork;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_FIO;
        private System.Windows.Forms.TextBox tb_BirthDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_EmployDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_DocNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_Generate;
    }
}
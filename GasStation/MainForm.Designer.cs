namespace GasStation
{
    partial class MainForm
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
            this.MenuItemDataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_Action = new System.Windows.Forms.GroupBox();
            this.rb_Sale = new System.Windows.Forms.RadioButton();
            this.rb_Fuel = new System.Windows.Forms.RadioButton();
            this.bt_AddPosition = new System.Windows.Forms.Button();
            this.gb_Payment = new System.Windows.Forms.GroupBox();
            this.rb_Cash = new System.Windows.Forms.RadioButton();
            this.rb_CreditCard = new System.Windows.Forms.RadioButton();
            this.MenuItemSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_Finish = new System.Windows.Forms.Button();
            this.bt_Pay = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.gb_Discount = new System.Windows.Forms.GroupBox();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.bt_ApplyDiscount = new System.Windows.Forms.Button();
            this.MenuItemFinishWork = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_DeletePosition = new System.Windows.Forms.Button();
            this.ColName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSumup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.gb_Action.SuspendLayout();
            this.gb_Payment.SuspendLayout();
            this.gb_Discount.SuspendLayout();
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
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemSale
            // 
            this.MenuItemSale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuItemSale.Name = "MenuItemSale";
            this.MenuItemSale.Size = new System.Drawing.Size(69, 20);
            this.MenuItemSale.Text = "Продажа";
            // 
            // MenuItemDataBase
            // 
            this.MenuItemDataBase.Name = "MenuItemDataBase";
            this.MenuItemDataBase.Size = new System.Drawing.Size(86, 20);
            this.MenuItemDataBase.Text = "База данных";
            // 
            // MenuItemUsers
            // 
            this.MenuItemUsers.Name = "MenuItemUsers";
            this.MenuItemUsers.Size = new System.Drawing.Size(193, 20);
            this.MenuItemUsers.Text = "Редактирование пользователей";
            // 
            // gb_Action
            // 
            this.gb_Action.Controls.Add(this.rb_Fuel);
            this.gb_Action.Controls.Add(this.rb_Sale);
            this.gb_Action.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Action.Location = new System.Drawing.Point(0, 27);
            this.gb_Action.Name = "gb_Action";
            this.gb_Action.Size = new System.Drawing.Size(200, 78);
            this.gb_Action.TabIndex = 1;
            this.gb_Action.TabStop = false;
            this.gb_Action.Text = "Операция";
            // 
            // rb_Sale
            // 
            this.rb_Sale.AutoSize = true;
            this.rb_Sale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Sale.Location = new System.Drawing.Point(10, 46);
            this.rb_Sale.Name = "rb_Sale";
            this.rb_Sale.Size = new System.Drawing.Size(87, 23);
            this.rb_Sale.TabIndex = 1;
            this.rb_Sale.Text = "Продажа";
            this.rb_Sale.UseVisualStyleBackColor = true;
            // 
            // rb_Fuel
            // 
            this.rb_Fuel.AutoSize = true;
            this.rb_Fuel.Checked = true;
            this.rb_Fuel.Location = new System.Drawing.Point(9, 21);
            this.rb_Fuel.Name = "rb_Fuel";
            this.rb_Fuel.Size = new System.Drawing.Size(88, 23);
            this.rb_Fuel.TabIndex = 0;
            this.rb_Fuel.TabStop = true;
            this.rb_Fuel.Text = "Заправка";
            this.rb_Fuel.UseVisualStyleBackColor = true;
            // 
            // bt_AddPosition
            // 
            this.bt_AddPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_AddPosition.Location = new System.Drawing.Point(0, 108);
            this.bt_AddPosition.Name = "bt_AddPosition";
            this.bt_AddPosition.Size = new System.Drawing.Size(200, 30);
            this.bt_AddPosition.TabIndex = 3;
            this.bt_AddPosition.Text = "Добавить позицию";
            this.bt_AddPosition.UseVisualStyleBackColor = true;
            // 
            // gb_Payment
            // 
            this.gb_Payment.Controls.Add(this.rb_Cash);
            this.gb_Payment.Controls.Add(this.rb_CreditCard);
            this.gb_Payment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Payment.Location = new System.Drawing.Point(0, 322);
            this.gb_Payment.Name = "gb_Payment";
            this.gb_Payment.Size = new System.Drawing.Size(200, 78);
            this.gb_Payment.TabIndex = 4;
            this.gb_Payment.TabStop = false;
            this.gb_Payment.Text = "Способ оплаты";
            // 
            // rb_Cash
            // 
            this.rb_Cash.AutoSize = true;
            this.rb_Cash.Checked = true;
            this.rb_Cash.Location = new System.Drawing.Point(9, 21);
            this.rb_Cash.Name = "rb_Cash";
            this.rb_Cash.Size = new System.Drawing.Size(109, 23);
            this.rb_Cash.TabIndex = 0;
            this.rb_Cash.TabStop = true;
            this.rb_Cash.Text = "Наличными";
            this.rb_Cash.UseVisualStyleBackColor = true;
            // 
            // rb_CreditCard
            // 
            this.rb_CreditCard.AutoSize = true;
            this.rb_CreditCard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_CreditCard.Location = new System.Drawing.Point(9, 46);
            this.rb_CreditCard.Name = "rb_CreditCard";
            this.rb_CreditCard.Size = new System.Drawing.Size(153, 23);
            this.rb_CreditCard.TabIndex = 1;
            this.rb_CreditCard.Text = "Кредитной картой";
            this.rb_CreditCard.UseVisualStyleBackColor = true;
            // 
            // MenuItemSupply
            // 
            this.MenuItemSupply.Name = "MenuItemSupply";
            this.MenuItemSupply.Size = new System.Drawing.Size(70, 20);
            this.MenuItemSupply.Text = "Поставка";
            // 
            // bt_Finish
            // 
            this.bt_Finish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Finish.Location = new System.Drawing.Point(0, 185);
            this.bt_Finish.Name = "bt_Finish";
            this.bt_Finish.Size = new System.Drawing.Size(200, 30);
            this.bt_Finish.TabIndex = 8;
            this.bt_Finish.Text = "Завершить ввод";
            this.bt_Finish.UseVisualStyleBackColor = true;
            // 
            // bt_Pay
            // 
            this.bt_Pay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Pay.Location = new System.Drawing.Point(0, 406);
            this.bt_Pay.Name = "bt_Pay";
            this.bt_Pay.Size = new System.Drawing.Size(200, 30);
            this.bt_Pay.TabIndex = 9;
            this.bt_Pay.Text = "Оплатить";
            this.bt_Pay.UseVisualStyleBackColor = true;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Cancel.Location = new System.Drawing.Point(0, 520);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(200, 30);
            this.bt_Cancel.TabIndex = 10;
            this.bt_Cancel.Text = "Отмена";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            // 
            // gb_Discount
            // 
            this.gb_Discount.Controls.Add(this.bt_ApplyDiscount);
            this.gb_Discount.Controls.Add(this.tb_Discount);
            this.gb_Discount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Discount.Location = new System.Drawing.Point(0, 221);
            this.gb_Discount.Name = "gb_Discount";
            this.gb_Discount.Size = new System.Drawing.Size(200, 100);
            this.gb_Discount.TabIndex = 11;
            this.gb_Discount.TabStop = false;
            this.gb_Discount.Text = "Дисконтная карта";
            // 
            // tb_Discount
            // 
            this.tb_Discount.Location = new System.Drawing.Point(6, 25);
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(188, 26);
            this.tb_Discount.TabIndex = 0;
            // 
            // bt_ApplyDiscount
            // 
            this.bt_ApplyDiscount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_ApplyDiscount.Location = new System.Drawing.Point(0, 57);
            this.bt_ApplyDiscount.Name = "bt_ApplyDiscount";
            this.bt_ApplyDiscount.Size = new System.Drawing.Size(200, 30);
            this.bt_ApplyDiscount.TabIndex = 12;
            this.bt_ApplyDiscount.Text = "Применить";
            this.bt_ApplyDiscount.UseVisualStyleBackColor = true;
            // 
            // MenuItemFinishWork
            // 
            this.MenuItemFinishWork.Margin = new System.Windows.Forms.Padding(230, 0, 0, 0);
            this.MenuItemFinishWork.Name = "MenuItemFinishWork";
            this.MenuItemFinishWork.Size = new System.Drawing.Size(117, 20);
            this.MenuItemFinishWork.Text = "Завершить смену";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColID,
            this.ColCost,
            this.ColCount,
            this.ColSumup});
            this.dataGridView1.Location = new System.Drawing.Point(206, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(578, 533);
            this.dataGridView1.TabIndex = 12;
            // 
            // bt_DeletePosition
            // 
            this.bt_DeletePosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_DeletePosition.Location = new System.Drawing.Point(0, 144);
            this.bt_DeletePosition.Name = "bt_DeletePosition";
            this.bt_DeletePosition.Size = new System.Drawing.Size(200, 30);
            this.bt_DeletePosition.TabIndex = 13;
            this.bt_DeletePosition.Text = "Удалить позицию";
            this.bt_DeletePosition.UseVisualStyleBackColor = true;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Наименование";
            this.ColName.Name = "ColName";
            this.ColName.Width = 180;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "Код товара";
            this.ColID.Name = "ColID";
            this.ColID.Width = 140;
            // 
            // ColCost
            // 
            this.ColCost.HeaderText = "Цена";
            this.ColCost.Name = "ColCost";
            this.ColCost.Width = 70;
            // 
            // ColCount
            // 
            this.ColCount.HeaderText = "Количество";
            this.ColCount.Name = "ColCount";
            this.ColCount.Width = 70;
            // 
            // ColSumup
            // 
            this.ColSumup.HeaderText = "Сумма";
            this.ColSumup.Name = "ColSumup";
            this.ColSumup.Width = 75;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.bt_DeletePosition);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_Discount);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Pay);
            this.Controls.Add(this.bt_Finish);
            this.Controls.Add(this.gb_Payment);
            this.Controls.Add(this.bt_AddPosition);
            this.Controls.Add(this.gb_Action);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "GasStation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_Action.ResumeLayout(false);
            this.gb_Action.PerformLayout();
            this.gb_Payment.ResumeLayout(false);
            this.gb_Payment.PerformLayout();
            this.gb_Discount.ResumeLayout(false);
            this.gb_Discount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSale;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDataBase;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUsers;
        private System.Windows.Forms.GroupBox gb_Action;
        private System.Windows.Forms.RadioButton rb_Fuel;
        private System.Windows.Forms.RadioButton rb_Sale;
        private System.Windows.Forms.Button bt_AddPosition;
        private System.Windows.Forms.GroupBox gb_Payment;
        private System.Windows.Forms.RadioButton rb_Cash;
        private System.Windows.Forms.RadioButton rb_CreditCard;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSupply;
        private System.Windows.Forms.Button bt_Finish;
        private System.Windows.Forms.Button bt_Pay;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFinishWork;
        private System.Windows.Forms.GroupBox gb_Discount;
        private System.Windows.Forms.Button bt_ApplyDiscount;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_DeletePosition;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSumup;
    }
}
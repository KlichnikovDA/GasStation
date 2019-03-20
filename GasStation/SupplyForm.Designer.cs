namespace GasStation
{
    partial class SupplyForm
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
            this.gb_Discount = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_SupplierName = new System.Windows.Forms.ComboBox();
            this.cb_Account = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Apply = new System.Windows.Forms.Button();
            this.bt_DeletePosition = new System.Windows.Forms.Button();
            this.bt_Finish = new System.Windows.Forms.Button();
            this.bt_AddPosition = new System.Windows.Forms.Button();
            this.bt_Accept = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSumup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_ImportExcel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.TabIndex = 1;
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
            this.MenuItemSupply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuItemSupply.Name = "MenuItemSupply";
            this.MenuItemSupply.Size = new System.Drawing.Size(70, 20);
            this.MenuItemSupply.Text = "Поставка";
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
            // MenuItemFinishWork
            // 
            this.MenuItemFinishWork.Margin = new System.Windows.Forms.Padding(230, 0, 0, 0);
            this.MenuItemFinishWork.Name = "MenuItemFinishWork";
            this.MenuItemFinishWork.Size = new System.Drawing.Size(117, 20);
            this.MenuItemFinishWork.Text = "Завершить смену";
            // 
            // gb_Discount
            // 
            this.gb_Discount.Controls.Add(this.bt_Apply);
            this.gb_Discount.Controls.Add(this.cb_Account);
            this.gb_Discount.Controls.Add(this.label2);
            this.gb_Discount.Controls.Add(this.cb_SupplierName);
            this.gb_Discount.Controls.Add(this.label1);
            this.gb_Discount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Discount.Location = new System.Drawing.Point(0, 27);
            this.gb_Discount.Name = "gb_Discount";
            this.gb_Discount.Size = new System.Drawing.Size(200, 179);
            this.gb_Discount.TabIndex = 12;
            this.gb_Discount.TabStop = false;
            this.gb_Discount.Text = "Поставщик";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Наименование";
            // 
            // cb_SupplierName
            // 
            this.cb_SupplierName.FormattingEnabled = true;
            this.cb_SupplierName.Location = new System.Drawing.Point(7, 45);
            this.cb_SupplierName.Name = "cb_SupplierName";
            this.cb_SupplierName.Size = new System.Drawing.Size(187, 27);
            this.cb_SupplierName.TabIndex = 3;
            // 
            // cb_Account
            // 
            this.cb_Account.FormattingEnabled = true;
            this.cb_Account.Location = new System.Drawing.Point(6, 104);
            this.cb_Account.Name = "cb_Account";
            this.cb_Account.Size = new System.Drawing.Size(187, 27);
            this.cb_Account.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Рассчетный счет";
            // 
            // bt_Apply
            // 
            this.bt_Apply.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Apply.Location = new System.Drawing.Point(0, 137);
            this.bt_Apply.Name = "bt_Apply";
            this.bt_Apply.Size = new System.Drawing.Size(200, 30);
            this.bt_Apply.TabIndex = 13;
            this.bt_Apply.Text = "Применить";
            this.bt_Apply.UseVisualStyleBackColor = true;
            // 
            // bt_DeletePosition
            // 
            this.bt_DeletePosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_DeletePosition.Location = new System.Drawing.Point(0, 248);
            this.bt_DeletePosition.Name = "bt_DeletePosition";
            this.bt_DeletePosition.Size = new System.Drawing.Size(200, 30);
            this.bt_DeletePosition.TabIndex = 16;
            this.bt_DeletePosition.Text = "Удалить позицию";
            this.bt_DeletePosition.UseVisualStyleBackColor = true;
            // 
            // bt_Finish
            // 
            this.bt_Finish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Finish.Location = new System.Drawing.Point(0, 289);
            this.bt_Finish.Name = "bt_Finish";
            this.bt_Finish.Size = new System.Drawing.Size(200, 30);
            this.bt_Finish.TabIndex = 15;
            this.bt_Finish.Text = "Завершить ввод";
            this.bt_Finish.UseVisualStyleBackColor = true;
            // 
            // bt_AddPosition
            // 
            this.bt_AddPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_AddPosition.Location = new System.Drawing.Point(0, 212);
            this.bt_AddPosition.Name = "bt_AddPosition";
            this.bt_AddPosition.Size = new System.Drawing.Size(200, 30);
            this.bt_AddPosition.TabIndex = 14;
            this.bt_AddPosition.Text = "Добавить позицию";
            this.bt_AddPosition.UseVisualStyleBackColor = true;
            // 
            // bt_Accept
            // 
            this.bt_Accept.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Accept.Location = new System.Drawing.Point(0, 367);
            this.bt_Accept.Name = "bt_Accept";
            this.bt_Accept.Size = new System.Drawing.Size(200, 30);
            this.bt_Accept.TabIndex = 17;
            this.bt_Accept.Text = "Подтвердить";
            this.bt_Accept.UseVisualStyleBackColor = true;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Cancel.Location = new System.Drawing.Point(0, 520);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(200, 30);
            this.bt_Cancel.TabIndex = 18;
            this.bt_Cancel.Text = "Отмена";
            this.bt_Cancel.UseVisualStyleBackColor = true;
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
            this.dataGridView1.TabIndex = 19;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Наименование";
            this.ColName.Name = "ColName";
            // 
            // ColID
            // 
            this.ColID.HeaderText = "Код товара";
            this.ColID.Name = "ColID";
            // 
            // ColCost
            // 
            this.ColCost.HeaderText = "Цена";
            this.ColCost.Name = "ColCost";
            // 
            // ColCount
            // 
            this.ColCount.HeaderText = "Количество";
            this.ColCount.Name = "ColCount";
            // 
            // ColSumup
            // 
            this.ColSumup.HeaderText = "Сумма";
            this.ColSumup.Name = "ColSumup";
            // 
            // bt_ImportExcel
            // 
            this.bt_ImportExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_ImportExcel.Location = new System.Drawing.Point(0, 444);
            this.bt_ImportExcel.Name = "bt_ImportExcel";
            this.bt_ImportExcel.Size = new System.Drawing.Size(200, 30);
            this.bt_ImportExcel.TabIndex = 20;
            this.bt_ImportExcel.Text = "Импорт данных из Excel";
            this.bt_ImportExcel.UseVisualStyleBackColor = true;
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.bt_ImportExcel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Accept);
            this.Controls.Add(this.bt_DeletePosition);
            this.Controls.Add(this.bt_Finish);
            this.Controls.Add(this.bt_AddPosition);
            this.Controls.Add(this.gb_Discount);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SupplyForm";
            this.Text = "GasStation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_Discount.ResumeLayout(false);
            this.gb_Discount.PerformLayout();
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
        private System.Windows.Forms.GroupBox gb_Discount;
        private System.Windows.Forms.ComboBox cb_Account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_SupplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Apply;
        private System.Windows.Forms.Button bt_DeletePosition;
        private System.Windows.Forms.Button bt_Finish;
        private System.Windows.Forms.Button bt_AddPosition;
        private System.Windows.Forms.Button bt_Accept;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSumup;
        private System.Windows.Forms.Button bt_ImportExcel;
    }
}
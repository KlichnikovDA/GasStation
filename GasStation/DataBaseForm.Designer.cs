namespace GasStation
{
    partial class DataBaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_ExportExcel = new System.Windows.Forms.Button();
            this.bt_Query = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Tables = new System.Windows.Forms.ComboBox();
            this.lv_Attributes = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bt_AddAttr = new System.Windows.Forms.Button();
            this.bt_RemoveAttr = new System.Windows.Forms.Button();
            this.bt_AddAll = new System.Windows.Forms.Button();
            this.bt_RemoveAll = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColTable = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColAttr = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColOper = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColConjunction = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.MenuItemDataBase.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Конструктор запросов";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTable,
            this.ColAttr,
            this.ColOper,
            this.ColValue,
            this.ColConjunction});
            this.dataGridView1.Location = new System.Drawing.Point(4, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(760, 130);
            this.dataGridView1.TabIndex = 5;
            // 
            // bt_ExportExcel
            // 
            this.bt_ExportExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_ExportExcel.Location = new System.Drawing.Point(177, 271);
            this.bt_ExportExcel.Name = "bt_ExportExcel";
            this.bt_ExportExcel.Size = new System.Drawing.Size(200, 25);
            this.bt_ExportExcel.TabIndex = 21;
            this.bt_ExportExcel.Text = "Экспорт данных в Excel";
            this.bt_ExportExcel.UseVisualStyleBackColor = true;
            // 
            // bt_Query
            // 
            this.bt_Query.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Query.Location = new System.Drawing.Point(616, 271);
            this.bt_Query.Name = "bt_Query";
            this.bt_Query.Size = new System.Drawing.Size(100, 25);
            this.bt_Query.TabIndex = 22;
            this.bt_Query.Text = "Поиск";
            this.bt_Query.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Сущность";
            // 
            // cb_Tables
            // 
            this.cb_Tables.FormattingEnabled = true;
            this.cb_Tables.Location = new System.Drawing.Point(16, 61);
            this.cb_Tables.Name = "cb_Tables";
            this.cb_Tables.Size = new System.Drawing.Size(200, 21);
            this.cb_Tables.TabIndex = 24;
            // 
            // lv_Attributes
            // 
            this.lv_Attributes.Location = new System.Drawing.Point(254, 61);
            this.lv_Attributes.Name = "lv_Attributes";
            this.lv_Attributes.Size = new System.Drawing.Size(200, 200);
            this.lv_Attributes.TabIndex = 25;
            this.lv_Attributes.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(250, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Атрибуты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(512, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Искомые атрибуты";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(516, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(200, 200);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bt_AddAttr
            // 
            this.bt_AddAttr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_AddAttr.Location = new System.Drawing.Point(460, 118);
            this.bt_AddAttr.Name = "bt_AddAttr";
            this.bt_AddAttr.Size = new System.Drawing.Size(50, 40);
            this.bt_AddAttr.TabIndex = 29;
            this.bt_AddAttr.Text = ">";
            this.bt_AddAttr.UseVisualStyleBackColor = true;
            this.bt_AddAttr.Click += new System.EventHandler(this.bt_AddAttr_Click);
            // 
            // bt_RemoveAttr
            // 
            this.bt_RemoveAttr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_RemoveAttr.Location = new System.Drawing.Point(460, 164);
            this.bt_RemoveAttr.Name = "bt_RemoveAttr";
            this.bt_RemoveAttr.Size = new System.Drawing.Size(50, 40);
            this.bt_RemoveAttr.TabIndex = 30;
            this.bt_RemoveAttr.Text = "<";
            this.bt_RemoveAttr.UseVisualStyleBackColor = true;
            // 
            // bt_AddAll
            // 
            this.bt_AddAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_AddAll.Location = new System.Drawing.Point(460, 72);
            this.bt_AddAll.Name = "bt_AddAll";
            this.bt_AddAll.Size = new System.Drawing.Size(50, 40);
            this.bt_AddAll.TabIndex = 31;
            this.bt_AddAll.Text = ">>";
            this.bt_AddAll.UseVisualStyleBackColor = true;
            // 
            // bt_RemoveAll
            // 
            this.bt_RemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_RemoveAll.Location = new System.Drawing.Point(460, 210);
            this.bt_RemoveAll.Name = "bt_RemoveAll";
            this.bt_RemoveAll.Size = new System.Drawing.Size(50, 40);
            this.bt_RemoveAll.TabIndex = 32;
            this.bt_RemoveAll.Text = "<<";
            this.bt_RemoveAll.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 433);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(760, 400);
            this.dataGridView2.TabIndex = 33;
            // 
            // ColTable
            // 
            this.ColTable.HeaderText = "Сущность";
            this.ColTable.Name = "ColTable";
            this.ColTable.Width = 210;
            // 
            // ColAttr
            // 
            this.ColAttr.HeaderText = "Атрибут";
            this.ColAttr.Name = "ColAttr";
            this.ColAttr.Width = 210;
            // 
            // ColOper
            // 
            this.ColOper.HeaderText = "Оператор";
            this.ColOper.Name = "ColOper";
            this.ColOper.Width = 65;
            // 
            // ColValue
            // 
            this.ColValue.HeaderText = "Значение";
            this.ColValue.Name = "ColValue";
            this.ColValue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColValue.Width = 215;
            // 
            // ColConjunction
            // 
            this.ColConjunction.HeaderText = "Союз";
            this.ColConjunction.Name = "ColConjunction";
            this.ColConjunction.Width = 55;
            // 
            // DataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bt_RemoveAll);
            this.Controls.Add(this.bt_AddAll);
            this.Controls.Add(this.bt_RemoveAttr);
            this.Controls.Add(this.bt_AddAttr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lv_Attributes);
            this.Controls.Add(this.cb_Tables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Query);
            this.Controls.Add(this.bt_ExportExcel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DataBaseForm";
            this.Text = "DataBaseForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_ExportExcel;
        private System.Windows.Forms.Button bt_Query;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Tables;
        private System.Windows.Forms.ListView lv_Attributes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bt_AddAttr;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColTable;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColAttr;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColOper;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValue;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColConjunction;
        private System.Windows.Forms.Button bt_RemoveAttr;
        private System.Windows.Forms.Button bt_AddAll;
        private System.Windows.Forms.Button bt_RemoveAll;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
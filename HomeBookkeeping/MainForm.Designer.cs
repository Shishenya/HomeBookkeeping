namespace HomeBookkeeping
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРасходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddNewCategoryBtn = new System.Windows.Forms.Button();
            this.CategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.homeBookkeepingDataSet = new HomeBookkeeping.HomeBookkeepingDataSet();
            this.categoryCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryCostTableAdapter = new HomeBookkeeping.HomeBookkeepingDataSetTableAdapters.categoryCostTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdateCategoryButton = new System.Windows.Forms.Button();
            this.DeleteCategoryButton = new System.Windows.Forms.Button();
            this.NameCategoryRedactTextBox = new System.Windows.Forms.TextBox();
            this.IDRedactTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ExpenditureByCategoryButton = new System.Windows.Forms.Button();
            this.AddExpenditureButton = new System.Windows.Forms.Button();
            this.ExpenditureDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.GenerateReportByPeriodButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EndDateTimePickerByPeriod = new System.Windows.Forms.DateTimePicker();
            this.BeginDateTimePickerByPeriod = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBookkeepingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCostBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenditureDataGridView)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКатегориюToolStripMenuItem,
            this.добавитьРасходToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // добавитьКатегориюToolStripMenuItem
            // 
            this.добавитьКатегориюToolStripMenuItem.Name = "добавитьКатегориюToolStripMenuItem";
            this.добавитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.добавитьКатегориюToolStripMenuItem.Text = "Добавить Категорию";
            this.добавитьКатегориюToolStripMenuItem.Click += new System.EventHandler(this.добавитьКатегориюToolStripMenuItem_Click);
            // 
            // добавитьРасходToolStripMenuItem
            // 
            this.добавитьРасходToolStripMenuItem.Name = "добавитьРасходToolStripMenuItem";
            this.добавитьРасходToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.добавитьРасходToolStripMenuItem.Text = "Добавить расход";
            this.добавитьРасходToolStripMenuItem.Click += new System.EventHandler(this.добавитьРасходToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddNewCategoryBtn);
            this.groupBox1.Controls.Add(this.CategoryDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(34, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 384);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Категории";
            // 
            // AddNewCategoryBtn
            // 
            this.AddNewCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewCategoryBtn.Location = new System.Drawing.Point(22, 335);
            this.AddNewCategoryBtn.Name = "AddNewCategoryBtn";
            this.AddNewCategoryBtn.Size = new System.Drawing.Size(271, 31);
            this.AddNewCategoryBtn.TabIndex = 1;
            this.AddNewCategoryBtn.Text = "Добавить новую категорию";
            this.AddNewCategoryBtn.UseVisualStyleBackColor = true;
            this.AddNewCategoryBtn.Click += new System.EventHandler(this.добавитьКатегориюToolStripMenuItem_Click);
            // 
            // CategoryDataGridView
            // 
            this.CategoryDataGridView.AllowUserToAddRows = false;
            this.CategoryDataGridView.AllowUserToDeleteRows = false;
            this.CategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryDataGridView.Location = new System.Drawing.Point(22, 21);
            this.CategoryDataGridView.Name = "CategoryDataGridView";
            this.CategoryDataGridView.ReadOnly = true;
            this.CategoryDataGridView.Size = new System.Drawing.Size(271, 308);
            this.CategoryDataGridView.TabIndex = 0;
            this.CategoryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryDataGridView_CellClick);
            // 
            // homeBookkeepingDataSet
            // 
            this.homeBookkeepingDataSet.DataSetName = "HomeBookkeepingDataSet";
            this.homeBookkeepingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryCostBindingSource
            // 
            this.categoryCostBindingSource.DataMember = "categoryCost";
            this.categoryCostBindingSource.DataSource = this.homeBookkeepingDataSet;
            // 
            // categoryCostTableAdapter
            // 
            this.categoryCostTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpdateCategoryButton);
            this.groupBox2.Controls.Add(this.DeleteCategoryButton);
            this.groupBox2.Controls.Add(this.NameCategoryRedactTextBox);
            this.groupBox2.Controls.Add(this.IDRedactTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(36, 425);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 137);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение записи";
            // 
            // UpdateCategoryButton
            // 
            this.UpdateCategoryButton.Location = new System.Drawing.Point(182, 92);
            this.UpdateCategoryButton.Name = "UpdateCategoryButton";
            this.UpdateCategoryButton.Size = new System.Drawing.Size(108, 39);
            this.UpdateCategoryButton.TabIndex = 5;
            this.UpdateCategoryButton.Text = "Изменить";
            this.UpdateCategoryButton.UseVisualStyleBackColor = true;
            this.UpdateCategoryButton.Click += new System.EventHandler(this.UpdateCategoryButton_Click);
            // 
            // DeleteCategoryButton
            // 
            this.DeleteCategoryButton.Location = new System.Drawing.Point(23, 92);
            this.DeleteCategoryButton.Name = "DeleteCategoryButton";
            this.DeleteCategoryButton.Size = new System.Drawing.Size(108, 39);
            this.DeleteCategoryButton.TabIndex = 4;
            this.DeleteCategoryButton.Text = "Удалить";
            this.DeleteCategoryButton.UseVisualStyleBackColor = true;
            this.DeleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
            // 
            // NameCategoryRedactTextBox
            // 
            this.NameCategoryRedactTextBox.Location = new System.Drawing.Point(153, 57);
            this.NameCategoryRedactTextBox.Name = "NameCategoryRedactTextBox";
            this.NameCategoryRedactTextBox.Size = new System.Drawing.Size(137, 20);
            this.NameCategoryRedactTextBox.TabIndex = 3;
            // 
            // IDRedactTextBox
            // 
            this.IDRedactTextBox.Enabled = false;
            this.IDRedactTextBox.Location = new System.Drawing.Point(153, 29);
            this.IDRedactTextBox.Name = "IDRedactTextBox";
            this.IDRedactTextBox.Size = new System.Drawing.Size(137, 20);
            this.IDRedactTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название категории";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(127, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.ExpenditureByCategoryButton);
            this.groupBox3.Controls.Add(this.AddExpenditureButton);
            this.groupBox3.Controls.Add(this.ExpenditureDataGridView);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Location = new System.Drawing.Point(370, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(647, 529);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Формирование отчета";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Выгрузить в Excel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ExpenditureByCategoryButton
            // 
            this.ExpenditureByCategoryButton.Location = new System.Drawing.Point(241, 484);
            this.ExpenditureByCategoryButton.Name = "ExpenditureByCategoryButton";
            this.ExpenditureByCategoryButton.Size = new System.Drawing.Size(150, 39);
            this.ExpenditureByCategoryButton.TabIndex = 4;
            this.ExpenditureByCategoryButton.Text = "Показать расходы в разрезе категорий";
            this.ExpenditureByCategoryButton.UseVisualStyleBackColor = true;
            this.ExpenditureByCategoryButton.Click += new System.EventHandler(this.ExpenditureByCategoryButton_Click);
            // 
            // AddExpenditureButton
            // 
            this.AddExpenditureButton.Location = new System.Drawing.Point(21, 484);
            this.AddExpenditureButton.Name = "AddExpenditureButton";
            this.AddExpenditureButton.Size = new System.Drawing.Size(150, 39);
            this.AddExpenditureButton.TabIndex = 3;
            this.AddExpenditureButton.Text = "Добавить расход";
            this.AddExpenditureButton.UseVisualStyleBackColor = true;
            this.AddExpenditureButton.Click += new System.EventHandler(this.добавитьРасходToolStripMenuItem_Click);
            // 
            // ExpenditureDataGridView
            // 
            this.ExpenditureDataGridView.AllowUserToAddRows = false;
            this.ExpenditureDataGridView.AllowUserToDeleteRows = false;
            this.ExpenditureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpenditureDataGridView.Location = new System.Drawing.Point(18, 95);
            this.ExpenditureDataGridView.Name = "ExpenditureDataGridView";
            this.ExpenditureDataGridView.ReadOnly = true;
            this.ExpenditureDataGridView.Size = new System.Drawing.Size(602, 374);
            this.ExpenditureDataGridView.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.GenerateReportByPeriodButton);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.EndDateTimePickerByPeriod);
            this.groupBox6.Controls.Add(this.BeginDateTimePickerByPeriod);
            this.groupBox6.Location = new System.Drawing.Point(18, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(603, 64);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Детальный отчет за период";
            // 
            // GenerateReportByPeriodButton
            // 
            this.GenerateReportByPeriodButton.Location = new System.Drawing.Point(428, 19);
            this.GenerateReportByPeriodButton.Name = "GenerateReportByPeriodButton";
            this.GenerateReportByPeriodButton.Size = new System.Drawing.Size(169, 26);
            this.GenerateReportByPeriodButton.TabIndex = 4;
            this.GenerateReportByPeriodButton.Text = "Сформировать отчет";
            this.GenerateReportByPeriodButton.UseVisualStyleBackColor = true;
            this.GenerateReportByPeriodButton.Click += new System.EventHandler(this.GenerateReportByPeriodButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(220, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Конец:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Начало:";
            // 
            // EndDateTimePickerByPeriod
            // 
            this.EndDateTimePickerByPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDateTimePickerByPeriod.Location = new System.Drawing.Point(292, 25);
            this.EndDateTimePickerByPeriod.Name = "EndDateTimePickerByPeriod";
            this.EndDateTimePickerByPeriod.Size = new System.Drawing.Size(117, 20);
            this.EndDateTimePickerByPeriod.TabIndex = 1;
            // 
            // BeginDateTimePickerByPeriod
            // 
            this.BeginDateTimePickerByPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeginDateTimePickerByPeriod.Location = new System.Drawing.Point(84, 25);
            this.BeginDateTimePickerByPeriod.Name = "BeginDateTimePickerByPeriod";
            this.BeginDateTimePickerByPeriod.Size = new System.Drawing.Size(117, 20);
            this.BeginDateTimePickerByPeriod.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 601);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Домашнаяя бухгалтерия";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBookkeepingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCostBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenditureDataGridView)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКатегориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView CategoryDataGridView;
        private HomeBookkeepingDataSet homeBookkeepingDataSet;
        private System.Windows.Forms.BindingSource categoryCostBindingSource;
        private HomeBookkeepingDataSetTableAdapters.categoryCostTableAdapter categoryCostTableAdapter;
        private System.Windows.Forms.Button AddNewCategoryBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UpdateCategoryButton;
        private System.Windows.Forms.Button DeleteCategoryButton;
        private System.Windows.Forms.TextBox NameCategoryRedactTextBox;
        private System.Windows.Forms.TextBox IDRedactTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker BeginDateTimePickerByPeriod;
        private System.Windows.Forms.Button GenerateReportByPeriodButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EndDateTimePickerByPeriod;
        private System.Windows.Forms.ToolStripMenuItem добавитьРасходToolStripMenuItem;
        private System.Windows.Forms.DataGridView ExpenditureDataGridView;
        private System.Windows.Forms.Button AddExpenditureButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ExpenditureByCategoryButton;
    }
}


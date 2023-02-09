namespace HomeBookkeeping
{
    partial class ExpendetureByCategoryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExpenditureByCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.BeginDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenditure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenditureByCategoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExpenditureByCategoryDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ExpenditureByCategoryDataGridView
            // 
            this.ExpenditureByCategoryDataGridView.AllowUserToAddRows = false;
            this.ExpenditureByCategoryDataGridView.AllowUserToDeleteRows = false;
            this.ExpenditureByCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpenditureByCategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.category,
            this.expenditure});
            this.ExpenditureByCategoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpenditureByCategoryDataGridView.Location = new System.Drawing.Point(3, 16);
            this.ExpenditureByCategoryDataGridView.Name = "ExpenditureByCategoryDataGridView";
            this.ExpenditureByCategoryDataGridView.ReadOnly = true;
            this.ExpenditureByCategoryDataGridView.Size = new System.Drawing.Size(336, 399);
            this.ExpenditureByCategoryDataGridView.TabIndex = 0;
            // 
            // BeginDateLabel
            // 
            this.BeginDateLabel.AutoSize = true;
            this.BeginDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeginDateLabel.Location = new System.Drawing.Point(26, 14);
            this.BeginDateLabel.Name = "BeginDateLabel";
            this.BeginDateLabel.Size = new System.Drawing.Size(55, 20);
            this.BeginDateLabel.TabIndex = 1;
            this.BeginDateLabel.Text = "Begin";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDateLabel.Location = new System.Drawing.Point(26, 49);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(41, 20);
            this.EndDateLabel.TabIndex = 2;
            this.EndDateLabel.Text = "End";
            // 
            // category
            // 
            this.category.HeaderText = "Категория";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // expenditure
            // 
            this.expenditure.HeaderText = "Расходы";
            this.expenditure.Name = "expenditure";
            this.expenditure.ReadOnly = true;
            // 
            // ExpendetureByCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 502);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.BeginDateLabel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ExpendetureByCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расходы в разрезе категорий.";
            this.Load += new System.EventHandler(this.ExpendetureByCategoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenditureByCategoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ExpenditureByCategoryDataGridView;
        private System.Windows.Forms.Label BeginDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenditure;
    }
}
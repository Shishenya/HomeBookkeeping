namespace HomeBookkeeping
{
    partial class AddNewCategoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NewCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.AddNewCategoryButton = new System.Windows.Forms.Button();
            this.StatusNewCategoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название категории";
            // 
            // NewCategoryNameTextBox
            // 
            this.NewCategoryNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewCategoryNameTextBox.Location = new System.Drawing.Point(26, 32);
            this.NewCategoryNameTextBox.Name = "NewCategoryNameTextBox";
            this.NewCategoryNameTextBox.Size = new System.Drawing.Size(283, 23);
            this.NewCategoryNameTextBox.TabIndex = 1;
            this.NewCategoryNameTextBox.TextChanged += new System.EventHandler(this.AddNewCategoryForm_TextChanged);
            // 
            // AddNewCategoryButton
            // 
            this.AddNewCategoryButton.Location = new System.Drawing.Point(93, 83);
            this.AddNewCategoryButton.Name = "AddNewCategoryButton";
            this.AddNewCategoryButton.Size = new System.Drawing.Size(146, 26);
            this.AddNewCategoryButton.TabIndex = 2;
            this.AddNewCategoryButton.Text = "Добавить категорию";
            this.AddNewCategoryButton.UseVisualStyleBackColor = true;
            this.AddNewCategoryButton.Click += new System.EventHandler(this.AddNewCategoryButton_Click);
            // 
            // StatusNewCategoryLabel
            // 
            this.StatusNewCategoryLabel.AutoSize = true;
            this.StatusNewCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusNewCategoryLabel.Location = new System.Drawing.Point(76, 58);
            this.StatusNewCategoryLabel.Name = "StatusNewCategoryLabel";
            this.StatusNewCategoryLabel.Size = new System.Drawing.Size(104, 15);
            this.StatusNewCategoryLabel.TabIndex = 3;
            this.StatusNewCategoryLabel.Text = "Статус создания";
            // 
            // AddNewCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 121);
            this.Controls.Add(this.StatusNewCategoryLabel);
            this.Controls.Add(this.AddNewCategoryButton);
            this.Controls.Add(this.NewCategoryNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddNewCategoryForm";
            this.Text = "Добавление категории";
            this.Load += new System.EventHandler(this.AddNewCategoryForm_Load);
            this.TextChanged += new System.EventHandler(this.AddNewCategoryForm_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewCategoryNameTextBox;
        private System.Windows.Forms.Button AddNewCategoryButton;
        private System.Windows.Forms.Label StatusNewCategoryLabel;
    }
}
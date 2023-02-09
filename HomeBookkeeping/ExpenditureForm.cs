using DataBaseNamespace;
using HomeBookkeeping.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HomeBookkeeping
{
    public partial class ExpenditureForm : Form
    {
        public ExpenditureForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ExpenditureForm_Load(object sender, EventArgs e)
        {
            // Добавляем категории в ComboBox
            IDataBase dataBase = new DataBaseNamespace.DataBase();
            Category category = new Category(dataBase);
            category.AddCategoryToCheckBox(CategoryComboBox);
            if (CategoryComboBox.Items.Count>0) CategoryComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Добавление нового расхода
        /// </summary>
        private void AddNewExpenditureButton_Click(object sender, EventArgs e)
        {

            int selectedCategory = CategoryComboBox.SelectedIndex;
            string nameCategory = CategoryComboBox.Items[selectedCategory].ToString();
            string comment = CommentTextBox.Text;

            DateTime dateTime = DateTime.Parse(ExpenditureDateTimePicker.Value.ToString("MM-dd-yyyy"));

            if (!float.TryParse(CostTextBox.Text, out float cost))
            {
                MessageBox.Show("Неверная строка с затратами.\nВведите сумму в формате ХХХ,ХХ");
                return;
            }

            IDataBase dataBase = new DataBaseNamespace.DataBase();
            Expenditure expenditure = new Expenditure(dataBase);
            expenditure.AddNewExpenditure(dateTime, nameCategory, cost, comment);

            // Обнуление полей
            CommentTextBox.Text = "";
            CostTextBox.Text = "";
        }
    }
}

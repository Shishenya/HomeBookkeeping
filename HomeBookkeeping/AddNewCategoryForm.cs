using DataBaseNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBookkeeping
{
    public partial class AddNewCategoryForm : Form
    {

        private readonly string _errorLenghtNewCategory = "Неверная длина в имени категории!";
        private readonly string _errorNewNameCategory = "Такая категория уже существует!";
        private readonly string _noError = "Имя категории доступно для создания";

        private readonly MainForm _mainForm;
        private readonly DataGridView _categoryData;

        public AddNewCategoryForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public AddNewCategoryForm(DataGridView categoryData)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _categoryData = categoryData;
        }

        private void AddNewCategoryForm_Load(object sender, EventArgs e)
        {
            StatusNewCategoryLabel.Text = _errorLenghtNewCategory;
            StatusNewCategoryLabel.ForeColor = Color.Red;
            AddNewCategoryButton.Enabled = false;
        }

        /// <summary>
        /// Проверка на правильное название и длину в имени категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewCategoryForm_TextChanged(object sender, EventArgs e)
        {
            IDataBase dataBase = new DataBaseNamespace.DataBase();
            Category newCategory = new Category(dataBase);

            // Проверка на правильное название
            if (!newCategory.CheckLenghtNewCategory(NewCategoryNameTextBox.Text))
            {
                StatusNewCategoryLabel.Text = _errorLenghtNewCategory;
                StatusNewCategoryLabel.ForeColor = Color.Red;
                AddNewCategoryButton.Enabled = false;
            }
            else
            {
                if (newCategory.CheckCategoryName(NewCategoryNameTextBox.Text))
                {
                    StatusNewCategoryLabel.Text = _errorNewNameCategory;
                    StatusNewCategoryLabel.ForeColor = Color.Red;
                    AddNewCategoryButton.Enabled = false;
                }
                else
                {
                    StatusNewCategoryLabel.Text = _noError;
                    StatusNewCategoryLabel.ForeColor = Color.Green;
                    AddNewCategoryButton.Enabled = true;
                }
            }

        }

        /// <summary>
        /// Добавление новой категории
        /// </summary>
        private void AddNewCategoryButton_Click(object sender, EventArgs e)
        {
            IDataBase dataBase = new DataBaseNamespace.DataBase();
            Category category = new Category(dataBase);
            category.AddNewCategory(NewCategoryNameTextBox.Text);
            NewCategoryNameTextBox.Text = "";
            category.ReadFromDBToDataGrid(_categoryData);
        }
    }
}

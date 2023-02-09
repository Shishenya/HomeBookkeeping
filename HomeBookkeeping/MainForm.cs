using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseNamespace;
using HomeBookkeeping.DataBase;

namespace HomeBookkeeping
{
    public partial class MainForm : Form
    {

        private int _selectedRowCategory; // Выбранная категория

        private DateTime _beginDate;
        private DateTime _endDate;

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeBookkeepingDataSet.categoryCost". При необходимости она может быть перемещена или удалена.
            this.categoryCostTableAdapter.Fill(this.homeBookkeepingDataSet.categoryCost);
            // Соединяемся с БД
            IDataBase dataBase = new DataBaseNamespace.DataBase();
            Category category = new Category(dataBase);
            //category.AddNewCategory("Автозапчасти");
            category.CreateColumns(CategoryDataGridView);
            category.ReadFromDBToDataGrid(CategoryDataGridView);
        }

        private void добавитьКатегориюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCategoryForm addNewCategoryForm = new AddNewCategoryForm(CategoryDataGridView);
            addNewCategoryForm.ShowDialog();
        }

        private void CategoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRowCategory = e.RowIndex;
            if (_selectedRowCategory > 0)
            {
                DataGridViewRow currentRow = CategoryDataGridView.Rows[_selectedRowCategory];
                IDRedactTextBox.Text = currentRow.Cells[0].Value.ToString();
                NameCategoryRedactTextBox.Text = currentRow.Cells[1].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Удаление категории
        /// </summary>
        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(IDRedactTextBox.Text, out int id))
            {
                IDataBase dataBase = new DataBaseNamespace.DataBase();
                Category deleteCategory = new Category(dataBase);

                if (!deleteCategory.IsCategoryInExpenditure(id))
                {

                    deleteCategory.DeleteCategory(id, CategoryDataGridView);
                    IDRedactTextBox.Text = "";
                    NameCategoryRedactTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Данная категория есть в расходах. Ее нельзя удалить!");
                }
            }
            else
            {
                MessageBox.Show("Выберите категорию для удаления!");
            }
        }

        /// <summary>
        /// Кнопка редактирования категории
        /// </summary>
        private void UpdateCategoryButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(IDRedactTextBox.Text, out int id))
            {
                IDataBase dataBase = new DataBaseNamespace.DataBase();
                Category redactCategory = new Category(dataBase);
                redactCategory.RedactCategoryName(id, CategoryDataGridView, NameCategoryRedactTextBox.Text);
                IDRedactTextBox.Text = "";
                NameCategoryRedactTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Выберите категорию для изменения!");
            }
        }

        private void добавитьРасходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenditureForm expenditureForm = new ExpenditureForm();
            expenditureForm.ShowDialog();
        }

        private void GenerateReportByPeriodButton_Click(object sender, EventArgs e)
        {

            _beginDate = BeginDateTimePickerByPeriod.Value;
            _endDate = EndDateTimePickerByPeriod.Value;

            IDataBase dataBase = new DataBaseNamespace.DataBase();
            Expenditure expenditure = new Expenditure(dataBase);

            DateTime beginDate = BeginDateTimePickerByPeriod.Value;
            DateTime endDate = EndDateTimePickerByPeriod.Value;

            expenditure.CreateColumnsForReportByPeriod(ExpenditureDataGridView);
            expenditure.ReadFromDBToDataGrid(ExpenditureDataGridView, beginDate, endDate);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExpenditureByCategoryButton_Click(object sender, EventArgs e)
        {
            ExpendetureByCategoryForm expendetureByCategoryForm = new ExpendetureByCategoryForm(_beginDate, _endDate, ExpenditureDataGridView);
            expendetureByCategoryForm.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseNamespace
{
    public class Category
    {

        private IDataBase _dataBase;
        private readonly string _nameTableCategory = "categoryCost";
        private readonly string _nameTableExpenditure = "expenditure";
        private readonly string _errorNameCategory = "Такая категория уже существует!";
        private readonly string _errorLenghtNameCategory = "Неверная длина в имени категории!";

        public Category(IDataBase dataBase)
        {
            _dataBase = dataBase;
        }

        /// <summary>
        /// Добавление новой категории в БД
        /// </summary>
        public void AddNewCategory(string nameCategory)
        {

            string headerError = "Ошибка создания!";

            if (CheckCategoryName(nameCategory))
            {
                MessageBox.Show(_errorNameCategory, headerError);
                return;
            }

            if (!CheckLenghtNewCategory(nameCategory))
            {
                MessageBox.Show(_errorLenghtNameCategory, headerError);
                return;
            }

            string query = $"INSERT INTO {_nameTableCategory}(nameCategory) VALUES('{nameCategory}')";
            SqlCommand command = new SqlCommand(query, _dataBase.GetConnection());

            _dataBase.OpenConnectDB();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Категория успешно создана", "Выполнение запроса!");
            }
            else
            {
                MessageBox.Show("Ошибка при создании новой категории", headerError);
            }

            _dataBase.CloseConnectDB();
        }

        /// <summary>
        /// Возвращает True, если такая категория существует
        /// </summary>
        public bool CheckCategoryName(string nameCategory)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"SELECT nameCategory FROM {_nameTableCategory} WHERE nameCategory = '{nameCategory}'";

            SqlCommand command = new SqlCommand(query, _dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Проверяет длину названия категории
        /// Возвращает True, если длина верная
        /// </summary>
        public bool CheckLenghtNewCategory(string nameCategory)
        {
            if (nameCategory.Length < 3 || nameCategory.Length > 50) return false;
            return true;
        }

        /// <summary>
        /// Создание колонок для таблицы с категориями
        /// </summary>
        public void CreateColumns(DataGridView categoryData)
        {
            categoryData.Columns.Add("idCategory", "ID");
            categoryData.Columns.Add("nameCategory", "Категория расходов");
        }

        /// <summary>
        /// Установка параметров полей
        /// </summary>
        public void ReadSingleRows(DataGridView categoryData, IDataRecord record)
        {
            categoryData.Rows.Add(record.GetInt32(0), record.GetString(1));
        }

        /// <summary>
        /// Чтение данных из БД в DataGrid
        /// </summary>
        public void ReadFromDBToDataGrid(DataGridView categoryData)
        {
            categoryData.Rows.Clear();

            string query = $"SELECT * FROM {_nameTableCategory}";

            SqlCommand command = new SqlCommand(query, _dataBase.GetConnection());
            _dataBase.OpenConnectDB();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRows(categoryData, reader);
            }

            reader.Close();
            _dataBase.CloseConnectDB();
        }

        /// <summary>
        /// Удаление категории по ID
        /// </summary>
        public void DeleteCategory(int idCategory, DataGridView categoryData)
        {
            _dataBase.OpenConnectDB();

            string query = $"DELETE FROM {_nameTableCategory} WHERE idCategory={idCategory}";
            SqlCommand command = new SqlCommand(query, _dataBase.GetConnection());
            command.ExecuteNonQuery();

            _dataBase.CloseConnectDB();

            ReadFromDBToDataGrid(categoryData);
        }

        /// <summary>
        /// обновление названия категории
        /// </summary>
        public void RedactCategoryName(int idCategory, DataGridView categoryData, string nameCategory)
        {

            string headerError = "Ошибка изменения";

            if (CheckCategoryName(nameCategory))
            {
                MessageBox.Show(_errorNameCategory, headerError);
                return;
            }

            if (!CheckLenghtNewCategory(nameCategory))
            {
                MessageBox.Show(_errorLenghtNameCategory, headerError);
                return;
            }

            _dataBase.OpenConnectDB();

            string query = $"UPDATE {_nameTableCategory} SET nameCategory='{nameCategory}' WHERE idCategory={idCategory}";
            SqlCommand command = new SqlCommand(query, _dataBase.GetConnection());
            command.ExecuteNonQuery();

            _dataBase.CloseConnectDB();

            ReadFromDBToDataGrid(categoryData);
        }


        /// <summary>
        /// Добавляет категории в CheckBox
        /// </summary>
        public void AddCategoryToCheckBox(ComboBox categoryComboBox)
        {
            _dataBase.OpenConnectDB();

            string query = $"SELECT (nameCategory) FROM {_nameTableCategory}";
            SqlCommand command = new SqlCommand(query, _dataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string nameCategory = reader.GetValue(0).ToString();
                    categoryComboBox.Items.Add(nameCategory);
                }
            }

            reader.Close();

            _dataBase.CloseConnectDB();
        }

        /// <summary>
        /// Возвращает ID категории по ее названию
        /// </summary>
        public int GetIDCategoryByName(string nameCategory)
        {
            int id = 0;
            _dataBase.OpenConnectDB();

            string query = $"SELECT (idCategory) FROM {_nameTableCategory} WHERE nameCategory='{nameCategory}'";
            SqlCommand command = new SqlCommand(query, _dataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string idCategory = reader.GetValue(0).ToString();
                    if (Int32.TryParse(idCategory, out int idReader))
                    {
                        id = idReader;
                    }
                }
            }

            reader.Close();

            _dataBase.CloseConnectDB();

            return id;
        }

        /// <summary>
        /// Вовзаращет Истину, если количество записей в таблице расходов с данной категорией больше нуля
        /// </summary>
        public bool IsCategoryInExpenditure(int idCategory)
        {
            bool result = false;
            _dataBase.OpenConnectDB();

            string query = $"SELECT * FROM {_nameTableExpenditure} WHERE idCategoryExpenditure={idCategory}";
            SqlCommand command = new SqlCommand(query, _dataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                result = true;
            } else
            {
                result = false;
            }

            _dataBase.CloseConnectDB();
            return result;
        }

    }
}

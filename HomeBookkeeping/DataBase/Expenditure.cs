using DataBaseNamespace;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBookkeeping.DataBase
{
    public class Expenditure
    {

        private IDataBase _dataBase;
        private readonly string _nameTableExpenditure = "expenditure";

        public Expenditure(IDataBase dataBase)
        {
            _dataBase = dataBase;
        }

        /// <summary>
        /// Добавление нового расхода
        /// </summary>
        public void AddNewExpenditure(DateTime dateTime, string nameCategory, float cost, string comment)
        {

            string header = "Добавление расхода";
            string queryErrorExecute = "Ошибка при создании новой категории";
            string queryOkExecute = "расход успешно добавлен";

            // Получаем ID категории
            Category category = new Category(_dataBase);
            int idCategory = category.GetIDCategoryByName(nameCategory);
            if (idCategory == 0)
            {
                MessageBox.Show(queryErrorExecute, header);
                return;
            }

            string query = $"INSERT INTO {_nameTableExpenditure}(idCategoryExpenditure, costExpenditure, comment, dateExpenditure) " +
                $"VALUES({idCategory}, {cost}, '{comment}', '{dateTime}')";
            SqlCommand command = new SqlCommand(query, _dataBase.GetConnection());

            _dataBase.OpenConnectDB();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(queryOkExecute, header);
            }
            else
            {
                MessageBox.Show(queryErrorExecute, header);
            }

            _dataBase.CloseConnectDB();
        }

        /// <summary>
        /// Создание строки
        /// </summary>
        public void ReadSingleRows(DataGridView expenditureData, IDataRecord record)
        {
            expenditureData.Rows.Add(record.GetInt32(0), 
                                     record.GetFloat(1), 
                                     record.GetString(2), 
                                     record.GetString(3),
                                     record.GetString(4)
                                     );
        }

        /// <summary>
        /// Чтение данных из БД в DataGrid
        /// </summary>
        public void ReadFromDBToDataGrid(DataGridView expenditureData, DateTime beginDate, DateTime endDate)
        {
            expenditureData.Rows.Clear();

            string strBeginData = beginDate.ToString("MM-dd-yyyy");
            string strEndData = endDate.ToString("MM-dd-yyyy");

            string query = $"SELECT (idExpenditure), (costExpenditure), (comment), FORMAT( dateExpenditure, 'D', 'ru'), (categoryCost.nameCategory) FROM {_nameTableExpenditure}" +
                $" LEFT JOIN categoryCost as categoryCost on expenditure.idCategoryExpenditure = categoryCost.idCategory " +
                $" WHERE dateExpenditure BETWEEN '{strBeginData}' AND '{strEndData}' ORDER BY dateExpenditure";

            SqlCommand command = new SqlCommand(query, _dataBase.GetConnection());
            _dataBase.OpenConnectDB();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRows(expenditureData, reader);
            }

            reader.Close();
            _dataBase.CloseConnectDB();
        }

        /// <summary>
        /// Создание столбцов для DataGridView по запросу отчета за период
        /// </summary>
        public void CreateColumnsForReportByPeriod(DataGridView expenditureData)
        {
            expenditureData.Columns.Clear();
            expenditureData.Columns.Add("idExpenditure", "ID");
            expenditureData.Columns.Add("costExpenditure", "Затраты");
            expenditureData.Columns.Add("comment", "Коментарий");
            expenditureData.Columns.Add("data", "Дата");
            expenditureData.Columns.Add("idExpenditureCategory", "Категория");
        }

    }
}

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
    public partial class ExpendetureByCategoryForm : Form
    {

        private DataGridView _expenditureData;
        private Dictionary<string, float> _expenditureByCategoryDict = new Dictionary<string, float>();

        public ExpendetureByCategoryForm()
        {
            InitializeComponent();
        }

        public ExpendetureByCategoryForm(DateTime beginDate, DateTime endDate, DataGridView expenditureData)
        {
            InitializeComponent();
            BeginDateLabel.Text = "Начало периода:" + beginDate.ToString("dd-MM-yyyy");
            EndDateLabel.Text = "Конец периода: " + endDate.ToString("dd-MM-yyyy");
            _expenditureData = expenditureData;
        }

        private void ExpendetureByCategoryForm_Load(object sender, EventArgs e)
        {
            CreateExpenditureDictionary(_expenditureData);
            ShowExpenditureByCategory(ExpenditureByCategoryDataGridView);
        }

        /// <summary>
        /// Создание словаря с расходами
        /// </summary>
        private void CreateExpenditureDictionary(DataGridView expenditureData)
        {
            for (int i = 0; i < expenditureData.Rows.Count; i++)
            {
                string categoryName = expenditureData.Rows[i].Cells[4].Value.ToString();
                if (!_expenditureByCategoryDict.ContainsKey(categoryName))
                {
                    _expenditureByCategoryDict.Add(categoryName, 0);
                    _expenditureByCategoryDict[categoryName] = float.Parse(expenditureData.Rows[i].Cells[1].Value.ToString());
                }
                else
                {
                    _expenditureByCategoryDict[categoryName] += float.Parse(expenditureData.Rows[i].Cells[1].Value.ToString());
                }
            }
        }

        /// <summary>
        /// Выводит расходы в разрезе категорий
        /// </summary>
        private void ShowExpenditureByCategory(DataGridView expenditureData)
        {
            int index = 0;
            foreach (var expenditure in _expenditureByCategoryDict)
            {
                expenditureData.Rows.Add();
                expenditureData.Rows[index].Cells[0].Value = expenditure.Key.ToString();
                expenditureData.Rows[index].Cells[1].Value = expenditure.Value.ToString();
                index++;
            }
        }

    }
}

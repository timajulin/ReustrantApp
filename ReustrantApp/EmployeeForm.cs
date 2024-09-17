using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReustrantApp
{
    public partial class EmployeeForm : Form
    {
        Functions con;
        private int selectedOrderId = -1; // Переменная для хранения ID выбранного пользователя
        public EmployeeForm()
        {
            InitializeComponent();
            con = new Functions();
            LoadTables();
        }
        private void LoadTables()
        {
            try
            {
                dataGridViewOrders.DataSource = con.GetData("SELECT * FROM Orders"); // Загрузка данных из таблицы Orders
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (textBoxUserID.Text == "" || textBoxTotalPrice.Text == "" || comboBoxOrderStatus.Text == "")
            {
                MessageBox.Show("Не введены все данные для создания заказа");
            }
            else
            {
                try
                {
                    string Query = "insert into Orders (UserID, TotalPrice, OrderStatus, OrderDate) values('{0}', '{1}', '{2}', '{3}')";
                    Query = string.Format(Query, textBoxUserID.Text, textBoxTotalPrice.Text, comboBoxOrderStatus.Text, DateTime.Now);
                    con.SetData(Query);
                    LoadTables();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Получение данных из строки
            DataGridViewRow row = dataGridViewOrders.Rows[e.RowIndex];

            // Заполняем поля значениями из выбранной строки
            selectedOrderId = Convert.ToInt32(row.Cells["OrderID"].Value);
            textBoxUserID.Text = row.Cells["UserID"].Value.ToString();
            textBoxTotalPrice.Text = row.Cells["TotalPrice"].Value.ToString();
            comboBoxOrderStatus.Text = row.Cells["OrderStatus"].Value.ToString();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == -1)
            {
                MessageBox.Show("Выберите заказ для редактирования.");
                return;
            }

            if (textBoxUserID.Text == "" || textBoxTotalPrice.Text == "" || comboBoxOrderStatus.Text == "")
            {
                MessageBox.Show("Не введены все данные");
            }
            else
            {
                try
                {
                    string Query = "UPDATE Orders SET UserID = '{0}', TotalPrice = '{1}', OrderStatus = '{2}' WHERE OrderID = '{3}'";
                    Query = string.Format(Query, textBoxUserID.Text, textBoxTotalPrice.Text, comboBoxOrderStatus.Text, selectedOrderId);
                    con.SetData(Query);
                    LoadTables();
                    MessageBox.Show("Заказ обновлен.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == -1)
            {
                MessageBox.Show("Выберите заказ для удаления.");
                return;
            }

            try
            {
                string Query = "DELETE FROM Orders WHERE OrderID = '{0}'";
                Query = string.Format(Query, selectedOrderId);
                con.SetData(Query);
                LoadTables();
                MessageBox.Show("Заказ удален.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

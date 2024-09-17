using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ReustrantApp
{

    public partial class ClientForm : Form
    {
        string connectionString = "Data Source=PC-TONIC;Initial Catalog=reustrant;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public ClientForm()
        {
            InitializeComponent();
        }
        //private void LoadMenuData()
        //{
        //    string query = "SELECT MenuID, Name, Description, Price, Status FROM Menu";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        //        DataTable menuTable = new DataTable();

        //        connection.Open();
        //        adapter.Fill(menuTable);
        //        connection.Close();

        //        dataGridViewMenu.DataSource = menuTable;
        //    }
        //}

        // Хранение выбранных блюд
        public List<OrderItem> selectedItems = new List<OrderItem>();

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            
        }

        private void btnCake_Click(object sender, EventArgs e)
        {
            selectedItems.Add(new OrderItem(3, "Шоколадный торт", 499, 1));
            MessageBox.Show("Торт добавлен в заказ");
        }

        private void btnSalad_Click(object sender, EventArgs e)
        {
            selectedItems.Add(new OrderItem(1, "Салат Цезарь", 799, 1));
            MessageBox.Show("Салат Цезарь добавлен в заказ");
        }

        private void btnSoda_Click(object sender, EventArgs e)
        {
            selectedItems.Add(new OrderItem(4, "Газировка", 199, 1));
            MessageBox.Show("Газировка добавлена в заказ");
        }

        private void btnSteak_Click(object sender, EventArgs e)
        {
            selectedItems.Add(new OrderItem(2, "Стейк", 1999, 1));
            MessageBox.Show("Стейк добавлен в заказ");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (selectedItems.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одно блюдо!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Открытие формы оформления заказа
            OrderForm orderForm = new OrderForm(selectedItems);
            orderForm.ShowDialog();
        }
    }
}

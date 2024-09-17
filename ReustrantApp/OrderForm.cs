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
    public partial class OrderForm : Form
    {
        public List<OrderItem> selectedItems;
        public decimal totalPrice;
        int currentUserId = 3;
        string connectionString = "Data Source=PC-TONIC;Initial Catalog=reustrant;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public OrderForm(List<OrderItem> items)
        {
            InitializeComponent();
            selectedItems = items;
            LoadOrderItems(selectedItems);
            CalculateTotalPrice();
        }

        private void LoadOrderItems(List<OrderItem> selectedItems)
        {
            // Пример привязки данных выбранных блюд к DataGridView

            foreach (OrderItem item in selectedItems)
            {
                dataGridViewOrderItems.Rows.Add(item.menuID, item.name, item.price, item.quantity);
            }

        }

        private void CalculateTotalPrice()
        {
            totalPrice = selectedItems.Sum(item => item.price * item.quantity);
            lblTotalPrice.Text = $"Итоговая цена: {totalPrice:C}";
        }

        private void SaveOrderToDatabase()
        {
            string queryOrder = "INSERT INTO Orders (UserID, TotalPrice, OrderStatus, OrderDate) OUTPUT INSERTED.OrderID VALUES (@UserID, @TotalPrice, @OrderStatus, @OrderDate)";
            string queryOrderItems = "INSERT INTO OrderItems (OrderID, MenuID, Quantity, Price) VALUES (@OrderID, @MenuID, @Quantity, @Price)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Запись в таблицу Orders
                    int orderId = 0;
                    using (SqlCommand command = new SqlCommand(queryOrder, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@UserID", currentUserId);
                        command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        command.Parameters.AddWithValue("@OrderStatus", "Новый");
                        command.Parameters.AddWithValue("@OrderDate", DateTime.Now);

                        orderId = (int)command.ExecuteScalar();
                    }

                    // Запись в таблицу OrderItems
                    foreach (var item in selectedItems)
                    {
                        using (SqlCommand command = new SqlCommand(queryOrderItems, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@OrderID", orderId);
                            command.Parameters.AddWithValue("@MenuID", item.menuID);
                            command.Parameters.AddWithValue("@Quantity", item.quantity);
                            command.Parameters.AddWithValue("@Price", item.price);
                            command.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Заказ успешно оформлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка при оформлении заказа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConfirmOrder_Click_1(object sender, EventArgs e)
        {
            SaveOrderToDatabase();
        }
    }

}

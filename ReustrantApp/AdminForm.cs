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
    public partial class AdminForm : Form
    {
        Functions con;
        private int selectedUserId = -1; // Переменная для хранения ID выбранного пользователя
        public AdminForm()
        {
            InitializeComponent();
            con = new Functions();
            LoadTables();
        }
        private void LoadTables()
        {
            try
            {
                dataGridViewUsers.DataSource = con.GetData("SELECT * FROM Users");
                dataGridViewReviews.DataSource = con.GetData("SELECT * FROM Reviews");
                //dataGridViewCategories.DataSource = con.GetData("SELECT * FROM Categories");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPass.Text == "" || comboBoxRole.Text == "")
            {
                MessageBox.Show("Не введены все данные");
            }
            else
            {
                try
                {
                    string Query = "insert into Users values('{0}','{1}','{2}')";
                    Query = string.Format(Query, comboBoxRole.Text, textBoxLogin.Text, textBoxPass.Text);
                    con.SetData(Query);
                    LoadTables();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // Выбор записи для редактирования
        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Получение данных из строки
            DataGridViewRow row = dataGridViewUsers.Rows[e.RowIndex];

            // Заполняем поля значениями из выбранной строки
            selectedUserId = Convert.ToInt32(row.Cells["UserID"].Value);
            comboBoxRole.Text = row.Cells["Role"].Value.ToString();
            textBoxLogin.Text = row.Cells["Login"].Value.ToString();
            textBoxPass.Text = row.Cells["Password"].Value.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Выберите пользователя для редактирования.");
                return;
            }

            if (textBoxLogin.Text == "" || textBoxPass.Text == "" || comboBoxRole.Text == "")
            {
                MessageBox.Show("Не введены все данные");
            }
            else
            {
                try
                {
                    string Query = "UPDATE Users SET Role = '{0}', Login = '{1}', Password = '{2}' WHERE UserID = '{3}'";
                    Query = string.Format(Query, comboBoxRole.Text, textBoxLogin.Text, textBoxPass.Text, selectedUserId);
                    con.SetData(Query);
                    LoadTables();
                    MessageBox.Show("Запись обновлена.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Выберите пользователя для удаления.");
                return;
            }

            try
            {
                string Query = "DELETE FROM Users WHERE UserID = '{0}'";
                Query = string.Format(Query, selectedUserId);
                con.SetData(Query);
                LoadTables();
                MessageBox.Show("Запись удалена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // ОТЗЫВЫ
        private void btnCreateReview_Click(object sender, EventArgs e)
        {
            if (textBoxRating.Text == "" || textBoxComment.Text == "" || textBoxReviewID.Text == "" || textBoxUserID.Text == "")
            {
                MessageBox.Show("Не введены все данные для создания отзыва");
            }
            else
            {
                try
                {
                    string Query = "insert into Reviews (OrderID, UserID, Rating, Comment) values('{0}', '{1}', '{2}', '{3}')";
                    Query = string.Format(Query, textBoxReviewID.Text, textBoxUserID.Text, textBoxRating.Text, textBoxComment.Text);
                    con.SetData(Query);
                    LoadTables();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnUpdateReview_Click(object sender, EventArgs e)
        {
            if (textBoxReviewID.Text == "" || textBoxRating.Text == "" || textBoxComment.Text == "" || textBoxReviewID.Text == "" || textBoxUserID.Text == "")
            {
                MessageBox.Show("Не введены все данные для изменения отзыва");
            }
            else
            {
                try
                {
                    string Query = "update Reviews set OrderID = '{0}', UserID = '{1}', Rating = '{2}', Comment = '{3}' where ReviewID = {4}";
                    Query = string.Format(Query, textBoxReviewID.Text, textBoxUserID.Text, textBoxRating.Text, textBoxComment.Text, textBoxReviewID.Text);
                    con.SetData(Query);
                    LoadTables();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxReviewID.Text == "")
            {
                MessageBox.Show("Введите ID отзыва для удаления");
            }
            else
            {
                try
                {
                    string Query = "delete from Reviews where ReviewID = {0}";
                    Query = string.Format(Query, textBoxReviewID.Text);
                    con.SetData(Query);
                    LoadTables();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

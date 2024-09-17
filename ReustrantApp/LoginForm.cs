using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
namespace ReustrantApp
{
    public partial class LoginForm : Form
    {
        string connectionString = "Data Source=PC-TONIC;Initial Catalog=reustrant;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public LoginForm()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Role FROM Users WHERE Login = @login AND Password = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", txtLogin.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string role = reader["Role"].ToString();

                    switch (role)
                    {
                        case "Client":
                            OpenClientInterface();
                            break;
                        case "Employee":
                            OpenEmployeeInterface();
                            break;
                        case "Admin":
                            OpenAdminInterface();
                            break;
                        default:
                            MessageBox.Show("Неизвестная роль.");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль.");
                }

                reader.Close();
            }
            void OpenClientInterface()
            {
                this.Hide();
                ClientForm clientForm = new ClientForm();
                clientForm.Show();
            }

            void OpenEmployeeInterface()
            {
                this.Hide();
                EmployeeForm employeeForm = new EmployeeForm();
                employeeForm.Show();
            }

            void OpenAdminInterface()
            {
                this.Hide();
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using Microsoft.Data.SqlClient;
using NUnit.Framework;
using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ReustrantApp.Tests
{
    [TestFixture]
    public class FunctionsTests
    {
        private Functions functions;
        private AdminForm adminForm;

        [SetUp]
        public void SetUp()
        {
            // ������������� ����� ������ ������
            functions = new Functions();
            adminForm = new AdminForm();
        }

        [Test]
        public void GetData_ShouldReturnDataTable_WhenQueryIsValid()
        {
            string query = "SELECT * FROM Users";

            DataTable result = functions.GetData(query);

            Assert.IsNotNull(result); // ���������, ��� ��������� �� null
            Assert.IsTrue(result.Rows.Count > 0); // ���������, ��� ���� ������
        }

        [Test]
        public void SetData_ShouldInsertRecord_WhenQueryIsValid()
        {
            string query = "INSERT INTO Users (Role, Login, Password) VALUES ('User', 'testuser', 'password')";

            int rowsAffected = functions.SetData(query);

            Assert.AreEqual(1, rowsAffected); // ������ ���� ��������� ���� ������
        }

        [Test]
        public void SetData_ShouldUpdateRecord_WhenQueryIsValid()
        {
            string query = "UPDATE Users SET Role = 'Admin' WHERE Login = 'testuser'";

            int rowsAffected = functions.SetData(query);

            Assert.AreEqual(1, rowsAffected); // ������ ���� �������� ���� ������
        }

        [Test]
        public void SetData_ShouldDeleteRecord_WhenQueryIsValid()
        {
            string query = "INSERT INTO Users Values('user','testuser', 'testpassword')";

            int rowsAffected = functions.SetData(query);

            query = "DELETE FROM Users WHERE Login = 'testuser'";

            rowsAffected = functions.SetData(query);

            Assert.AreEqual(1, rowsAffected); // ������ ���� ������� ���� ������
        }
        [Test]
        public void GetData_ValidQuery_ReturnsDataTable()
        {
            string query = "SELECT * FROM Users";

            DataTable result = functions.GetData(query);

            Assert.IsNotNull(result, "DataTable �� ������ ���� null.");
            Assert.IsTrue(result.Rows.Count > 0, "� ������� ������ ���� ������.");
        }

        [Test]
        public void SetData_ValidInsertQuery_ReturnsRowsAffected()
        {
            string query = "INSERT INTO Users (Role, Login, Password) VALUES ('TestRole', 'TestUser', 'TestPassword')";

            int rowsAffected = functions.SetData(query);

            Assert.AreEqual(1, rowsAffected, "������ ���� ��������� ���� ������.");
        }

        [Test]
        public void SetData_ValidUpdateQuery_ReturnsRowsAffected()
        {
            string query = "UPDATE Users SET Role = 'UpdatedRole' WHERE Login = 'TestUser'";

            int rowsAffected = functions.SetData(query);

            Assert.AreEqual(1, rowsAffected, "������ ���� �������� ���� ������.");
        }

        [Test]
        public void SetData_ValidDeleteQuery_ReturnsRowsAffected()
        {
            string query = "DELETE FROM Users WHERE Login = 'TestUser'";

            int rowsAffected = functions.SetData(query);

            Assert.AreEqual(1, rowsAffected, "������ ���� ������� ���� ������.");
        }

        [Test]
        public void GetData_InvalidQuery_ThrowsSqlException()
        {
            string invalidQuery = "SELECT * FROM NonExistingTable";

            var ex = Assert.Throws<Microsoft.Data.SqlClient.SqlException>(() => functions.GetData(invalidQuery));
            Assert.That(ex.Message, Does.Contain("������������ ��� �������"));
        }

        [Test]
        public void SetData_InvalidQuery_ThrowsSqlException()
        {
            string invalidQuery = "INSERT INTO NonExistingTable VALUES ('Test')";

            var ex = Assert.Throws<Microsoft.Data.SqlClient.SqlException>(() => functions.GetData(invalidQuery));
            Assert.That(ex.Message, Does.Contain("������������ ��� �������"));
        }

    }
}

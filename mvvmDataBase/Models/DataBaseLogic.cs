using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmDataBase.Models
{
    internal class DataBaseLogic
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=User;Integrated Security=True;Encrypt=False";
        public DataBaseLogic(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public DataTable GetUserData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM [dbo].[USER]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
        public bool LogIn(Users user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM [dbo].[User] WHERE UserName = @Username AND Password = @Password AND AccessLevel = @AccessLevel";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@AccessLevel", Convert.ToInt32(user.AccessLevel));

                    connection.Open();
                    int u = Convert.ToInt32(command.ExecuteScalar());

                    return u >0;
                }
            }
        }
        public bool inDataBase(Users user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM [dbo].[User] WHERE UserName = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", user.Username);
                    connection.Open();
                    int u = Convert.ToInt32(command.ExecuteScalar());

                    return u >0;
                }
            }
        }
        public List<Users> GetUsers()
        {
            List<Users> users = new List<Users>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id, Username, Password, Name,AccessLevel FROM [dbo].[user]";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Users user = new Users
                                {
                                    id = Convert.ToInt32(reader["ID"]),
                                    Username = reader["Username"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    Name = reader["Name"].ToString(),
                                    AccessLevel = Convert.ToInt32(reader["AccessLevel"])
                                };

                                users.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок, например, логирование или отображение сообщения
                Console.WriteLine($"Ошибка при загрузке данных из БД: {ex.Message}");
            }

            return users;
        }
        public void AddUser(Users user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO [dbo].[user] (Name, Password, UserName, AccessLevel) VALUES (@Name, @Password, @UserName, @AccessLevel)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", user.Name);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@UserName", user.Username);
                    command.Parameters.AddWithValue("@AccessLevel", Convert.ToInt32(user.AccessLevel));

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}

using System;
using System.Data.SqlClient;

namespace ConexionToDB
{
    public class DatabaseManager
    {
        private SqlConnection sqlConnection;
        private string connectionString;

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
            sqlConnection = new SqlConnection(connectionString);
        }

        public void Connect()
        {
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar: " + ex.Message);
            }
        }

        public void Disconnect()
        {
            if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public bool IsConnected()
        {
            return sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open;
        }

        public void InsertEmployee(string first_name, string last_name, string email, string phone_number, DateTime hire_date, int job_id, decimal salary, int? manager_id, int department_id)
        {
            string query = "INSERT INTO employees (first_name, last_name, email, phone_number, hire_date, job_id, salary, manager_id, department_id) " +
                           "VALUES (@first_name, @last_name, @email, @phone_number, @hire_date, @job_id, @salary, @manager_id, @department_id)";

            if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
            {
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@first_name", first_name);
                    command.Parameters.AddWithValue("@last_name", last_name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phone_number", phone_number);
                    command.Parameters.AddWithValue("@hire_date", hire_date);
                    command.Parameters.AddWithValue("@job_id", job_id);
                    command.Parameters.AddWithValue("@salary", salary);
                    command.Parameters.AddWithValue("@manager_id", manager_id);
                    command.Parameters.AddWithValue("@department_id", department_id);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al insertar datos: " + ex.Message);
                    }
                }
            }
            else
            {
                throw new Exception("No hay conexión establecida con la base de datos.");
            }
        }
    }
}

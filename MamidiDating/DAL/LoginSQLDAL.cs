using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MamidiDating.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace MamidiDating.DAL
{
    public class LoginSQLDAL : ILoginDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MamidiDating"].ConnectionString;

        public bool RegisterUser(LoginViewModel login)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlAddLoginInfo = $"Insert into Login Values(@registrationId, @username, @password, @salt);";
                    SqlCommand command = new SqlCommand(sqlAddLoginInfo, conn);
                    command.Parameters.AddWithValue("@registrationId", login.RegistrationId);
                    command.Parameters.AddWithValue("@username", login.Username);
                    command.Parameters.AddWithValue("@password", login.Password);
                    command.Parameters.AddWithValue("@salt", login.Salt);
                    rowsAffected = command.ExecuteNonQuery();

                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return rowsAffected > 0;
        }

        public LoginViewModel GetUsername(string username)
        {
            LoginViewModel output = new LoginViewModel();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string usernameQuery = $"Select TOP 1 * from Login where username = @username";
                    SqlCommand command = new SqlCommand(usernameQuery, conn);
                    command.Parameters.AddWithValue("@username", username);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        output.LoginId = Convert.ToInt32(reader["loginId"]);
                        output.RegistrationId = Convert.ToInt32(reader["registrationId"]);
                        output.Username = Convert.ToString(reader["username"]);
                        output.Password = Convert.ToString(reader["password"]);
                        output.Salt = Convert.ToString(reader["salt"]);
                    }
                }
            }
            catch (SqlException ex)
            {
                ex.Message.ToString();
                throw;
            }
            return output;
        }
    }
}
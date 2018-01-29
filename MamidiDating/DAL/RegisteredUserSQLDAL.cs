using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MamidiDating.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace MamidiDating.DAL
{
    public class RegisteredUserSQLDAL : IRegisteredUserDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MamidiDating"].ConnectionString;

        public RegisteredUserViewModel GetUser(string username)
        {
            RegisteredUserViewModel registeredUser = null;
            try
            {
                string sqlQueryForGetUser = $"Select TOP 1 * from users where Username = @username";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQueryForGetUser, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        registeredUser = new RegisteredUserViewModel();
                        registeredUser.RegisteredUserId = Convert.ToInt32(reader["registeredUserID"]);
                        registeredUser.Username = Convert.ToString(reader["username"]);
                        registeredUser.Password = Convert.ToString(reader["password"]);
                        registeredUser.Salt = Convert.ToString(reader["salt"]);
                    }
                }
            }
            catch (SqlException e)
            {
                e.Message.ToString();
                throw;
            }
            return registeredUser;
        }

        public RegisteredUserViewModel GetUser(string username, string password)
        {
            RegisteredUserViewModel registeredUser = null;

            try
            {
                string sqlQueryForGetUser = $"Select TOP 1 * from users where Username = @username and password = @password";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQueryForGetUser, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        registeredUser = new RegisteredUserViewModel();
                        registeredUser.RegisteredUserId = Convert.ToInt32(reader["registeredUserID"]);
                        registeredUser.Username = Convert.ToString(reader["username"]);
                        registeredUser.Password = Convert.ToString(reader["password"]);
                        registeredUser.Salt = Convert.ToString(reader["salt"]);
                    }
                }
            }
            catch (SqlException e)
            {
                e.Message.ToString();
                throw;
            }
            return registeredUser;
        }

        public bool RegisterNewUser(RegisteredUserViewModel newUser)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlAddInfo = $"Insert into RegisteredUser Values(@username, @password, @salt);";
                    SqlCommand command = new SqlCommand(sqlAddInfo, conn);
                    command.Parameters.AddWithValue("@username", newUser.Username);
                    command.Parameters.AddWithValue("@password", newUser.Password);
                    command.Parameters.AddWithValue("@salt", newUser.Salt);
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

        public bool AddRegisteredUserInfo(NewUserViewModel userInfo)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlAddInfo = $"Insert into RegisteredUser Values(@firstName, @lastName, @emailAddress, @month, @day, @year, @age, @isYes);";
                    SqlCommand command = new SqlCommand(sqlAddInfo, conn);
                    command.Parameters.AddWithValue("@firstName", userInfo.FirstName);
                    command.Parameters.AddWithValue("@lastName", userInfo.LastName);
                    command.Parameters.AddWithValue("@emailAddress", userInfo.EmailAddress);
                    command.Parameters.AddWithValue("@month", userInfo.Month);
                    command.Parameters.AddWithValue("@day", userInfo.Day);
                    command.Parameters.AddWithValue("@year", userInfo.Year);
                    command.Parameters.AddWithValue("@age", userInfo.Age);
                    command.Parameters.AddWithValue("@isYes", 0);
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
    }
}
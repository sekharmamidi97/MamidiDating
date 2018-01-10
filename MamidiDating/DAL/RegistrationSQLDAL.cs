using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MamidiDating.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace MamidiDating.DAL
{
    public class RegistrationSQLDAL : IRegistrationDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MamidiDating"].ConnectionString;

        public bool AddRegistrationInfo(RegistrationViewModel registration)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlAddRegistrationInfo = $"Insert into Registration Values(@firstName, @lastName, @emailAddress, @month, @day, @year, @age, @isYes);";
                    SqlCommand command = new SqlCommand(sqlAddRegistrationInfo, conn);
                    command.Parameters.AddWithValue("@firstName", registration.FirstName);
                    command.Parameters.AddWithValue("@lastName", registration.LastName);
                    command.Parameters.AddWithValue("@emailAddress", registration.EmailAddress);
                    command.Parameters.AddWithValue("@month", registration.Month);
                    command.Parameters.AddWithValue("@day", registration.Day);
                    command.Parameters.AddWithValue("@year", registration.Year);
                    command.Parameters.AddWithValue("@age", registration.Age);
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

        public RegistrationViewModel GetRegistrationInformationById(int registrationId)
        {
            RegistrationViewModel output = new RegistrationViewModel();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string queryRegistration = "Select * from Registration where registrationId = @registrationId";
                    SqlCommand command = new SqlCommand(queryRegistration, conn);
                    command.Parameters.AddWithValue("@registrationId", registrationId);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        output.RegistrationId = Convert.ToInt32(reader["registrationId"]);
                        output.FirstName = Convert.ToString(reader["firstName"]);
                        output.LastName = Convert.ToString(reader["lastName"]);
                        output.EmailAddress = Convert.ToString(reader["emailAddress"]);
                        output.Month = Convert.ToString(reader["month"]);
                        output.Day = Convert.ToString(reader["day"]);
                        output.Year = Convert.ToString(reader["year"]);
                        output.Age = Convert.ToString(reader["age"]);
                        output.IsYes = Convert.ToBoolean(reader["isYes"]);
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
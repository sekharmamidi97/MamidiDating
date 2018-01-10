using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MamidiDating.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace MamidiDating.DAL
{
    public class ContactSQLDAL : IContactDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MamidiDating"].ConnectionString;

        public bool AddContactMessageInfo(ContactViewModel contact)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlAddInfo = $"Insert into Contact Values(@firstName, @lastName, @username, @emailAddress, @contactReason, @message);";
                    SqlCommand command = new SqlCommand(sqlAddInfo, conn);
                    command.Parameters.AddWithValue("@firstName", contact.FirstName);
                    command.Parameters.AddWithValue("@lastName", contact.LastName);
                    command.Parameters.AddWithValue("@emailAddress", contact.EmailAddress);
                    command.Parameters.AddWithValue("@contactReason", contact.ContactReason);
                    command.Parameters.AddWithValue("@message", contact.Message);
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
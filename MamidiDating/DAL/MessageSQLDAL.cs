using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MamidiDating.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace MamidiDating.DAL
{
    public class MessageSQLDAL : IMessageDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MamidiDating"].ConnectionString;

        public bool AddMessageInfo(MessageViewModel message)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlAddMessageInfo = $"Insert into Message Values(@registrationId, @toUsername, @subject, @message, @fromUsername);";
                    SqlCommand command = new SqlCommand(sqlAddMessageInfo, conn);
                    command.Parameters.AddWithValue("@registrationId", message.RegistrationId);
                    command.Parameters.AddWithValue("@toUsername", message.ToUsername);
                    command.Parameters.AddWithValue("@subject", message.Subject);
                    command.Parameters.AddWithValue("@message", message.Message);
                    command.Parameters.AddWithValue("@fromUsername", message.FromUsername);
                    rowsAffected = command.ExecuteNonQuery();

                }
              
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return rowsAffected > 0;
        }
    }
}
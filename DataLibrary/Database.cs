using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DataLibrary
{
    public class Database
    {
        public static string connectionString;

        public string checkConnection()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    connection.Close();
                    return "Connection Success";
                }
                catch (Exception exc)
                {
                    connection.Close();
                    return exc.Message;
                }
            }
        }

        public bool ExecuteData(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    connection.Close();
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // Get Data from Database
        public DataTable GetData(string query)
        {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                try { 
                    MySqlDataAdapter dAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dTable = new DataTable();
                    connection.Open();
                    dAdapter.Fill(dTable);
                    connection.Close();
                    return dTable;
                }
                catch (Exception)
                {
                    connection.Close();
                    throw;
                }
            }
        }

        public bool executeImageQuery(string query, string parameter, byte[] image)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader datareader;
                    command.Parameters.Add(new MySqlParameter(parameter, image));
                    datareader = command.ExecuteReader();
                    datareader.Close();
                    connection.Close();
                    
                    return true;
                }
                catch (Exception)
                {
                    connection.Close();
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public string getSingleValue(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    string result = command.ExecuteScalar().ToString();
                    command.Dispose();
                    connection.Close();

                    return result;
                }
                catch (Exception)
                {
                    connection.Close();
                    throw;
                }
            }
        }
    }
}

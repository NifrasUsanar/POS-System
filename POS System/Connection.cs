using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace POS_System
{
    class Connection
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
            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    connection.Close();
                    Animation.showMessage(e.Message,"error");
                    return false;
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
                    MySqlDataAdapter dAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dTable = new DataTable();
                    connection.Open();
                    dAdapter.Fill(dTable);
                    connection.Close();
                    return dTable;
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
                catch(Exception exc)
                {
                    Animation.showMessage(exc.Message,"error");
                    connection.Close();
                }
                return null;
            }
        }
    }
}

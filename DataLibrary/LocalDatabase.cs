using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace DataLibrary
{
    public class LocalDatabase
    {
        public static string connectionString= "Data Source=db_local.db; Version=3;";

        public string checkConnection()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
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
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
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
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    SQLiteDataAdapter dAdapter = new SQLiteDataAdapter(query, connection);
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

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                try
                {
                    connection.Open();
                    SQLiteDataReader datareader;
                    command.Parameters.Add(new SQLiteParameter(parameter, image));
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
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(query, connection);
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

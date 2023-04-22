using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace attendance_tracker
{
    internal class Database
    {
        private static string connection = "server=localhost;uid=root;pwd=NatureSon22;database=db_attendance_tracker";
        private static MySqlConnection myconnection;
        private static MySqlCommand command;
        private static MySqlDataAdapter myadapter;

        //setup for database connection and command
        public static void setUpConnection()
        {
            myconnection = new MySqlConnection(connection);
            myconnection.Open();
            command = myconnection.CreateCommand();
        }

        // this is only to execute queries without the use of data table
        public static void query(string query, params MySqlParameter[] parameters) 
        {
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            if(parameters != null && parameters.Length > 0)
            {
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
            }
            command.Parameters.Clear();
        }

        // execute queries that make use of data table
        public static DataTable executeQuery(string query, params MySqlParameter[] parameters)
        {
            myadapter = new MySqlDataAdapter();
            DataTable dataTable = new DataTable();
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            if (parameters != null && parameters.Length > 0)
            {
                command.Parameters.AddRange(parameters);
            }

            myadapter.SelectCommand = command;
            myadapter.Fill(dataTable);
            command.Parameters.Clear();
            return dataTable;
        }
    }
}

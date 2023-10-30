﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformCase.Utility
{
    public class SqlHelper
    {
        public static string Constr = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        public static DataTable ExecuteTable(string commondText) 
        {
            using (MySqlConnection conn = new MySqlConnection(Constr))
            {
                conn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(commondText,conn);
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                return ds.Tables[0];
            }
        }

        public static int ExecuteNoQuery(string commondText) 
        {
            using (MySqlConnection conn = new MySqlConnection(Constr))
            {
                conn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(commondText,conn);
                int effectRows = sqlCommand.ExecuteNonQuery();
                if(effectRows<0) 
                {
                    throw new Exception("Database operate handle occurred error.");
                }
                return effectRows;
            }
        }
    }
}
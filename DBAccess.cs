using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Dapper;
using System.Data.SQLite;

namespace ClockIn
{
    class DBAccess
    {
        public static List<Employee> LoadEmployees()
        {
            Form1 f = new Form1();
            string id = f.logInTb;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                
                var output = cnn.Query<Employee>($"Select * from Hours", new DynamicParameters());
                return output.ToList();
            }
        }
        // Use this function in boss to make emp
        public static void SaveEmployee(Employee emp)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

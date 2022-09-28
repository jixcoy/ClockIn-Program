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
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                
                var output = cnn.Query<Employee>("Select * from Hours", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Employee> LoadStats()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                var output = cnn.Query<Employee>("Select * from Stats", new DynamicParameters());
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
            return "Data Source=.\\Employee.db;Version=3";


        }
    }
}

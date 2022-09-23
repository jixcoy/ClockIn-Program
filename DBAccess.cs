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
                var output = cnn.Query<Employee>("Select * from employee", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveEmployee(Employee emp)
        {

        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

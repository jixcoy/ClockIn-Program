﻿using System;
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
                // Returns list with data from Hours data table
                var output = cnn.Query<Employee>("Select * from Hours", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Employee> LoadStats()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Returns list with data from Stats data table
                var output = cnn.Query<Employee>("Select * from Stats", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveEmployee(Employee emp)
        {
            // Saves a new employee to Stats data table
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO \"main\".\"Stats\"(\"Name\",\"Shift\",\"Rating\",\"Pay\",\"Id\") VALUES (\"{emp.Name}\", \"{emp.Shift}\", \"{emp.Rating}\", \"{emp.Pay}\", \"{emp.Id}\");");
            }
        }
        public static void SaveHours(Employee emp)
        {
            // Saves new hour entry to Hours data table
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO \"main\".\"Hours\"(\"Hours\",\"Date\",\"Name\",\"ID\",\"Role\",\"Shift\") VALUES ();");
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            // Returns Location of Employee data base
            return "Data Source=.\\Employee.db;Version=3";
        }
    }
}

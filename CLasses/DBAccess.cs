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
            // Saves a new employee to Stats and hours Data table
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO \"main\".\"Stats\"(\"Name\",\"Shift\",\"Pay\",\"Id\", \"Role\") VALUES (\"{emp.Name}\", \"{emp.Shift}\", \"{emp.Pay}\", \"{emp.Id}\", \"{emp.Role}\");");
                cnn.Execute($"INSERT INTO \"main\".\"Hours\"(\"Hours\",\"Date\",\"Name\",\"Id\", \"Role\", \"Shift\") VALUES (\"{emp.Hours}\", \"{emp.Date}\", \"{emp.Name}\", \"{emp.Id}\", \"{emp.Role}\", \"{emp.Shift}\");");

            }
        }
        public static void SaveHours(Employee emp)
        {
            // Saves new hour entry to Hours data table
            // NOT DONE
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO \"main\".\"Hours\"(\"Hours\",\"Date\",\"Name\",\"ID\",\"Role\",\"Shift\") VALUES (\"{emp.Hours}\", \"{emp.Date}\", \"{emp.Name}\", \"{emp.Id}\", \"{emp.Role}\", \"{emp.Shift}\");");
            }
        }
        public static void DeleteEmployee(Employee emp)
        {
            // Saves new hour entry to Hours data table
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM \"main\".\"Stats\" WHERE Id=\"{emp.Id}\"");
                cnn.Execute($"DELETE FROM \"main\".\"Hours\" WHERE Id=\"{emp.Id}\"");
            }
        }
        public static void ChangeSchedule(Employee emp, string newShift, string newRole)
        {
            // Edits the shift and role of an employee
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE \"main\".\"Stats\" SET Shift = \"{newShift}\", Role = \"{newRole}\" WHERE Name = \"{emp.Name}\";");
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            // Returns Location of Employee data base
            return "Data Source=.\\Employee.db;Version=3";
        }
    }
}

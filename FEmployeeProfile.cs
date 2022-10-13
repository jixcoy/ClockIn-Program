using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace ClockIn
{
    public partial class FEmployeeProfile : UserControl
    {
        List<Employee> employees = new List<Employee>();
        public FEmployeeProfile()
        {
            InitializeComponent();
            try
            {
                // sets employees to hours data table
                employees = DBAccess.LoadEmployees();
            }
            catch (Exception)
            {
                Employee newEmployee = new Employee();
                employees.Add(newEmployee);
            }
        }

        private void EnterHours()
        {
            // Sets datatable view to employees hours, date, role, and shift
            profileHoursDtb.DataSource = employees
                .Where(i => i.Id.ToString() == Form1.logInTb)
                .Select(i => new { i.Hours, i.Date, i.Role, i.Shift }).ToList();
        }

        private void FEmployeeProfile_Load(object sender, EventArgs e)
        {
            EnterHours();
            // Sets username and role labels to respective value
            var lol = employees
                .Where(i => i.Id.ToString() == Form1.logInTb)
                .Select(i => new {i.Name, i.Role}).ToList();
            UserNameLabel.Text = lol[0].Name;
            RoleLabel.Text = lol[0].Role;
        }
    }
}

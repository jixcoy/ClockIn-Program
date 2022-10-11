using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace ClockIn
{
    public partial class FEmployeeProfile : UserControl
    {
        List<Employee> employees = new List<Employee>();
        //private string ID = Form1.form
        public FEmployeeProfile()
        {
            InitializeComponent();
            try
            {
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
            profileHoursDtb.DataSource = employees
                .Where(i => i.Id.ToString() == Form1.logInTb)
                .Select(i => new { i.Hours, i.Date, i.Role, i.Shift }).ToList();
        }

        private void FEmployeeProfile_Load(object sender, EventArgs e)
        {
            EnterHours();
            var lol = employees
                .Where(i => i.Id.ToString() == Form1.logInTb)
                .Select(i => new {i.Name, i.Role}).ToList();
            UserNameLabel.Text = lol[0].Name;
            RoleLabel.Text = lol[0].Role;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HoursTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace ClockIn
{
    public partial class HoursF : UserControl
    {
        List<Employee> employees = new List<Employee>();
        public HoursF()
        {
            InitializeComponent();
            try
            {
                employees = DBAccess.LoadEmployees();
            }
            catch(Exception)
            {
                Employee newEmployee = new Employee();
                employees.Add(newEmployee);
            }
        }
        private void EnterHours()
        {
            HoursDtb.DataSource = employees
                .Where(i => Form1.logInTb == i.Id.ToString())
                .Select(i => new { i.Hours, i.Date, i.Shift}).ToList();
        }
        private void HoursF_Load(object sender, EventArgs e)
        {
            EnterHours();
            HideAllAdd();
        }
        private void HideAllAdd()
        {
            hoursTB.Hide();
            dateTB.Hide();
            shiftTB.Hide();
            cancelBtn.Hide();
            enterBtn.Hide();

            hoursTB.Texts = "Hours";
            dateTB.Texts = "Date";
            shiftTB.Texts = "Shift";
        }
        private void addHoursBtn_Click(object sender, EventArgs e)
        {
            hoursTB.Show();
            dateTB.Show();
            shiftTB.Show();
            cancelBtn.Show();
            enterBtn.Show();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            HideAllAdd();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            // Creates new employee object and adds to database
            Employee newEmployee = new Employee();
            newEmployee.Hours = hoursTB.Texts;
            newEmployee.Date = dateTB.Texts;
            newEmployee.Shift = shiftTB.Texts;
            newEmployee.Id = Convert.ToInt32(Form1.logInTb);
            newEmployee.Role = Form1.role;
            newEmployee.Name = Form1.name;

            // Saves employee to data base and reloads data table
            DBAccess.SaveHours(newEmployee);
            employees = DBAccess.LoadEmployees();
            EnterHours();

            HideAllAdd();
        }
    }
}

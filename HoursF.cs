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
            CancelButton.Hide();
            EnterButton.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            hoursTB.Show();
            dateTB.Show();
            shiftTB.Show();
            CancelButton.Show();
            EnterButton.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            HideAllAdd();
        }

        private void EnterButton_Click(object sender, EventArgs e)
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

        // Placeholder Text Enter

        private void hoursTB_Enter(object sender, EventArgs e)
        {
            if (hoursTB.Texts == "Hours (number)")
            {
                hoursTB.Texts = "";
            }
        }

        private void dateTB_Enter(object sender, EventArgs e)
        {
            if (dateTB.Texts == "mm/dd/yyyy")
            {
                dateTB.Texts = "";
            }
        }

        private void shiftTB_Enter(object sender, EventArgs e)
        {
            if (shiftTB.Texts == "Shift")
            {
                shiftTB.Texts = "";
            }
        }

        private void hoursTB_Leave(object sender, EventArgs e)
        {
            if (hoursTB.Texts == "")
            {
                hoursTB.Texts = "Hours (number)";
            }
        }

        private void dateTB_Leave(object sender, EventArgs e)
        {
            if (dateTB.Texts == "")
            {
                dateTB.Texts = "mm/dd/yyyy";
            }
        }

        private void shiftTB_Leave(object sender, EventArgs e)
        {
            if (shiftTB.Texts == "")
            {
                shiftTB.Texts = "Shift";
            }
        }
    }
}

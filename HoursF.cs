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

        private void customTB3_Load(object sender, EventArgs e)
        {

        }
        private void HideAllAdd()
        {
            hoursTB.Hide();
            dateTB.Hide();
            shiftTB.Hide();
            cancelBtn.Hide();
            enterBtn.Hide();
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
    }
}

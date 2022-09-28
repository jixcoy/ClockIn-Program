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
            catch(Exception exc)
            {
                Employee newEmployee = new Employee();
                employees.Add(newEmployee);
            }
        }

        private void HoursF_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employees
                .Where(i => Form1.logInTb == i.Id.ToString())
                .Select(i => new { i.Hours, i.Date }).ToList();

            dataGridView2.DataSource = employees
                .Where(i => Form1.logInTb == i.Id.ToString())
                .Select(i => new { i.Shift, i.Date }).ToList();
        }
    }
}

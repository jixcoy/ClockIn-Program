using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            employees = DBAccess.LoadEmployees();
        }

        private void HoursF_Load(object sender, EventArgs e)
        {
            foreach(var employee in employees)
            {
                int i = 0;
                if (Form1.logInTb == employee.Id.ToString())
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(dataGridView1);
                    dr.Cells[0].Value = employee.Hours;
                    dr.Cells[1].Value = employee.Date;
                    dataGridView1.Rows.Add(dr);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TableLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

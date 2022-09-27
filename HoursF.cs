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
                if (Form1.logInTb == employee.Id.ToString())
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(dataGridView1);
                    dr.Cells[0].Value = employee.Hours;
                    dr.Cells[1].Value = employee.Date;
                    dataGridView1.Rows.Add(dr);

                    DataGridViewRow dr2 = new DataGridViewRow();
                    dr2.CreateCells(dataGridView2);
                    dr2.Cells[0].Value = employee.Shift;
                    dr2.Cells[1].Value = employee.Date;
                    dataGridView2.Rows.Add(dr2);
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

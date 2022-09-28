using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockIn
{
    public partial class BossManageEmployees : UserControl
    {
        List<Employee> employees = new List<Employee>();
        public BossManageEmployees()
        {
            InitializeComponent();
            try
            {
                employees = DBAccess.LoadStats();
            }
            catch (Exception exc)
            {
                Employee newEmployee = new Employee();
                employees.Add(newEmployee);
            }
        }

        private void BossManageEmployees_Load(object sender, EventArgs e)
        {
            foreach (var employee in employees)
            {
                if (Form1.logInTb == employee.Id.ToString())
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(manageEmployeesDTbl);
                    dr.Cells[0].Value = employee.Name;
                    dr.Cells[1].Value = employee.Rating;
                    dr.Cells[2].Value = employee.Pay;
                    manageEmployeesDTbl.Rows.Add(dr);
                }
            }
        }
    }
}

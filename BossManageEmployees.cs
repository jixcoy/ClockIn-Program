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
            // do linq
            manageEmployeesDTbl.DataSource = employees
                .Select(i => new { i.Name, i.Shift, i.Rating, i.Pay }).ToList();
        }

        private void manageEmployeesDTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

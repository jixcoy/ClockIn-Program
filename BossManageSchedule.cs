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
    public partial class BossManageSchedule : UserControl
    {
        List<Employee> employees = new List<Employee>();
        public BossManageSchedule()
        {
            InitializeComponent();
            try
            {
                employees = DBAccess.LoadStats();
            }
            catch (Exception)
            {
                // If sql breaks, this base employee with default values fixes it
                Employee newEmployee = new Employee();
                employees.Add(newEmployee);
            }
        }
        private void EnterStats()
        {
            manageScheduleDTBL.DataSource = employees
                .Select(i => new { i.Name, i.Shift, i.Role }).ToList();
        }

        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            editNameTB.Show();
            editShiftTB.Show();
            editRoleTB.Show();
        }
    }
}

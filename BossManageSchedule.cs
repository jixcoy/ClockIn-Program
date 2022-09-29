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
        private void HideAllEdits()
        {
            // Hides all the edit components
            editCancelBtn.Hide();
            editEnter.Hide();
            editNameTB.Hide();
            editRoleTB.Hide();
            editShiftTB.Hide();

            // Sets text to default value
            editNameTB.Texts = "Name";
            editRoleTB.Texts = "Role";
            editShiftTB.Texts = "Shift";
        }
        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            // Shows all edit components
            editNameTB.Show();
            editShiftTB.Show();
            editRoleTB.Show();
            editCancelBtn.Show();
            editEnter.Show();
        }

        private void editCancelBtn_Click(object sender, EventArgs e)
        {
            HideAllEdits();
        }

        private void editEnter_Click(object sender, EventArgs e)
        {
            // Chooses the employee based of the name given in the Edit Name Textbox
            Employee editEmployee = new Employee();
            foreach (Employee employee in employees)
                if (employee.Name == editNameTB.Texts)
                    editEmployee = employee;

            // Updates the Database
            DBAccess.ChangeSchedule(editEmployee, editShiftTB.Texts, editRoleTB.Texts);
            employees = DBAccess.LoadStats();
            EnterStats();
            HideAllEdits();
        }

        private void BossManageSchedule_Load(object sender, EventArgs e)
        {
            EnterStats();
            HideAllEdits();
        }
    }
}

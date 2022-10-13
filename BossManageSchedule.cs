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
            CancelButton.Hide();
            EnterButton.Hide();
            editNameTB.Hide();
            editRoleTB.Hide();
            editShiftTB.Hide();
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

        public void refresh(object sender, EventArgs e)
        {
            employees = DBAccess.LoadStats();
            EnterStats();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // Shows all edit components
            editNameTB.Show();
            editShiftTB.Show();
            editRoleTB.Show();
            CancelButton.Show();
            EnterButton.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            HideAllEdits();
        }

        private void EnterButton_Click(object sender, EventArgs e)
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
        
        // Placeholder text enter
        private void editNameTB_Enter(object sender, EventArgs e)
        {
            if (editNameTB.Texts == "Full Name")
            {
                editNameTB.Texts = "";
            }
        }

        private void editShiftTB_Enter(object sender, EventArgs e)
        {
            if (editShiftTB.Texts == "Shift")
            {
                editShiftTB.Texts = "";
            }
        }

        private void editRoleTB_Enter(object sender, EventArgs e)
        {
            if (editRoleTB.Texts == "Role")
            {
                editRoleTB.Texts = "";
            }
        }

        // Placeholder text leave

        private void editNameTB_Leave(object sender, EventArgs e)
        {
            if (editNameTB.Texts == "")
            {
                editNameTB.Texts = "Full Name";
            }
        }

        private void editShiftTB_Leave(object sender, EventArgs e)
        {
            if (editShiftTB.Texts == "")
            {
                editShiftTB.Texts = "Shift";
            }
        }

        private void editRoleTB_Leave(object sender, EventArgs e)
        {
            if (editRoleTB.Texts == "")
            {
                editRoleTB.Texts = "Role";
            }
        }
    }

}

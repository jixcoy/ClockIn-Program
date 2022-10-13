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
            catch (Exception)
            {
                Employee newEmployee = new Employee();
                employees.Add(newEmployee);
            }
        }
        private void EnterStats()
        {
            // Enters employee stats into data grid view
            manageEmployeesDTbl.DataSource = employees
                .Select(i => new { i.Name, i.Role, i.Pay }).ToList();
        }
        private void BossManageEmployees_Load(object sender, EventArgs e)
        {
            EnterStats();
            hideRemoveButtons();
            hideAddButtons();
        }

        private void hideAddButtons()
        {
            nnameCustomTb.Hide();
            nidCustomTb.Hide();
            npayCustomTb.Hide();
            nRoleCustomTB.Hide();
            CancelButton.Hide();
            EnterButton.Hide();
        }
        private void hideRemoveButtons()
        {
            // Hides all remove buttons and textboxes. Resets textboxs values
            RCancelBtn.Hide();
            removeConfirmTb.Hide();
            REnterBtn.Hide();
            removeNameTb.Hide();
            removeConfirmTb.Hide();
            removeNameTb.Texts = "Name";
            removeConfirmTb.Texts = "Confirm? (Type \"Yes\" or \"No\")";

        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            // Shows all Employee add buttons and Textboxes
            nnameCustomTb.Show();
            nnameCustomTb.Texts = "Name";
            nidCustomTb.Show();
            nidCustomTb.Texts = "ID";
            npayCustomTb.Show();
            npayCustomTb.Texts = "Pay";
            nRoleCustomTB.Show();
            nRoleCustomTB.Texts = "Role";
            CancelButton.Show();
            EnterButton.Show();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            // Creates new employee object and adds to database
            Employee newEmployee = new Employee();
            newEmployee.Name = nnameCustomTb.Texts;
            newEmployee.Id = Convert.ToInt32(nidCustomTb.Texts);
            newEmployee.Role = nRoleCustomTB.Texts;
            newEmployee.Pay = npayCustomTb.Texts;


            // Saves employee to data base and reloads data table
            DBAccess.SaveEmployee(newEmployee);
            employees = DBAccess.LoadStats();
            EnterStats();

            hideAddButtons();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            hideAddButtons();
        }

        private void RCancelBtn_Click(object sender, EventArgs e)
        {
            hideRemoveButtons();
        }

        private void REnterBtn_Click(object sender, EventArgs e)
        {
            // Removes Employee from Stats and Hours Datatables 
            if (removeConfirmTb.Texts.ToLower() == "yes")
            {
                Employee removedEmployee = new Employee();
                foreach (Employee employee in employees)
                    if (employee.Name == removeNameTb.Texts)
                        removedEmployee = employee;
                DBAccess.DeleteEmployee(removedEmployee);
                employees = DBAccess.LoadStats();
                EnterStats();
                hideRemoveButtons();
            }
            else
                hideRemoveButtons();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            // Shows all remove Buttons
            RCancelBtn.Show();
            removeConfirmTb.Show();
            REnterBtn.Show();
            removeNameTb.Show();
            removeConfirmTb.Show();
        }
    }
}

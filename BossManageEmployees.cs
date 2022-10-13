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
            nidCustomTb.Show();
            npayCustomTb.Show();
            nRoleCustomTB.Show();
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

        // Place Holder Texts Enter
        private void nnameCustomTb_Enter(object sender, EventArgs e)
        {
            if (nnameCustomTb.Texts == "Full Name")
            {
                nnameCustomTb.Texts = "";
            }
        }

        private void npayCustomTb_Enter(object sender, EventArgs e)
        {
            if (npayCustomTb.Texts == "Pay")
            {
                npayCustomTb.Texts = "";
            }
        }

        private void nidCustomTb_Enter(object sender, EventArgs e)
        {
            if (nidCustomTb.Texts == "ID")
            {
                nidCustomTb.Texts = "";
            }
        }

        private void nRoleCustomTB_Enter(object sender, EventArgs e)
        {
            if (nRoleCustomTB.Texts == "Role")
            {
                nRoleCustomTB.Texts = "";
            }
        }

        private void removeNameTb_Enter(object sender, EventArgs e)
        {
            if (removeNameTb.Texts == "Full Name")
            {
                removeNameTb.Texts = "";
            }
        }

        private void removeConfirmTb_Enter(object sender, EventArgs e)
        {
            if (removeConfirmTb.Texts == "Confirm? Yes or No")
            {
                removeConfirmTb.Texts = "";
            }
        }


        // Placeholder Text Leave

        private void nnameCustomTb_Leave(object sender, EventArgs e)
        {
            if (nnameCustomTb.Texts == "")
            {
                nnameCustomTb.Texts = "Full Name";
            }
        }

        private void npayCustomTb_Leave(object sender, EventArgs e)
        {
            if (npayCustomTb.Texts == "")
            {
                npayCustomTb.Texts = "Pay";
            }
        }

        private void nidCustomTb_Leave(object sender, EventArgs e)
        {
            if (nidCustomTb.Texts == "")
            {
                nidCustomTb.Texts = "ID";
            }
        }

        private void nRoleCustomTB_Leave(object sender, EventArgs e)
        {
            if (nRoleCustomTB.Texts == "")
            {
                nRoleCustomTB.Texts = "Role";
            }
        }

        private void removeNameTb_Leave(object sender, EventArgs e)
        {
            if (removeNameTb.Texts == "")
            {
                removeNameTb.Texts = "Full Name";
            }
        }

        private void removeConfirmTb_Leave(object sender, EventArgs e)
        {
            if (removeConfirmTb.Texts == "")
            {
                removeConfirmTb.Texts = "Confirm? Yes or No";
            }
        }
    }
}

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
        private void EnterStats()
        {
            manageEmployeesDTbl.DataSource = employees
                .Select(i => new { i.Name, i.Shift, i.Rating, i.Pay }).ToList();
        }
        private void BossManageEmployees_Load(object sender, EventArgs e)
        {
            EnterStats();
            hideRemoveButtons();
            hideAddButtons();
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            nnameCustomTb.Show();
            nnameCustomTb.Texts = "Name";
            nidCustomTb.Show();
            nidCustomTb.Texts = "ID";
            npayCustomTb.Show();
            npayCustomTb.Texts = "Pay";
            nshiftCustomTB.Show();
            nshiftCustomTB.Texts = "Shift";
            cancelBtn.Show();
            enterBtn.Show();
        }
        private void hideAddButtons()
        {
            nnameCustomTb.Hide();
            nidCustomTb.Hide();
            npayCustomTb.Hide();
            nshiftCustomTB.Hide();
            cancelBtn.Hide();
            enterBtn.Hide();
        }
        private void hideRemoveButtons()
        {
            // Hides all remove buttons and textboxes. Resets textboxs values
            removeCancelBtn.Hide();
            removeConfirmTb.Hide();
            removeEnterBtn.Hide();
            removeNameTb.Hide();
            removeConfirmTb.Hide();
            removeNameTb.Texts = "Name";
            removeConfirmTb.Texts = "Confirm? (Type \"Yes\" or \"No\")";

        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            hideAddButtons();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            // Creates new employee object and adds to database
            Employee newEmployee = new Employee();
            newEmployee.Name = nnameCustomTb.Texts;
            newEmployee.Id = Convert.ToInt32(nidCustomTb.Texts);
            newEmployee.Shift = nshiftCustomTB.Texts;
            newEmployee.Pay = npayCustomTb.Texts;

            // Saves employee to data base and reloads data table
            DBAccess.SaveEmployee(newEmployee);
            employees = DBAccess.LoadStats();
            EnterStats();

            hideAddButtons();
        }

        private void removeEmpBtn_Click(object sender, EventArgs e)
        {
            removeCancelBtn.Show();
            removeConfirmTb.Show();
            removeEnterBtn.Show();
            removeNameTb.Show();
            removeConfirmTb.Show();
        }

        private void removeCancelBtn_Click(object sender, EventArgs e)
        {
            hideRemoveButtons();
        }
    }
}

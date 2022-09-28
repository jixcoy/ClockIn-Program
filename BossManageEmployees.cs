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
            // do linq
            EnterStats();
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            nameCustomTb.Show();
            nameCustomTb.Texts = "Name";
            idCustomTb.Show();
            idCustomTb.Texts = "ID";
            payCustomTb.Show();
            payCustomTb.Texts = "Pay";
            shiftCustomTB.Show();
            shiftCustomTB.Texts = "Shift";
            cancelBtn.Show();
            enterBtn.Show();
        }
        private void hideAddButtons()
        {
            nameCustomTb.Hide();
            idCustomTb.Hide();
            payCustomTb.Hide();
            shiftCustomTB.Hide();
            cancelBtn.Hide();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            hideAddButtons();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            // Creates new employee object and adds to database
            Employee newEmployee = new Employee();
            newEmployee.Name = nameCustomTb.Texts;
            newEmployee.Id = Convert.ToInt32(idCustomTb.Texts);
            newEmployee.Shift = shiftCustomTB.Texts;
            newEmployee.Pay = payCustomTb.Texts;
            DBAccess.SaveEmployee(newEmployee);

            EnterStats();
            hideAddButtons();
        }
    }
}

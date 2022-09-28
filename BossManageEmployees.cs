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

        private void customTB1_Load(object sender, EventArgs e)
        {

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameCustomTb.Hide();
            idCustomTb.Hide();
            payCustomTb.Hide();
            shiftCustomTB.Hide();
            cancelBtn.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

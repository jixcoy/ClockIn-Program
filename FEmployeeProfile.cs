using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClockIn
{
    public partial class FEmployeeProfile : UserControl
    {
        List<Employee> employeeList = new List<Employee>();
        //private string ID = Form1.form
        public FEmployeeProfile()
        {
            InitializeComponent();
        }
        private void LoadHoursDB()
        {
            employeeList = DBAccess.LoadEmployees();
            //Get Specific employee
            // 
            foreach (var employee in employeeList)
            {

                if (Form1.logInTb == employee.Id.ToString())
                {
                    UserNameLabel.Text = employeeList[0].Name;
                    HoursValue.Text = employeeList[0].Hours;
                    DateValue.Text = employeeList[0].Date;
                    RoleLabel.Text = employeeList[0].Role;
                }
            }


            //UserNameLabel.Text = employee[].Name;
            //HoursHead.Text = employee[0].Name;
        }

        private void SetData()
        {

        }

        private void FEmployeeProfile_Load(object sender, EventArgs e)
        {
            LoadHoursDB();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HoursTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

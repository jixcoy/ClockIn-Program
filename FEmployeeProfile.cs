using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClockIn
{
    public partial class FEmployeeProfile : UserControl
    {
        List<Employee> employee = new List<Employee>();
        public FEmployeeProfile()
        {
            InitializeComponent();
        }
        private void LoadHoursDB()
        {
            employee = DBAccess.LoadEmployees();
        }

        private void SetData()
        {

        }

        private void FEmployeeProfile_Load(object sender, EventArgs e)
        {

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

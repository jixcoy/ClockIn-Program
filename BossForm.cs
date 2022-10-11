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
    public partial class BossForm : Form
    {
        public BossForm()
        {
            InitializeComponent();

            // Sets clock in logo to top of panel
            workerLeftPanel.Controls.SetChildIndex(clockInLabel, 5);
            // Sets log out button to bottom of panel
            workerLeftPanel.Controls.SetChildIndex(logOutBtn, 0);

        }
        private void hideAllUserControls()
        {
            // Hides all user controls on the form
            bossProfiel1.Hide();
            bossManageSchedule1.Hide();
            bossManageEmployees1.Hide();
        }
        private void profileIconButton_Click(object sender, EventArgs e)
        {
            // Shows Boss Profile 
            hideAllUserControls();
            bossProfiel1.Show();
        }

        private void emailIconBtn_Click(object sender, EventArgs e)
        {
            // Shows Boss Email
            hideAllUserControls();
        }


        private void logOutBtn_Click(object sender, EventArgs e)
        {
            //Log out
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void ManageScheduleBtn_Click(object sender, EventArgs e)
        {
            // Shows Manage Schedule
            hideAllUserControls();
            bossManageSchedule1.Show();
        }

        private void BossForm_Load(object sender, EventArgs e)
        {
            // Shows profile on load and hides all other user controls
            hideAllUserControls();
            bossProfiel1.Show();
        }

        private void ManageEmployeesBtn_Click(object sender, EventArgs e)
        {
            // Shows Manage Employees
            hideAllUserControls();
            bossManageEmployees1.Show();
        }

        private void clockInLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

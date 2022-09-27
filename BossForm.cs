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
            workerLeftPanel.Controls.SetChildIndex(clockInLabel, 5);
            workerLeftPanel.Controls.SetChildIndex(logOutBtn, 0);

        }
        private void hideAllUserControls()
        {
            bossProfiel1.Hide();
            bossEmail1.Hide();
            bossManageSchedule1.Hide();
            bossManageEmployees1.Hide();
        }
        private void profileIconButton_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            bossProfiel1.Show();
        }

        private void emailIconBtn_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            bossEmail1.Show();
        }


        private void logOutBtn_Click(object sender, EventArgs e)
        {
            // LOG OUT
        }

        private void ManageScheduleBtn_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            bossManageSchedule1.Show();
        }

        private void BossForm_Load(object sender, EventArgs e)
        {
            bossProfiel1.Show();
        }

        private void ManageEmployeesBtn_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            bossManageEmployees1.Show();
        }
    }
}

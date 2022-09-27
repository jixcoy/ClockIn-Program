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
            //fEmployeeProfile1.Hide();
            //emailF1.Hide();
            //hoursF1.Hide();
        }
        private void profileIconButton_Click(object sender, EventArgs e)
        {

        }

        private void emailIconBtn_Click(object sender, EventArgs e)
        {

        }

        private void hoursIconBtn_Click(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {

        }

        private void ManageScheduleBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

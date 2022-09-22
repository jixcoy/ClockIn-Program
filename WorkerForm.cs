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
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
            workerLeftPanel.Controls.SetChildIndex(clockInLabel, 5);
        }

        private void hideAllUserControls()
        {
            fEmployeeProfile1.Hide();
            emailF1.Hide();
            hoursF1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            fEmployeeProfile1.Show();
        }

        private void emailIconBtn_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            emailF1.Show();
        }

        private void hoursIconBtn_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            hoursF1.Show();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            hideAllUserControls();
            fEmployeeProfile1.Show();
        }
    }
}

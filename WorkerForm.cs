using System;
using System.Windows.Forms;

namespace ClockIn
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
            // Sets Clock in logo to the top
            workerLeftPanel.Controls.SetChildIndex(clockInLabel, 5);
        }

        private void hideAllUserControls()
        {
            // Hides all the user controls on the form
            fEmployeeProfile1.Hide();
            hoursF1.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Show profile
            hideAllUserControls();
            fEmployeeProfile1.Show();
        }

        private void emailIconBtn_Click(object sender, EventArgs e)
        {
            // Show email
            hideAllUserControls();
        }

        private void hoursIconBtn_Click(object sender, EventArgs e)
        {
            // Show hours and shifts
            hideAllUserControls();
            hoursF1.Show();

        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // Show profile on load and hide other user controls
            hideAllUserControls();
            fEmployeeProfile1.Show();

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            //Log out
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void fEmployeeProfile1_Load(object sender, EventArgs e)
        {

        }
    }
}

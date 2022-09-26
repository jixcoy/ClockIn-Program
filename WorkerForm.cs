using System;
using System.Windows.Forms;

namespace ClockIn
{
    public partial class WorkerForm : Form
    {
        public string ID { get; set; }
        public WorkerForm(string id)
        {
            InitializeComponent();
            //FormManager.wform = this;
            //ID = id;
            //workerLeftPanel.Controls.SetChildIndex(clockInLabel, 5);
        }

        private void hideAllUserControls()
        {
            //fEmployeeProfile1.Hide();
            //emailF1.Hide();
            //hoursF1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //FormManager.form1.Show();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            //fEmployeeProfile1.Show();
        }

        private void emailIconBtn_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            //emailF1.Show();
        }

        private void hoursIconBtn_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            //hoursF1.Show();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            hideAllUserControls();
            //fEmployeeProfile1.Show();

        }

        private void fEmployeeProfile1_Load(object sender, EventArgs e)
        {

        }
            
    }
}

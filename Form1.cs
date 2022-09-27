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
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
            FormManager.form1 = this;
            

        }
        public static string logInTb;
        private void logInBtn_Click(object sender, EventArgs e)
        {
            employees = DBAccess.LoadEmployees();
            logInTb = textBox1.Text;

            foreach (var employee in employees)
            {
                if (logInTb == employee.Id.ToString())
                {
                    WorkerForm worker = new WorkerForm(logInTb);
                    this.Hide();
                    worker.ShowDialog();
                }
            }
        }

        private void iconStartButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

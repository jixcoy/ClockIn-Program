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
            WorkerForm worker = new WorkerForm();
            foreach (var employee in employees)
            {
                if (logInTb == employee.Id.ToString())
                {
                    FormManager.wform = worker;
                    this.Hide();
                    worker.ShowDialog();
                    this.Close();
                }
            }
            if (logInTb == "boss")
            {
                BossForm boss = new BossForm();
                FormManager.bform = boss;
                this.Hide();
                boss.ShowDialog();
                this.Close();
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

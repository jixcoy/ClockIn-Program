using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClockIn
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }
        public static string logInTb;
        public static string role;
        public static string name;
        private void customButton1_Click(object sender, EventArgs e)
        {
            employees = DBAccess.LoadStats();
            logInTb = textBox1.Text;
            WorkerForm worker = new WorkerForm();
            BossForm boss = new BossForm();
            foreach (var employee in employees)
            {
                if (logInTb == employee.Id.ToString())
                {
                    if (employee.Role.ToLower() == "admin")
                    {
                        this.Hide();
                        boss.ShowDialog();
                        this.Close();
                    } else
                    {
                        role = employee.Role;
                        name = employee.Name;
                        this.Hide();
                        worker.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}

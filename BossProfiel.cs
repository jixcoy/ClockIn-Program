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
    public partial class BossProfiel : UserControl
    {
        List<Employee> employees = new List<Employee>();
        public BossProfiel()
        {
            InitializeComponent();
            try
            {
                // sets employees to hours data table
                employees = DBAccess.LoadStats();
            }
            catch (Exception)
            {
                Employee newEmployee = new Employee();
                employees.Add(newEmployee);
            }
        }

        private void BossProfiel_Load(object sender, EventArgs e)
        {
            var lol = employees
                .Where(i => i.Id.ToString() == Form1.logInTb)
                .Select(i => new { i.Name, i.Role }).ToList();
            UserNameLabel.Text = lol[0].Name;
            RoleLabel.Text = lol[0].Role;
        }
    }
}

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
        public Form1()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "69")
            {
                WorkerForm worker = new WorkerForm();
                this.Hide();
                worker.ShowDialog();
                this.Close();
            } else
            {

            }
        }
    }
}

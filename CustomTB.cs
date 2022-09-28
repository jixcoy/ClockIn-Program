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
    public partial class CustomTB : UserControl
    {
        public CustomTB()
        {
            InitializeComponent();
        }
        public string Texts
        {
            get
            {
                return textBox.Text;
            }
            set
            {
                textBox.Text = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockIn
{
    class Employee
    {
        public int Id { get; set; } = 0000;
        public string Name { get; set; } = "John Doe";
        public string Date { get; set; } = "00/00/0000";
        public string Hours { get; set; } = "0";
        public string Role { get; set; } = "Employee";
        public string Shift { get; set; } = "1rst";
        public string Pay { get; set; } = "$0.00";
        public string Rating { get; set; } = "0";
    }
}

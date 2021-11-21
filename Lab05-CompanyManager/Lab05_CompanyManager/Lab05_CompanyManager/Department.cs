using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_CompanyManager
{
    public class Department
    {
        // Thuộc tính
        public int DNumber { get; set; }
        public string DName { get; set; }
        public List<string> Locations { get; set; }

        public Department(int number = 0, string name = "", List<string> locations = null)
        {
            DNumber = number;
            DName = name;
            Locations = locations;
        }

        // Quan hệ
        public List<Employee> Employees { get; set; }
        public Employee Manager { get; set; }
        public List<Project> Projects { get; set; }

        public string MgrStartDate { get; set; }
    }
}

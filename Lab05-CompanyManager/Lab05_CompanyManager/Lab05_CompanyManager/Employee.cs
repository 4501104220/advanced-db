using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_CompanyManager
{
    public class Employee
    {
        // Thuộc tính
        public int Ssn { get; set; }
        public string FName { get; set; }
        public string MInit { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }

        // Khởi tạo
        public Employee (int ssn = 0, string fname = "", string minit = "", string lname = "", string address = "", string birthdate = "", double salary = 0, string gender = "")
        {
            Ssn = ssn;
            FName = fname;
            MInit = minit;
            LName = lname;
            Address = address;
            BirthDate = birthdate;
            Salary = salary;
            Gender = gender;
        }

        // Phương thức
        public string _ToString()
        {
            return FName + ":" + MInit + ":" + LName + ":" + Ssn.ToString() + ":" + BirthDate + ":" + Address + ":" + Gender + ":" + Salary.ToString();
        }

        // Quan hệ
        public Department WorksFor { get; set; }
        public Department Manager { get; set; }
        public List<WorksOn> WorksOn { get; set; }
        public List<Dependent> Dependents { get; set; }
        public Employee Supervisor { get; set; }
        public List<Employee> Supervisees { get; set; }
    }
}
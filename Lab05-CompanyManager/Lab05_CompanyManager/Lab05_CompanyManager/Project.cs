using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_CompanyManager
{
    public class Project
    {
        // Thuộc tính
        public int PNumber { get; set; }
        public string PName { get; set; }
        public string Location { get; set; }

        // Khởi tạo
        public Project(int pnumber = 0, string pname = "", string location = "")
        {
            PNumber = pnumber;
            PName = pname;
            Location = location;
        }

        // Phương thức
        public string _ToString()
        {
            return PNumber.ToString() + "," + PName + "," + Location;
        }

        // Quan hệ
        public Department ControlledBy { get; set; }
        public List<WorksOn> WorksOn { get; set; }
    }
}

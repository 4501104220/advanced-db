using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_CompanyManager
{
    public class Project
    {
        // Props
        public int PNumber { get; set; }
        public string PName { get; set; }
        public string Location { get; set; }

        // Initial
        public Project(int pnumber = 0, string pname = "", string location = "")
        {
            PNumber = pnumber;
            PName = pname;
            Location = location;
        }

        // Method
        public string _ToString()
        {
            return PNumber.ToString() + "," + PName + "," + Location;
        }

        // Relationship
        public Department ControlledBy { get; set; }
        public List<WorksOn> WorksOn { get; set; }
    }
}

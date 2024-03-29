﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_CompanyManager
{
    public class Dependent
    {
        // Props
        public string Name { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string Relationship { get; set; }

        // Initial
        public Dependent (string name = "", string gender = "", string birthdate = "", string relationship = "")
        {
            Name = name;
            Gender = gender;
            BirthDate = birthdate;
            Relationship = relationship;
        }

        // Method
        public string _ToString()
        {
            return DependentOf.Ssn.ToString() + "," + Name + "," + Gender + "," + BirthDate + "," + Relationship;
        }

        // Relationship
        public Employee DependentOf { get; set; }
    }
}

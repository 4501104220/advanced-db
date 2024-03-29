﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_CompanyManager
{
    public class WorksOn
    {
        // Props
        public float Hours { get; set; }

        public WorksOn(float hours = 0)
        {
            Hours = hours;
        }

        // Relationship
        public Employee Employee { get; set; }

        public Project Project { get; set; }
    }
}

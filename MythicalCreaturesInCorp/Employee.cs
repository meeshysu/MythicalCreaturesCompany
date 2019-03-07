using System;
using System.Collections.Generic;
using System.Text;

namespace MythicalCreaturesInCorp
{
    class Employee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }

        //constructor, make sure you put it in the flipping class! meesh.
        public Employee(string name, string jobtitle, DateTime startdate)
        {
            Name = name;
            JobTitle = jobtitle;
            StartDate = startdate;
        }
    }
}

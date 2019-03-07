using System;
using System.Collections.Generic;
using System.Text;

namespace MythicalCreaturesInCorp
{
    class Company
    {
        public string CompanyName { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Summary { get; set; }

        public List<Employee> Employees = new List<Employee>(); 

        public Company(string companyname, DateTime createdOn, string summary)
        {
            CompanyName = companyname;
            CreatedOn = createdOn;
            Summary = summary;
        }

        public void AddEmployees(Employee newEmployee)
        {
            Employees.Add(newEmployee);
        }

        public void ListEmployees()
        {
            foreach (Employee emp in Employees)
            {
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.JobTitle);
                Console.WriteLine(emp.StartDate);

            }
        }
    }
}

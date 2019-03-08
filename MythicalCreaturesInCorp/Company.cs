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

        public List<Employee> companyEmployees = new List<Employee>(); 

        public Company(string companyname, DateTime createdOn, string summary)
        {
            CompanyName = companyname;
            CreatedOn = createdOn;
            Summary = summary;
        }

        public void AddEmployees(Employee newEmployee)
        {
            companyEmployees.Add(newEmployee);
        }

        public void RemoveEmployees(Employee employee)
        {
            companyEmployees.Remove(employee);
        }

        public void ListEmployees()
        {
            foreach (var employee in companyEmployees)
            {
                Console.WriteLine($"{employee.Name} is the {employee.JobTitle} and started the company on {employee.StartDate}.");

            }
        }
    }
}

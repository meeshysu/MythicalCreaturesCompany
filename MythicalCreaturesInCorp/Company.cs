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

        public List<string> Employees { get; set; }

        public Company(string companyname, DateTime createdOn, string summary)
        {
            CompanyName = companyname;
            CreatedOn = createdOn;
            Summary = summary;
        }


    }




}

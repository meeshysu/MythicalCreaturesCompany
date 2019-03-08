using System;

namespace MythicalCreaturesInCorp
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCompany = new Company("Mythical Creates In Corp", DateTime.Now, "The one and only business that will sell you a mythical creature. These creatures have come from all over the many realms of the Enchanted Forest and so on. No Unicorns though...");
            var henryMills = new Employee("Prince Henry Mills of Storybrooke", "Magical Author", DateTime.Now);
            var evilQueen = new Employee("Regina of Queen Evilness", "Evil Queen", DateTime.Now);
            var snowWhite = new Employee("Snow White", "Hope filler and positivity meter", DateTime.Now);
            var princeCharming = new Employee("Prince Charming", "Warrior and Sherrif", DateTime.Now);
            var emmaSwan = new Employee("Emma Swan", "The Savior", DateTime.Now);
            var captainHook = new Employee("Captain 'Killian' Hook", "Professional Pirate", DateTime.Now);
            var rumplestiltskin = new Employee("Rumplestiltskin", "Deal Maker", DateTime.Now);

            newCompany.AddEmployees(henryMills);
            newCompany.AddEmployees(evilQueen);
            newCompany.AddEmployees(snowWhite);
            newCompany.AddEmployees(princeCharming);
            newCompany.AddEmployees(emmaSwan);
            newCompany.AddEmployees(captainHook);
            newCompany.AddEmployees(rumplestiltskin);

            newCompany.RemoveEmployees(rumplestiltskin);

            newCompany.ListEmployees();

            Console.ReadLine();
        }
    }
}


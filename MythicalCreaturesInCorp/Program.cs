using System;

namespace MythicalCreaturesInCorp
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCompany = new Company("Mythical Creates In Corp", DateTime.Now, "The one and only business that will sell you a mythical creature. Except for a unicorn. #Overrated.");
            var blueFairy = new Employee("Ramilda the Blue Fairy", "Healer and Fairy Dust Thrower", DateTime.Now);
            var henryMills = new Employee("Prince Henry Mills of Storybrooke", "Magical Author", DateTime.Now);
            var evilQueen = new Employee("Evil Queen of Queen Evilness", "Evil Queen", DateTime.Now);
        }


    }
}

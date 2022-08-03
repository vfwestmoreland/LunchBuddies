using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    internal class LunchBuddy
    {
        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Eat()
        {
            Restaurant restaurant = new();
            Console.WriteLine($"{FirstName} is at {restaurant.Name}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} ate {food} at the office.");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            Restaurant restaurant = new();
            string buddies = "";
            foreach (LunchBuddy companion in companions)
            {
                buddies += companion.FirstName + ", ";
            }
            Console.WriteLine($"{FirstName} is at {restaurant.Name}" + buddies);
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            Restaurant restaurant = new();
            string buddies = "";
            foreach (LunchBuddy companion in companions)
            {
                buddies += companion.FirstName + ", ";
            }
            Console.WriteLine($"{FirstName} is at {restaurant.Name} and ordered {food} with " + buddies);
        }
    }

}

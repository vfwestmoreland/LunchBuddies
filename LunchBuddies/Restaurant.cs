using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    internal class Restaurant
    {
        public Restaurant()
        {
            Random random = new Random();
            Name = _restaurants[random.Next(0, _restaurants.Count())];
        }
        private List<string> _restaurants = new()
        {
            "Mike's Crab Shack",
            "Chuy's",
            "Cookout",
            "Taco Bell"
        };

        public string Name { get; set; }
    }
}

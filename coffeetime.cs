using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soloLearnproject
{
    class coffeetime
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);


            //your code goes here

            foreach (KeyValuePair<string, int> coffeetype in coffee)
            {
                Console.WriteLine(coffeetype.Key + ": " + (coffeetype.Value - coffeetype.Value * discount / 100));
            }
            Console.ReadLine();
        }
    }
}

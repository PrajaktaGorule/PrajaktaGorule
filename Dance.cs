using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnClasses
{
    class Dance
    {
        static void Main(string[] args)        
        {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
            Console.ReadLine();
        }
    }

    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        //overload the + operator

        public static DancerPoints operator +(DancerPoints b, DancerPoints c)
        {
            DancerPoints dp = new DancerPoints(b.name,b.points);
            DancerPoints dp1 = new DancerPoints(c.name, c.points);
            dp.name=dp.name+" & "+dp1.name;
            dp.points = dp.points + dp1.points;
            return dp;
        }

    }
}


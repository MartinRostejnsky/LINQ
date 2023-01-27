using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class Extensions
    {
        public delegate double DoubleInput (double a, double b);
        public static DoubleInput density = (p, a) => { return p / a; };
        public static List<Country> RandomE(this List<Country> list, int count)
        {
            List<Country> result = new List<Country>();
            for (int i = 0; i < count; i++)
            {
                result.Add(list[Random.Shared.Next(0, list.Count)]);
            }
            return result;
        }

        public static List<Country> RandomE(this List<Country> list)
        {
            int count = Random.Shared.Next(0, list.Count);
            List<Country> result = new List<Country>();
            for (int i = 0; i < count; i++)
            {
                result.Add(list[Random.Shared.Next(0, list.Count)]);
            }
            return result;
        }
        public static List<Country> InEurope(this List<Country> list)
        {
            return list.Where(c => c.Continent==Continent.Europe).ToList();
        }

        public static List<double> Densities(this List<Country> list)
        {
            List<double> result = new List<double>();
            foreach (Country c in list)
            {
                result.Add(density((double)c.Population,c.LandArea));
            }
            return result;
        }


    }
}

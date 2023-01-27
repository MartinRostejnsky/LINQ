using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ;

namespace LINQ
{
    public class Storage
    {
        public List<Country> countries = new List<Country>
        {
             new Country{ Name = "China", Continent = Continent.Asia, Population = 1406357120, LandArea = 9388211, FertilityRate = 1.7, GDP = 14860775 },
             new Country{ Name = "India", Continent = Continent.Asia, Population = 1380004385, LandArea = 2973190, FertilityRate = 2.2, GDP = 2592583 },
             new Country{ Name = "United States", Continent = Continent.NorthAmerica, Population = 331002651, LandArea = 9147420, FertilityRate = 1.8, GDP = 20807269 },
             new Country{ Name = "Indonesia", Continent = Continent.Asia, Population = 273523615, LandArea = 1811570, FertilityRate = 2.3, GDP = 1088768 },
             new Country{ Name = "Nigeria", Continent = Continent.Africa, Population = 206139589, LandArea = 910770, FertilityRate = 5.4, GDP = 442976 },
             new Country{ Name = "Russia", Continent = Continent.Europe, Population = 145934462, LandArea = 16376870, FertilityRate = 1.8, GDP = 1464078 },
             new Country{ Name = "Czechia", Continent = Continent.Europe, Population = 10708981, LandArea = 77240, FertilityRate = 1.6, GDP = 241975 },
             new Country{ Name = "Poland", Continent = Continent.Europe, Population = 37846611, LandArea = 306230, FertilityRate = 1.4, GDP = 580894 },
             new Country{ Name = "Slovakia", Continent = Continent.Europe, Population = 5459642, LandArea = 48088, FertilityRate = 1.5, GDP = 101892 },
             new Country{ Name = "France", Continent = Continent.Europe, Population = 65273511, LandArea = 547557, FertilityRate = 1.9, GDP = 2551451 },
             new Country{ Name = "United Kingdom", Continent = Continent.Europe, Population = 67886011, LandArea = 241930, FertilityRate = 1.8, GDP = 2638296 },
             new Country{ Name = "Germany", Continent = Continent.Europe, Population = 83783942, LandArea = 547557, FertilityRate = 1.8, GDP = 3780553 },
             new Country{ Name = "Egypt", Continent = Continent.Africa, Population = 102334404, LandArea = 995450, FertilityRate = 3.3, GDP = 361875 },
             new Country{ Name = "Venezuela", Continent = Continent.SouthAmerica, Population = 28435940, LandArea = 882050, FertilityRate = null, GDP = 134960 },
             new Country{ Name = "Monaco", Continent = Continent.Europe, Population = 39242, LandArea = 1, FertilityRate = null, GDP = 7423 }
        };
    }
}

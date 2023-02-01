using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;
using LINQ;
using static LINQ.Extensions;

Storage data = new Storage ();

var OrderByNameQuery = data.countries.OrderBy(c => c.Name);
foreach (Country c in OrderByNameQuery)
{
    Console.WriteLine(c);
}

Console.WriteLine("------------------------------------------------------");

var OrderByDensityQuery = data.countries.OrderBy(c => density((double)c.Population,c.LandArea));
foreach (Country c in OrderByDensityQuery)
{
    Console.WriteLine(c);
}

Console.WriteLine("------------------------------------------------------");

var EuropeanQuery = data.countries.Where(c => c.Continent == Continent.Europe);
foreach (Country c in EuropeanQuery)
{
    Console.WriteLine(c);
}

Console.WriteLine("------------------------------------------------------");

var OrderByFertilityRateQuery = data.countries.Where(c => c.FertilityRate > 2).OrderByDescending(c => c.FertilityRate);
foreach (Country c in OrderByFertilityRateQuery)
{
    Console.WriteLine(c);
}

Console.WriteLine("------------------------------------------------------");

var gdp = data.countries.Select((c) => new CountryEconomic() { Name = c.Name, GDP = (double)c.GDP, Population= (double)c.Population, PerCapita=(double)c.GDP/(double)c.Population});
foreach (CountryEconomic c in gdp)
{
    Console.WriteLine(c);
}

Console.WriteLine("------------------------------------------------------");

var GroupByContinentQuery = data.countries.GroupBy(c => c.Continent);
foreach (var c in GroupByContinentQuery)
{
    Console.WriteLine("There are " + c.Count() + " countries in " + c.Key);
}

Console.WriteLine("------------------------------------------------------");

List<Country> SelectedCountries = new List<Country>();
SelectedCountries.Add(data.countries[5]);
SelectedCountries.Add(data.countries[6]);
SelectedCountries.Add(data.countries[12]);
var PopulationInContinentQuery = data.countries.Where(c => SelectedCountries.Contains(c)).GroupBy(c => c.Continent);
foreach (var c in PopulationInContinentQuery)
{
    Console.WriteLine(c.Key + " " + c.Sum(cl => cl.Population));
}

Console.WriteLine("------------------------------------------------------");

var Top5PopQuery = data.countries.OrderByDescending(c => c.Population).Where((c, i) => i<5);
foreach (var c in Top5PopQuery)
{
    Console.WriteLine(c);
}

Console.WriteLine("------------------------------------------------------");

var Top5DenseQuery = data.countries.OrderByDescending(c => density((double)c.Population,c.LandArea)).Where((c, i) => i < 5);
foreach (var c in Top5DenseQuery)
{
    Console.WriteLine(c);
}

Console.WriteLine("------------------------------------------------------");
var StartsWithCQuery = data.countries.Where(c => c.Name.StartsWith("C"));
foreach (var c in StartsWithCQuery)
{
    Console.WriteLine(c);
}
Console.WriteLine("------------------------------------------------------");
var StartsWithCQuery2 = from c in data.countries where c.Name.StartsWith("C") select c;
foreach (var c in StartsWithCQuery2)
{
    Console.WriteLine(c);
}
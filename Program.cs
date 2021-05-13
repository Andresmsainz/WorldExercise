using System;
using WorldNamespace;

namespace WorldExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("World Exercise!");

            Country countryOneInstance = new Country();
            Country countryTwoInstance = new Country();

            CountryLanguages countryLanguages = new CountryLanguages();

            countryLanguages.FirstLanguage = Languages.Czech.ToString();
            countryLanguages.SecondLanguage = Languages.Spanish.ToString();

            countryOneInstance.CountryLanguages = countryLanguages;
            countryOneInstance.PlanetName = "Earth";
            countryOneInstance.CountryName = "USA";
            countryOneInstance.Currency = Currencies.USD;
            countryOneInstance.Continents = Continents.NorthAmerica;

            countryOneInstance.SayHi(countryOneInstance.CountryName);

        }
    }
}

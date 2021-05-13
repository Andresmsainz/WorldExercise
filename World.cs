using System;
using System.Collections.Generic;
using System.Text;

namespace WorldNamespace
{
    //abstract keyword won't allow instance
    abstract class World
    {
        private string planetName;
        private Continents continents;

        public string PlanetName
        {
            get { return planetName; }
            set { planetName = value; }
        }

        public Continents Continents
        {
            get { return continents; }
            set { continents = value; }
        }
    }

    class Country : World
    {
        private string countryName;
        private string capital;
        private CountryLanguages countryLanguages;
        private Currencies currency;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        public Currencies Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public CountryLanguages CountryLanguages
        {
            get { return countryLanguages; }
            set { countryLanguages = value; }
        }
        public Country()
        {
            Capital = "";
            CountryName = "";
        }

        public void SayHi()
        {
            Console.WriteLine("Hello from some unknown lands");
        }

        public void SayHi(string sCountryName)
        {
            Console.WriteLine($"Hello from {sCountryName}");
        }
    }


    struct CountryLanguages
    {
        private string firstLanguage;
        private string secondLanguage;

        public string FirstLanguage
        {
            get { return firstLanguage; }
            set { firstLanguage = value; }
        }

        public string SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }

    }
    enum Continents
    {
        Africa,
        Asia,
        NorthAmerica,
        SouthAmerica,
        Antarctica,
        Europe,
        Australia
    }

    enum Languages
    {
        Arabic,
        Azerbaijani,
        Bengali,
        Czech,
        Dutch,
        English,
        French,
        German,
        Greek,
        Hindi,
        Hungarian,
        Italian,
        Japanese,
        Javanese,
        Korean,
        Kurdish,
        Malay,
        Mandarin,
        Persian,
        Polish,
        Portuguese,
        Romanian,
        Russian,
        Spanish,
        Swedish,
        Thai,
        Turkish,
        Ukrainian,
        Urdu,
        Vietnamese,
        Zulu
    }
    enum Currencies
    {
        USD,
        EUR,
        JPY,
        GBP,
        AUD,
        CAD,
        CHF,
        CNY,
        SEK,
        NZD,
        MXN,
        SGD,
        HKD,
        NOK,
        KRW,
        TRY,
        RUB,
        INR,
        EGP,
        BRL,
        ZAR,
        AED,
        TND,
        SAR,
        RON,
        PLN
    }
}

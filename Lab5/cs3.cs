using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class City
    {
        private string _cityName { get; set; }
        private string _countryName { get; set; }
        private int _population { get; set; }
        private string _phoneCode { get; set; }
        private List<string> _districts { get; set; }

        public City(string cityName, string countryName, int population, string phoneCode, List<string> districts)
        {
            this._cityName = cityName;
            this._countryName = countryName;
            this._population = population;
            this._phoneCode = phoneCode;
            this._districts = districts;
        }

        public void SetCityName(string cityName)
        {
            this._cityName = cityName;
        }

        public string GetCityName()
        {
            return this._cityName;
        }

        public void SetCountryName(string countryName)
        {
            this._countryName = countryName;
        }

        public string GetCountryName()
        {
            return this._countryName;
        }

        public void SetPopulation(int population)
        {
            this._population = population;
        }

        public int GetPopulation()
        {
            return this._population;
        }

        public void SetPhoneCode(string phoneCode)
        {
            this._phoneCode = phoneCode;
        }

        public string GetPhoneCode()
        {
            return this._phoneCode;
        }

        public void SetDistricts(List<string> districts)
        {
            this._districts = districts;
        }

        public List<string> GetDistricts()
        {
            return this._districts;
        }
        public static City operator +(City city, int populationIncrease)
        {
            city._population += populationIncrease;
            return city;
        }

        public static City operator -(City city, int populationDecrease)
        {
            city._population -= populationDecrease;
            return city;
        }

        public static bool operator ==(City city1, City city2)
        {
            if (ReferenceEquals(city1, city2)) return true;
            if (ReferenceEquals(null, city1) || ReferenceEquals(null, city2)) return false;
            return city1._population == city2._population;
        }

        public static bool operator !=(City city1, City city2)
        {
            return !(city1 == city2);
        }

        public static bool operator <(City city1, City city2)
        {
            if (ReferenceEquals(city1, city2)) return false;
            if (ReferenceEquals(null, city1)) return true;
            if (ReferenceEquals(null, city2)) return false;
            return city1._population < city2._population;
        }

        public static bool operator >(City city1, City city2)
        {
            if (ReferenceEquals(city1, city2)) return false;
            if (ReferenceEquals(null, city1)) return false;
            if (ReferenceEquals(null, city2)) return true;
            return city1._population > city2._population;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((City)obj);
        }

        protected bool Equals(City other)
        {
            return _population == other._population;
        }

        public override int GetHashCode()
        {
            return _population;
        }

    }
    internal class cs3 
    { 
        public static void task_3()
        {
            City city1 = new City("Kyiv", "Ukraine", 3000000, "+380", new List<string>() { "Shevchenkivskyi", "Pecherskyi", "Podilskyi" });
            City city2 = new City("New York", "USA", 8400000, "+1", new List<string>() { "Manhattan", "Brooklyn", "Queens" });

            // Перевантаження +
            City city3 = city1 + 1000000;
            Console.WriteLine($"Population Kyiv {city3.GetPopulation()}");

            // Перевантаження -
            City city4 = city2 - 500000;
            Console.WriteLine($"Population New York {city4.GetPopulation()}");

            // Перевантаження ==
            bool isEqual = city1 == city2;
            Console.WriteLine($"Population Kyiv == New York = {isEqual}");

            // Перевантаження <
            bool isSmaller = city1 < city2;
            Console.WriteLine($"Population Kyiv < New York = {isSmaller}"); 

            // Перевантаження >
            bool isGreater = city1 > city2;
            Console.WriteLine($"Population Kyiv > New York = {isGreater}"); 

            // Перевантаження !=
            bool isNotEqual = city1 != city2;
            Console.WriteLine($"Population Kyiv != New York = {isNotEqual}");

            // Перевантаження Equals
            bool isEqual2 = city1.Equals(city2);
            Console.WriteLine($"Population Kyiv =(Equal) New York = {isEqual2}");
        }
    }
}

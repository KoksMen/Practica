using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PR10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country("Belarus", 375);
            country.ChangeName("Mega Belarus");
            country.ChangeCountryCode(37544);

            country.ShowName();
            country.ShowCountryCode();

            country.ShowCounty();

            Console.WriteLine("=====================================");

            Kingdom kingdom = new Kingdom("Russia", 100, "Petr I");
            kingdom.ChangeKing("Petr II");
            kingdom.ChangeName("Mega Russia");
            kingdom.ChangeCountryCode(456);

            kingdom.ShowKing();
            kingdom.ShowName();
            kingdom.ShowCountryCode();

            kingdom.ShowCounty();

            Console.WriteLine("=====================================");

            Monarchy monarch = new Monarchy("Reinhart Impire", 789, "Tanya Von Degurchaff");
            monarch.ChangeMonarch("Tanya Von Degurchaff season 2");
            monarch.ChangeName("Reinchart Impire Pro");
            monarch.ChangeCountryCode(1789);

            monarch.ShowMonarch();
            monarch.ShowName();
            monarch.ShowCountryCode();

            monarch.ShowCounty();

            Console.WriteLine("=====================================");

            Republic republic = new Republic("USA Republic", 9, "Mary Sue");
            republic.ChangePresident("Mary =(");
            republic.ChangeName("USA Republic Colony");
            republic.ChangeCountryCode(13);

            republic.ShowPresident();
            republic.ShowName();
            republic.ShowCountryCode();

            republic.ShowCounty();

            Console.ReadLine();
        }
    }

    public class Country
    {
        public string Name;
        public int CountryCode;
        public Country(string name, int countryCode)
        {
            Name = name;
            CountryCode = countryCode;
        }

        public void ChangeName(string name) { Name = name; }
        public void ShowName() { Console.WriteLine("Name: {0}", Name); }
        public void ChangeCountryCode(int code) { CountryCode = code; }
        public void ShowCountryCode() { Console.WriteLine("Country code: {0}", CountryCode); }
        public virtual void ShowCounty() => Console.WriteLine($"Country name: {Name}\t Country code: {CountryCode}");
    }

    public sealed class Kingdom : Country
    {
        public string King;

        public Kingdom(string name, int countryCode, string king): base(name, countryCode)
        {
            King = king;
        }

        public void ChangeKing(string king) { King = king;}
        public void ShowKing() { Console.WriteLine("King: {0}", King); }

        public override void ShowCounty()
        {
            base.ShowCounty();
            Console.WriteLine($"King name: {King}");
        }
    }

    public class Monarchy : Country
    {
        public string Monarch;

        public Monarchy(string name, int countryCode, string monarch) : base(name, countryCode)
        {
            Monarch = monarch;
        }

        public void ChangeMonarch(string monarch) { Monarch = monarch; }
        public void ShowMonarch() { Console.WriteLine("Monarch: {0}", Monarch); }

        public override void ShowCounty()
        {
            base.ShowCounty();
            Console.WriteLine($"Monarch name: {Monarch}");
        }
    }

    public class Republic : Country
    {
        public string President;

        public Republic(string name, int countryCode, string president) : base(name, countryCode)
        {
            President = president;
        }

        public void ChangePresident(string president) { President = president; }
        public void ShowPresident() { Console.WriteLine("President: {0}", President); }
        public override void ShowCounty()
        {
            base.ShowCounty();
            Console.WriteLine($"President name: {President}");
        }
    }
}

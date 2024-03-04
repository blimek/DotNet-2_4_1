using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkołaDotNet

{
    public class Program

    {

        static void Main(string[] args)
        {
            string imie = "Przemek";
            string nazwisko = "Milke";
            int wiek = 44;
            char plec = 'm';
            string pesel = "79081300000";
            string numerPracownika = "2509324094";

            Console.WriteLine($"Imię :{imie} , Nazwisko: {nazwisko} , Wiek: {wiek} , Płeć: {plec} " +
                              $", Pesel: {pesel} ,Numer Pracownika: {numerPracownika}");

            Console.ReadLine();

        }
    }

}
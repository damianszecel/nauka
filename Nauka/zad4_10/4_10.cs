/*Napisać program, który pobierze datę w formacie DD-MM-RRRR, z której pobierze
miesiąc i wyświetli jego nazwę słownie.*/

using System;
using System.Security.Cryptography.X509Certificates;

namespace zad4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] miesiace = { "Styczeń", "Luty", "Marzec",
                "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień", "Październik", "Listopad", "Grudzien" };
            Console.WriteLine("Podaj date w formacie DD-MM-RRRR");
            string data = Console.ReadLine();
            int x = int.Parse(data.Substring(3, 2));
            Console.WriteLine("Miesiąc urodzenia to {0}", miesiace[x - 1]);
            Console.ReadKey();
        }
    }
}

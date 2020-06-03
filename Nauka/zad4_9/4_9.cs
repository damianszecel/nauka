/*Napisz program obliczający liczbę wyrazów w łańcuchu znaków wprowadzonym przez
użytkownika. Należy przyjąć, że wyrazy to ciągi znaków rozdzielone spacją.*/

using System;

namespace zad4._9
{
    class Program
    {
        static void Main(string[] args)
        {
        Pocz:
            Console.WriteLine("Wprowadz tekst a program obliczy z ilu wyrazów się składa");
            int n = 0;
            int start = 0;
            int pozycja;
            string tekst = Console.ReadLine();
            if (tekst.Length != 0)
            {
                n = 1;
                while ((pozycja = tekst.IndexOf(' ', start)) >= 1)
                {
                    n++;
                    start = pozycja + 1;
                }
            }
            Console.WriteLine("Liczba wyrazow we wprowadzonym tekscie wynosi {0}", n);
            Console.WriteLine("Jezeli chcesz wprowadzic inny ciag wyrazow nacisnij spacje i zatwierdz enterem");
            string a = Console.ReadLine();
            if (a == " ")
            {
                goto Pocz;
            }
            Console.ReadKey();
        }
    }
}

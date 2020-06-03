/*Napisz program analizujący częstość występowania poszczególnych znaków w
łańcuchu znaków wprowadzonym przez użytkownika.Np.dla wprowadzonego tekstu
„abrakadabra” program powinien wyświetlić informacje: a – 5, b – 2, r – 2, k – 1, d – 1.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace zad4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 50;
            //Console.WriteLine("Wprowadz tekst do przeanalizowania");
            //string x = Console.ReadLine();
            string x = "asbsadfwernaskdfieryajsndfnbaweirjhbfsadf;;sdfawp";
            int n1 = x.Length;
            if (n1 < n) { n = n1; }
            // mógłbyś zrobić int n = x.length, a w ogole to ta zmienna tak naprawde jest Ci niepotrzebna bo i tak uzywasz w 2 kolejnych linijkach :P wiec mozesz zrobic new string[x.length]

            string[] tab = new string[n];
            int[] ilosc = new int[n];
            tab[0] = x.Substring(0, 1);
            ilosc[0] = 1;
            int z = 1; bool o;

            // generalnie unika sie tworzenia zmiennych o nazwach z, o, n, bo teraz jak patrze na twoj kod to go w ogole nie rozumiem :P
            // dobrą praktyką jest też tworzenie nazw zmiennych/metod/klas po angielsku - raczej wszedzie się tak pisze teraz

            for (int i = 1; i < x.Length; i++)
            {
                o = true;
                for (int j = 0; j < i; j++)
                {
                    // spoko, ze wiesz juz jak dziala substring, ale w C# string jest też tablicą charów, więc jeżeli chcesz sprawdzić jeden znak to zawsze możesz się odwołać do stringa x[i] 
                    // np if (x[i] == x[j])
                    if (x.Substring(i, 1) == x.Substring(j, 1))
                    {
                        ilosc[j]++;
                        o = false;
                        break;
                    }
                }
                if (o)
                {
                    z++;
                    tab[z - 1] = x.Substring(i, 1);
                    ilosc[z - 1]++;
                }
            }
            for (int k = 0; k < z; k++)
            {
                Console.WriteLine("Liczba znakow {0} wynosi {1}", tab[k], ilosc[k]);
            }

            //moja implementacja tego zadania:
            string stringToCheck = x;
            Dictionary<char, int> numberOfOccurences = new Dictionary<char, int>();
            foreach(char currentChar in stringToCheck)
            {
                if(numberOfOccurences.Keys.Contains(currentChar))
                {
                    numberOfOccurences[currentChar]++;
                }
                else
                {
                    numberOfOccurences.Add(currentChar, 1);
                }
            }

            Console.WriteLine();
            foreach(char key in numberOfOccurences.Keys)
            {
                Console.WriteLine($"Liczba znakow {key} wynosi {numberOfOccurences[key]}");
            }

            Console.ReadKey();

        }
    }
}
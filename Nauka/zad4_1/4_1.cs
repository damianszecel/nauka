/*Napisz program, który pozwoli zapełnić n–elementową tablicę jednowymiarową liczb
całkowitych wartościami podanymi przez użytkownika.Na początku działania programu
użytkownik podaje liczbę elementów tablicy, a następnie poszczególne wartości jej
elementów.Po wypełnieniu całej tablicy program powinien wypisać je w oknie konsoli*/

using System;

namespace zad4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj, ile numerów chciałbyś wprowadzić");
            int x = int.Parse(Console.ReadLine());
            int[] tablica = new int[x];
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("Podaj {0} liczbe", i + 1);
                tablica[i] = int.Parse(Console.ReadLine());
            }
            int b = 0;
            foreach (int z in tablica)
            {
                b++;
                Console.WriteLine("Liczba numer {0} wynosi {1}", b, z);
            }
            Console.ReadKey();
        }
    }
}

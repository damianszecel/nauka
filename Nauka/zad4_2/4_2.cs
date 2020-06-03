using System;

namespace zad4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj wprowadź 10 liczb całkowitych");
            int[] tab1 = new int[10];
            int[] tab2 = new int[10];
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine("Podaj {0} liczbe", i + 1);
                tab1[i] = int.Parse(Console.ReadLine());
                if (tab1[i] > 0)
                {
                    tab2[i] = tab1[i];
                }
            }
            Console.WriteLine("Wartosci danych w drugiej tablicy to");
            int g = 0;
            foreach (int z in tab2)
            {
                g++;
                Console.WriteLine("Wartosc {0} liczby wynosi {1}", g, z);
            }
            Console.ReadKey();
        }
    }
}

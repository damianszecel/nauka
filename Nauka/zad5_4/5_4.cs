using System;

namespace zad5_4
{
    class wersion_a
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int[] tab = new int[number.Next(5, 20)];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = number.Next(5, 20);
                Console.Write("{0,-5}", tab[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Przez ile mnozymy?");
            int MultiplyNumber = int.Parse(Console.ReadLine());
            int[] tab5 =MultiplyTab(tab, MultiplyNumber);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("{0,-5}", tab[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < tab5.Length; i++)
            {
                Console.Write("{0,-5}", tab5[i]);
            }
            Console.ReadKey();
        }

       
        //wersja z tworzeniem nowej tabeli i nie zmienianiem starej
        static int[] MultiplyTab(int[] tab1, int x)
        {
            int[] tab2 = new int[tab1.Length];
            Array.Copy(tab1, tab2, tab1.Length);
            for (int i = 0; i < tab2.Length; i++)
            {
                tab2[i] = tab2[i] * x;
            }
            return tab2;
        }
    }
}

using System;

namespace zad5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dlugosc: ");
            int leng = int.Parse(Console.ReadLine());
            Console.Write("Szerokosc: ");
            int widt = int.Parse(Console.ReadLine());
            Console.Write("Symbol: ");
            string symb = (Console.ReadLine());
            Console.WriteLine();
            Print(leng, widt, symb[0]);
            Console.WriteLine();
            Console.WriteLine("I odwrocony");
            Print(widt, leng, symb[0]);
            Console.ReadKey();
        }

        static void Print(int x, int y, char a)
        {
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

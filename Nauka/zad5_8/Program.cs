using System;

namespace zad5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Liczba naturalna: ");
            int Number = int.Parse(Console.ReadLine());
            int W = NumberSum(Number);
            Console.WriteLine(W);
            Console.ReadKey();

        }

        static int NumberSum(int a)
        {
            if (a != 0)
	        {
                return (a % 10) + NumberSum(a/10);
	        }
            else return (0);
        }
    }
}

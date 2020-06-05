using System;

namespace zad5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Podaj n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = SumNumbers(x, n);
            Console.WriteLine("Suma ciagu wynosi {0}", sum);
            Console.ReadKey();
        }

        static int SumNumbers(int x, int n)
        {
            if (n != 0)
            {
                return (x + n) + SumNumbers(x, (n - 1));
            }
            else return (0);
        }
    }
}

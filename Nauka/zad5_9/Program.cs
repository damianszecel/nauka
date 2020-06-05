using System;

namespace zad5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik ciagu obliczony wynosi {0}", Fibonacci(n));
            Console.WriteLine("Wynik ciagu obliczony za pomoca rekurencji wynosi {0}", FibonacciRek(n));
            Console.ReadKey();
        }

        static int Fibonacci(int a)
        {
            if (a == 0 | a == 1) return 1;
            else return ((a - 1) + (a - 2));
        }

        static int FibonacciRek(int a, int b = 0)
        {
            if (a == 0 | a == 1) return 1;
            if (b < 2)
            {
                b++;
                return (a - b) + FibonacciRek(a, b);
            }
            else return 0;
        }
    }
}

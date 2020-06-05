using System;

namespace zad5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min wartosc przedzialu");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Maksymalna wartosc przedzialu");
            int maxValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Sprawdzanan wartosc");
            int checkValue = int.Parse(Console.ReadLine());
            if (CheckBelong(minValue,maxValue,checkValue))
            {
                Console.WriteLine("Liczba nalezy do przedziału");
            }
            else
            {
                Console.WriteLine("Liczba nie nalezy do przedzialu");
            }
            Console.ReadKey();
        }

        static bool CheckBelong(int x, int y, int z)
        {
            bool a = false;
            if (z > x && z < y)
            {
                a = true;
            }
            return a;
        }
    }
}

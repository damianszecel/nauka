using System;

namespace zad5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temp w stopniach Fahrenheita");
            double temp = double.Parse(Console.ReadLine());
            Console.WriteLine("Podana temp to {0} stopni celsjusza", CountToC(temp));
            Console.ReadKey();
        }

        static double CountToC (double x)
        {
            return 5 * (x - 32) / 9;
            //return (x - 32) * (5 / 9); - dlaczego taki zapis nie dziala?
        }
    }
}

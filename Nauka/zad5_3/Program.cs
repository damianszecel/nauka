using System;
using System.Xml.Schema;

namespace zad5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wartosc x punktu");
            double PointX = double.Parse(Console.ReadLine());
            Console.WriteLine("Wartosc y punktu");
            double PointY = double.Parse(Console.ReadLine());
            AddVector(ref PointX, ref PointY);
            Console.WriteLine("Wspolrzedne vectora po przesunieciu ({0},{1})", PointX, PointY);
            Console.ReadKey();
        }

        static void AddVector(ref double a, ref double b)
        {
            double vectorA = 3; double vectorB = 2;
            a += vectorA;
            b += vectorB;
        }
    }
}

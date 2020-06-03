using System;

namespace zad4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] dnitygodnia = new string[7, 3]
            {
                { "Poniedziałek", "Monday", "Montag" },
                { "Wtorek", "Tuesday", "Dienstag" },
                { "Środa", "Wednesday", "Mittwoch" },
                { "Czwartek", "Thursday", "Donnerstag" },
                { "Piątek", "Friday", "Freitag" },
                { "Sobota", "Saturday", "Samstag" },
                { "Niedziela", "Sunday", "Sonntag" },
            };
            for (int i = 0; i < dnitygodnia.GetLength(0); i++)
            {
                for (int j = 0; j < dnitygodnia.GetLength(1); j++)
                {
                    Console.Write("{0} ,", dnitygodnia[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

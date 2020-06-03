using System;

namespace zad1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tab =
                { {"Damian" , "Nikola"} , {"Damiancio" , "Niki"} , { "Damiano" , "Nikolo" } };
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write("{0, -10}", tab[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            
        }
    }
}

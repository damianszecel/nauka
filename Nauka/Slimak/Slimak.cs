using System;

namespace Slimak
{
    class Slimak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj wprowadz liczbe wierszy");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Witaj wprowadz liczbe kolumn");
            int y = int.Parse(Console.ReadLine());
            int[,] tab = new int[x, y];
            int a = 1;
            for (int rz = 0; a <= tab.Length; rz++)
            {
                for (int i = (tab.GetLength(0) - rz); i > rz; i--) //pionowy
                {
                    tab[i - 1, rz] = a;
                    a++;
                }
                if (a > tab.Length) { goto Koniec; }
                for (int j = 1 + rz; j < (tab.GetLength(1) - rz); j++) //poziomy
                {
                    tab[rz, j] = a;
                    a++;
                }
                if (a > tab.Length) { goto Koniec; }
                for (int k = 1 + rz; k < (tab.GetLength(0) - rz); k++) //pionowy
                {
                    tab[k, (tab.GetLength(1) - (1 + rz))] = a;
                    a++;
                }
                if (a > tab.Length) { goto Koniec; }
                for (int l = (tab.GetLength(1) - (1 + rz)); l > 1 + rz; l--) //poziomy
                {
                    tab[(tab.GetLength(0) - (1 + rz)), l - 1] = a;
                    a++;
                }
                if (a > tab.Length) { goto Koniec; }

            }
        Koniec:
            Console.WriteLine();
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write("{0, -5}", tab[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}

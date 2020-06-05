using System;

namespace zad5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab = { "Dam", "Niki", "Roc" };
            Console.Write("Ile razy chcesz dokleic tekst");
            int x = int.Parse(Console.ReadLine());
            MultiplyText(tab, x);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.ReadKey();
                
        }

        static void MultiplyText(string[] tab1, int a)
        {
            string zm;
            for (int i = 0; i < tab1.Length; i++)
            {
                zm = tab1[i];
                for (int j = 1; j < a; j++)
                {
                    tab1[i] += zm; 
                }
            }
        }
            
            
       
    }
}

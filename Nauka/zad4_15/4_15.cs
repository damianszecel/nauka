using System;
using System.Threading;

namespace zad4._15
{
    class Program
    {
        static void Main(string[] args)
        {
        Pocz:
            int a = 0;
            Console.WriteLine("Wprowadź tekst");
            string tekst = Console.ReadLine();
            string zmieniony = "";
            int x = tekst.Length;
            string y;
            for (int i = 0; i < x; i++)
            {
                y = tekst.Substring(i, 1);
                if (tekst.Substring(i, 1) == "G") zmieniony += "A";
                else if (tekst.Substring(i, 1) == "G") zmieniony += "A";
                else if (tekst.Substring(i, 1) == "A") zmieniony += "G";
                else if (tekst.Substring(i, 1) == "D") zmieniony += "E";
                else if (tekst.Substring(i, 1) == "E") zmieniony += "D";
                else if (tekst.Substring(i, 1) == "R") zmieniony += "Y";
                else if (tekst.Substring(i, 1) == "Y") zmieniony += "R";
                else if (tekst.Substring(i, 1) == "P") zmieniony += "O";
                else if (tekst.Substring(i, 1) == "O") zmieniony += "P";
                else if (tekst.Substring(i, 1) == "L") zmieniony += "U";
                else if (tekst.Substring(i, 1) == "U") zmieniony += "L";
                else if (tekst.Substring(i, 1) == "K") zmieniony += "I";
                else if (tekst.Substring(i, 1) == "I") zmieniony += "K";
                else zmieniony += y;
            }
            Console.WriteLine("tekst bo zaszyfrowaniu brzmi {0}.", zmieniony);
            Console.WriteLine("Jesli chcesz zaczac na nowo wpisz 1 i zatwierdz enterem");
            a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                goto Pocz;
            }
            Console.ReadKey();
        }
    }
}

// GA DE RY PO LU KI

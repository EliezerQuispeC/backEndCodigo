using System;

namespace Ej9
{
    class Program
    {
        static int[,] tienda = new int[,] { { 1, 2, 3 }, { 4, 5, 6,}, { 7, 8, 9} };
        static void Main(string[] args)
        {
            Console.WriteLine(tienda[1,2]);
            Console.ReadKey();
        }
    }
}

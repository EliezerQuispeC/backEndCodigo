using System;

namespace Ejercicio1
{
    class Program
    {
        static int[] LlenarArray()
        {
            int[] Arreglo = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return Arreglo;
        }
        
        static void ImprimirArray(int[]Arreglo)
        {
            foreach (int item in Arreglo)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            ImprimirArray(LlenarArray());
            Console.ReadLine();
        }
    }
}

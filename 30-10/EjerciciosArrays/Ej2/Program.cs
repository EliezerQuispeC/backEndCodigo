using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimirArray(LlenarArray(IniciarArray()));
            Console.ReadKey();
        }

        static int[] IniciarArray()
        {
            int n = Int16.Parse(Console.ReadLine());
            int[] Arreglo = new int[n];
            return Arreglo;
        }
        static int[] LlenarArray(int[] Arreglo)
        {
            for (int i = 1; i <= Arreglo.Length; i++)
            {
                Arreglo[i - 1] = i * 2;
            }
            return Arreglo;
        }

        static void ImprimirArray(int []Arreglo)
        {
            foreach (int item in Arreglo)
            {
                Console.Write($"[{item}]");
            }
        }
    }
}

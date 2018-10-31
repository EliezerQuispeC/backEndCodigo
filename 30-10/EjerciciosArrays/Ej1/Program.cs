using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimirArray(LlenarArray());
            
        }

        static int[] LlenarArray()
        {
            int[] A = new int[10];
            for (int i = 1; i <= 10; i++)
            {
                A[i - 1] = i * 2;
            }
            return A;
        }
        static void ImprimirArray(int[] A)
        {
            foreach (var item in A)
            {
                Console.Write($"[{item}]");
            }
        }
    }
}

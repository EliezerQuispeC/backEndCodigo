using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[3] { 1, 2, 3 };
            int suma = SumarElementosRecur(A, A.Length-1);
            Console.WriteLine(suma);
            //ImprimirArray(LlenarArray());
            Console.ReadKey();
        }
        static int[] LlenarArray()
        {
            int N = Int16.Parse(Console.ReadLine());
            int[] Arreglo = new int[N];
            Random Aleatorio = new Random();
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Arreglo[i] = Aleatorio.Next(0, 20);
            }
            return Arreglo;
        }
        static void ImprimirArray(int[] Arreglo)
        {
            int i = 0, sumatoria = 0;
            foreach (int item in Arreglo)
            {
                Console.WriteLine($"{i.ToString()} => [{item}]");
                i++;
                sumatoria = sumatoria + item;
            }
            Console.WriteLine($"Sumatoria = {sumatoria}");
        }

        static int SumarElementosRecur(int []A,int lenght)
        {
            if (lenght == -1) return 0;
            return A[lenght] + SumarElementosRecur(A, lenght - 1);
        }
    }
}

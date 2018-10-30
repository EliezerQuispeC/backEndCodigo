using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimirArray(LlenarArray());
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
    }
}

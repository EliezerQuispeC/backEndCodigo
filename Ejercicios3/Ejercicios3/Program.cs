using System;

namespace Ejercicios3
{
    class Program
    {
        static float Ejercicio1a()
        {
            Console.WriteLine("Ingrese la cantidad de notas a registrar");
            int nota = int.Parse(Console.ReadLine());
            float acumulador = new float();
            float[] notas = new float[nota];
            for (int i = 0; i < nota; i++)
            {
                Console.WriteLine($"Ingrese la {i+1} nota");
                notas[i] = float.Parse(Console.ReadLine());
                acumulador = acumulador + notas[i];
            }
            return (acumulador / nota);
        }
        static void Ejercicio1b(float prom)
        {
            if(prom >= 10.5)
            {
                Console.WriteLine($"Su promedio es de {prom}. Usted ha aprobado");
            }
            else
            {
                Console.WriteLine($"Su promedio es de {prom}. Usted no ha aprobado");
            }
        }

        static float[] LlenarArray()
        {
            Console.WriteLine("Ingrese cuántos números desea ordenar :");
            int nros = Int16.Parse(Console.ReadLine());
            float[] numeros = new float[nros];
            for (int i = 0; i < nros; i++)
            {
                Console.WriteLine($"Ingrese el {i + 1} numero");
                numeros[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sin ordenar : ");
            foreach (var item in numeros)
            {
                Console.Write($"[{item.ToString()}]");
            }
            return numeros;
        }
        static void OrdenarArray(float[]array)
        {
            float[] numeros = array;
            
            float aux = new float();
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length - 1 ; j++)
                {
                    if(numeros[j] > numeros[j + 1])
                    {
                        aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("\nOrdenados : ");
            foreach(var item in numeros)
            {
                Console.Write($"[{item.ToString()}]");
            }
        }
        static int LeerNumero()
        {
            Console.WriteLine("Ingrese el número");
            int numero = Int16.Parse(Console.ReadLine());
            return numero;
        }
        public static int factorial(int nro)//Método recursivo
        {
            if (nro == 1)
                return 1;
            return nro * factorial(nro - 1);
        }

        static void Sumatoria(int nro)
        {
            int acumulador = new Int16();
            for (int i = 1; i <= nro; i++)
            {
                acumulador = acumulador + i;
            }
            Console.WriteLine($"La sumatoria es {acumulador}");
        }
        static int Sumatoria1(int nro)//Método recursivo
        {
            if (nro == 1)
                return 1;
            return nro + Sumatoria1(nro - 1);
        }

        static int[] LeerBaseYExponente()
        {
            int[] numeros = new int[2];
            Console.WriteLine("Ingrese la base");
            numeros[0] = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el exponente");
            numeros[1] = Int16.Parse(Console.ReadLine());
            return numeros;
        }

        static void Potencia(int[] numeros)
        {
            int b = numeros[0];
            int e = numeros[1];
            int resultado = 1;
            for (int i = 1; i <= e; i++)
            {
                resultado = resultado * b;
            }
            Console.WriteLine($"El resultado es : {resultado}");
        }
        public static int Potencia1(int nro)//Método recursivo
        {
            if (nro == 1)
                return 1;
            return nro * Potencia1(nro - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("_________________Ingrese el nro de ejercicio:_________________");
            int opc = Int16.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Ejercicio1b(Ejercicio1a());
                    break;
                case 2:
                    OrdenarArray(LlenarArray());
                    break;
                case 3:
                    Console.WriteLine($"El resultado es : {factorial(LeerNumero())}");
                    break;
                case 5:
                    Sumatoria(LeerNumero());
                    break;
                case 6:
                    Console.WriteLine($"El resultado es : {Sumatoria1(LeerNumero())}");
                    break;
                case 7:
                    Potencia(LeerBaseYExponente());
                    break;
                default:
                    break;
            }
        }
    }
}

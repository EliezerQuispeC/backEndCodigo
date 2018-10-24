using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios2
{
    class Program
    {
        static void Ejercicio1()
        {
            int acumulador = 0;
            for(int i = 1; i <= 7; i++)
            {
                Console.WriteLine("Ingrese la " + i + " nota");
                acumulador = acumulador + Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("El promedio es : " + (acumulador / 7)); 
        }

        static void Ejercicio2()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Número " + i + "; Cubo " + Math.Pow(i,3) + "; Cuarta" + Math.Pow(i,4));
            }
        }

        static void Ejercicio3()
        {
            string acumulador = "";
            int x = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese el " + i + " número");
                x = Int32.Parse(Console.ReadLine());
                if (x > 0)
                {
                    acumulador = acumulador  + x.ToString() + ",";
                }
            }
            Console.WriteLine("Los positivos " + acumulador);
        }
        static void Ejercicio4()
        {
            Console.WriteLine("Ingrese 20 números");
            int[] numeros = new int[20];
            int positivos = 0;
            int negativos = 0;
            int neutros = 0;
            for (int i = 0; i < 20; i++)
            {
                numeros[i] = Int32.Parse(Console.ReadLine());
                if (numeros[i] > 0)
                {
                    positivos++;
                }
                else if (numeros[i] < 0)
                {
                    negativos++;
                }
                else
                {
                    neutros++;
                }
            }
            Console.WriteLine("Positivos : " + positivos + " Negativos : " + negativos + " Neutros : " + neutros);
        }

        static void Ejercicio5()
        {
            int numero = 0;
            string acumulador = "";

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Ingrese el " + (i + 1) + " número");
                numero = Int32.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    Console.WriteLine("Por favor ingrese un número negativo");
                    i--;
                }
                else
                {
                    acumulador = acumulador + Math.Abs(numero) + ",";
                }
            }
            Console.WriteLine("Números convertidos : " + acumulador);
        }

        static void Ejercicio6()
        {
            int[] notas = new int[10]{10, 15, 12, 04, 17, 29, 08, 20, 13, 15};
            int nota1 = notas[0];
            int aux = 0;

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 9; j > 0; j--)
                {
                    aux = j - 1; 
                    if (notas[j] < notas[aux])
                    {
                        nota1 = notas[aux];
                        notas[aux] = notas[j];
                        notas[j] = nota1;
                    }
                }
            }
            foreach(var item in notas)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void Ejercicio8()
        {
            int h = 8;
            int m = 30;
            int s = 01;
            int x;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Son las {0}:{1}:{2}", h, m, s);
                x = Environment.TickCount;
                while (Environment.TickCount <= x + 1000) ;
                s = s + 1;

                if (s == 60)
                {
                    s = 0;
                    m = m + 1;
                    if (m == 60)
                    {
                        m = 0;
                        h = h + 1;
                        if (h == 24)
                        {
                            h = 0;

                        }
                    }
                }
            }
        }

        public static void Ejercicio12()
        {
            int contador = 0;
            while (contador <= 100)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }

        static void Ejercicio16()
        {
            int contador1 = 1;
            int contador2 = 2;
            while (contador1 < 1000)
            {
                Console.WriteLine(contador1);
                contador1 += 2;
            }
            while (contador2 <= 1000)
            {
                Console.WriteLine(contador2);
                contador2 += 2;
            }
        }

        static void Ejercicio20()
        {
            int contador1 = 2;
            int contador2 = 3;
            int contador3 = 4;
            string linea1 = "";
            string linea2 = "";
            string linea3 = "";
            while (contador1 <= 200)
            {
                linea1 = linea1 + " " + contador1.ToString();
                contador1 += 2;
            }
            while (contador2 <= 300)
            {
                linea2 = linea2 + " " + contador2.ToString();
                contador2 += 3;
            }
            while (contador3 <= 400)
            {
                linea3 = linea3 + " " + contador3.ToString();
                contador3 += 4;
            }
            Console.WriteLine(linea1);
            Console.WriteLine("******************************************************");
            Console.WriteLine(linea2);
            Console.WriteLine("******************************************************");
            Console.WriteLine(linea3);
        }

        static void Ejercicio21()
        {
            int x = 0;
            int resultado = 0;
            while (x <= 10)
            {
                resultado = (3 * x) + (2 * x) - 5;
                Console.WriteLine("Para " + x + " el resultado es : " + resultado);
                x++;
            }
        }
        
        static void Ejercicio22()
        {
            int x = 0;
            int resultado = 0;
            while (x <= 40)
            {
                resultado = (3 * x) + 15 - (2 * (2 * x)) + 3;
                Console.WriteLine("Para " + x + " el resultado es : " + resultado);
                x += 2;
            }
        }
        
        static void Ejercicio23()
        {
            double x = -10;
            double resultado = 0;
            Console.WriteLine("Ingrese la variable N");
            int n = Int32.Parse(Console.ReadLine());
            while(x <= n)
            {
                resultado = (4/(3 * x) - (2 * x)) / (x + 3);
                Console.WriteLine("Para " + x + " el resultado es : " + resultado);
                x += 0.5;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de ejercicio a resolver:");
            int opc = Int32.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;
                case 4:
                    Ejercicio4();
                    break;
                case 5:
                    Ejercicio5();
                    break;
                case 6:
                    Ejercicio6();
                    break;
                case 8:
                    Ejercicio8();
                    break;
                case 12:
                    Ejercicio12();
                    break;
                case 16:
                    Ejercicio16();
                    break;
                case 20:
                    Ejercicio20();
                    break;
                case 21:
                    Ejercicio21();
                    break;
                case 22:
                    Ejercicio22();
                    break;
                case 23:
                    Ejercicio23();
                    break;
            }
        }
    }
}

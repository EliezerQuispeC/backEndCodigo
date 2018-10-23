using System;
using Operaciones;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu calculadora - Elija una opción");
            Console.WriteLine("(1) Suma");
            Console.WriteLine("(2) Resta");
            Console.WriteLine("(3) Multiplicación");
            Console.WriteLine("(4) División");
            Console.WriteLine("(5) Potencia");
            Console.WriteLine("(6) Raiz");
            Console.WriteLine("(7) Resto");
            int opc = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el primer número");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int n2 = Int32.Parse(Console.ReadLine());
            double resultado;
            switch (opc)
            {
                case 1:
                    resultado = Opera.Suma(n1,n2);
                    Console.WriteLine("El resultado de la suma es : " + resultado);
                    break;
                case 2:
                    resultado = Opera.Resta(n1, n2);
                    Console.WriteLine("El resultado de la resta es : " + resultado);
                    break;
                case 3:
                    resultado = Opera.Multiplicacion(n1, n2);
                    Console.WriteLine("El resultado de la multiplicación es : " + resultado);
                    break;
                case 4:
                    resultado = Opera.Division(n1, n2);
                    Console.WriteLine("El resultado de la división es : " + resultado);
                    break;
                case 5:
                    resultado = Opera.Potencia(n1, n2);
                    Console.WriteLine("El resultado de la potencia es  : " + resultado);
                    break;
                case 6:
                    resultado = Opera.Raiz(n1, n2);
                    Console.WriteLine("El resultado de la raiz es : " + resultado);
                    break;
                case 7:
                    resultado = Opera.Resto(n1, n2);
                    Console.WriteLine("El resultado del resto es : " + resultado);
                    break;
                default:
                    Console.WriteLine("No seleccionó una opción correcta. Adios ;)");
                    break;
            }

            Console.ReadKey();
            
            
            
        }
    }
}

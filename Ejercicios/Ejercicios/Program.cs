using System;
using Funciones;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar) { 
                Console.WriteLine("Elija el ejercicio a resolver");
                Console.WriteLine("1 - Primo");
                Console.WriteLine("2 - Par o impar");
                Console.WriteLine("3 - Dia de la semana");
                Console.WriteLine("4 - Mes");
                Console.WriteLine("5 - 3 numeros menor a mayor");
                Console.WriteLine("6 - Positivo o negativo");
                Console.WriteLine("7 - Es vocal");
                Console.WriteLine("8 - 10 numeros el mayor y menor");
                Console.WriteLine("9 - 3 numeros el tercero igual al primero");
                Console.WriteLine("11 - Sueldo de acuerdo al año");


                int opc = Int32.Parse(Console.ReadLine());
                int num,num2,num3,num4,num5,num6,num7,num8,num9,num10;
                string letra;
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Ingresa un numero del 1 al 5");
                        num = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(Funcion.Ejercicio1(num));
                        break;
                    case 2:
                        Console.WriteLine("Ingresa un numero");
                        num = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(Funcion.Ejercicio2(num));
                        break;
                    case 3:
                        Console.WriteLine("Ingresa un numero del 1 al 7");
                        num = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(Funcion.Ejercicio3(num));
                        break;
                    case 4:
                        Console.WriteLine("Ingresa un numero del 1 al 12");
                        num = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(Funcion.Ejercicio4(num));
                        break;
                    case 5:
                        Console.WriteLine("Ingrese tres numeros");
                        num = Int32.Parse(Console.ReadLine());
                        num2 = Int32.Parse(Console.ReadLine());
                        num3 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(Funcion.Ejercicio5(num,num2,num3));
                        break;
                    case 6:
                        Console.WriteLine("Ingresa un numero");
                        num = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(Funcion.Ejercicio6(num));
                        break;
                    case 7:
                        Console.WriteLine("Ingresa una letra");
                        letra = Console.ReadLine();
                        Console.WriteLine(Funcion.Ejercicio7(letra));
                        break;
                    case 8:
                        Console.WriteLine("Ingrese diez numeros");
                        num = Int32.Parse(Console.ReadLine());
                        num2 = Int32.Parse(Console.ReadLine());
                        num3 = Int32.Parse(Console.ReadLine());
                        num4 = Int32.Parse(Console.ReadLine());
                        num5 = Int32.Parse(Console.ReadLine());
                        num6 = Int32.Parse(Console.ReadLine());
                        num7 = Int32.Parse(Console.ReadLine());
                        num8 = Int32.Parse(Console.ReadLine());
                        num9 = Int32.Parse(Console.ReadLine());
                        num10 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(Funcion.Ejercicio8(num,num2,num3,num4,num5,num6,num7,num8,num9,num10));
                        break;
                    case 9:
                        Console.WriteLine("Ingrese tres numeros");
                        num = Int32.Parse(Console.ReadLine());
                        num2 = Int32.Parse(Console.ReadLine());
                        num3 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(Funcion.Ejercicio9(num, num2, num3));
                        break;
                    case 11:
                        Console.WriteLine("Ingrese la cantidad de años");
                        num = Int32.Parse(Console.ReadLine());
                        num2 = 50000;
                        double aumento = 0;
                        if (num < 3)
                        {
                            aumento = num2 * 0.03;
                        }
                        if (num >= 3 && num < 5)
                        {
                            aumento = num2 * 0.05;
                        }
                        if (num >= 5 && num < 10)
                        {
                            aumento = num2 * 0.07;
                        }
                        if (num >= 10)
                        {
                            aumento = num2 * 0.1;
                        }
                        Console.WriteLine("El aumento es de : " + aumento);
                        break;
                    default:
                        Console.WriteLine("Ingrese una opción válida");
                        break;
                }
                Console.WriteLine("Desea continuar : S/N");
                string respuesta = Console.ReadLine().ToUpper();
                if(respuesta != "S"){
                    continuar = false;
                }
            }
        }
    }
}

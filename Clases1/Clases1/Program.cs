using System;
using Clases1.MisClases;

namespace Clases1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo m = new Moto("VH-32",enumColores.ROJO,"KAWA-777","1000");
            Vehiculo a = new Auto("VH4-432",enumColores.AZUL,"MUST-1234",3);
            Console.ReadKey();
        }
    }
}

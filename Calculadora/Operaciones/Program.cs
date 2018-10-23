using System;

namespace Operaciones
{
    
    public class Opera
    {
        public static int Suma(int n1, int n2)
        {
            int resultado = n1 + n2;
            return resultado;
        }
        public static int Resta(int n1, int n2)
        {
            int resta = n1 - n2;
            return resta;
        }
        public static int Multiplicacion(int n1, int n2)
        {
            int resultado = n1 * n2;
            return resultado;
        }
        public static double Division(int n1, int n2)
        {
            double resultado = n1 / n2;
            return resultado;
        }
        public static double Potencia(int n1, int n2)
        {
            double resultado = Math.Pow(n1,n2);
            return resultado;
        }
        public static double Raiz(int n1, int n2)
        {
            double raiz = 1 / n2;
            double resultado = Math.Pow(n1, raiz);
            return resultado;
        }

        public static int Resto(int n1, int n2)
        {
            int resultado = n1 % n2;
            return resultado;
        }

        static void Main(string[] args)
        {
           
        }


    }
}

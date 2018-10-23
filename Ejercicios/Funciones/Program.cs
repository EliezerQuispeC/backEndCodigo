using System;

namespace Funciones
{
    public class Funcion
    {
        public static string Ejercicio1(int n1)
        {
            double num1 = n1, num2, num3, num4;
            num2 = num1 / 2;
            num3 = num1 / 3;
            num4 = num1 / 5;

            string respuesta;
            if (num2 == 1 || num3 == 1 || num4 == 1)
            {
                respuesta = "Es primo";
            }
            else
            {
                respuesta = "No es primo";
            }
            return respuesta;
        }
        public static string Ejercicio2(int n1)
        {
            string respuesta;
            if (n1%2 == 0)
            {
                respuesta = "Es par";
            }
            else
            {
                respuesta = "Es impar";
            }
            return respuesta;
        }

        public static string Ejercicio3(int n1)
        {
            int dia = n1;
            switch (dia){
                case 1:
                    return "Es lunes";
                case 2:
                    return "Es martes";
                case 3:
                    return "Es miércoles";
                case 4:
                    return "Es jueves";
                case 5:
                    return "Es viernes";
                case 6:
                    return "Es sábado";
                case 7:
                    return "Es domingo";
                default:
                    return "No ingreso un número correcto";
            }
        }

        public static string Ejercicio4(int n1)
        {
            int mes = n1;
            switch (mes)
            {
                case 1:
                    return "Es enero";
                case 2:
                    return "Es febrero";
                case 3:
                    return "Es marzo";
                case 4:
                    return "Es abril";
                case 5:
                    return "Es mayo";
                case 6:
                    return "Es junio";
                case 7:
                    return "Es julio";
                case 8:
                    return "Es agosto";
                case 9:
                    return "Es septiembre";
                case 10:
                    return "Es octubre";
                case 11:
                    return "Es noviembre";
                case 12:
                    return "Es diciembre";
                default:
                    return "No ingreso un número correcto";
            }
        }

        public static string Ejercicio5(int n1, int n2, int n3)
        {
            int numero1 = n1, numero2 = n2, numero3 = n3;
            if (numero1 < numero2)
            {
                if(numero1 < numero3)
                {
                    if(numero2 < numero3)
                    {
                        return numero1 + " " + numero2 + " " + numero3;
                    }
                    else
                    {
                        return numero1 + " " + numero3 + " " + numero2;
                    }
                }
                else
                {
                    return numero3 + " " + numero1 + " " + numero2;
                }
            }
            else
            {
                if(numero2 < numero3)
                {
                    if(numero1 < numero3)
                    {
                        return numero2 + " " + numero1 + " " + numero3;
                    }
                    else
                    {
                        return numero2 + " " + numero3 + " " + numero1;
                    }
                }
                else
                {
                    return numero3 + " " + numero2 + " " + numero1;
                }
            }
        }

        public static string Ejercicio6(int n1)
        {
            int numero1 = n1;
            if(numero1 >= 0)
            {
                return "Es positivo";
            }
            else
            {
                return "Es negativo";
            }
        }

        public static string Ejercicio7(string letras)
        {
            string letra = letras;
            if(letra=="a"|| letra=="e"|| letra=="i" || letra == "o" || letra == "u")
            {
                return "Es vocal";
            }
            else
            {
                return "No es vocal";
            }
        }

        public static string Ejercicio8(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9, int n10)
        {
            int nn1 = n1, nn2 = n2, nn3 = n3, nn4 = n4, nn5 = n5, nn6 = n6, nn7 = n7, nn8 = n8, nn9 = n9, nn10 = n10;
            int[] numeros = {nn1,nn2,nn3,nn4,nn5,nn6,nn7,nn8,nn9,nn10};
            int mayor = numeros[0];
            int menor = numeros[0];
            for(int i = 1; i < 10; i++)
            {
                if(mayor < numeros[i])
                {
                    mayor = numeros[i];
                }
                if(menor > numeros[i])
                {
                    menor = numeros[i];
                }
            }
            return "El mayor es : " + mayor + " y el menor es : " + menor;
        }

        public static string Ejercicio9(int n1, int n2, int n3)
        {
            int nn1 = n1, nn2 = n2, nn3 = n3;
            int suma = nn1 + nn2;
            if (suma == nn3)
            {
                return "El tercero es igual a la suma de los dos";
            }
            else
            {
                return "El tercero no es igual";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

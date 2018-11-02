
using System;

namespace Ej10
{
    class Program
    {
        static void Main(string[] args)
        {
            TablaClientes();
            Console.ReadKey();
        }

        static string [,] TablaClientes()
        {
            string[,] TablaClientes;
            TablaClientes = new string[,] { { "0", "44215568", "123489" ,"Giancarlo", "Gamarra", "23", "1000.00"} };
            return TablaClientes;
        }
        static void CrearCliente(string[,] TablaClientes)
        {
            string indice = TablaClientes.Length.ToString();
            Console.WriteLine("Ingrese el DNI del cliente");
            string dni = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del cliente");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del cliente");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del cliente");
            string edad = Console.ReadLine();
            Console.WriteLine("Ingrese el saldo del cliente");
            string saldo = Console.ReadLine();
            TablaClientes = new string[,] { { indice, dni, nombre, apellido, edad, saldo } };
            Console.WriteLine("El cliente se ha creado exitosamente");
        }

        static int BuscarCliente(string [,] TablaClientes)
        {
            Console.WriteLine("Ingrese el DNI o la Contraseña del cliente");
            string dato = Console.ReadLine();
            bool bandera = true;
            if(dato.Length == 8)
            {
                for (int i = 0; i < TablaClientes.GetLength(0); i++)
                {
                    if(TablaClientes[i,1] == dato)
                    {
                        bandera = false;
                        return Int16.Parse(TablaClientes[i, 0]);
                    }
                }
                if (bandera)
                {
                    return -1;
                }
            }
            else
            {
                for (int i = 0; i < TablaClientes.GetLength(0); i++)
                {
                    if (TablaClientes[i, 2] == dato)
                    {
                        bandera = false;
                        return Int16.Parse(TablaClientes[i, 0]);
                    }
                }
                if (bandera)
                {
                    return -1;
                }
            }
        }
        static void Retiro(string[,] TablaClientes)
        {
            int codigo = BuscarCliente(TablaClientes);
            if (codigo != -1)
            {
                Console.WriteLine("Ingrese el monto a retirar");
                int monto = Int16.Parse(Console.ReadLine());
                if (monto > 0)
                {
                    int saldo = Int16.Parse(TablaClientes[codigo, 6]);
                    if (saldo >= monto)
                    {
                        saldo = saldo - monto;
                        TablaClientes[codigo, 6] = saldo.ToString();
                        Console.WriteLine($"Retiro completado, su nuevo saldo es {saldo}");
                    }
                    else
                    {
                        Console.WriteLine("Retiro denegado, usted no tiene suficiente saldo");
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un monto mayor a 0");
                }
            }
            else
            {
                Console.WriteLine("Datos erroneos, por favor ingrese sus datos nuevamente");
            }
        }

        static void Deposito(string[,] TablaClientes)
        {
            int codigo = BuscarCliente(TablaClientes);
            if(codigo != -1)
            {
                Console.WriteLine("Ingrese el monto a depostar");
                int monto = Int16.Parse(Console.ReadLine());
                if(monto > 0)
                {
                    int saldo = Int16.Parse(TablaClientes[codigo, 6]) + monto;
                    TablaClientes[codigo, 6] = saldo.ToString();
                    Console.WriteLine($"Deposito completado, su nuevo saldo es {saldo}");
                }
                else
                {
                    Console.WriteLine("Ingrese un monto mayor a 0");
                }

            }
        }

    }
}

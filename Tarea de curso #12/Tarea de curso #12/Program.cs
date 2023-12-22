using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_curso__12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreAr, apellidoAr, direccionAr, rtcAr;
            double saltoAr, montoAr;

            Console.WriteLine("Estás a punto de crear una cuenta, presiona cualquier tecla para continuar: ");
            Console.ReadKey();

            Console.Write("Nombre: ");
            nombreAr = Console.ReadLine();

            Console.Write("Apellido: ");
            apellidoAr = Console.ReadLine();

            Console.Write("Direccion: ");
            direccionAr = Console.ReadLine();

            Console.Write("RTC: ");
            rtcAr = Console.ReadLine();

            Console.Write("Saldo inicial: ");
            saltoAr = Convert.ToDouble(Console.ReadLine());

            CuentaBancaria Cliente1 = new CuentaBancaria(nombreAr, apellidoAr, direccionAr, rtcAr, saltoAr);

            Console.WriteLine("Felicidades, su cuenta ha sido creada con éxito, presione cualquier tecla para continuar");
            Console.ReadKey();

            int opcion;
            //menu
            do
            {
                Console.WriteLine("\n1. Deposito");
                Console.WriteLine("2. Retiro");
                Console.WriteLine("3. Consultar Saldo");
                Console.WriteLine("4. Mostrar información de la cuenta");
                Console.WriteLine("5. Salir");

                Console.Write("\nElige la opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Digite el Monto a depositar: ");
                        montoAr = Convert.ToDouble(Console.ReadLine());
                        Cliente1.Deposito(montoAr);
                        break;

                    case 2:
                        Console.Write("Digite el Monto a retirar: ");
                        montoAr = Convert.ToDouble(Console.ReadLine());
                        Cliente1.Retiro(montoAr);
                        break;

                    case 3:
                        double saldoConsulta = Cliente1.ConsultarSaldo();
                        Console.WriteLine("Saldo actual: " + saldoConsulta);
                        break;

                    case 4:
                        Console.WriteLine(Cliente1.ToString());
                        break;

                    case 5:
                        break;
                }

            } while (opcion != 5);
        }

        class CuentaBancaria
        {
            private string nombre, apellido, direccion, rtc;
            private double saldo;

            public CuentaBancaria(string nombre1, string apellido1, string direccion1, string rtc1, double saldo1)
            {
                nombre = nombre1;
                apellido = apellido1;
                direccion = direccion1;
                rtc = rtc1;
                saldo = saldo1;
            }

            public double Deposito(double montopa)
            {
                saldo += montopa;
                Console.WriteLine("Depósito exitoso. Nuevo saldo: " + saldo);
                return saldo;
            }

            public double Retiro(double montopa)
            {
                if (montopa < saldo)
                {
                    saldo -= montopa;
                    Console.WriteLine("Retiro exitoso. Nuevo saldo: " + saldo);
                    return saldo;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                    return -1;
                }
            }

            public double ConsultarSaldo()
            {
                return saldo;
            }

            public override string ToString()
            {
                return "Nombre: " + nombre + "\nApellido: " + apellido + "\nDireccion: " + direccion + "\nRTC: " + rtc + "\nSaldo: " + saldo;
            }
        }
    }
}


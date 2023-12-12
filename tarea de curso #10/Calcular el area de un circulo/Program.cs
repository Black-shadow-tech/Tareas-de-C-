using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_el_area_de_un_circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opc;
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Circulo");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Rectangulo");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("A cual le deseas calcular el area? ");
            Console.Write("Nombre de la figura: ");
            opc = Convert.ToString(Console.ReadLine());

            switch (opc)
            {
                case "Circulo":
                case "circulo":
                    circulo();
                    break;

                case "Cuadrado":
                case "cuadrado":
                    cuadrado();
                    break;


                case "Triangulo":
                case "triangulo":
                    Triangulo();
                    break;

                case "Rectangulo":
                case "rectangulo":
                    rectangulo();
                    break;

            }
        }

        static void circulo()
        {
            double i;
            double p=1;
            double radio;
            double tt = 3.14159;

            Console.Write("Cual es el radio del circulo? ");
            radio = Convert.ToDouble(Console.ReadLine());
           if (radio == 0)
            {
                return;
            }
            else
            {
                for (i = 1; i <= 2; i++)
                {

                    p *= radio;

                }
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            double formula = (tt * p);
            Console.WriteLine("A = TT x r^2 = {0}",formula);
            Console.WriteLine("\n");
        }

        static void cuadrado()
        {
            double largoAcho,x=1;
            Console.Write("******************************************************************************");
            Console.Write("Se supone que si es u cuadrado su lados miden lo mismo.\n");
            Console.Write("Largo y ancho: ");
            largoAcho = Convert.ToDouble(Console.ReadLine());

            for (int i=1; i<=2; i++)
            {
                x *= largoAcho;
            }
            Console.Write("------------------------------------------------------------------------------");
            Console.WriteLine("     2");
            Console.WriteLine("A = {0} = {1}\n",largoAcho,x);
        }

        static void Triangulo()
        {
            double Base,altura, t = 1;
            Console.Write("******************************************************************************");
            Console.Write("Base: ");
            Base = Convert.ToDouble(Console.ReadLine());

            Console.Write("Altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            t = (altura * Base)/2;
            Console.Write("------------------------------------------------------------------------------");
            Console.WriteLine("    1");
            Console.WriteLine("A = 2 x {0} x {1} u\n",altura,Base);
            Console.WriteLine("        2");
            Console.WriteLine("A = {0} u\n", t);
        }

        static void rectangulo()
        {
            double ancho, altura, t = 1;
            Console.Write("******************************************************************************");
            Console.Write("Logitud: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            t = (altura * ancho);
            Console.Write("------------------------------------------------------------------------------");
            Console.WriteLine("                 2");
            Console.WriteLine("A = {0} x {1} = {2} u\n", altura, ancho,t);
        }

    }
}

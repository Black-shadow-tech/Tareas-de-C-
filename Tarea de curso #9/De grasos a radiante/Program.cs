using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_grasos_a_radiante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Formula(); 
        }

        static void Formula()
        {
            double grados;
            Console.Write("Cuantos grados hay? ");
            grados = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");


            while (grados <= 0 || grados > 360)
            {
                Console.WriteLine("Solo se permite de 0 a 360 ");
                Console.Write("Vuelva a intentarlo: ");
                grados = Convert.ToDouble(Console.ReadLine());

                if (grados <= 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Error system ");
                    Console.WriteLine("\n");

                    return;
                }
            }

            Console.WriteLine("\n");
            var formula = (3.1416 / 180) * grados;
            Console.WriteLine("(TT/180) x {0} = {1}",grados,formula);
            Console.WriteLine("\n");

        }
    }
}

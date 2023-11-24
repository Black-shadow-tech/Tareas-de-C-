using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_curso__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convirtiento centigrados a grados fahrenheit:\n");

            float c, resolucion;
            Console.Write("Digite su temperatura:");
            c = Convert.ToInt16(Console.ReadLine());

            float d = 1.8f;
            resolucion = (d*c) + 32;

            Console.WriteLine("\nFormula: F = 9/5 x {0} + 32 = {1}",c, resolucion,"\n");







        }
    }
}

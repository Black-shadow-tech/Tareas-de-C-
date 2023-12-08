using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_la_potyencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite la ptencia: ");
            int exponete = Convert.ToInt32(Console.ReadLine());
            int resultado = 1, i;

            Console.Write("Digite la base: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(i=0; i<exponete; i++)
            {
                resultado *= n;
            }

            Console.WriteLine("\n");
            Console.WriteLine("   {0}    ",exponete);
            Console.WriteLine(" ({0}) = {1}  ",n,resultado);

            Console.WriteLine("\n");
            


        }
    }
}

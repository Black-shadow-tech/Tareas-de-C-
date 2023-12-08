using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quieres saber si tu numero es primo o no? digita un numero: ");
            int n = Convert.ToInt32(Console.ReadLine());

          
            if (n %2 == 0 && n > 0)
            {
                if (n == 2)
                {
                    Console.WriteLine("\nEl {0} es el unico numero primopar.\n",n);
                }
                else
                {
                    Console.WriteLine("\nEl numero {0} es primo.\n", n);

                }
            }
            else
            {
                Console.WriteLine("\nEl numero {0} no es primo.\n",n);
            }

        }
    }
}

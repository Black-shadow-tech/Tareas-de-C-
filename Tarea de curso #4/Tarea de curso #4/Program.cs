using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_curso__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes;
            Console.Write("Digite un numero del 1 al 12: ");
            mes = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero");break;
                    Console.WriteLine("\n");
                case 2: Console.WriteLine("Febrero");break;
                    Console.WriteLine("\n");
                case 3: Console.WriteLine("marzo");break;
                    Console.WriteLine("\n");
                case 4: Console.WriteLine("Abril");break;
                    Console.WriteLine("\n");
                case 5: Console.WriteLine("Mayo");break;
                    Console.WriteLine("\n");
                case 6: Console.WriteLine("Junio");break;
                    Console.WriteLine("\n");
                case 7: Console.WriteLine("Julio");break;
                    Console.WriteLine("\n");
                case 8: Console.WriteLine("Agosto");break;
                    Console.WriteLine("\n");
                case 9: Console.WriteLine("Septiembre");break;
                    Console.WriteLine("\n");
                case 10: Console.WriteLine("Octubre");break;
                    Console.WriteLine("\n");
                case 11: Console.WriteLine("noviembre");break;
                    Console.WriteLine("\n");
                case 12: Console.WriteLine("Diciembre");
                    Console.WriteLine("\n");break;




            }

          
        }
    }
}

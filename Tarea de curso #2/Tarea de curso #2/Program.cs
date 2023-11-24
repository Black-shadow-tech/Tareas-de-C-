using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_curso__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Lados,alturaLados, suma;
            Console.WriteLine("Calculando el perimetro del poligono\n");

            Console.Write("Cuantos lado tiene su poligono?: ");
            Lados = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cuanto mide cada lado de su poligono?: ");
            alturaLados = float.Parse(Console.ReadLine());

            suma = (Lados*alturaLados);
            Console.WriteLine("\nEl peremetro de su poligono es: {0}", suma,"\n");
         




        }
    }
}

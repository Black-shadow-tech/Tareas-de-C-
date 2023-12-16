using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioooooo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Ejercicio de los alumnos

            byte i,j, nCursos, nAlumnos;
            double nMin = 100, nMax = 0, promedio;

            // Input o pidiendo datos al usuario
            Console.Write("Numero de cursos: ");
            nCursos = Convert.ToByte(Console.ReadLine());

            // Initializing the matrix
            double[][] calificaciones = new double[nCursos][];//Aqui asignamos el numero de curso digitado por el usuario.

            Console.Write("\n");

            // Pedimos el numero de estudiante que va haber en cada curso digitado por el usuario
            for (i = 0; i < nCursos; i++)
            {
                Console.Write("Ingrese el numero de alumnos para el curso {0}: ", i);//pedimos el numero de estudiantee
                nAlumnos = Convert.ToByte(Console.ReadLine());

                // Instanciamos las matrices internas (Alumnos en cada salon)
                calificaciones[i] = new double[nAlumnos];
            }



            Console.Write("\n");


            // Pedimos las calificaciones de los alumnos de cada salon
            // Inicializando el bucle
            for (i = 0; i < nCursos; i++)
            {
                Console.WriteLine("Curso #{0}", i);
                double sCalif = 0;  // Reiniciar la suma para cada curso

                // Inicializar variables para encontrar al estudiante con mayor y menor calificación en cada curso
                nMax = double.MinValue;  // Inicializar con el valor mínimo posible
                 nMin = double.MaxValue;  // Inicializar con el valor máximo posible

                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.Write("Estudiante {0}: ", j);
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

                    sCalif += calificaciones[i][j];

                    // Actualizar la calificación máxima y mínima para cada curso
                    if (calificaciones[i][j] > nMax)
                    {
                        nMax = calificaciones[i][j];
                    }

                    if (calificaciones[i][j] < nMin)
                    {
                        nMin = calificaciones[i][j];
                    }
                }

                 promedio = sCalif / calificaciones[i].Length;  // Calcular el promedio para cada curso
                Console.WriteLine("Promedio para el curso {0}: {1}", i, promedio);
                Console.Write("\n");

                // Imprimir la calificación máxima y mínima para el curso
                Console.WriteLine("Calificación máxima para el curso {0}: {1}", i, nMax);
                Console.WriteLine("Calificación mínima para el curso {0}: {1}", i, nMin);
                Console.Write("\n");
            }





            Console.WriteLine("--------------------------------------------------");


            // Promedio
            

            // Mayor calificación de los alumnos
            for (i = 0; i < nCursos; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    if (calificaciones[i][j] > nMax)
                    {
                        nMax = calificaciones[i][j];
                    }
                }
            }
            Console.WriteLine("La calificación más alta de toda la escuela: {0}", nMax);

            // Menor calificación de los alumnos
            for (i = 0; i < nCursos; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    if (calificaciones[i][j] < nMin)
                    {
                        nMin = calificaciones[i][j];
                    }
                }
            }
            Console.WriteLine("La calificación más baja de toda la escuela es: {0}", nMin);

            // Corrección en la línea siguiente (agregando {0} para mostrar el valor de promedio)
           
        }
    }
}


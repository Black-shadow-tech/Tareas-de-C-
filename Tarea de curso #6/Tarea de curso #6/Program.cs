using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tarea_de_curso__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuanto minutos ah durado en el estacionamiento? ");
            float m = Convert.ToSingle(Console.ReadLine());

            if ( m <= 60)
            {
                Console.WriteLine("Deposite 5,000 ");
                float d1 = Convert.ToSingle(Console.ReadLine());

                if (d1 >= 5000)
                {
                    if (d1 > 5000)
                    {
                        float resta1 = (d1 - 5000);
                        Console.WriteLine("Aqui tiene su devuelta: {0}", resta1);
                        Console.WriteLine("Pase buen dia :D ");
                    }
                    else
                    {
                        Console.WriteLine("Pase buen dia :D ");
                    }
                }
                else
                {
                    Console.WriteLine("Lo siento no puede salir del establecimiento PAGUE");
                }
            }
            else
            {
                if (m > 60 && m <= 120 )
                {
                    Console.WriteLine("Deposite 15,000 ");
                    float d1 = Convert.ToSingle(Console.ReadLine());

                    if (d1 >= 15000)
                    {
                        if (d1 > 15000)
                        {
                            float resta1 = (d1 - 15000);
                            Console.WriteLine("Aqui tiene su devuelta: {0}", resta1);
                            Console.WriteLine("Pase buen dia :D ");
                        }
                        else
                        {
                            Console.WriteLine("Pase buen dia :D ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lo siento no puede salir del establecimiento PAGUE");
                    }
                }
                else
                {
                    if(m >= 120)
                    {
                        Console.WriteLine("Deposite 40,000 ");
                        float d1 = Convert.ToSingle(Console.ReadLine());

                        if (d1 >= 40000)
                        {
                            if (d1 > 40000)
                            {
                                float resta1 = (d1 - 40000);
                                Console.WriteLine("Aqui tiene su devuelta: {0}", resta1);
                                Console.WriteLine("Pase buen dia :D ");
                            }
                            else
                            {
                                Console.WriteLine("Pase buen dia :D ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lo siento no puede salir del establecimiento PAGUE");
                        }
                    }
                }
            }
        }
    }
}

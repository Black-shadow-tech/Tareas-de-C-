using System;

class Program
{
    static void Main(string[] args)
    {
        int x;

        Console.Write("Digite un numero: ");
        x = Convert.ToInt32(Console.ReadLine());

        if (x % 2 == 0)//EJEMPLO: x = 4 / 4 % 2 = 2 / 2 % 2 = 1 esto es par
                       //EJEMPLO: x = 5 / 5 % 2 = 2.5 / 2.5 % 2 = 1.25 impar
        {
            Console.WriteLine("Par");
        }
        else
        {
            Console.WriteLine("Impar");
        }
    }

}

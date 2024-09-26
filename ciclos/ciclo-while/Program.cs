using System;

namespace ciclo_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 0;

            Console.WriteLine("ingrese un numero");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                cont++;
                Console.WriteLine("ingrese un numero");
            n = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Ingresaste " + cont + " numeros.");
        }
    }
}

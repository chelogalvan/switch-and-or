using System;

namespace ciclo_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 0;

            

            do
            {
                
                Console.WriteLine("ingrese un numero");
                n = int.Parse(Console.ReadLine());
                cont++;
                
            }while (n != 0);
            Console.WriteLine("Ingresaste " + cont + " numeros.");
        }
    }
}

using System;

namespace ciclo_for
{
    class Program
    {
        static void Main(string[] args)
        {
            // ejercicio loco de maxi

            //int n = 90;

            //for (int x = n; x < 5 && n%3 != 15; x= n%7 + x *23){
            //    Console.WriteLine("Hola mundo!!");
            //}

            //ejemplo maxi 

            //for (int x = 0; x < 5; x++)
            //{
            //    Console.WriteLine("Hola mundo!" + x);
            //}


            int  n = 0, promedio, suma= 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese una nota:");
                n = int.Parse(Console.ReadLine());
                suma += n;
            }

            promedio = suma / 5;
            Console.WriteLine("El promedio de nota   es : " + promedio);
        }
    }
}

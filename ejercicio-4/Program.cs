using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio
            //  si la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int a, b, c;


            //sumaAB= a+b;
            //multiBC=b*c;

            int resultado;
            Console.WriteLine("ingrese un numero ");
            a= int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese otro.");
            b= int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese otro ");
            c= int.Parse(Console.ReadLine());

            if ((a+b) > (c*b))
            {
                resultado = a + b;
                Console.WriteLine("La suma de a + b = "+ resultado + ", es mayor a la multiplicacion de b por c " );
            }
            else {

                
                Console.WriteLine("Fin..");


            }
        }
    }
}

﻿using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
             //Hacer un programa para ingresar 4 números. Luego analizar e informar por 
             //pantalla si los mismos se encuentran ordenados de forma decreciente .

             int n1 , n2 , n3 , n4 ;

             Console.WriteLine("Ingrese un numero ");
             n1 = int.Parse(Console.ReadLine());

             Console.WriteLine("Ingrese otro numero");
             n2 = int.Parse(Console.ReadLine());

             Console.WriteLine("ingrese otro numero");
             n3 = int.Parse(Console.ReadLine());

             Console.WriteLine("ingrese otro numero ");
             n4 = int.Parse(Console.ReadLine());

             if ( n1 > n2 && n2 > n3 && n3 > n4 )
             {
                Console.WriteLine("Los numeros estan ordenados de mayor a menor ");
             }
             else 
             {
                Console.WriteLine("No estan ordenados Fin....");
             }


        }
    }
} 

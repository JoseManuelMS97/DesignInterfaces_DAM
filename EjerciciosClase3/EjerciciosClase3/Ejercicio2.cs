using System;
using System.Runtime.ConstrainedExecution;
//2. Se desea diseñar un algoritmo para saber si un número es primo o no.
namespace EjerciciosClase3
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Introduce un numero: ");
            int num = int.Parse(Console.ReadLine());

            for(int i=1; i<num; i++)
            {
                if (num % i == 0) n++;
            }

           if(n>=2) Console.WriteLine("El numero NO es primo.");
           else Console.WriteLine("El numero es primo.");

        }
    }
}

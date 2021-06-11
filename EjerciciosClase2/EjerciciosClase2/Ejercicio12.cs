using System;
using System.Collections.Generic;
using System.Linq;
//12. Un programa que sume el valor de los numeros pares de una lista de 30 elementos.

namespace EjerciciosClase2
{
    class Ejercicio12
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30 };
            int suma = 0;

            for (int i=0; i<=29; i++)
            {
                if (numeros[i] % 2 == 0) suma += numeros[i];
            }
            Console.WriteLine("La suma de los numeros pares de la lista es: " + suma);
        }
    }
}

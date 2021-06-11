using System;
//11. Un programa que sume el valor de los números pares del 1 al 30.

namespace EjerciciosClase2
{
    class Ejercicio11
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for(int i=0; i<=30; i += 2)
            {
                suma += i;
            }
            Console.WriteLine("La suma de los numeros pares del 1 al 30 es: "+suma);
        }
    }
}

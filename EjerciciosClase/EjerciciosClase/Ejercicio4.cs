using System;
//4- Diseñar el algoritmo correspondiente a un programa que obtiene la última cifra de un número introducido.

namespace EjerciciosClase
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero entero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nLa ultima cifra del numero introducido es: " + (num % 10));
        }
    }
}

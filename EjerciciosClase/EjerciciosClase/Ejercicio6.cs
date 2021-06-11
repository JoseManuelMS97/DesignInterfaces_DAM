using System;
//6- Diseñar el algoritmo (ordinograma y pseudocódigo) correspondiente a un programa que tras introducir una medida
//y otro dato que nos dice si son centímetros ó pulgadas la convierta en pulgadas ó centímetros
//dependiendo de lo que era (1 pulgada = 2,54 centímetros).

namespace EjerciciosClase
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una medida: ");
            double medida = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¿Son centimetros (c) o pulgadas (p) ?");

            ConsoleKeyInfo eleccion = Console.ReadKey();

            if (eleccion.KeyChar == 'c')
                Console.WriteLine("\n" + medida + " centímetros serían "+ (medida/2.54) + " pulgadas.");
            else if (eleccion.KeyChar == 'p')
                Console.WriteLine("\n" + medida + " pulgadas serían " + (medida*2.54) + " centímetros.");
            else Console.WriteLine("\nDebes escribir 'c' o 'p' ");
        }
    }
}

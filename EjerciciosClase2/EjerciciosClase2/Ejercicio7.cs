using System;
//7. Un programa que lea un número, que compruebe que está comprendido entre 10 y
//100, que lo muestre por pantalla o que lo vuelva a leer en el caso que no cumpla la condición.

namespace EjerciciosClase2
{
    class Ejercicio7
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Escriba un numero entre 10 y 100");
            num = Convert.ToDouble(Console.ReadLine());

            while((num<10) || (num>100))
            {
                Console.WriteLine("Lo siento, no está comprendido entre 10 y 100, vuelve a intentarlo.");
                num = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("\nCorrecto, el "+num);
        }
    }
}

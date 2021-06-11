using System;
//1. Leer dos números e indicar cual es el mayor.

namespace EjerciciosClase2
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba 2 numeros");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2) Console.WriteLine("El primer numero es mayor. ( "+num1+" > "+num2+"  ) ");
            else Console.WriteLine("El segundo numero es mayor. ( " + num2 + " > " + num1 + "  ) ");


        }
    }
}

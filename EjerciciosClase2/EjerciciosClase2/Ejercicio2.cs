using System;
//2. Leer tres números e indicar cual es el mayor.

namespace EjerciciosClase2
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba 3 numeros");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());

            if ( (num1 > num2) && (num1>num3)) Console.WriteLine("El primer numero es el mayor. ( " + num1 + " > " + num2+ " y "+ num3+ "  ) ");
            else if ((num2 > num1) && (num2 > num3)) Console.WriteLine("El segundo numero es el mayor. ( " + num2 + " > " + num1 + " y " + num3 + "  ) ");
            else Console.WriteLine("El tercer numero es el mayor. ( " + num3 + " > " + num1 + " y " + num2 + "  ) ");


        }
    }
}

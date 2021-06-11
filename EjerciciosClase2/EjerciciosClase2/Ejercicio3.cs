using System;
//3. Leer tres números e indicar cual es el mayor y cual el menor.
namespace EjerciciosClase2
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba 3 numeros");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3))
            {
                if (num2 > num3)
                    Console.WriteLine("El primer numero es el mayor y el tercero el menor. ( " + num1 + " > " + num2 + " > " + num3 + "  ) ");
                else
                    Console.WriteLine("El primer numero es el mayor y el segundo el menor. ( " + num1 + " > " + num3 + " > " + num2 + "  ) ");
            }
            else if ((num2 > num1) && (num2 > num3)) {
                if (num1 > num3)
                    Console.WriteLine("El segundo numero es el mayor y el tecero el menor. ( " + num2 + " > " + num1 + " > " + num3 + "  ) ");
                else
                    Console.WriteLine("El segundo numero es el mayor y el primero el menor. ( " + num2 + " > " + num3 + " > " + num1 + "  ) ");
            }
            else
            {
                if(num1>num2) 
                    Console.WriteLine("El tercer numero es el mayor y el segundo el menor. ( " + num3 + " > " + num1 + " > " + num2 + "  ) ");
                else
                    Console.WriteLine("El tercer numero es el mayor y el primero el menor. ( " + num3 + " > " + num2 + " > " + num1 + "  ) ");
            }
        }
    }
}

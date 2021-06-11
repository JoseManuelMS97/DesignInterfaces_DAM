using System;
//5. Un programa que lea 4 números y calcule la media, el mayor y el menor.
//Y lea una operación (+ - * /) y muestre el resultado utilizando el mayor y el menor.

namespace EjerciciosClase2
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            double mayor, menor;
            Console.WriteLine("Escriba 4 numeros");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba la operación que quiera realizar ( + - * / ) ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");

            double media = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("\nLa media entre los 4 numeros es: " + media+"\n");

            //mayor
            if ((num1 > num2) && (num1 > 3) && (num1 > num4)) mayor = num1;
            else if ((num2 > num1) && (num2 > 3) && (num2 > num4)) mayor = num2;
            else if ((num3 > num1) && (num3 > 2) && (num3 > num4)) mayor = num3;
            else mayor = num4;


            //menor
            if ((num1 < num2) && (num1 < 3) && (num1 < num4)) menor = num1;
            else if ((num2 < num1) && (num2 < 3) && (num2 < num4)) menor = num2;
            else if ((num3 < num1) && (num3 < 2) && (num3 < num4)) menor = num3;
            else menor = num4;

            switch (op)
            {
                case '+':
                    {
                        Console.WriteLine(mayor + " + " + menor + " = " + (mayor + menor));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(mayor + " - " + menor + " = " + (mayor - menor));
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(mayor + " * " + menor + " = " + (mayor * menor));
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine(mayor + " / " + menor + " = " + (mayor / menor));
                        break;
                    }

                default:
                    {
                        Console.WriteLine("No se ha encontrado ese operador.");
                        break;
                    }
            }

        }
    }
}

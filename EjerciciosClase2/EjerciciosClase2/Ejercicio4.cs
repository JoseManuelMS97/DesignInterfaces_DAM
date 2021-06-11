using System;
//4. Leer dos números y una operación (+ - * /) y mostrar el resultado.

namespace EjerciciosClase2
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba 2 numeros");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba la operación que quiera realizar ( + - * / ) ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");

            switch (op)
            {
                case '+' :
                    {
                        Console.WriteLine(num1+" + "+ num2+ " = "+ (num1+num2));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                        break;
                    }

                default: { Console.WriteLine("No se ha encontrado ese operador.");
                        break;
                    }
            }
        }
    }
}
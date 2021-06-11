using System;

//3- Diseñar el algoritmo (ordinograma y pseudocódigo) correspondiente a un programa que pida por
//teclado dos números enteros y muestre su suma, resta, multiplicación, división y el resto (módulo) de la división.
//Si la operación no es conmutativa, también se mostrará el resultado invirtiendo los operadores.

namespace EjerciciosClase
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 2 numeros para operar.");
            Console.WriteLine("Numero 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Numero 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSuma: " + num1 + " + " + num2 + " = " + (num1 + num2) + "\n" +
                "Resta: " + num1 + " - " + num2 + " = " + (num1 - num2) + "\n" +
                "Multiplicacion: " + num1 + " * " + num2 + " = " + (num1 * num2));
                if(num2==0) { Console.WriteLine("No se puede dividir por 0"); }
                    else { Console.WriteLine("Division: " + num1 + " / " + num2 + " = " + (num1 / num2) + "  Resto: " + num1 % num2); }

            if (num1!=num2) Console.WriteLine("\nCambiando el orden de los factores:" +
                "\nResta: " + num2 + " - " + num1 + " = " + (num2 - num1) + "\n" +
                "Division: " + num2 + " / " + num1 + " = " + (num2 / num1) + "  Resto: "+num2%num1);

        }
    }
}

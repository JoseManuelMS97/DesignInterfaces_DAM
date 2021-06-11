using System;
using System.Data;
//4. Se proporciona una secuencia de números n, y se desea contar el número de veces que se encuentra
// el número x en la secuencia. La cantidad de números a introducir y el nº que se desea saber
// cuantas veces se repita se debe introducir por teclado.
namespace EjerciciosClase3
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            int contador = 0;

            Console.WriteLine("Qué tamaño tiene la secuencia de números?: ");
            int tam = int.Parse(Console.ReadLine());

            int[] secuencia = new int[tam];

            Console.WriteLine("Introduce los numeros uno a uno: ");

            for (int i=0; i < tam; i++)
            {
                secuencia[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("¿Qué número quiere buscar?");
            int num = int.Parse(Console.ReadLine());

            for (int j = 0; j < tam; j++)
            {
                if (secuencia[j] == num) contador++;
            }

            Console.WriteLine("El número "+num+" se repite "+contador+" veces.");
        }
    }
}

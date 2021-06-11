using System;
//Ejemplo 6.
//Crear un array de N elementos (crearlo por teclado o de forma aleatoria),
//ordenarlo de mayor a menor y viceversa, buscar el n.º x (se pide por consola)en
//el array, si existe decir en que posición del array está y hallar su factorial y el
//fibonacci. En caso que no se pueda o no exista el numero u otro tipo de error siempre informar al usuario.

namespace EjerciciosClase3
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            int fact=1; int auxiliar;
            int a = 0;
            int b = 1;
            Console.WriteLine("Qué tamaño tiene la secuencia de números?: ");
            int tam = int.Parse(Console.ReadLine());

            int[] secuencia = new int[tam];

            Console.WriteLine("Introduce los numeros uno a uno: ");

            for (int i = 0; i < tam; i++){
                secuencia[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Qué número desea buscar?: ");
            int num = int.Parse(Console.ReadLine());
            if (Array.IndexOf(secuencia, num) == -1) Console.WriteLine("\nNo se encuentra ese numero");
            else Console.WriteLine("\nEl numero se encuentra en la posicion: " + Array.IndexOf(secuencia, num));//Devuelve el índice donde se encuentra el numero

            for (int i = 1; i <= num; i++){
                fact = fact * i;
            }
            Console.Write("\nEl factorial de " + num + " es: " + fact);//Devuelve el factorial del numero


            Console.Write("\n\nEl fibonacci del numero "+num+" es: \n");//Devuelve el fibonacci del numero
            for (int i = 0; i < num; i++){
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                Console.WriteLine(a);
            }


            //Ordena de menor a mayor
            Array.Sort(secuencia);
            Console.WriteLine("\n\nLa secuencia ordenada de menor a mayor es: ");
           for (int i = 0; i < secuencia.Length; i++){
                Console.WriteLine(secuencia[i]);
            }
           //Le da la vuelta
            Array.Reverse(secuencia);
            Console.WriteLine("\n\nLa secuencia ordenada de mayor a menor es: ");

            for (int i = 0; i < secuencia.Length; i++){
                Console.WriteLine(secuencia[i]);
            }
        }
    }
}

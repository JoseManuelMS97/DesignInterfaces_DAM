using System;
//8. Un programa que lea un valor N, que indica cuantos números va a leer, y calcule la suma y la media
namespace EjerciciosClase2
{
    class Ejercicio8
    {
        static void Main(string[] args)
        {
            int suma = 0;
            Console.WriteLine("¿Cuántos numeros va a introducir?: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n\n");

            for (int i = 0; i<n; i++){
                int a = Convert.ToInt16(Console.ReadLine());
                suma = suma + a;            
            }
            double media = suma / n;
            Console.WriteLine("La suma de todos los numeros es: "+suma);
            Console.WriteLine("La media de todos los numeros es: "+media);
        }
    }
}
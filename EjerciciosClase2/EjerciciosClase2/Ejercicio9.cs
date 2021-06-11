using System;
//9. Un programa que lea números, los sume hasta que el usuario introduzca el número 0,
//entones los muestra la suma y la media.
namespace EjerciciosClase2
{
    class Ejercicio9
    {
        static void Main(string[] args)
        {
            int n = 0; 
            int num = 0;
            double suma = 0;

            Console.WriteLine("Introduce numeros hasta introducir un 0: \n");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                suma=suma + num;
                n++;
                num = Convert.ToInt32(Console.ReadLine());
            }
            double media = suma / n;

            Console.WriteLine("\nLa suma de todos los numeros introducidos es: " + suma);
            Console.WriteLine("La media es: " + media);

        }
    }
}

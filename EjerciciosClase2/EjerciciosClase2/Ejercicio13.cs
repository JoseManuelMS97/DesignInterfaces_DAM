using System;
//13. Introducir un número por teclado, si no se adivina el número oculto, borrar pantalla,
//indicar si el nº es superior o inferior. Repetir la operación hasta acertar.
namespace EjerciciosClase2
{
    class Ejercicio13
    {
        static void Main(string[] args)
        {
            int intento = -1;
            Random random = new Random();
            int num = random.Next(10);

            while (intento != num)
            {
                Console.WriteLine("Adivine el numero oculto: ");
                intento = int.Parse(Console.ReadLine());
                if (intento != num)
                {
                    Console.Clear();
                    if (intento < num) Console.WriteLine("El numero oculto es más grande, prueba otra vez.");
                    else Console.WriteLine("El numero oculto es más pequeño, prueba otra vez.");
                }

                else if (intento == num) Console.WriteLine("¡Enhorabuena! Es ese.");

            }
        }
    }
}

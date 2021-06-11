using System;
//6. Muestre el mensaje “procesando datos... desea continuar (s/n)”, si el usuario
//introduce ‘S’, se repite el mensaje y si dice ‘N’ muestra el mensaje adiós y termina.

namespace EjerciciosClase2
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            char decision = 's';

            while (decision != 'n')
            {
                Console.WriteLine("\nProcesando datos... desea continuar (s/n): ");
                decision = Console.ReadKey().KeyChar;
            }
        }
    }
}

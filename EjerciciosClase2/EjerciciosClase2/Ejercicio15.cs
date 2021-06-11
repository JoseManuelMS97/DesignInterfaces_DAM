using System;
//15. Elaborar un programa que muestre el precio de un billete de autobús, que se calcula
// en base a los kilómetros de trayecto (0.30 Euros por Km), Pero si el recorrido supera los
// 80Km se aplica un 15 % de descuento y que si el trayecto se realiza en día laborable
//(‘L’) hay un 5% de descuento respecto si es día festivo (‘F’). Datos ha introducir: kilómetros de recorrido y tipo de día.
namespace EjerciciosClase2
{
    class Ejercicio15
    {
        static void Main(string[] args)
        {
            double precio = 0;
            Console.WriteLine("¿Cuántos Km va a recorrer?: ");
            int km = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Hoy es laborable o festivo (L / F ): ");
            char dia = char.Parse(Console.ReadLine());

            precio = km * 0.3;

            if ((km > 80) && (dia == 'l')) precio -= precio * 0.2;
            else if (km > 80) precio -= precio * 0.15;
            else if (dia == 'l') precio -= precio * 0.05;

            Console.WriteLine("El precio del billete es de: "+Math.Round(precio,2));
        }
    }
}

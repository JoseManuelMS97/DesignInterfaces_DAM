using System;
//14. Realizar un programa que muestre el valor de una factura telefónica sabiendo que
//cada paso consumido se cobra a 0.10 Euros y que cuando se consumen más de 1000
//pasos se aplica un descuento del 18 % sobre el total de la factura. El número de pasos
//consumidos se solicita al usuario. Hay que chequear que este valor siempre es mayor que 0.
namespace EjerciciosClase2
{
    class Ejercicio14
    {
        static void Main(string[] args)
        {
            int pasos = 0;
            while (pasos == 0)
            {
                Console.WriteLine("¿Cuántos pasos ha consumido? (Debe ser mayor que 0) : ");
                pasos = int.Parse(Console.ReadLine());
            }
            double valor = pasos*0.1;

            if (pasos > 1000) valor = valor - (valor * 0.18);
            Console.WriteLine("El valor de la factura es de: "+Math.Round(valor,2));
        }
    }
}

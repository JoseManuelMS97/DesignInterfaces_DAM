using System;
//10- Suponiendo que una paella se puede cocinar exclusivamente con arroz y gambas,
//y que para cada cuatro personas se utiliza medio kilo de arroz y un cuarto de kilo de gambas,
//escribir un programa que pida por pantalla el número de comensales para la paella, el precio por kilo de los ingredientes
//y muestre las cantidades de los ingredientes necesarios y el coste de la misma.

namespace EjerciciosClase
{
    class Ejercicio10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de comensales: ");
            int comensales = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Precio/Kg del arroz: ");
            double precioArroz = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Precio/Kg de las gambas: ");
            double precioGambas = Convert.ToDouble(Console.ReadLine());

            //Si para 4 personas es 1/2 de arroz y 1/4 de gambas   ->  Para 1 persona es 0,125kg de arroz y 0.0625Kg de gambas
            double arrozNecesario = comensales*0.125;
            double gambasNecesarias = comensales*0.0625;

            double precio = (arrozNecesario * precioArroz) + (gambasNecesarias*precioGambas);

            Console.WriteLine("\nSerá necesario: "+ arrozNecesario+" Kg de arroz y "+gambasNecesarias+" Kg de gambas.");
            Console.WriteLine("En total costará la paella: "+precio+" euros.");

        }
    }
}

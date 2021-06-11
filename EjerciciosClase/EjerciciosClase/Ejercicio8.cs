using System;
//8- Diseñar el algoritmo (ordinograma y pseudocódigo) correspondiente a un programa que pida el total de kilómetros recorridos,
// el precio de la gasolina (por litro), el dinero de gasolina gastado en el viaje y
//el tiempo que se ha tardado (en horas y minutos) y que calcule:
//• Consumo de gasolina (en litros y euros) por cada 100 km.
//• Consumo de gasolina (en litros y euros) por cada km.
//• Velocidad media (en km/h y m/s).

namespace EjerciciosClase
{
    class Ejercicio8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el total de Km recorridos: ");
            int km = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el precio de gasolina por litro: ");
            double precioLitro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el dinero de gasolina gastado: ");
            int dineroGastado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el tiempo de viaje en Horas y Minutos (separado por coma): ");
            double tiempo = Convert.ToDouble(Console.ReadLine());

            double consumoKm = dineroGastado * precioLitro / km;
            double consumo100Km = consumoKm * 100;
            double velmediakh = km / tiempo;
            double velmediams = velmediakh / 3.6;
            Console.WriteLine("El consumo de gasolina por Km es de " + Math.Round(consumoKm,2) + " litros. \nEl consumo de gasolina por cada 100Km es de " +
                Math.Round(consumo100Km, 2) + " litros.");
            Console.WriteLine("La velocidad media es de " + Math.Round(velmediakh,2) + " Km/h   ------> " + Math.Round(velmediams,2) + " m/s."); 
        }
    }
}

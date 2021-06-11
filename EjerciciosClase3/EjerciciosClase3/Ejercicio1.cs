using System;
//1. Calcular la paga neta de un trabajador conociendo el número de horas trabajadas, la tarifa horaria
// y la tasa de impuestos.
namespace EjerciciosClase3
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca horas, tarifa y tasa de impuestos: ");
            int horas = int.Parse(Console.ReadLine());
            double tarifa = double.Parse(Console.ReadLine());
            double tasa = double.Parse(Console.ReadLine());

            double pagaBruta = horas * tarifa;
            double impuestos = pagaBruta * tasa;
            double pagaNeta = pagaBruta - impuestos;

            Console.WriteLine("La paga bruta es de: "+pagaBruta);
            Console.WriteLine("Los impuestos son: " + impuestos);
            Console.WriteLine("La paga neta es de: " + pagaNeta);
        }
    }
}

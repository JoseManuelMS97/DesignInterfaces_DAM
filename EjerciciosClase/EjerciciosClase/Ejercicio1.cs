using System;

//1. Diseñar el algoritmo (ordinograma y pseudocódigo) correspondiente a un programa que lea el valor correspondiente
//a una distancia en millas marinas y las escriba expresadas en metros. Sabiendo que 1 milla marina equivale a 1852 metros.

namespace EjerciciosClase
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Dame una distancia en millas: ");
			double millas = Convert.ToDouble(Console.ReadLine());
			double metros = millas * 1852;
			Console.WriteLine("La distancia de " + millas + " millas son " + metros + " metros.");
		}
    }
}
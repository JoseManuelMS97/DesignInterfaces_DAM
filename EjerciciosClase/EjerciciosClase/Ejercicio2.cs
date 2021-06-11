using System;
using System.Collections.Generic;
using System.Text;
//2- Diseñar el algoritmo (ordinograma y pseudocódigo) correspondiente a un programa que escribe el porcentaje
//descontado en una compra, introduciendo por teclado el precio de la tarifa y el precio pagado.

namespace EjerciciosClase
{
	class Ejercicio2
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Precio tarifa: ");
			double tarifa = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Precio pagado: ");
			double pagado = Convert.ToDouble(Console.ReadLine());

			double descuento = pagado / tarifa * 100;

			Console.WriteLine("El porcentaje descontado es de " + descuento + "%");

		}
	}
}
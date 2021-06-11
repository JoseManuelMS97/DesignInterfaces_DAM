using System;
//9- Diseñar el algoritmo (ordinograma y pseudocódigo) correspondiente a un programa que al introducir una cantidad de dinero
//expresado en euros nos indique cuántos billetes y monedas se puede tener como mínimo.

namespace EjerciciosClase
{
    class Ejercicio9
    {
        static void Main(string[] args)
        {
            int cinco, diez,veinte,cincuenta, cien, doscientos, quinientos, uno, dos;

            Console.WriteLine("Introduce una cantidad de euros: ");
            int euros = int.Parse(Console.ReadLine());

            uno = euros;
            quinientos = (uno - uno % 500) / 500;
            uno = uno % 500;
            doscientos = (uno - uno % 200) / 200;
            uno = uno % 200;
            cien = (uno - uno % 100) / 100;
            uno = uno % 100;
            cincuenta = (uno - uno % 50) / 50;
            uno = uno % 50;
            veinte = (uno - uno % 20) / 20;
            uno = uno % 20;
            diez = (uno - uno % 10) / 10;
            uno = uno % 10;
            cinco = (uno - uno % 5) / 5;
            uno = uno % 5;
            dos = (uno - uno % 2) / 2;
            uno = uno % 2;
            Console.WriteLine("\nDesglose: \n");

            Console.WriteLine("Billetes de 500: " + quinientos);
            Console.WriteLine("Billetes de 200: " + doscientos);
            Console.WriteLine("Billetes de 100: " + cien);
            Console.WriteLine("Billetes de 50: " + cincuenta);
            Console.WriteLine("Billetes de 20: " + veinte);
            Console.WriteLine("Billetes de 10: " + diez);
            Console.WriteLine("Billetes de 5: " + cinco);
            Console.WriteLine("Monedas de 1: " + uno);
            Console.WriteLine("Monedas de 2: " + dos);
        }
    }
}

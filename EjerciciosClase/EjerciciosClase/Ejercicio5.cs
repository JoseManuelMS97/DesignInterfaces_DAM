using System;
// 5- Diseñar el algoritmo (ordinograma y pseudocódigo) correspondiente a un programa que calcule el área y el perímetro 
//(introducir p ó a) de un triángulo rectángulo dada la base, la altura y lo que hay que calcular( p ó a).

namespace EjerciciosClase
{
    class Ejercicio5
    {
        static public double calculaPerimetro(double bass, double altura)
        {
            double hipotenusa = Math.Sqrt(Math.Pow(bass, 2) + Math.Pow(altura, 2));
            double perimetro = hipotenusa + bass + altura;
            return perimetro;
        }

        static public double calculaArea(double bass, double altura)
        {
            double area = (bass * altura) / 2;
            return area;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la base y altura de un triangulo rectangulo: ");
            double bass = Convert.ToDouble(Console.ReadLine());
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¿Qué quieres calcular, el perimetro (p) o el área(a)? : ");

            ConsoleKeyInfo eleccion = Console.ReadKey();

            if (eleccion.KeyChar== 'p' ) Console.WriteLine("\nEl perimetro del triangulo es: "+calculaPerimetro(bass, altura));
            else if (eleccion.KeyChar == 'a') Console.WriteLine("\nEl area del triangulo es: " + calculaArea(bass, altura));
            else Console.WriteLine("\nSolo puedes introducir 'a' o 'p'.");
        }
    }
}

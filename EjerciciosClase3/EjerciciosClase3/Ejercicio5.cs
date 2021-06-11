using System;
//5. Se desea calcular el salario neto semanal de un trabajador en función del número de horas
// trabajadas y la tasa de impuestos:
// • Las primeras 35 horas se pagan a tarifa normal,
// • Las horas que pasen de 35 se pagan a 1,5 veces la tarifa normal,
// • Las tasas de impuestos son:
// a) las primeras 360€ son libres de impuestos,
// b) las siguientes 250€ tienen un 25 por 100 de impuesto,
// c) las restantes, un 45 por 100 de impuestos,
// • La tarifa horaria es 5€ .
// También se desea escribir el nombre, salario bruto, tasas y salario neto.
namespace EjerciciosClase3
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            double pagaBruta, impuestos, pagaNeta;
            Console.WriteLine("Introduce Horas trabajadas, tasa de impuestos y nombre: ");
            int horas = int.Parse(Console.ReadLine());
            double tasa = double.Parse(Console.ReadLine());
            string nombre = Convert.ToString(Console.ReadLine());

            //tarifa = 5€ 

            if (horas <= 35) pagaBruta = horas * 5;
            else pagaBruta = (35 * 5) + (1.5 * (5 * (horas - 35)));  
   
             impuestos = pagaBruta * tasa;
             pagaNeta = pagaBruta - impuestos;

            Console.WriteLine("El salario de " + nombre + " es de: " + pagaNeta + " euros.");
            Console.WriteLine("Su salario bruto es: "+pagaBruta+" y de impuestos: "+impuestos);
        }
    }
}

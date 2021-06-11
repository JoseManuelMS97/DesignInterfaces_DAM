using System;
//3. Se desea realizar el algoritmo que resuelva el siguiente problema: Cálculo de los salarios
// mensuales de los empleados de una empresa, sabiendo que éstos se calculan en base a las horas
// trabajadas y de acuerdo a un precio especificado por horas. Si se pasan de cuarenta
// horas semanales, las horas extraordinarias se pagarán a razón de 1.5 veces la hora ordinaria.
namespace EjerciciosClase3
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            double salario = 0;
            Console.WriteLine("Introduce Horas, Precio/hora, Nombre: ");
            int horas = int.Parse(Console.ReadLine());
            int precioH = int.Parse(Console.ReadLine());
            string nombre = Convert.ToString(Console.ReadLine());

            if (horas <= 40) salario = horas * precioH;
            else salario= (40*precioH) + (1.5*(precioH*(horas-40)));

            Console.WriteLine("El salario de "+nombre+" es de: "+ salario+" euros.");

        }
    }
}

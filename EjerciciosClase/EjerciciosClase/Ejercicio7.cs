using System;
//7- Diseñar el algoritmo (ordinograma y pseudocódigo) correspondiente a un programa que exprese en horas,
//minutos y segundos un tiempo expresado en segundos.

namespace EjerciciosClase
{
    class Ejercicio7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una cantidad de segundos: ");
            int segundos = Convert.ToInt32(Console.ReadLine());
            int horas = 0;
            int minutos = segundos / 60;
            segundos = segundos % 60;
            if (minutos >= 60){
                horas = minutos / 60;
                minutos = minutos % 60;
            }
            Console.WriteLine(segundos + " segundos son: " + horas + " horas, " + minutos + " minutos y " + segundos +" segundos.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace Ejercicio2_ArchivoTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            string nombre=".";
            string modulo;
            string path = @"G:\VisualStudio\Workspace\Ejercicio2_ArchivoTexto\NotasTodas.txt";
            


           List<Nota> Notas = new List<Nota>();

            //Recogida de datos
            while (nombre != "")
            {
                Console.WriteLine("Escriba el nombre del alumno (ENTER para dejar de introducir contactos) :");
                nombre = Console.ReadLine();
                if (nombre=="") break;

                Console.WriteLine("Escriba el modulo del alumno:");
                modulo = Console.ReadLine();
                Console.WriteLine("Escriba la nota del alumno:");
                nota = Convert.ToInt32(Console.ReadLine());

                Notas.Add(new Nota() { Alumno = nombre, Modulo = modulo, nota = nota });
            }

            //Escritura y lectura en los archivos si existen
            try
            {
                if (File.Exists(path))
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        foreach (Nota c in Notas)
                        {
                            sw.WriteLine(c);
                        }
                    }

                    using (StreamReader sr = new StreamReader(path))
                    {
                        while (sr.Peek() >= 0)
                        {
                            Console.WriteLine(sr.ReadLine());
                        }
                    }
                }
                else Console.WriteLine("El fichero NotasTodas no existe.");

                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }


            //Ejemplos de uso de los métodos
            Console.WriteLine("Escribe un modulo:");
            modulo = Console.ReadLine();

            Nota.MostrarNotasModulo(modulo, Notas);


            Console.WriteLine("Escribe un nombre:");
            nombre = Console.ReadLine();

            Nota.MostrarNotasAlumno(nombre, Notas);
           
        }
    
    }
}

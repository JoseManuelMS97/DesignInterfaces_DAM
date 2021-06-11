using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ejercicio2_ArchivoTexto
{
    class Nota
    {
        public string Alumno { get; set; }
        public string Modulo { get; set; }
        public int nota { get; set; }

        static string path2 = @"G:\VisualStudio\Workspace\Ejercicio2_ArchivoTexto\NotasModulo.txt";
        static string path3 = @"G:\VisualStudio\Workspace\Ejercicio2_ArchivoTexto\NotasAlumno.txt";

        public Nota()
        {
        }

        public Nota(string alumno, string modulo, int nota)
        {
            Alumno = alumno;
            Modulo = modulo;
            this.nota = nota;
        }
        public override string ToString()
        {
            return "Alumno " + Alumno.ToString() + " - Modulo:  " + Modulo.ToString() + " - Nota: " + nota.ToString();
        }

        public static void MostrarNotasModulo(string modulo, List<Nota> Notas){

            if (File.Exists(path2)){
                using (StreamWriter sw = new StreamWriter(path2)){

                    foreach (Nota c in Notas){
                        if (c.Modulo == modulo)
                        {
                            sw.WriteLine(c);
                            Console.WriteLine(c);
                        }
                    }
                }              
            }else Console.WriteLine("El fichero NotasTodas no existe.");     
        }

        public static void MostrarNotasAlumno(string alumno, List<Nota> Notas)
        {
            if (File.Exists(path3))
            {
                using (StreamWriter sw = new StreamWriter(path3))
                {

                    foreach (Nota c in Notas)
                    {
                        if (c.Alumno == alumno)
                        {
                            sw.WriteLine(c);
                            Console.WriteLine(c);
                        }
                    }
                }
            }
            else Console.WriteLine("El fichero NotasTodas no existe.");
        }      
    }
}

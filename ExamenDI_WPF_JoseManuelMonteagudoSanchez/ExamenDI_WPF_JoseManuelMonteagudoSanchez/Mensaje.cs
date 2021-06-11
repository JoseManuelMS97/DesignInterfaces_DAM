using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDI_WPF_JoseManuelMonteagudoSanchez
{
    class Mensaje
    {
        //Propiedades
        private static int contador = 0;

        public static int Id { get; set; }
        public string Contact { get; set; }

        public DateTime Fecha { get; set; }
        public string Message { get; set; }
        public string Estado { get; set; }


        //Constructor por defecto
        public Mensaje()
        {
            Id = contador;
            Contact = "Anonimo";
            Fecha = DateTime.Today;
            Estado = "Guardado";
            Message = "Mensaje por defecto.";
            contador++;
        }

        //Constructor parametrizado
        public Mensaje(string contact, DateTime fecha,string estado, string message)
        {
            Id = contador;
            Contact = contact;
            Fecha = fecha;
            Estado = estado;
            Message = message;
            contador++;
        }

        public string Mostrar()
        {

            return (Contact + "\t" + Fecha + "\t" + Message);

        }
    }
}

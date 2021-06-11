using System;
using System.Collections.Generic;
using System.Text;

namespace JoseManuelMonteagudo_Examen1
{
    class CuentaJoven:Cuenta
    {
        //Propiedades
        protected long Bonificacion { get; set; }
        protected int Edad { get; set; }

        //Constructor parametrizado
        public CuentaJoven(string titular, string dni, double saldo, long bonificacion, int edad):base(titular,dni,saldo)
        {
            this.Titular = titular;
            this.Dni = dni;
            this.Saldo = saldo;
            this.Bonificacion = bonificacion;
            this.Edad = edad;
        }

        //Metodo que comprueba la edad
        public bool esTitularValido()
        {
            if (this.Edad > 18 && this.Edad < 25) return true;
            else return false;       
        }

        //Metodo que hace un ingreso con bonificacion
        public bool IngresoBonifica(double importeIngresar)
        {
            if (importeIngresar < 0)
            {
                Console.WriteLine("Lo siento, la cantidad no puede ser negativa.");
                return false;
            }
            else
            {
                if (importeIngresar > 1000)
                {
                    double plus = (importeIngresar * this.Bonificacion) / 100;
                    this.Saldo += importeIngresar + plus;
                    return true;
                }
                else
                {
                    Ingreso(importeIngresar);
                    return true;
                };
            }
        }

        //Metodo que muestra la cuenta joven
        public void Mostrar()
        {
            Console.WriteLine($" Cuenta Joven - {this.Bonificacion} % de bonificacion - {this.Saldo} euros de saldo. ");
        }
    }
}

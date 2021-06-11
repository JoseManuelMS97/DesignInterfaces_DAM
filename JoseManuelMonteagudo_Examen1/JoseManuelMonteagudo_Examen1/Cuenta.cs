using System;
using System.Collections.Generic;
using System.Text;

namespace JoseManuelMonteagudo_Examen1
{
    class Cuenta
    {
        //Propiedades
        private static int num;
        public int Numero { get; set; }
        protected string Titular { get; set; }
        protected string Dni { get; set; }
        protected double Saldo { get; set; }

        //Constructor defecto
        public Cuenta() {
            Numero = CrearNumero();
            Titular = "Jose Manuel";
            Dni = "49172811L";
            Saldo = 1000;
        }

        //Constructor parametrizado
        public Cuenta(string titular, string dni, double saldo){
            this.Numero = CrearNumero();
            this.Titular = titular;
            this.Dni = dni;
            this.Saldo = saldo;

        }
        //Metodo que crea los numeros de las cuentas
        protected int CrearNumero()
        {
            return ++num;
        }

        //Metodo para retirar dinero
        public bool Reintegro(double importeRetirar){
            if (importeRetirar > this.Saldo){
                Console.WriteLine("Lo siento, no se permite retirar más dinero del que se tiene.");
                return false;
            }else{ 
                this.Saldo -= importeRetirar;
                return true;
            }
        }

        //Metodo para ingresar dinero
        public bool Ingreso(double importeIngresar){
            if (importeIngresar < 0){
                Console.WriteLine("Lo siento, la cantidad no puede ser negativa.");
                return false;
            }
            else{
                this.Saldo += importeIngresar;
                return true;
            }
        }

        //Metodo toString
        public override string ToString(){
            return String.Format(" NumeroCuenta: {0} - Titular: {1} - DNI: {2} - Saldo: {3}", this.Numero, this.Titular, this.Dni, this.Saldo);
        }

        //Metodo para realizar transferencias
        public bool Transferencia(Cuenta cuentaDestino, double importe){
            if (importe > this.Saldo) {
                Console.WriteLine("Lo siento, no hay dinero suficiente.");
                return false;
            }
            else
            {
                this.Saldo -= importe;
                cuentaDestino.Saldo += importe;
                return true;
            }
        }
    }
}

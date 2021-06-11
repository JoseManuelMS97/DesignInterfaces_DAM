using System;

namespace EjercicioRepaso
{
    class CuentaEmpresa : Cuenta {
        //Propiedades
        protected long Interes { get; set; }
        protected double Credito { get; }
        protected int mesesCredito { get; set; }


        //Constructor parametrizado
        public CuentaEmpresa(string titular, string dni, double saldo, long interes, double credito, int mesesCredito) : base(titular, dni, saldo)
        {
            this.Titular = titular;
            this.Dni = dni;
            this.Saldo = saldo;
            this.Interes = interes;
            this.Credito = credito;
            this.mesesCredito = mesesCredito;
        }

        public bool Reintegro(double importeRetirar)
        {
            if (importeRetirar > this.Saldo)
            {
                CalcularCredito(importeRetirar);
                return true;
            }
            else
            {
                this.Saldo -= importeRetirar;
                return true;
            }
        }

        private void CalcularCredito(double importeRetirar)
        {
            throw new NotImplementedException();
        }

        public void mostrarCredito(int mesesCredito)
        {
            double cuotaMensual = (Credito + (Credito * Interes)) / mesesCredito;
              
            Console.WriteLine($" Credito -->  Importe:{this.Credito} - Interes:{this.Interes} - Cuota Mensual:{this.Interes}");
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

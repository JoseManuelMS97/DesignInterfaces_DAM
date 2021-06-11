using System;
using System.Collections.Generic;

namespace JoseManuelMonteagudo_Examen1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto List de la clase Cuenta
            List<Cuenta> LasCuentas = new List<Cuenta>();
            
            //Operaciones

            //Altas de cuentas
            Cuenta cuenta1 = new Cuenta("Jose Manuel", "12345678L", 2000);
            Cuenta cuenta2 = new Cuenta("Ramon", "1111111L", 9000);
            CuentaJoven cuenta3 = new CuentaJoven("Ricardo", "22222222L", 4000, 2, 21);

            LasCuentas.Add(cuenta1);
            LasCuentas.Add(cuenta2);
            LasCuentas.Add(cuenta3);

            //Imprime todas las cuentas
            void Consultas()
            {
                foreach (Cuenta a in LasCuentas)
                {
                    Console.WriteLine(a);
                }
            }

            //Consulta de una cuenta segun su numero
            void Consulta(int num) {
                bool encontrado=false;
                foreach (Cuenta a in LasCuentas)
                {
                    if (a.Numero == num)
                    {
                        Console.WriteLine(a);
                        encontrado = true;
                    }
                }
                if (encontrado == false) Console.WriteLine(" Cuenta no encontrada.");
            }

            //Voy a imprimir por pantalla el estado de las cuentas antes y despues de realizar operaciones

            Consultas();
            Console.WriteLine();

            //Consulta de la cuenta 2 y de una que no existe
            Consulta(2);
            Consulta(5);

            Console.WriteLine();

            //Operaciones con ingresos
            if(cuenta1.Ingreso(1000)) Console.WriteLine("Ingreso realizado con exito");
            if(cuenta2.Ingreso(500)) Console.WriteLine("Ingreso realizado con exito");
            if(cuenta3.IngresoBonifica(2000)) Console.WriteLine("Ingreso realizado con exito");

            Console.WriteLine();

            //Operaciones con reintegros
            if (cuenta2.Reintegro(50)) Console.WriteLine("Reintegro realizado con exito");
            if (cuenta3.Reintegro(10)) Console.WriteLine("Reintegro realizado con exito");

            Console.WriteLine();

            //Transferencias entre cuentas
            if(cuenta1.Transferencia(cuenta2, 100)) Console.WriteLine("Transferencia realizada con exito");
            if(cuenta2.Transferencia(cuenta3, 300)) Console.WriteLine("Transferencia realizada con exito");

            Console.WriteLine();

            //Consulta de como han quedado las cuentas
            Consultas();

            //Muestro la cuenta 3 que es cuentaJoven 
            cuenta3.Mostrar();
        }
    }
}
 
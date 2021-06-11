using System;
//10. Un programa que lea 200 números y me indique cual el máximo y el mínimo.

namespace EjerciciosClase2
{
    class Ejercicio10
    {
        static void Main(string[] args)
        {
            float[] num = new float[200];
            float mayor = 0, menor = 0;
            int flag = 0;

            for (int i = 0; i < 200; i++)
            {
                Console.Write("Ingrese {0}º número:", i + 1);
                num[i] = float.Parse(Console.ReadLine());

                if (flag == 0)
                {
                    mayor = num[i];
                    menor = num[i];
                    flag = 1;
                }
                else
                {
                    if (num[i] > mayor)
                        mayor = num[i];
                    if (num[i] < menor)
                        menor = num[i];
                }
            }
            if (mayor == menor)
                Console.Write("\nLos números son todos iguales\n");
            else
                Console.Write("\nEl menor de los 200 números es el {0} y el mayor es el {1}", menor, mayor);

        }
    }
}

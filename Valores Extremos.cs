using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valores_extremos
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.Write("Ingrese el número de datos: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 200;
            string nombreMax="", nombreMin="";

            while (i < n)
            {
                Console.Write("Ingrese nombre:\nedad:\n");
                string nombre = Console.ReadLine().ToString();
                int edad = int.Parse(Console.ReadLine());

                if (edad > max)
                {
                    max = edad;
                    nombreMax = nombre;
                }
                if (edad < min)
                {
                    min = edad;
                    nombreMin = nombre;
                }
                total += edad;
                i++;
            }
            double promedio = total / n;
            Console.Write($"El promedio es:{promedio},El mayor es {nombreMax} con {max}, y el menor es {nombreMin} con {min}\n");

        }
    }
}

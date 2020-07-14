using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcuacionCuadratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese los valores de\na:\nb:\nc:\n ");
            double a = double.Parse(Console.ReadLine()), b = double.Parse(Console.ReadLine()), c = double.Parse(Console.ReadLine());
            double discriminante = Math.Pow(b, 2) - 4 * a * c;
            if (discriminante == 0)
            {
                double x = -b / 2 * a;
                Console.Write("La solución es x: " + x);
            }
            else if (discriminante > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / 2 * a, x2 = (-b - Math.Sqrt(discriminante)) / 2 * a;
                Console.Write($"La solución es\nx1: {x1}\nx2: {x2}\n");
            }
            else
            {
                Console.Write("No existe solución\n");
            }
        }
    }
}

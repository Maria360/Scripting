using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triángulo_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Ingreso de datos 
            Console.WriteLine("Ingrese b: \nz: \nz: \ny:");
            double bGrados = double.Parse(Console.ReadLine()), z = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            double b = bGrados * (Math.PI / 180);
            Console.WriteLine(b);
            //Hallar datos
            double yPow = Math.Pow(y, 2), zPow = Math.Pow(z, 2);
            double t = Math.Sqrt(yPow + zPow);
            double e = Math.PI - Math.Atan(z / y);
            double x = (t * Math.Sin(b)) / (Math.Sin(Math.PI - b - e));
            //Print
            Console.WriteLine("x es: " + x);



        }
    }
}

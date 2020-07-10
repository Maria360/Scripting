using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triángulos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.Write("Ingrese Y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Inserte Z: ");
            double z = double.Parse(Console.ReadLine());

            //Hallar t
            double zPow = Math.Pow(z, 2), yPow = Math.Pow(y, 2);
            double t = Math.Sqrt(zPow+yPow);

            //Hallar a
            double a = Math.Asin((y * Math.Sin(Math.PI / 2)) / t);
            double aGrados = a * 180/Math.PI;

            //Hallar c
            double c = Math.PI - (Math.PI) / 2 - a;
            double cGrados = c * 180/Math.PI;

            //Print results
            Console.WriteLine($"Los resultados son \n a: {aGrados} c: {cGrados} t: {t} z: {z} y: {y}");
            Console.ReadLine();
        }
    }
}

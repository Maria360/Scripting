using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triángulos_III
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso y conversión de datos
            Console.WriteLine("Ingrese C: ");
            double cGrados = double.Parse(Console.ReadLine());
            double c = cGrados * Math.PI / 180;
            Console.WriteLine("Ingrese Z: ");
            double z = double.Parse(Console.ReadLine());

            //Hallar datos restantes
            double t = (Math.Sin(Math.PI / 2) * z) / Math.Sin(c);
            double a = Math.PI - Math.PI / 2 - c;
            double aGrados = a * 180 / Math.PI;
            double y = (Math.Sin(a) * z) / Math.Sin(c);

            //Print results
            Console.WriteLine($"Los datos restantes son \n t: {t} a: {aGrados} y: {y}");
            Console.ReadLine();
        }
    }
}

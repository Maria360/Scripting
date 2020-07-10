using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triángulos_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos y conversiones
            Console.WriteLine("Ingrese T: ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese A: ");
            double aGrados = double.Parse(Console.ReadLine());
            double a = aGrados * ((Math.PI) / 180);

            //Hallar datos restantes
            double c = Math.PI - (Math.PI) / 2 - a;
            double cGrados = c * 180 / Math.PI;
            double z = (t * (Math.Sin(c))) / Math.Sin((Math.PI) / 2);
            double tPow = Math.Pow(t, 2);
            double zPow = Math.Pow(z, 2);
            double y = Math.Sqrt(tPow - zPow);

            //Print results
            Console.Write($"Los valores restantes son \n z: {z} y: {y} c: {cGrados}");
            Console.ReadLine();

        }
    }
}

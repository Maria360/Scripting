using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese d: \nb: \ny:");
            double dGrados = double.Parse(Console.ReadLine()), bGrados = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            double d = dGrados * Math.PI / 180, b = bGrados * Math.PI / 180;
            double z = y * Math.Tan(b + d);
            Console.Write("z es " + z);

        }
    }
}

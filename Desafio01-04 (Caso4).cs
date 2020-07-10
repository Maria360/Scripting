using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese \nw:\nc:\nt:\n");
            int w = int.Parse(Console.ReadLine());
            double cGrados = double.Parse(Console.ReadLine()), t = double.Parse(Console.ReadLine());
            double c = cGrados * Math.PI / 180;
            double d = Math.Asin((t * Math.Sin((Math.PI) - c)) / w);
            double x = (t * Math.Sin(c -d)) / Math.Sin(d);
            Console.Write("x es " + x);
        }
    }
}

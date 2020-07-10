using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloVI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese\nw: \nx: \nd:\n ");
            int w = int.Parse(Console.ReadLine()), x = int.Parse(Console.ReadLine());
            double dGrados = double.Parse(Console.ReadLine());
            double y = (w * Math.Cos(dGrados * Math.PI / 180)) - x;
            Console.WriteLine("y es " + y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bin2dec
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso y conversion
            Console.Write("Ingrese \nb4: \nb3: \nb2: \nb1: \nb0:\n ");
            int b4Bin = int.Parse(Console.ReadLine()), b3Bin = int.Parse(Console.ReadLine()), b2Bin = int.Parse(Console.ReadLine()), b1Bin = int.Parse(Console.ReadLine()), b0Bin = int.Parse(Console.ReadLine());
            //De binario a dec
            double b4 = b4Bin * Math.Pow(2, 4), b3 = b3Bin * Math.Pow(2, 3), b2 = b2Bin * Math.Pow(2, 2), b1 = b1Bin * Math.Pow(2, 1), b0 = b0Bin * Math.Pow(2, 0);
            //Print result
            Console.WriteLine($"{b4Bin}{b3Bin}{b2Bin}{b1Bin}{b0Bin} equivale a: {b4 + b3 + b2 + b1 + b0}");
        }
    }
}

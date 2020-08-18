using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sin_x_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese x:");
            double x = double.Parse(Console.ReadLine());
            double sumatoria = 0;
            int n = 100, divisor = 0;
            double factorial = 0;
            for (int i=0; i <= n; i++)
            {
                divisor = (2*i) + 1;
                for(int j =1; j <=divisor; j++)
                {
                    factorial *= j;
                    if (factorial == 0) factorial = 1;
                }
                
                sumatoria += ((Math.Pow(-1, i)) / factorial) * Math.Pow(x, divisor);
                
            }
            Console.WriteLine($"Sin({x})= "+sumatoria);
        }
    }
}

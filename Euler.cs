using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 100, x = 3, factorial=0, sumatoria=0;
            for(int i = 0; i<=n; i++) 
            {
                factorial *= i;
                if (factorial == 0) factorial = 1;
                sumatoria += (Math.Pow(x, i))/(factorial);
                
            }
            Console.WriteLine(sumatoria);
        }
    }
}

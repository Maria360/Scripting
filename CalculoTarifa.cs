using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoTarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su salario mensual: ");
            double salario = double.Parse(Console.ReadLine());
            double smmlv = salario / 980657;
            if(smmlv < 2)
            {
                Console.Write("Su tarifa es A\n");
            }
            else if (2<=smmlv && smmlv<4)
            {
                Console.Write("Su tarifa es B\n");
            }
            else 
            {
                Console.Write("Su tarifa es C\n");
            }

            
        }
    }
}

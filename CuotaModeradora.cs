using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCuotaModeradora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su salario mensual: ");
            double salario = double.Parse(Console.ReadLine());
            double smmlv = salario / 980657;
            if (smmlv < 2)
            {
                Console.Write("Tarifa: A\nCuota Moderadora: 3400\n");
            }
            else if (2 <= smmlv && smmlv < 5)
            {
                Console.Write("Tarifa: B\nCuota Moderadora: 13500\n");
            }
            else
            {
                Console.Write("Tarifa: C\nCuota Moderadora: 35600\n");
            }
        }
    }
}

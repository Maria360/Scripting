using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese\nAltura en metros:\nPeso en Kg:\n ");
            double talla = double.Parse(Console.ReadLine()), peso = double.Parse(Console.ReadLine());
            double imc = peso / Math.Pow(talla,2);
            if(imc < 18.5)
            {
                Console.Write($"Su IMC es {imc} y su clasificación es: peso insuficiente");
            }
            else if (18.5 <= imc && imc <= 24.9)
            {
                Console.Write($"Su IMC es {imc} y su clasificación es: peso normal");
            }
            else if(25<= imc && imc <= 29.9)
            {
                Console.Write($"Su IMC es {imc} y su clasificación es: sobrepeso");
            }
            else
            {
                Console.Write($"Su IMC es {imc} y su clasificación es: obesidad ");
            }

            Console.Write("\nFINITO\n");




        }
    }
}

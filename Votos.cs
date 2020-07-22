using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese\nVotos por a:\nVotos por b:\nVotos en blanco:\nVotos anulados:\nNúmero total de la población:\nPorcentaje de la población que es mayor de edad (Ingrese el valor sin el símbolo %):\n");
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), blanco = int.Parse(Console.ReadLine()), anulados = int.Parse(Console.ReadLine()), n = int.Parse(Console.ReadLine()), p = int.Parse(Console.ReadLine());
            int mayoresDeEdad = (int)(p * 0.01 * n), totalVotantes = a + b + blanco + anulados;
            int abstencion = mayoresDeEdad - totalVotantes ;
            bool ganoA = a > b && a > blanco;
            bool ganoB = b > a && b > blanco;
            Console.Write($"\nPersonas mayores de edad:{mayoresDeEdad}\nTotal de votantes:{totalVotantes}\nAbstención:{abstencion}\n");

            if ((anulados < ((a + b) * 0.30)|| (a + b) > blanco )&& abstencion < totalVotantes)
            {
                Console.WriteLine($"Las votaciones fueron exitosas");
                if (ganoA) Console.Write("El ganador es el Partido 1 (A)\n");
                if (ganoB) Console.Write("El ganador es el Partido 2 (B)\n");
            }
            else Console.Write("Las elecciones deben repetirse\n");

        }
    }
}

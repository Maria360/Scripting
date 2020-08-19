using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Tanjiro", "Nazuko", "Zenitsu", "Inosuke", "Genya","Kanao", "Tomioka"};
            double[] estatura = {165, 153, 164.5,164, 180, 156, 176};
            int count = 0;
            double total=0;
            double min = 165.5;
            string nombre = "";
            for(int i=0; i<estatura.Length; i++)
            {
                total += estatura[i];

            }
            double promedio = total / estatura.Length;
            Console.WriteLine("PROMEDIO: " + promedio);
            double[] distancia = new double[estatura.Length];
            for (int i=0; i<estatura.Length; i++)
            {
                count++;
                distancia[i] = Math.Abs(estatura[i] - promedio);
                if (distancia[i] < min) {//guardar min
                    min = distancia[i];
                    nombre = nombres[i];
                }
                Console.WriteLine($"ELEMENTO #{count}: DISTANCIA: " + distancia[i]);
                
            }
            double sumatoria = 0;
            for (int i = 0; i < estatura.Length; i++) {
                double diferencia = estatura[i] - promedio;
                sumatoria += Math.Pow(diferencia, 2);
            }
            double desviacion = Math.Sqrt(sumatoria / estatura.Length);
            Console.WriteLine("DESVIACION: " + desviacion);
            Console.WriteLine("El más parecido al promedio es: " + nombre);

        }
    }
}

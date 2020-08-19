using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento_Nombres
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Nezuko", "Tanjiro", "Zanitsu", "Inosuke", "Ganya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 165.5, 164, 180, 156, 176 };
            
            for(int j = 0; j < estatura.Length; j++)
            {//Ordenar Estatura
                for (int i = 0; i < estatura.Length - 1; i++)
                {
                    if (estatura[i] > estatura[i + 1]) 
                    {
                        double tmp = estatura[i]; 
                        estatura[i] = estatura[i + 1];
                        estatura[i + 1] = tmp;
                    }
                }
                //Console.WriteLine(estatura[j]);
            }
            for (int j = 0; j < estatura.Length; j++)
            {//Para lo del problema con el 156
                Console.WriteLine(estatura[j]);
            }
            for(int j=0; j < nombres.Length; j++)
            {
                for(int i=0; i < nombres.Length - 1; i++)
                {
                    if (string.Compare(nombres[i] , nombres[i + 1])>0)
                    {//Compare=>iguales da 0, stringA < stringB da -1, stringA>stringB da 1
                        string tmp = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = tmp;
                    }
                }
            }
            for (int j = 0; j < nombres.Length; j++)
            {
                Console.WriteLine(nombres[j]);
            }

        }
    }
}

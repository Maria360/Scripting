using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "o", "x" };
            int n = 10;
            int m = 15;
            int x = 0, o = 0, guion = 0, total = 0;
            double porcentajeX = 0, porcentajeO = 0, porcentajeGuion = 0;
            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];

            
            for (int i=0; i < tablero.GetLength(0); i++)
            {
                for(int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";
                }
            }
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    if (tablero[i, j] == "x") x++;
                    if (tablero[i, j] == "o") o++;
                    if (tablero[i, j] == "-") guion++;
                }
            }
            total = x + o + guion;
            porcentajeGuion = ((double)guion * 100) / total;
            porcentajeX = ((double)x * 100) / total;
            porcentajeO = ((double)o * 100) / total;
            Console.WriteLine($"PORCENTAJES\nx: {porcentajeX}\no: {porcentajeO}\n-: {porcentajeGuion}");
            Console.WriteLine("ENTRADA");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|"+tablero[i, j]);
                }
                Console.WriteLine("|\n");
            }
            for (int i = 0; i < tablero.GetLength(0); i++)
            {//condiciones
                for (int j = 0; j < tablero.GetLength(1)-2; j++)
                {
                    if (tablero[i, j] == "x") {
                        if (tablero[i, j] == tablero[i, j + 1]&&tablero[i,j]==tablero[i,j+2]) {

                            salida[i, j] = "1";
                            salida[i, j + 1] = "1";
                            salida[i, j + 2] = "1";
                        }
                    }
                    if (tablero[i, j] == "o")
                    {
                        if (tablero[i, j] == tablero[i, j + 1] && tablero[i, j] == tablero[i, j + 2])
                        {
                            salida[i, j] = "2";
                            salida[i, j + 1] = "2";
                            salida[i, j + 2] = "2";
                        }
                    }

                }
            }
            for (int i = 0; i < tablero.GetLength(0)-2; i++)
            {//condiciones
                for (int j = 0; j < tablero.GetLength(1); j++)
                {

                    if (tablero[i, j] == "x")
                    {
                        if (tablero[i, j] == tablero[i + 1, j] && tablero[i, j] == tablero[i + 2, j])
                        {

                            salida[i, j] = "1";
                            salida[i+1, j] = "1";
                            salida[i + 2, j ] = "1";
                        }
                    }
                    if (tablero[i, j] == "o")
                    {
                        if (tablero[i, j] == tablero[i + 1, j] && tablero[i, j] == tablero[i + 2, j])
                        {
                            salida[i, j] = "2";
                            salida[i + 1, j ] = "2";
                            salida[i + 2, j ] = "2";
                        }
                    }
                }
            }
            for (int i =0; i < salida.GetLength(0); i++)
            {
                for(int j=0; j < salida.GetLength(1) - 1; j++)
                {

                }
            }
            Console.WriteLine("SALIDA");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + salida[i, j]);
                }
                Console.WriteLine("|\n");
            }

        }
    }
}

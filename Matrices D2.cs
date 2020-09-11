using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 10;
            int m = 15;
            string[,] tablero = new string[n, m];


            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {

                    tablero[i, j] = "-";
                }
            }
            Console.WriteLine("ENTRADA");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }
                Console.WriteLine("|\n");
            }
            Console.WriteLine("¿Donde desea colocar la X?\nfila: ");
            int fila = int.Parse(Console.ReadLine());
            Console.WriteLine("columna:");
            int columna = int.Parse(Console.ReadLine());
            while(tablero[fila, columna] != "-")
            {
                Console.WriteLine($"La posición {fila},{columna} se encuentra ocupada\nSeleccione otra");
                Console.WriteLine("¿Donde desea colocar la X?\nfila:");
                fila = int.Parse(Console.ReadLine());
                Console.WriteLine("¿Donde desea colocar la X?\ncolumna:");
                columna = int.Parse(Console.ReadLine());
            }
            if (tablero[fila, columna] == "-") tablero[fila, columna] = "x";
            Console.WriteLine("SALIDA");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }
                Console.WriteLine("|\n");
            }
        }
    }
}

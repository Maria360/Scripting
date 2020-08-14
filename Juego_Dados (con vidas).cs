using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroP2_Casa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, vidas = 3, puntos = 100, total = 0, i = 0;
            string continuar = "s";
            while (continuar=="s" && vidas != 0 && total < puntos)
            {
                dado1 = aleatorio.Next(1, 7);
                total += dado1;
                Console.WriteLine($"Dado: {dado1}\nTotal: {total}\nVidas: {vidas}\n¿Continuar? s/n");
                continuar = Console.ReadLine();
                i++;
                if (i % 2 == 0) {
                    vidas--;
                    if (vidas == 0)
                    {
                        Console.WriteLine($"Vidas: {vidas}\nPerdedor");
                        break;
                    }
                }
                if(i%3==0)
                {
                    dado2 = aleatorio.Next(1, 7);
                    total += dado1 + dado2;
                    Console.WriteLine($"Dado 1: {dado1}\nDado 2: {dado2}\nTotal: {total}\nVidas: {vidas}\n¿Continuar? s/n");
                    continuar = Console.ReadLine();
                    if (dado1 == dado2) vidas++;
                }
            }
            if(total>=puntos)Console.WriteLine("Ganador");
        }
    }
}

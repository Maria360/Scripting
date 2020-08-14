using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta1 = 0, carta2 = 0, total = 0, blackjack = 21, i = 0, max=0;
            Console.WriteLine("Número de jugadores:");
            int j= int.Parse(Console.ReadLine());
            while (j < 2 || j > 5) {
                Console.WriteLine("Número de jugadores no permitido\nNúmero de jugadores:");
                j= int.Parse(Console.ReadLine());
            }
            string continuar = "", nombre = "", ganador="";
            bool seguirJugando = true;
            while (i<j&&seguirJugando==true)
            {
                i++;
                total = 0;
                Console.WriteLine($"Jugador {i}, ¿Desea jugar?");
                continuar = Console.ReadLine();
                while (continuar != "s" && continuar != "n")
                {
                    Console.WriteLine("Respuesta inválida\n¿Desea jugar?");
                    continuar = Console.ReadLine();
                }
                if (continuar == "s"){
                    Console.WriteLine("Nombre:");
                    nombre = Console.ReadLine();
                    carta1 = aleatorio.Next(1, 11);
                    carta2 = aleatorio.Next(1, 11);
                    total += carta1 + carta2;
                    Console.WriteLine($"Cartas: {carta1} y {carta2}\nTotal: {total}");
                    while (total < blackjack&&continuar=="s")
                    {
                        Console.WriteLine("¿Desea continuar?");
                        continuar = Console.ReadLine();
                        while (continuar != "s" && continuar != "n")
                        {
                            Console.WriteLine("Respuesta inválida\n¿Desea continuar?");
                            continuar = Console.ReadLine();
                        }
                        if (continuar == "s")
                        {
                            carta1 = aleatorio.Next(1, 11);
                            total += carta1;
                            Console.WriteLine($"Carta: {carta1}\nTotal: {total}");
                        }
                    }
                }
                if (total > max&&total<=blackjack)
                {
                    max = total;//Sirve para decir cuál gano fue el que obtuvo tanto
                    ganador = nombre;
                }
                if (continuar == "n" && total < blackjack) Console.WriteLine("Su total es: " + total);
                if (total > blackjack && i > j + 1) seguirJugando =false;
            }
            if (total <= blackjack) Console.WriteLine($"El ganador es: {ganador}");
            if (total > blackjack) Console.WriteLine("Perdedor");
        }
    }
}

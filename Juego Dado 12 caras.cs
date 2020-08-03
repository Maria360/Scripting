using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroP1_Dado12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desea iniciar el juego? (s/n)");
            string continuar = Console.ReadLine();
            Random aleatorio = new Random();
            int dado = aleatorio.Next(1, 13), puntajeGanador = 100, i = 0, total = 0;
            bool ganadorInnato = false;
            while(i >= 0 && i <=2 && continuar == "s")
            {
                dado = 10/*aleatorio.Next(1, 13)*/;
                total += dado;
                Console.WriteLine($"Su dado es: {dado}\nTotal:{total}\n Desea continuar?(s/n)");
                continuar = Console.ReadLine();
                i++;
                if (dado == 10 && i < (i + 1))
                {
                    dado = 12/*aleatorio.Next(1, 13)*/;
                    if (dado == 12)
                    {
                        Console.WriteLine($"Su nuevo dado es: {dado}\n ¡Ganador Innato!");
                        ganadorInnato = true;
                        break;
                    }
                }
            }
            while (continuar == "s" && total<puntajeGanador && ganadorInnato == false)
            {
                dado = aleatorio.Next(1, 13);
                if (dado % 2 != 0)
                {
                    total = 0;
                    Console.WriteLine($"Su nuevo dado es: {dado}\nTotal: {total}\nPERDISTE");
                    break;
                }
                total += dado;
                Console.WriteLine($"Su nuevo dado es: {dado}\nTotal: {total}\n Desea continuar? (s/n)");
                continuar = Console.ReadLine();
                i++;
                if (dado == 10 && i < (i + 1))
                {
                    dado = aleatorio.Next(1, 13);
                    if (dado == 12)
                    {
                        Console.WriteLine($"Su nuevo dado es: {dado}\n ¡Ganador Innato!");
                        break;
                    }
                }
            }
            if (total >= 100) Console.WriteLine($"Tu puntaje final es: {total}\n GANASTE");
        }
    }
}

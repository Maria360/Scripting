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
            int carta1 = aleatorio.Next(1, 11), carta2 = aleatorio.Next(1, 11);
            int total = carta1 + carta2, blackjack = 21, i = 0;
            string continuar = "s";
            Console.Write($"Sus cartas son: {carta1} y {carta2}\n");

            while(continuar == "s" && total < blackjack)
            {
                Console.WriteLine("Total: "+total);
                Console.Write("Desea continuar (s/n)\n");
                continuar = Console.ReadLine().ToString();
                if (continuar == "s") 
                {
                    int nuevaCarta = aleatorio.Next(1, 11);
                    Console.Write("Su nueva carta es: "+nuevaCarta+"\n");
                    total += nuevaCarta;
                }
                i++;
            }
            if (total > blackjack) Console.Write("Eliminado :(\n");
            Console.Write("Su total es: "+total+"\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroP1___Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = aleatorio.Next(1, 7), dado2 = aleatorio.Next(1, 7);
            int total = dado1 + dado2, puntajeGanador = 100, i = 0, contador = 0, c=0;
            double porcentaje=0;
            String continuar = "s";
            Console.WriteLine($"Sus dados son: {dado1} y {dado2}, sumando {total}");
            if (dado1 == 1 && dado2 == 1) Console.WriteLine("Perdiste");
            if (total > 6) contador++;
             while (total < puntajeGanador && continuar == "s" && (dado1 != 1 || dado2 != 1))
             {
                if (dado1 == dado2)
                {
                    c++;
                    if (c == 3)
                    {
                       Console.WriteLine("Ganador Innato");
                       break;
                    }
                }
                else c = 0;
                Console.WriteLine("Desea continuar? (s/n)");
                continuar = Console.ReadLine();
                 if (continuar == "s")
                 {
                    dado1 = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);
                     if (dado1 == 1 && dado2 == 1)
                     {
                         Console.WriteLine($"Dados: {dado1} y {dado2}\n Perdiste");
                         break;
                     }
                     int totalNuevosDados = dado1 + dado2;
                     if (totalNuevosDados > 6) contador++;
                     total += totalNuevosDados;
                     Console.WriteLine($"Sus nuevos dados son: {dado1} y {dado2}, para un nuevo total de: {total}");
                 }
                 i++;
             }
             if (i > 0) porcentaje = Math.Round((((double)contador / i) * 100), 2);
             if (continuar == "n") Console.WriteLine($"El porcentaje de veces que obtuvo un total mayor de 6 fue: {porcentaje}%");
             if (total >= 100) Console.WriteLine("Ganaste y el porcentaje de veces que obtuvo un total mayor de 6 fue: "+porcentaje+"%");
        }
    }
}

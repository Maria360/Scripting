using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroP2_Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado=0, total=0, puntaje=100, vidas=1, unos=0, seis=0, especiales=2, dadoEspecial=0;
            string continuar = "s", usarEspecial = "n";
            while (continuar == "s" && vidas>0 && total<puntaje)
            {
                if (especiales > 0)
                {
                    Console.WriteLine($"Usted tiene {especiales} dados especiales\n¿Desea usar uno? (s/n)");
                    usarEspecial = Console.ReadLine();
                    if (usarEspecial == "s")
                    {
                        dadoEspecial = aleatorio.Next(1, 13);
                        total += dadoEspecial;
                        
                        
                        if (continuar == "n") break;
                        especiales--;
                        
                        if (dadoEspecial == 1) unos++;
                        if (dadoEspecial == 6) seis++;
                        else seis = 0;
                        if (vidas <= 3 && seis == 2) vidas++;
                        if (unos == 2)
                        {
                            //unos++;
                            vidas--;
                            if (total >= 10) total -= 10;
                            else total = 0;

                        }
                        if (especiales == 0) Console.WriteLine("Ya no tienes más dados especiales");
                        Console.WriteLine($"Su dado especial: {dadoEspecial}\nTotal: {total}\n¿Desea continuar?");
                        continuar = Console.ReadLine();
                    }
                }
                if(usarEspecial=="n"||especiales==0)
                {
                    dado = 6/*aleatorio.Next(1, 7)*/;
                    total += dado;
                    
                    
                    if (dado == 1) unos++;
                    if (dado == 6||seis!=2) seis++;
                    else seis = 0;
                    Console.WriteLine(seis);
                    if(vidas <= 3 && seis%2==0) vidas++;
                    if (unos == 2)
                    {
                        //unos++;
                        vidas--;
                        if (total >= 10) total -= 10;
                        else total = 0;
                        
                    }
                    if (vidas == 0)
                    {
                        Console.WriteLine($"Dado:{dado}\n¡Perdiste!\nTu total fue: {total}");
                        break;
                    }
                    Console.WriteLine($"Su dado : {dado}\nTotal: {total}\nVidas: {vidas}\n¿Desea continuar???");
                    continuar = Console.ReadLine();
                }

            }
            
            if (total >= puntaje) Console.WriteLine($"¡Ganaste!\nTu total fue: {total}");
        }
    }
}

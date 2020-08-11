using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int a = aleatorio.Next(0, 11), b = aleatorio.Next(0, 11), i=3;
            int sumaCorrecta = a + b;
            Console.WriteLine($"a: {a}\nb: {b}\nIngrese a+b:");
            int suma = int.Parse(Console.ReadLine());
            while (suma != sumaCorrecta && i!=0)
            {
                i--;
                if (i == 2) {
                    a = aleatorio.Next(0, 11);
                    b = aleatorio.Next(0, 11);
                    sumaCorrecta = a + b;
                    Console.WriteLine($"Te equivocaste. Tienes {i} intentos\n{a}+{b}=\nIngrese a+b:");
                    suma = int.Parse(Console.ReadLine());

                }
                if (i == 1) {
                    a = aleatorio.Next(0, 11);
                    b = aleatorio.Next(0, 11);
                    sumaCorrecta = a + b;
                    Console.WriteLine($"¡Error!. Solo tienes una última oportunidad\n{a}+{b}=\nIngrese a+b:");
                    suma = int.Parse(Console.ReadLine());
                }
            }
            if (suma == sumaCorrecta) Console.WriteLine("Puede continuar");
            else Console.WriteLine("Validación incorrecta, no puede continuar");
        }
    }
}

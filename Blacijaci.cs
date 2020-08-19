using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento_Blackjack
{
	class Program
	{
		static void Main(string[] args)
		{

			Random aleatorio = new Random();
			int carta1 = 0, carta2 = 0, total = 0, blacijaci = 21; // Mejor no usar i acá para dejarlo para los FOR
			Console.WriteLine("Número de jugadores:");
			int n = int.Parse(Console.ReadLine()); // Puede ser un número, no necesita ser un arreglo

			while (n < 2 || n > 5)
			{
				Console.WriteLine("Número de jugadores no permitido\nNúmero de jugadores:");
				n = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Nombres:");
			int[] totales = new int[n];
			string[] nombres = new string[n];
			for (int i = 0; i < nombres.Length; i++)
			{//Asignar valores al arreglo nombres
				nombres[i] = Console.ReadLine();
			}

			string continuar = "";
			for (int jugadorActual = 0; jugadorActual <n ; jugadorActual++)
			{ // La única condición que necesitamos es la del número de jugadores (incluso podría ser un FOR)
				total = 0;
				Console.WriteLine($"Jugador {nombres[jugadorActual]}, ¿Desea jugar?");
				continuar = Console.ReadLine(); //Esto podría sobras, podemos asumir que la primer vez el jugador siempre acepta jugar
				while (continuar != "s" && continuar != "n")
				{
					Console.WriteLine("Respuesta inválida\n¿Desea jugar?");
					continuar = Console.ReadLine();
				}
				if (continuar == "s")
				{
					carta1 = aleatorio.Next(1, 11);
					carta2 = aleatorio.Next(1, 11);
					total += carta1 + carta2;

					Console.WriteLine($"Cartas: {carta1} y {carta2}\nTotal: {total}");
					while (total < blacijaci && continuar == "s")
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
				if (continuar == "n" && total < blacijaci) Console.WriteLine("Su TOTAL es: " + total);

				if (total > blacijaci) total= 0;//para evitar que al ordenar se tenga en cuenta
				totales[jugadorActual] = total; // Podemos guardar el total sólo al final
			}


			for (int j = 0; j < totales.Length; j++)
			{//Ordenar puntajes Lo normal es usar las variables i y j
				for (int i = 0; i < totales.Length - 1; i++)
				{
					if (totales[i] < totales[i + 1])
					{
						int tmp = totales[i + 1];
						totales[i + 1] = totales[i];
						totales[i] = tmp;
						string tmp1 = nombres[i + 1]; //Ordenar nombres
						nombres[i + 1] = nombres[i];
						nombres[i] = tmp1;
					}
				}
			}
			for (int i = 0; i < totales.Length; i++)
			{//Prueba arreglo de totales y nombres
				Console.WriteLine(totales[i]);
				Console.WriteLine(nombres[i]);
			}
			if (total <= blacijaci)
			{
				Console.WriteLine($"El ganador es: {nombres[0]} con {totales[0]}");
				if (totales[1] != 0) Console.WriteLine($"El segundo lugar es: {nombres[1]} con {totales[1]}");
			}
			else Console.WriteLine("Perdedores");//funciona para cuando los 3 pierden
		}
	}
}

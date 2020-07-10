using System;

public class Program
{
	public static void Main()
	{
		// Entrada del usuario de la variable X1
		Console.Write("Ingrese X1: ");
		double x1 = double.Parse(Console.ReadLine());

		// Entrada del usuario de la variable Y1
		Console.Write("Ingrese Y1: ");
		double y1 = double.Parse(Console.ReadLine());

		// Entrada del usuario de las variables restantes
		Console.Write("Ingrese X2: ");
		double x2 = double.Parse(Console.ReadLine());
		Console.Write("Ingrese Y2: ");
		double y2 = double.Parse(Console.ReadLine());

		//Calculo pendiente
		double m = (y2 - y1) / (x2 - x1);
		double b = y1 - (m * x1);
		double Dx = x2 - x1 , Dy = y2 - y1;
		double DxPow = Math.Pow(Dx, 2);
		double DyPow = Math.Pow(Dy, 2);
		double distancia = Math.Sqrt(DxPow + DyPow);
		Console.Write($"La pendiente es: {m} , el intercepto es: {b} y la distancia es {distancia}");
		Console.ReadLine();
	}
}

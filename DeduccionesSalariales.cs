using System;

public class Program
{
	public static void Main()
	{
		// Entrada de datos
		Console.Write("Escriba 1 si su contrato es independiente y 2 si es dependiente\n");
		int contrato = int.Parse(Console.ReadLine()); // 1 = Independiente | 2 = Dependiente
		Console.Write("Ingrese su salario mensual: \n");
		int salario = int.Parse(Console.ReadLine());
		double cotizacion = salario * 40 / 100;
		int smmlv = 980657;
		double arl;
		double salarioReal;
		double ingresoAnual;
		// Entradas adicionales...

		if (contrato == 1)
		{ // Independiente
            if (cotizacion < smmlv)
            {
				cotizacion = smmlv;
				Console.Write("Ingrese su clase de riesgo:\n|1|2|3|4|5|\n");
				int nivelRiesgo = int.Parse(Console.ReadLine());
				switch (nivelRiesgo)
				{
					case 1:
						arl = cotizacion * 0.522 / 100;
						break;
					case 2:
						arl = cotizacion * 1.044 / 100;
						break;
					case 3:
						arl = cotizacion * 2.436 / 100;
						break;
					case 4:
						arl = cotizacion * 4.350 / 100;
						break;
					default:
						arl = cotizacion * 6.960 / 100;
						break;
				}
				double pension = cotizacion * 16 / 100;
				double eps = cotizacion * 12.5 / 100;
				salarioReal = salario - arl - eps - pension;
				ingresoAnual = salarioReal * 12;
				Console.Write($"Salario Real: {salarioReal} y las deducciones son:\narl:{arl}\npensión:{pension}\neps:{eps}\nEl salario anual es:{ingresoAnual}\n");

			}
            else
            {
				Console.Write("Ingrese su clase de riesgo:\n|1|2|3|4|5|\n");
				int nivelRiesgo = int.Parse(Console.ReadLine());
				switch (nivelRiesgo)
				{
					case 1:
						arl = cotizacion * 0.522 / 100;
						break;
					case 2:
						arl = cotizacion * 1.044 / 100;
						break;
					case 3:
						arl = cotizacion * 2.436 / 100;
						break;
					case 4:
						arl = cotizacion * 4.350 / 100;
						break;
					default:
						arl = cotizacion * 6.960 / 100;
						break;
				}
				double pension = cotizacion * 16 / 100;
				double eps = cotizacion * 12.5 / 100;
				salarioReal = salario - arl - eps - pension;
				ingresoAnual = salarioReal * 12;
				Console.Write($"Salario Real: {salarioReal} y las deducciones son:\narl:{arl}\npensión:{pension}\neps:{eps}\nEl salario anual es:{ingresoAnual}\n");
			}
			
	
		}
		else
		{ // Dependiente
			if (cotizacion < smmlv)
			{
				cotizacion = smmlv;
				arl = 0;
				double pension = cotizacion * 4 / 100;
				double eps = cotizacion * 4 / 100;
				salarioReal = salario - arl - eps - pension;
				ingresoAnual = salarioReal * 12;
				Console.Write($"Salario Real: {salarioReal} y las deducciones son:\narl:{arl}\npensión:{pension}\neps:{eps}\nEl salario anual es:{ingresoAnual + salario}\n");

			}
			else
			{
				arl = 0;
				double pension = cotizacion * 4 / 100;
				double eps = cotizacion * 4 / 100;
				salarioReal = salario - arl - eps - pension;
				ingresoAnual = salarioReal * 12;
				Console.Write($"Salario Real: {salarioReal} y las deducciones son:\narl:{arl}\npensión:{pension}\neps:{eps}\nEl salario anual es:{ingresoAnual+salario}\n");
			}
		}

	}
}
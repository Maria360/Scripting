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
		double cotizacion = salario * 0.4, arl, salarioReal, ingresoAnual,pension,eps;
		int smmlv = 877803;
		if (cotizacion < smmlv) cotizacion = smmlv;

		switch (contrato)
        {
			case 1:
				
				Console.Write("Ingrese su clase de riesgo:\n|1|2|3|4|5|\n");
				int nivelRiesgo = int.Parse(Console.ReadLine());
				switch (nivelRiesgo)
				{
					case 1: arl = cotizacion * 0.00522; break;
					case 2: arl = cotizacion * 0.01044; break;
					case 3: arl = cotizacion * 0.02436; break;
					case 4: arl = cotizacion * 0.04350; break;
					default: arl = cotizacion * 0.06960; break;
				}
				pension = cotizacion * 0.16;
				eps = cotizacion * 0.125;
				salarioReal = salario - arl - eps - pension;
				ingresoAnual = salarioReal * 12;
				Console.Write($"Salario Real: {(int)salarioReal} y las deducciones son:\narl:{(int)arl}\npensión:{(int)pension}\neps:{(int)eps}\nEl salario anual es:{(int)ingresoAnual}\n");break;
			default:

				arl = 0;
				pension = cotizacion * 0.04;
				eps = cotizacion * 0.04;
				salarioReal = salario - arl - eps - pension;
				ingresoAnual = salarioReal * 12;
				Console.Write($"Salario Real: {(int)salarioReal} y las deducciones son:\narl:{(int)arl}\npensión:{(int)pension}\neps:{(int)eps}\nEl salario anual es:{(int)(ingresoAnual + salario)}\n");break;


		}

		
	}
}
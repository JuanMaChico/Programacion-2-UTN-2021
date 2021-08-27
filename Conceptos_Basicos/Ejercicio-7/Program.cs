using System;

namespace Ejercicio_7
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ejercicio-7\n");
			//Hacer un programa que pida por pantalla la fecha de nacimiento de una persona(día, mes y año) y
			//calcule el número de días vividos por esa persona hasta la fecha actual(tomar la fecha del sistema
			//con DateTime.Now).
			//Nota: Utilizar estructuras selectivas.Tener en cuenta los años bisiestos.

			DateTime fechaNacimiento;
			string dia;
			string mes;
			string anno;

			Console.Write("Ingrese Fecha de Nacimiento (AAAA/MM/DD): ");
			

			if (DateTime.TryParse(Console.ReadLine(), out fechaNacimiento))
			{
				Console.WriteLine("OK");
			}
			else
			{
				Console.WriteLine("Fecha Invalida");
			}


		}
	}
}

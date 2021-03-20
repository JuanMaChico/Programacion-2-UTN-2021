using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

				/*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
				calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
				con DateTime.Now).
				Nota: Utilizar estructuras selectivas.Tener en cuenta los años bisiestos.*/
namespace Ejercicio_7__guia
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 7";

			DateTime fechaActual = DateTime.Now;
			DateTime fechaNacimiento;

			Console.WriteLine("Ingrese su fecha de nacimiento(dd/mm/aaaa): ");
			
			while (!DateTime.TryParse(Console.ReadLine(), out fechaNacimiento))
			{
				Console.WriteLine("La fecha ingresada es invalida \n -Ingrese su fecha de nacimiento(dd/mm/aaaa): ");
			}

			Console.WriteLine((int)(DateTime.Now - fechaNacimiento).TotalDays);


			Console.ReadKey();
		}
	}
}

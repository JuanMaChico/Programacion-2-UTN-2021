using System;
using System.Globalization;

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
			DateTime fechaActual = DateTime.Today;
			string diasVividos;

			//Bucle para validar el dato del usuario
            while (true)
            {
				//Mostramos por pantalla la interaccion con el usuario
				Console.Write("Ingrese Fecha de Nacimiento (AAAA/MM/DD): ");
				//Validamos el dato ingresado por el usuario
				if (DateTime.TryParse(Console.ReadLine(), out fechaNacimiento)) 
				{
					//verificamos que la fecha ingresada sea menos a la fecha actual
					if (fechaNacimiento < fechaActual)
					{
						//Calculamos la diferencia de dias
						diasVividos = (fechaActual - fechaNacimiento).ToString(@"dd\d\ ");
						//Mostramos los dias vividos al usuario
						Console.WriteLine($"Usted a vivido {diasVividos}");
						//Salimos del bucle
						break;
					}
					else
						//Si la fecha ingresada exede a la actual, mostramos este mensaje y volvemos a arrancar el bucle
						Console.WriteLine("ERROR....Fecha del Futuro...");
				}
				else
					//Si la fecha no cumple con el formato mostramos este mensaje y volvemos a arrancar el bucle
					Console.WriteLine("ERROR....Fecha Invalida");
				
            }
		}
	}
}

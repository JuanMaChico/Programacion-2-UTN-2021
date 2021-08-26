using System;

namespace Ejercicio_6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ejercicio-6");
			//Escribir un programa que determine si un año es bisiesto.
			//Un año es bisiesto si es múltiplo de 4.Los años múltiplos de 100 no son bisiestos, salvo si ellos
			//también son múltiplos de 400.Por ejemplo: el año 2000 es bisiesto pero 1900 no.
			//Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
			//Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).

			//solicitamos ingreso de datos al usuario
			int annoInicio = IngreseNumero("-Ingrese año de inicio: ");
			int annoFin = IngreseNumero("-Ingrese año de fin: ");


			//recorremos los annos indicados por el usuario
			for (int i = annoInicio; i <= annoFin; i++)
			{
				if (i % 4 == 0 && i % 100 != 0)
					Console.WriteLine($"{i} ->Es Bisiesto");
				else if (i % 4 == 0 & i % 100 == 0 & i % 400 == 0)
					Console.WriteLine($"{i} ->Es Bisiesto");
			}


			//Funcion de ingreso int por consola
			int IngreseNumero(string texto)
			{
				int numeroIngresado;
				while (true)
				{
					Console.Write(texto);
					if (int.TryParse(Console.ReadLine(), out numeroIngresado))
						break;
					else
						Console.WriteLine("ERROR...Ingreso Invalido\n");
				}
					return numeroIngresado;
			}
		}
	}
}

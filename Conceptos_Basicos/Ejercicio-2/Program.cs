using System;

namespace Ejercicio_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ejercicio-2");
			//Ingresar un número y mostrar: el cuadrado y el cubo del mismo.Se debe validar que el número sea
			//mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
			//Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.

			double numeroIngresado;
			double numeroCuadrado;
			double numeroCubo;

			while (true)
			{
				Console.Write("Ingrese un Numero: ");
				if (double.TryParse(Console.ReadLine(), out numeroIngresado))
				{
					numeroCuadrado = Math.Pow(numeroIngresado, 2);
					numeroCubo = Math.Pow(numeroIngresado, 3);
					Console.WriteLine($"Numero ingresado ^2: {numeroCuadrado}");
					Console.WriteLine($"Numero ingresado ^3: {numeroCubo}");
					break;
				}
				else
				{
					Console.WriteLine("Error.. Ingreso invalido.\n");
				}
			}

		}
	}
}

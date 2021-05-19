using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;

										/*
										Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la
										siguiente firma: bool Validar(int valor, int min, int max):

										a.valor: dato a validar
										b. min y max: rango en el cual deberá estar la variable valor.

										Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
										anteriormente que esten dentro del rango -100 y 100.
										Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
										Nota: Utilizar variables escalares, NO utilizar vectores.*/


namespace Clase_1_Laboratorio
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 11";
			Console.WriteLine("Ejercicio 11");
			int numeroIngresado;

			int cantidadInteraciones = 10;
			int max = int.MinValue;
			int min = int.MaxValue;

			float promedioAux = 0;
			float promedio=0;


			for (int i = 1; i <= cantidadInteraciones; i++)
			{
				Console.Write("{0}-Ingrese Un numero: ", i);

				if (int.TryParse(Console.ReadLine(), out numeroIngresado))
				{
					if (Validacion.Validar(numeroIngresado, -100, 100))
					{
						if (numeroIngresado > max)
						{
							max = numeroIngresado;
						}
						if (numeroIngresado < min)
						{
							min = numeroIngresado;
						}
						promedioAux = promedioAux + numeroIngresado;
					}
				}
				else 
				{
					i--;
					Console.Write("Ingrese un numero valido.");
				}
			}
			promedio = promedioAux / cantidadInteraciones;

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Minimo: {0}",min);

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Maximo: {0}",max);

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Promedio: {0}",promedio);

			Console.ReadKey();
		}
	}
}

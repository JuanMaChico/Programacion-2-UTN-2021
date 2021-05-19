using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;
						/*
						Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
						cálculo del área que corresponda:
						a. double CalcularCuadrado(double)
						b. double CalcularTriangulo(double, double)
						c. double CalcularCirculo(double)
						El ingreso de los datos como la visualización se deberán realizar desde el método Main().
						*/

namespace Ejercicio_14
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 14";
			int opcion;
			double resultado=0;
			bool menu = true;

			do
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("-Calculadora de Perimetros-");
				Console.WriteLine("-1- Calcular Perimetro de un Cuadrado.");
				Console.WriteLine("-2- Calcular Perimetro de un Triangulo.");
				Console.WriteLine("-3- Calcular Perimetro de un Circulo.");
				Console.WriteLine("-4- Salir");

				do
				{
					Console.Write("-Ingrese Opcion: ");
					if (int.TryParse(Console.ReadLine(), out opcion))
					{
						break;
					}
					else
					{
						Console.Write("Ingrese una opcion Valida.");
					}
				} while (true);

				switch (opcion)
				{
					case 1:
						Console.WriteLine("Ingresar Lado del Cuadrado.");
						resultado = CalculoDeArea.CalcularCuadrado(InputInt.Input());
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("El perimetro del cuadrado es: {0}", resultado);
						Console.ReadKey();
						break;
					case 2:
						Console.WriteLine("Ingresar Primero Base, Luego Altura.");
						resultado = CalculoDeArea.CalcularTriangulo(InputInt.Input(), InputInt.Input());
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("El perimetro del triangulo es: {0}", resultado);
						Console.ReadKey();
						break;
					case 3:
						Console.WriteLine("Ingresar Radio.");
						resultado = CalculoDeArea.CalcularCirculo(InputInt.Input());
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("El perimetro del circulo es: {0}",resultado);
						Console.ReadKey();
						break;
					case 4:
						menu = false;
						break;
				}
			} while (menu);
		}
	}
}

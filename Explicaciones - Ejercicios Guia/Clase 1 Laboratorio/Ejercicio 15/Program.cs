using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;
							/*
							Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
							multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
							operación que desea realizar (pulsando el caracter +, -, * ó /).
							El usuario decidirá cuándo finalizar el programa.
							Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
							a.Calcular(público): Recibirá tres parámetros, el primer número, el segundo número y la
							operación matemática. El método devolverá el resultado de la operación.
							b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
							utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
							TRUE si el número es distinto de CERO.*/

namespace Ejercicio_15
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 15";
			string errores;
			double resultados;
			char operador;
			char continuar;

			double operandoA;
			double operandoB;

			do
			{
				do
				{
					Console.Write("-Ingrese Primer numero: ");
					if (double.TryParse(Console.ReadLine(), out operandoA))
					{
						break;
					}
					else
					{
						Console.Write("!Error.Ingrese un numero valido.");
					}
				} while (true);

				do
				{
					Console.Write("-Ingrese Segundo numero: ");
					if (double.TryParse(Console.ReadLine(), out operandoB))
					{
						break;
					}
					else
					{
						Console.Write("!Error.Ingrese un numero valido.");
					}
				} while (true);

				do
				{
					Console.Write("-Ingrese Operacion( +, - , * , /): ");
					if (char.TryParse(Console.ReadLine(), out operador))
					{
						break;
					}
					else
					{
						Console.Write("!Error.Ingrese un numero valido.");
					}
				} while (true);

				resultados = Calculadora.Calcular(operandoA, operandoB, operador, out errores);

				Console.WriteLine("Resultado de la operacion: {0}",resultados);

				Console.Write("Continuar? (S/N)");
				char.TryParse(Console.ReadLine(), out continuar);

			} while (ValidarRespuesta.ValidarS_N(continuar));





			Console.ReadKey();
		}
	}
}

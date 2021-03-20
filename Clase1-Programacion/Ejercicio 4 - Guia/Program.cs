using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

									/*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
									(excluido el mismo) que son divisores del número.
									El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
									Escribir una aplicación que encuentre los 4 primeros números perfectos.
									Nota: Utilizar estructuras repetitivas y selectivas.*/
namespace Ejercicio_4___Guia
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 4";
			int contador = 0;
			int cantDePerfectos = 4;
			int num=0;
			int acumulador = 0;
			
			do
			{
				num++;
				for (int i = 1; i < num; i++)
				{
					if (num%i == 0)
					{
						acumulador += i;
					}
				}
				if (acumulador == num)
				{
					contador++;
					Console.WriteLine("Numero Perfecto: {0}",num);
				}
				acumulador = 0;
			} while (contador <= cantDePerfectos);
			Console.ReadKey();
		}
	}
}

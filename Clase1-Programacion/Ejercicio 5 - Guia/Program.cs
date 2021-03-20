using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


									/*Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
									dos grupos de números, cuyas sumas son iguales.
									El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8)
									cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
									49) en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595.
									Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
									usuario ingrese por consola.
									Nota: Utilizar estructuras repetitivas y selectivas.*/
namespace Ejercicio_5___Guia
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 5";
			string numeroIngresado;
			int auxIngresado;

			int acumuladorA = 0;
			
			int contador;
			
			do
			{
				Console.WriteLine("Ingrese un numero: ");
				numeroIngresado = Console.ReadLine();

			} while (!(int.TryParse(numeroIngresado, out auxIngresado)));


			for (int centro = 1; centro <= auxIngresado; centro++)
			{
				//Acumulo para abajo del Centro
				for (int i = 1; i < centro; i++)
				{
					acumuladorA += i;
				}
				//Calculo numeros superiores al centro
				contador = centro + 1;
				do
				{
					acumuladorA -= contador;
					contador++;

				} while (acumuladorA > 0);
				if (acumuladorA == 0)
				{
					Console.WriteLine("{0} es centro numerico", centro);
				}
				else
				{
					Console.WriteLine("{0} no es centro numerico",centro);
				}
			}

			



			Console.ReadKey();
		}
	}
}

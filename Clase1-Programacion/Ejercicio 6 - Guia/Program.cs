using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


					/*Escribir un programa que determine si un año es bisiesto.
					Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
					también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
					Pedirle al usuario un año de anio y otro de fin y mostrar todos los años bisiestos en ese rango.
					Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/

namespace Ejercicio_6___Guia
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = ("Ejercicio 6");

			string anoInicio;
			int auxInicio;

			string anoFin;
			int auxFin;

			do
			{
				Console.WriteLine("Ingrese un anio de Inicio: ");
				anoInicio = Console.ReadLine();

			} while (!(int.TryParse(anoInicio, out auxInicio)));

			do
			{
				Console.WriteLine("Ingrese un anio de Fin: ");
				anoFin = Console.ReadLine();

			} while (!(int.TryParse(anoFin, out auxFin)));

			for (int anio = auxInicio; anio <= auxFin ; anio++)
			{
				if (anio % 4 == 0)
				{
					if (anio % 100 != 0 || anio % 100 == 0 && anio % 400 == 0)
					{
						Console.WriteLine("Es Bisiesto: {0} \n",anio);
					}
				}

			}







			Console.ReadKey();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10__Guia
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 10";
			string alto;
			int altoPiramide;
			string piramide = " ";
			string espacios;

			do
			{
				Console.WriteLine("Ingrese alto de la piramide: ");
				alto = Console.ReadLine();

			} while (!(int.TryParse(alto, out altoPiramide)));

			for (int i = 0; i < altoPiramide; i++)
			{
				if (i == 0)
				{
					piramide = "*";
				}
				else
				{
					piramide = piramide + "**";
				}
				espacios = "";
				espacios = espacios.PadLeft(altoPiramide - (i + 1));
				Console.WriteLine(espacios + piramide);

			}

			Console.ReadKey();
		}
	}
}

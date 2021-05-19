using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9___Guia
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 9";
			string alto;
			int altoPiramide;
			string piramide = " ";

			do
			{
				Console.WriteLine("Ingrese alto de la piramide: ");
				alto = Console.ReadLine();

			} while (!(int.TryParse(alto, out altoPiramide)));

			for (int i = 0; i <= altoPiramide; i++)
			{
				piramide = piramide + "*";
				Console.WriteLine(piramide);

			}




			Console.ReadKey();
		}
	}
}

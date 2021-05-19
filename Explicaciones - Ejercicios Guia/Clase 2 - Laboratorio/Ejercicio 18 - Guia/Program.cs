using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_De_Clases;
using Geometria;
namespace Ejercicio_18___Guia
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 18";

			Punto vertice1 = new Punto(0,0);
			Punto vertice2 = new Punto(2,2);

			Rectangulo testRectangulo = new Rectangulo(vertice1,vertice2);

			testRectangulo.GetArea();
			testRectangulo.GetPerimetro();

			testRectangulo.Area();
			testRectangulo.Perimetro();

			Console.WriteLine(testRectangulo.Area());
			Console.WriteLine(testRectangulo.Perimetro());

			Console.WriteLine(Rectangulo.InfoRectangulo(testRectangulo));

			Console.ReadKey();
		}
	}
}

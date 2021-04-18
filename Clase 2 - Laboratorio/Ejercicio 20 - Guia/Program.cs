using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20___Guia
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 20";

			Dolar dolar1 = new Dolar(10);
			Dolar dolar2 = new Dolar(20);

			Euro euro1 = new Euro(10);
			Euro euro2 = new Euro(30);

			Pesos pesos1 = new Pesos(10);
			Pesos pesos2 = new Pesos(50);

			bool comparacionDolares = dolar1 == dolar2;
			Console.WriteLine("\n-dolar1 y dolar2 son iguales?: {0}", (comparacionDolares) ? "yes" : "no");

			bool comparaEuro = euro1 == euro2;
			Console.WriteLine("\n-euro1 y euro2 son iguales?: {0}", (comparaEuro) ? "yes" : "no");

			bool comparaPesos = pesos1 == pesos2;
			Console.WriteLine("\n-pesos1 y pesos2 son iguales?: {0}", (comparaPesos) ? "yes" : "no");

			bool compararPesosConEuros = pesos1 == euro1;
			Console.WriteLine("\n-pesos1 y euros1 son iguales?: {0}", (compararPesosConEuros) ? "yes" : "no");



			Dolar sumaD1yE1 = dolar1 + euro1;
			Console.WriteLine("\nLa Suma entre dolar1 y euro1 es: {0}", sumaD1yE1.GetCantidad());

			Dolar sumaD2yE2 = dolar2 + euro2;
			Console.WriteLine("\nLa Suma entre dolar2 y euro2 es: {0}", sumaD2yE2.GetCantidad());

			Pesos sumaP1yE2 = pesos1 + euro2;
			Console.WriteLine("\nLa Suma entre Pesos1 y Euro2 es: {0}", sumaP1yE2.GetCantidad());




			Console.ReadKey();
		}
	}
}

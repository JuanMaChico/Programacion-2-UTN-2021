using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;
		/*Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
		  string DecimalBinario(int). Convierte un número de entero a binario.
		  int BinarioDecimal(string). Convierte un número binario a entero.
		  NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.
		*/

namespace Ejercicio_13
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 13";
			int numeroIngresado;
			string binario;
			int ndecimal;

			numeroIngresado = InputInt.Input();

			Console.WriteLine("Numero original Ingresado: {0}",numeroIngresado);

			binario = Conversor.DecimalBinario(numeroIngresado);
			ndecimal = Conversor.BinarioDecimal(binario);

			Console.WriteLine("Decimal a binario: {0}",binario);
			Console.WriteLine("Binario a decimal: {0}",ndecimal);




			Console.ReadKey();
		}
	}
}

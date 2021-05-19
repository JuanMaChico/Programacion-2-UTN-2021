using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;

								/*Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
								un mensaje "¿Continuar? (S/N)".
								En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
								opciones.
								El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
								cualquier otro valor.*/
namespace Ejercicio_12
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 12";
			char continuar;
			int suma = 0;
			string numeroIngresado;

			do
			{
				Console.Write("Ingrese un numero: ");
				numeroIngresado = Console.ReadLine();

				suma = suma + int.Parse(numeroIngresado);				 

				Console.Write("Continuar? (S/N)");
				char.TryParse(Console.ReadLine(),out continuar);
				

			} while (ValidarRespuesta.ValidarS_N(continuar));

			Console.WriteLine("El valor de la suma: {0}",suma);



			Console.ReadKey();
		}
	}
}

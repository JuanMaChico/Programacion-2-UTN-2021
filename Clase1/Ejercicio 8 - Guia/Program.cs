using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


				/*Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
				trabajadas en el mes de N empleados de una fábrica.

				Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
				valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
				multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
				descuentos.
				Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
				bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
				Nota: Utilizar estructuras repetitivas y selectivas.*/


namespace Ejercicio_8___Guia
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 8";
			int cantidad=10;
			string nombre;
			string valorHora;
			string antiguedad;

			string [] nombres    = new string  [cantidad];
			float  [] valorHoras  = new float   [cantidad];
			int    [] antiguedades = new int     [cantidad];

			for (int i = 0; i < cantidad; i++)
			{
				Console.WriteLine("Ingrese Nombre: ");
				nombre = Console.ReadLine();

				Console.WriteLine("Ingrese Valor Hora: ");
				valorHora = Console.ReadLine();

				Console.WriteLine("Ingrese Antiguedad: ");
				antiguedad = Console.ReadLine();



			}
			








			Console.ReadKey();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
	public class InputInt
	{
		public static int Input()
		{
			int numeroIngresado;
			do
			{
				Console.Write("-Ingrese Un numero: ");
				if (int.TryParse(Console.ReadLine(), out numeroIngresado))
				{
					break;
				}
				else
				{
					Console.Write("Ingrese un numero valido.");
				}
			} while (true);

			return numeroIngresado;
		}


	}
}

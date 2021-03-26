using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
	public class Calculadora
	{
		public static double Calcular(double a, double b,char operacion,out string error) 
		{
			double retorno = 0;
			error = " ";
			if (Validar(b))
			{
				switch (operacion)
				{
					case '/':
						retorno = a / b;
						break;
					
					case '+':
						retorno = a + b;
						break;

					case '-':
						retorno = a - b;
						break;

					case '*':
						retorno = a * b;
						break;
					default:
						error = "ERROR! Operacion aritmetica no valida.";
						retorno = 0;
						break;
				}
			}
			else
			{
				error = "ERROR! No se admite Divicion por 0 (Cero).";
				retorno = 0;
			}
			return retorno;
		}


		/// <summary>
		/// Valida que A sea distinto de 0(Cero)
		/// </summary>
		/// <param name="a"></param>
		/// <returns>Retorna true en caso de que todo este correcto</returns>
		private static bool Validar(double a)
		{
			bool retorno = true;
			if (a == 0 )
			{
				retorno = false;
			}
			return retorno;
		}
	}
}

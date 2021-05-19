using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases
{
	public class NumeroDecimal
	{
		private double numero;

		private NumeroDecimal(double n)
		{
			this.numero = n;
		}
		
		public double Numero 
		{
			get 
			{
				return this.numero;
			}
		}

		public string DecimalBinario(double numero)
		{
			string resultado = string.Empty;
			while (numero > 0)
			{
				double resto = numero % 2;
				numero = numero / 2;
				resultado = resto.ToString() + resultado;
			}
			return resultado;
		}

		public static explicit operator NumeroDecimal(double numero)
		{
			return new NumeroDecimal(numero);
		}
		public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
		{
			return (NumeroBinario)numeroDecimal.DecimalBinario(numeroDecimal.Numero);
		}





	}
}

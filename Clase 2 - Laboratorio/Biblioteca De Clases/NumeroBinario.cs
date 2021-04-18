using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases
{
	public class NumeroBinario
	{
		private string numero;

		private NumeroBinario(string numero)
		{
			this.numero = numero;
		}
		public string Numero 
		{
			get
			{
				return this.numero;
			}
		}

		public double BinarioDecimal(string n)
		{
			double retorno = 0;
			int bit;

			for (int i = n.Length - 1; i >= 0; i--)
			{
				bit = n[i] - '0';
				retorno += bit * (int)(Math.Pow(2, (n.Length - 1) - i));
			}
			return retorno;
		}
		public static explicit operator NumeroBinario(string numero)
		{
			return new NumeroBinario(numero);
		}
		public static explicit operator NumeroDecimal(NumeroBinario numeroBinario) 
		{
			return (NumeroDecimal)numeroBinario.BinarioDecimal(numeroBinario.Numero);
		}






	}
}

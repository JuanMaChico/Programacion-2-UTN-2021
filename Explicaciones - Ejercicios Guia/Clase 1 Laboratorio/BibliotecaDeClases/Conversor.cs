using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
	public class Conversor
	{
		public static string DecimalBinario(int n)
		{
			string resultado = string.Empty;
			while (n > 0)
			{
				int resto = n % 2;
				n = n / 2;
				resultado = resto.ToString() + resultado;
			}
			return resultado;
		}

		public static int BinarioDecimal(string n)
		{
			int retorno=0;
			char aux;
			int bit;

			for (int i = n.Length-1; i >= 0; i--)
			{
				bit = n[i] -'0';
				retorno += bit * (int)(Math.Pow(2, (n.Length-1) - i));
			}
			return retorno;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
	public class ValidarRespuesta
	{
		public static bool ValidarS_N(char c) 
		{
			char continuar;
			bool retorno = false;
			continuar = char.ToLower(c);

			if (continuar.Equals('s'))
			{
				retorno = true;
			}
			return retorno;
		}
	}
}

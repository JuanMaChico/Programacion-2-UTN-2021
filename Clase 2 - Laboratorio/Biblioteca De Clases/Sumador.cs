using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases
{
	public class Sumador
	{
		private int cantidadSumas;


		public Sumador()
		{
			this.cantidadSumas = 0;
		}
		public Sumador(int cantidadSumas) : this()
		{
			this.cantidadSumas = cantidadSumas;
		}

		public int GetCantidadSumas() 
		{
			return this.cantidadSumas;
		}

		public long Sumar(long a, long b) 
		{
			long respuesta = a + b;
			this.cantidadSumas++;
			return respuesta;
		}
		public string Sumar(string a, string b)
		{
			string respuesta = string.Concat(a,b);
			this.cantidadSumas++;
			return respuesta;
		}
		public static explicit operator int(Sumador s)
		{
			return s.cantidadSumas;
		}
		public static bool operator |(Sumador s1, Sumador s2)
		{
			bool retorno = false;
			if (s1.cantidadSumas == s2.cantidadSumas)
			{
				retorno = true;
			}
			return retorno;
		}
		public static long operator +(Sumador s1, Sumador s2)
		{
			long retorno;
			retorno = s1.cantidadSumas  +  s2.cantidadSumas;
			return retorno;
		}



	}
}

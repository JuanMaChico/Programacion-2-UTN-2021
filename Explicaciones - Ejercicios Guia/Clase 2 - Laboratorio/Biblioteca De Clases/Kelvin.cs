using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases
{
	public class Kelvin
	{
		private double gradosK;



		private Kelvin()
		{
			this.gradosK = 0;
		}

		public Kelvin(double cantidad) : this()
		{
			this.gradosK = cantidad;
		}
		public double GetGrados()
		{
			return this.gradosK;
		}

		public static implicit operator Kelvin(double grados)
		{
			return new Kelvin(grados);
		}
		public static explicit operator Fahrenheit(Kelvin k)
		{
			return new Fahrenheit(k.gradosK * (9.0/5.0) - 459.67);
		}
		public static explicit operator Celsius(Kelvin k)
		{
			Fahrenheit kelvinCastF = (Fahrenheit)k;
			Celsius fcastC = (Celsius)kelvinCastF;
			return fcastC;
		}
		public static bool operator ==(Kelvin k, Fahrenheit f)
		{
			bool retorno = false;
			if (k == (Kelvin)f)
			{
				retorno = true;
			}
			return retorno;
		}
		public static bool operator !=(Kelvin k, Fahrenheit f)
		{
			return !(k == f);
		}
		public static bool operator ==(Kelvin k, Celsius c)
		{
			bool retorno = false;
			if (k == (Kelvin)c)
			{
				retorno = true;
			}
			return retorno;
		}
		public static bool operator !=(Kelvin k, Celsius c)
		{
			return !(k == c);
		}




	}
}

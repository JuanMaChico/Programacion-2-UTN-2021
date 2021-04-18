using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases
{
	public class Fahrenheit
	{
		private double gradosF;


		private Fahrenheit()
		{
			this.gradosF = 0;
		}

		public Fahrenheit(double cantidad)
		{
			this.gradosF = cantidad;
		}
		public double GetGrados()
		{
			return this.gradosF;
		}

		public static implicit operator Fahrenheit(double grados)
		{
			return new Fahrenheit(grados);
		}

		public static explicit operator Celsius(Fahrenheit f) 
		{
			return new Celsius((f.gradosF - 32.0) * (5.0 / 9.0));
		}
		public static explicit operator Kelvin(Fahrenheit f)
		{
			return new Kelvin((f.gradosF + 459.67) * (5.0 / 9.0));
		}
		public static bool operator ==(Fahrenheit f, Celsius c)
		{
			bool retorno = false;
			if (f == (Fahrenheit)c)
			{
				retorno = true;
			}
			return retorno;
		}
		public static bool operator !=(Fahrenheit f, Celsius c)
		{
			return !(f == c);
		}
		public static bool operator ==(Fahrenheit f, Kelvin k)
		{
			bool retorno = false;
			if (f == (Kelvin)k)
			{
				retorno = true;
			}
			return retorno;
		}
		public static bool operator !=(Fahrenheit f, Kelvin k)
		{
			return !(f == k);
		}








	}
}

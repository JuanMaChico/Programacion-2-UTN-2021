using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases
{
	public class Celsius
	{
		private double gradosC;

		private Celsius()
		{
			this.gradosC = 0;
		}
		public Celsius(double cantidad) : this()
		{
			this.gradosC = cantidad;
		}

		public double GetGrados() 
		{
			return this.gradosC;
		}

		public static implicit operator Celsius(double grados)
		{
			return new Celsius(grados);
		}

		public static explicit operator Fahrenheit(Celsius c)
		{
			return new Fahrenheit((c.GetGrados() * (9.0 / 5.0) + 32.0));
		}
		public static explicit operator Kelvin(Celsius c)
		{
			Fahrenheit celsiusCastF = (Fahrenheit)c;
			Kelvin celsiusCastKelvin = (Kelvin)celsiusCastF;
			return celsiusCastKelvin;
		}
		public static bool operator ==(Celsius c, Fahrenheit f)
		{
			bool retorno = false;
			if (c == (Celsius)f)
			{
				retorno = true;
			}
			return retorno;
		}
		public static bool operator !=(Celsius c, Fahrenheit f)
		{
			return !(c == f);
		}
		public static bool operator ==(Celsius c, Kelvin k)
		{
			bool retorno = false;
			if (c == (Celsius)k)
			{
				retorno = true;
			}
			return retorno;
		}
		public static bool operator !=(Celsius c, Kelvin k)
		{
			return !(c == k);
		}



	}
}

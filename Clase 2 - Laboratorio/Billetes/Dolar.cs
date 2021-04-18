using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
	public class Dolar
	{
		private double cantidad;
		private double cotizRespectoDolar;

		private Dolar() 
		{
			this.cantidad = 0;
			this.cotizRespectoDolar = 1;
		}
		public Dolar(double cantidad):this()
		{
			this.cantidad = cantidad;
		}
		public Dolar(double cantidad,double cotizacion):this(cantidad)
		{
			this.cantidad = cantidad;
			this.cotizRespectoDolar = cotizacion;
		}
		public double GetCantidad() 
		{
			return this.cantidad;
		}
		public double GetCotizacion() 
		{
			return this.cotizRespectoDolar;
		}

		public static implicit operator Dolar(double d)
		{
			return new Dolar(d);
		}

		public static explicit operator Euro(Dolar d)
		{
			Euro e = new Euro(1);
			double cotizacion = e.GetCotizacion();
			double cantidad = d.cantidad * cotizacion;
			e = (Euro)cantidad;
			return e;
		}
		public static explicit operator Pesos(Dolar d) 
		{
			Pesos p = new Pesos(1);
			double cotizacion = p.GetCotizacion();
			double cantidad = d.cantidad * cotizacion;
			p = (Pesos)cantidad;
			return p;
		}
		public static bool operator ==(Dolar d, Euro e) 
		{
			bool retorno = false;
			if (d == (Dolar)e)
			{
				retorno = true;
			}
			return retorno; 
		}
		public static bool operator !=(Dolar d, Euro e)
		{
			return !(d == e);
		}
		public static bool operator ==(Dolar d, Pesos p)
		{
			bool retorno = false;
			if (d == (Dolar)p)
			{
				retorno = true;
			}
			return retorno;
		}
		public static bool operator !=(Dolar d, Pesos p)
		{
			return !(d == p);
		}
		public static bool operator ==(Dolar d1, Dolar d2)
		{
			bool retorno = false;
			if (d1.cantidad == d2.cantidad)
			{
				retorno = true;
			}
			return retorno;
		}
		public static bool operator !=(Dolar d1, Dolar d2)
		{
			return !(d1 == d2);
		}

		public static Dolar operator +(Dolar d, Euro e)
		{
			Dolar eConvertido = (Dolar)e;
			d.cantidad = d.cantidad + eConvertido.cantidad;
			return d;
		}
		public static Dolar operator -(Dolar d, Euro e)
		{
			Dolar eConvertido = (Dolar)e;
			d.cantidad = d.cantidad - eConvertido.cantidad;
			return d;
		}

		public static Dolar operator +(Dolar d, Pesos p)
		{
			Dolar pConvertido = (Dolar)p;
			d.cantidad = d.cantidad + pConvertido.cantidad;
			return d;
		}
		public static Dolar operator -(Dolar d, Pesos p)
		{
			Dolar pConvertido = (Dolar)p;
			d.cantidad = d.cantidad - pConvertido.cantidad;
			return d;
		}
	}
}

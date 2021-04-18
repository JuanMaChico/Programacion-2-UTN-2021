using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
	public class Euro
	{
		private double cantidad;
		private double cotizRespectoDolar;


		private Euro()
		{
			this.cantidad = 0;
			this.cotizRespectoDolar = 1.08;
		}
		public Euro(double cantidad) : this()
		{
			this.cantidad = cantidad;
		}
		public Euro(double cantidad, double cotizacion) : this(cantidad)
		{
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
		public static implicit operator Euro(double e) 
		{
			return new Euro(e);
		}
		public static explicit operator Dolar(Euro e) 
		{
			return new Dolar(e.cantidad * e.cotizRespectoDolar);
		}
		public static explicit operator Pesos(Euro e)
		{
			double cantidad = e.cantidad * e.cotizRespectoDolar;
			Pesos p = new Pesos(1);
			Dolar d = new Dolar(cantidad);
			p = (Pesos)d;			
			return p;
		}

		public static bool operator ==(Euro e, Dolar d)
		{
			bool retorno = false;
			if (e == (Euro)d)
			{
				retorno = true;
			}
			return retorno;
		}
		public static bool operator !=(Euro e, Dolar d)
		{
			return !(e == d);
		}

		public static bool operator ==(Euro e, Pesos p)
		{
			bool retorno = false;
			if (e == (Euro)p)
			{
				retorno = true;
			}
			return retorno;
		}
		public static bool operator !=(Euro e, Pesos p)
		{
			return !(e == p);
		}


		public static bool operator ==(Euro e1, Euro e2)
		{
			bool retorno = false;
			if (e1.cantidad == e2.cantidad)
			{
				retorno = true;
			}
			return retorno;
		}
		public static bool operator !=(Euro d1, Euro d2)
		{
			return !(d1 == d2);
		}

		public static Euro operator +(Euro e, Dolar d)
		{
			Euro dConvertido = (Euro)d;
			e.cantidad = e.cantidad + dConvertido.cantidad;
			return e;
		}
		public static Euro operator -(Euro e, Dolar d)
		{
			Euro dConvertido = (Euro)d;
			e.cantidad = e.cantidad - dConvertido.cantidad;
			return e;
		}

		public static Euro operator +(Euro e, Pesos p)
		{
			Euro pConvertido = (Euro)p;
			e.cantidad = e.cantidad + pConvertido.cantidad;
			return e;
		}
		public static Euro operator -(Euro e, Pesos p)
		{
			Euro pConvertido = (Euro)p;
			e.cantidad = e.cantidad - pConvertido.cantidad;
			return e; ;
		}
	}
}

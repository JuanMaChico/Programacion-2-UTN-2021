using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private double cotizRespectoDolar;

        private Pesos()
        {
            this.cantidad = 0;
            this.cotizRespectoDolar = 66;
        }
        public Pesos(double cantidad):this()
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, double cotizacion): this(cantidad)
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
        public static implicit operator Pesos(double p)
        {
            return new Pesos(p);
        }
        public static explicit operator Dolar(Pesos p)
		{
            return new Dolar(p.cantidad * p.cotizRespectoDolar);
		}
        public static explicit operator Euro(Pesos p)
        {
            Dolar d = new Dolar(1);
            d = (Dolar)p;
            Euro e = new Euro(1);
            e = (Euro)d;
            return e;
        }




		public static bool operator ==(Pesos p, Dolar d)
		{
			bool retorno = false;
			if (p == (Pesos)d)
			{
				retorno = true;
			}
			return retorno;
		}
		public static bool operator !=(Pesos p, Dolar d)
		{
			return !(p == d);
		}

		public static bool operator ==(Pesos p, Euro e)
		{
			bool retorno = false;
			if (p == (Pesos)e)
			{
				retorno = true;
			}
			return retorno;
		}
		public static bool operator !=(Pesos p, Euro e)
		{
			return !(p == e);
		}


		public static bool operator ==(Pesos p1, Pesos p2)
		{
			bool retorno = false;
			if (p1.cantidad == p2.cantidad)
			{
				retorno = true;
			}
			return retorno;
		}
		public static bool operator !=(Pesos p1, Pesos p2)
		{
			return !(p1 == p2);
		}

		public static Pesos operator +(Pesos p, Dolar d)
		{
			Pesos dConvertido = (Pesos)d;
			p.cantidad = p.cantidad + dConvertido.cantidad;
			return p;
		}
		public static Pesos operator -(Pesos p, Dolar d)
		{
			Pesos dConvertido = (Pesos)d;
			p.cantidad = p.cantidad + dConvertido.cantidad;
			return p;
		}

		public static Pesos operator +(Pesos p, Euro e)
		{
			Pesos eConvertido = (Pesos)e;
			p.cantidad = p.cantidad + eConvertido.cantidad;
			return p;
		}
		public static Pesos operator -(Pesos p, Euro e)
		{

			Pesos eConvertido = (Pesos)e;
			p.cantidad = p.cantidad - eConvertido.cantidad;
			return p;
		}




	}
}

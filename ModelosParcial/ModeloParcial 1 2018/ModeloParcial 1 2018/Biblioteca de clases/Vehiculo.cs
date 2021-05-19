using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
	public abstract class Vehiculo
	{
		protected DateTime ingreso;
		private string patente;

		public Vehiculo(string patente) 
		{
			this.Patente = patente;
			this.ingreso = DateTime.Now.AddHours(-3);
		}

		public string Patente 
		{
			get 
			{
				return patente;
			}
			
			set 
			{
				if (value.Length == 6)
				{
					patente = value;
				}
			}
		}

		public static bool operator ==(Vehiculo v1, Vehiculo v2)
		{
			return v1.Equals(v2);
		}

		public static bool operator !=(Vehiculo v1, Vehiculo v2) 
		{
			return !(v1 == v2);
		}


		public override string ToString()
		{
			return string.Format("Patente: {0}",this.Patente);
		}

		public abstract string ConsultarDatos();

		public virtual string ImprimirTicket()
		{
			StringBuilder retorno = new StringBuilder();
			retorno.AppendLine(this.ToString());
			retorno.Append("Ingreso");
			retorno.AppendLine(this.ingreso.ToString());
			return retorno.ToString();
		}


	}
}

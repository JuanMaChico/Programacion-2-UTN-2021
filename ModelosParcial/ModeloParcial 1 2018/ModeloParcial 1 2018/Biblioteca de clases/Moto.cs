using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
	public class Moto : Vehiculo
	{
		private int cilindrada;
		private short ruedas;
		static int valorHora;

		static Moto() 
		{
			valorHora = 30;
		}
		public Moto(string patente, int cilindrada) : base (patente)
		{
			this.cilindrada = cilindrada;
		}
		public Moto(string patente, int cilindrada,short ruedas) : this(patente,cilindrada)
		{
			this.ruedas = ruedas;
		}

		public Moto(string patente, int cilindrada, short ruedas, int vh) : this(patente, cilindrada,ruedas)
		{
			valorHora = vh;
		}

		public override string ConsultarDatos() 
		{
			StringBuilder retorno = new StringBuilder();
			retorno.Append("Patente: ");
			retorno.AppendLine(this.Patente);
			retorno.Append("Ruedas: ");
			retorno.AppendLine(this.ruedas.ToString());
			retorno.Append("Valor Hora: ");
			retorno.AppendLine(valorHora.ToString());
			return retorno.ToString();
		}


		public override string ImprimirTicket() 
		{
			StringBuilder retorno = new StringBuilder();
			retorno.AppendLine(base.ToString());
			retorno.Append("Fecha de ingreso: ");
			retorno.AppendLine(this.ingreso.ToString());
			retorno.Append("Estadia: ");
			DateTime actual = DateTime.Now;
			TimeSpan diferencia = actual - this.ingreso;
			float estadia = diferencia.Hours * Moto.valorHora;
			retorno.AppendLine(estadia.ToString());
			return retorno.ToString();
		}

		public override bool Equals(object obj)
		{
			if (obj is Moto && this.Patente == ((Moto)obj).Patente)
			{
				return true;
			}
			return false;
		}
	}
}

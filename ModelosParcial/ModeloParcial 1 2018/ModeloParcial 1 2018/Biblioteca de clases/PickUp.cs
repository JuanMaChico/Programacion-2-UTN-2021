using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
	public class PickUp : Vehiculo
	{
		private string modelo;
		static int valorHora;


		static PickUp() 
		{
			valorHora = 70;
		}

		public PickUp(string patente, string modelo) : base (patente)
		{

		}
		public PickUp(string patente, string modelo, int valorHora) : this(patente , modelo)
		{

		}

		public override string ConsultarDatos()
		{
			StringBuilder retorno = new StringBuilder();
			retorno.Append("Patente: ");
			retorno.AppendLine(this.Patente);
			retorno.Append("Valor Hora: ");
			retorno.AppendLine(valorHora.ToString());
			return retorno.ToString();
		}

		public override bool Equals(object obj)
		{
			return obj is PickUp up && Patente == up.Patente;
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
			float estadia = diferencia.Hours * PickUp.valorHora;
			retorno.AppendLine(estadia.ToString());
			return retorno.ToString();
		}


	}
}

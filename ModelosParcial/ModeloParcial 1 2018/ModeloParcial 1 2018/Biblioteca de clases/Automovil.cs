using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
	public class Automovil : Vehiculo
	{
		private ConsoleColor color;
		static int valorHora;

		static Automovil() 
		{
			valorHora = 50;
		}

		public Automovil(string patente, ConsoleColor color) : base (patente)
		{
			this.color = color;
		}

		public Automovil(string patente, ConsoleColor color, int vh) : this(patente, color)
		{
			valorHora = vh;
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

		public override string ImprimirTicket() 
		{
			StringBuilder retorno = new StringBuilder();
			retorno.AppendLine(base.ToString());
			retorno.Append("Fecha de ingreso: ");
			retorno.AppendLine(this.ingreso.ToString());
			retorno.Append("Estadia: ");
			DateTime actual = DateTime.Now;
			TimeSpan diferencia = actual - this.ingreso;
			
			Console.WriteLine(diferencia.Hours);
			Console.WriteLine(Automovil.valorHora);

			float estadia = diferencia.Hours * Automovil.valorHora;
			retorno.AppendLine(estadia.ToString());
			return retorno.ToString();
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}




	}
}

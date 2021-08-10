using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chico.JuanManuel._2C
{
	public class Moto : Vehiculo
	{
		private Etipo tipo;
		private static double valorHora;

		static Moto()
		{
			valorHora = 100;
		}

		public Moto(string patente, DateTime horaIngreso, Etipo tipo)
							: base(patente, horaIngreso)
		{
			this.tipo = tipo;
		}


		public static double ValorHora
		{
			set
			{
				if (value > 0)
				{
					valorHora = value;
				}
			}
		}

		public override double CostoEstadia
		{
			get
			{

				return this.CargoDeEstacionamiento() * valorHora;
			}
		}

		public override string Descripcion
		{
			get
			{
				return this.tipo.ToString();
			}
		}

		protected string MostrarDatos()
		{
			StringBuilder retorno = new StringBuilder();
			retorno.AppendLine("\n****MOTO****");
			retorno.AppendLine(string.Format("Tipo: {0}", this.Descripcion));
			retorno.AppendLine(string.Format("Patente: {0}", this.Patente));
			return retorno.ToString();
		}



		public override string ToString()
		{
			return this.MostrarDatos();
		}

	public enum Etipo 
	{
		Ciclomotor,
		Scooter,
		Sport
	}
	}
}

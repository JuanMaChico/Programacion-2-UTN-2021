using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chico.JuanManuel._2C
{
	public class Automovil : Vehiculo
	{
		private string marca;
		private static double valorHora;



		static Automovil() 
		{
			valorHora = 120;
		}

		public Automovil(string patente, DateTime horaIngreso, string marca)
							: base(patente, horaIngreso)
		{
			this.marca = marca;
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
				return this.marca;
			}
		}
		public static double ValorHora
		{
			set
			{
				if (valorHora > 0)
				{
					valorHora = value;
				}
			}
		}

		protected string MostrarDatos()
		{
			StringBuilder retorno = new StringBuilder();
			retorno.AppendLine("\n****AUTOMOVIL****");
			retorno.AppendLine(string.Format("Marca: {0}",this.Descripcion));
			retorno.AppendLine(string.Format("Patente: {0}", this.Patente));
			return retorno.ToString();
		}

		/// <summary>
		/// Muesta informacion del Automovil
		/// </summary>
		/// <returns>String</returns>
		public override string ToString()
		{
			return this.MostrarDatos();
		}






	}
}

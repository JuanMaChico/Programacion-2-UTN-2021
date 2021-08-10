using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chico.JuanManuel._2C
{
    public abstract class Vehiculo
    {
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;

		/// <summary>
		/// Constructor publico de la clase Vehiculo
		/// </summary>
		/// <param name="patente">Patente del vehiculo, asignada desde la propiedad</param>
		/// <param name="horaIngreso">Hora de ingreso del vehiculo, asignado desde la propiedad</param>
		public Vehiculo(string patente, DateTime horaIngreso)
		{
			this.Patente = patente;
			this.HoraIngreso = horaIngreso;
		}
		public DateTime HoraIngreso
		{
			get 
			{ 
				return this.horaIngreso; 
			}
			set
			{
				this.horaIngreso = value;
			}
		}

		public DateTime HoraEgreso
		{
			get 
			{ 
				return this.horaEgreso;
			}
			set 
			{
				if (value > this.horaIngreso)
				{
					horaEgreso = value;
				}
			}
		}


		public string Patente
		{
			get 
			{ 
				return this.patente;
			}

			set 
			{
				if (ValidarPatente(value))
				{
					this.patente = value;
				}
			}
		}
		/// <summary>
		/// Corrobora que la pantente cuente con 6 o 7 dijistos
		/// </summary>
		/// <param name="patente">Patente del vehiculo</param>
		/// <returns></returns>
		private bool ValidarPatente(string patente)
		{
			if (patente.Length >= 6)
			{
				return true;
			}
			return false;
		}

		/// <summary>
		/// Propiedades Abstractas de solo lectura
		/// </summary>
		public abstract double CostoEstadia { get; }
		/// <summary>
		/// Propiedades Abstractas de solo lectura
		/// </summary>
		public abstract string Descripcion{ get; }



		/// <summary>
		/// retorna la cantidad de horas que permanecio el Vehiculo
		/// en el estacionamiento
		/// </summary>
		/// <returns>Double en horas</returns>
		protected double CargoDeEstacionamiento() 
		{
			DateTime actual = DateTime.Now;
			TimeSpan diferencia = actual - this.HoraIngreso;
			double retorno = diferencia.Hours;
			return retorno;
		}

		/// <summary>
		/// Informacion del vehiculo alojado en el estacionamiento
		/// </summary>
		/// <returns>Patente y hora de ingreso</returns>
		protected string MostrarDatos()
		{
			StringBuilder retorno = new StringBuilder();
			retorno.Append(string.Format("Patente: {0}",this.Patente));
			retorno.Append(string.Format("Hora De Ingreso: {0}", this.HoraIngreso));
			return retorno.ToString();
		}


		/// <summary>
		/// Verifica la identidad de un vehiculo comparando sus patentes
		/// </summary>
		/// <param name="v1">Objeto Vehiculo 1</param>
		/// <param name="v2">Objeto Vehiculo 2</param>
		/// <returns>True si las patentes son identicas</returns>
		public static bool operator ==(Vehiculo v1, Vehiculo v2)
		{
			if (string.IsNullOrEmpty(v1.patente) && string.IsNullOrEmpty(v2.patente))
			{
				if (v1.Patente == v2.Patente)
				{
					return true;
				}
			}
			return false;
		}
		public static bool operator !=(Vehiculo v1, Vehiculo v2)
		{
			return !(v1 == v2);
		}

	public enum EVehiculos
	{
		Automovil,
		Moto
	}

	}
}

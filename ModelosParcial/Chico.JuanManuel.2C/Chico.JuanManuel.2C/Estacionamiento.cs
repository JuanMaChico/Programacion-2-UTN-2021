using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chico.JuanManuel._2C
{
	public class Estacionamiento
	{
		private int capacidadEstacionamiento;
		private static Estacionamiento estacionamiento;
		private List<Vehiculo> listadoVehiculos;
		private string nombre;


		private Estacionamiento(string nombre, int capacidad)
		{
			listadoVehiculos = new List<Vehiculo>();
			this.nombre = nombre;
			this.capacidadEstacionamiento = capacidad;
		}

		public List<Vehiculo> ListadoVehiculos 
		{
			get 
			{
				return this.listadoVehiculos;
			}
		}
		public string Nombre 
		{
			get { return this.nombre; }
		}



		public static Estacionamiento GetEstacionamiento(string nombre, int capacidad) 
		{
			if (estacionamiento is null)
			{
				estacionamiento = new Estacionamiento(nombre, capacidad);
			}
			else 
			{
				estacionamiento.capacidadEstacionamiento = capacidad;
			}
			return estacionamiento;
		}


		public string InformarSalida(Vehiculo vehiculo) 
		{
			StringBuilder retorno = new StringBuilder();

			retorno.AppendLine(string.Format("Estacionamiento: {0} ",this.Nombre));
			retorno.AppendLine(vehiculo.ToString());
			retorno.AppendLine(string.Format("Ingreso: {0}",vehiculo.HoraIngreso.ToString()));
			retorno.AppendLine(string.Format("Egreso: {0}", vehiculo.HoraEgreso.ToString()));
			retorno.AppendLine(string.Format("Cargos por Estacionamiento: ${0}", vehiculo.CostoEstadia.ToString()));
			return retorno.ToString();
		}

		public static bool operator ==(Estacionamiento e, Vehiculo v)
		{
			foreach (Vehiculo item in e.listadoVehiculos)
			{
				if (item == v)
				{
					return true;
				}
			}
			return false;
		}
		public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
		{
			return !(estacionamiento == vehiculo);
		}


		public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
		{
			if (estacionamiento != vehiculo && estacionamiento.capacidadEstacionamiento > estacionamiento.listadoVehiculos.Count())
			{
				estacionamiento.listadoVehiculos.Add(vehiculo);
				return true;
			}
			return false;
		}


		public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
		{
			if (estacionamiento == vehiculo)
			{
				vehiculo.HoraEgreso = DateTime.Now;
				estacionamiento.listadoVehiculos.Remove(vehiculo);
				return true;
			}
			return false;
		}

	}
}

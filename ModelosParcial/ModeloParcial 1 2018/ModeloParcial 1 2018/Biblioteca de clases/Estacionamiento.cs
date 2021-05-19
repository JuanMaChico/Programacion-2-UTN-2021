using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;



        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }
        
        /// <summary>
        /// Retorna informacion del estacionamiento, y su lista de Vehiculos
        /// </summary>
        /// <param name="e">Estacionamiento</param>
        
        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("**Informacion del Estacionamiento**");
            retorno.Append("- Nombre del Estacionamiento: ");
            retorno.AppendLine(e.nombre);
            retorno.Append("- Espacios Disponibles: ");
            retorno.AppendLine(e.espacioDisponible.ToString());
            retorno.AppendLine("- Listado de Vehiculos-");
            foreach (Vehiculo item in e.vehiculos)
            {
                retorno.AppendLine(string.Format("- {0}",item.Patente));
            }
            return retorno.ToString();
        }


        /// <summary>
        /// Verifica la existencia de un vehiculo en el estacionamiento
        /// </summary>
        /// <param name="e">Estacionamiento donde se verificara la existencia del vehiculo</param>
        /// <param name="v">Vehiculo del cual se corroborara la existencia</param>
        /// <returns>True si existe, false si no</returns>
        public static bool operator ==(Estacionamiento e, Vehiculo v) 
        {
			foreach (Vehiculo item in e.vehiculos)
			{
				if (item.Equals(v))
				{
                    return true;
				}
			}
            return false;
        }
        /// <summary>
        /// Verifica la existencia de un vehiculo en el estacionamiento
        /// </summary>
        /// <param name="e">Estacionamiento donde se verificara la existencia del vehiculo</param>
        /// <param name="v">Vehiculo del cual se corroborara la existencia</param>
        /// <returns>False si existe, True si no</returns>
        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo) 
        {
            if (estacionamiento != vehiculo && estacionamiento.espacioDisponible > estacionamiento.vehiculos.Count() && vehiculo.Patente != null)
			{
                estacionamiento.vehiculos.Add(vehiculo);
			}
            return estacionamiento;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            string retorno;
			if (estacionamiento == vehiculo)
			{
                retorno = vehiculo.ImprimirTicket();
                estacionamiento.vehiculos.Remove(vehiculo);
                return retorno;
			}
            return "El vehículo no es parte del estacionamiento";
        }

    }
}

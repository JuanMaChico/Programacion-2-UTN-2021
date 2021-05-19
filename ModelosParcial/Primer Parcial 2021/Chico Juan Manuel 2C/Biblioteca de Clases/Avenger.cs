using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
	public class Avenger : Personaje
	{
		private EEquipamiento equipamiento;
		
		/// <summary>
		/// Constructor de Avenger, encargado de cargar el equipo y llamar a la clase base para cargar nombre y habilidad
		/// </summary>
		/// <param name="nombre">Nombre del Avenger</param>
		/// <param name="hab">Habilidad del Avenger</param>
		/// <param name="equipo">Equipo del Avenger</param>
		public Avenger(string nombre, List<EHabilidades> hab,EEquipamiento equipo) : base (nombre, hab)
		{
			this.equipamiento = equipo;	
		}
		/// <summary>
		/// Propiedad Geter que sobreescribe a la propiedad por defecto de la clase base
		/// </summary>
		protected override string Nombre 
		{
			get 
			{
				return string.Format("Mi nombre es: {0} y si no puedo proteger la tierra la vengare",base.Nombre);
			}
		}

		/// <summary>
		/// Sobrecarga del metodo tostring, encargado de formatear la informacion del avenger
		/// </summary>
		/// <returns>Retorna la informacion como tipo String</returns>
		public override string ToString()
		{
			StringBuilder texto = new StringBuilder();
			texto.AppendLine("************AVENGER************");
			texto.AppendLine(base.ToString());
			texto.Append("Equipamiento Principal: ");
			texto.AppendLine(this.equipamiento.ToString());
			return texto.ToString();
		}

	}
}

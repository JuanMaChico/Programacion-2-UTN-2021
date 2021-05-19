using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
	public class Enemigo : Personaje
	{
		private string objetivo;

		/// <summary>
		/// Constructor de la clase enemigo, encargado de cargar el Objetivo del enemigo.
		/// llama a la clase base para setear nombre y habilidad.
		/// </summary>
		/// <param name="nombre">Nombre del Enemigo</param>
		/// <param name="hab">Habilidad del Enemigo</param>
		/// <param name="objetivo">Objetivo del Enemigo</param>
		public Enemigo(string nombre, List<EHabilidades> hab, string objetivo) : base(nombre, hab)
		{
			this.objetivo = objetivo;
		}
		/// <summary>
		/// Sobreescritura de la propiedad heredada, encargada de aplicar el estilo de lectura de la clase.
		/// </summary>
		protected override string Nombre
		{
			get
			{
				return string.Format("Soy: {0} y los voy a hacer pure", base.Nombre);
			}
		}

		/// <summary>
		/// Metodo encargado de tranformar la informacion en string para poder ser visivilizada por el usuario.
		/// </summary>
		/// <returns>String con informacion del Enemigo</returns>
		public override string ToString()
		{
			StringBuilder texto = new StringBuilder();
			//texto.AppendLine(this.Nombre);
			texto.AppendLine("************ENEMIGO************");
			texto.AppendLine(base.ToString());
			texto.AppendLine(this.objetivo);
			return texto.ToString();
		}
	}
}

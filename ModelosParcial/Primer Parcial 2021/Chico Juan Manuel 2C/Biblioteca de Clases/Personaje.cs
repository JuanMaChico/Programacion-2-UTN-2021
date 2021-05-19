using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public abstract class Personaje
    {
        private List<EHabilidades> listaHabilidades;
        protected string nombre;

		/// <summary>
		/// Constructor Privado de Personaje, instancia la lista de habilidades.
		/// </summary>
		private Personaje()
		{
			this.listaHabilidades = new List<EHabilidades>();
		}

		/// <summary>
		/// Constructor de la clase personaje, encargado de setear nombre y habilidades en la lista previamente instanciada.
		/// </summary>
		/// <param name="nombre">Nombre del Personaje</param>
		/// <param name="habilidades">Habilidades del Personaje</param>
		public Personaje(string nombre, List<EHabilidades> habilidades)
		{
			this.nombre = nombre;
			this.listaHabilidades = habilidades;
		}
		
		/// <summary>
		/// Geter para obtener la lista de habilidades, encargado de devolver los datos como String
		/// </summary>
		private string ListaHabilidades
		{
			get 
			{
				StringBuilder lista = new StringBuilder();
				foreach (EHabilidades item in listaHabilidades)
				{
					lista.AppendLine(item.ToString());
				}
				return lista.ToString(); 
			}
		}

		/// <summary>
		/// Implementacion por defecto de la propiedad Get, para obtener el nombre del personaje.
		/// </summary>
		protected virtual string Nombre 
		{
			get 
			{
				return this.nombre;
			}
		}

		/// <summary>
		/// Sobreescritura del metodo ToString a fin de devolver la informacion del personaje
		/// </summary>
		/// <returns>retorna la informacion del personaje</returns>
		public override string ToString()
		{
			StringBuilder informacionPJ = new StringBuilder();
			informacionPJ.AppendLine(this.Nombre);
			informacionPJ.AppendLine("Lista de Habilidades: ");
			informacionPJ.AppendLine(this.ListaHabilidades);
			return informacionPJ.ToString();
		}

		/// <summary>
		/// Verifica la existencia del personaje en la lista.
		/// </summary>
		/// <param name="listaPersonajes">Lista de personajes donde se buscara el personaje</param>
		/// <param name="personaje">Personaje que sera buscado en la lista</param>
		/// <returns>True si el personaje se encuentra en la lista, False caso contrario</returns>
		public static bool operator ==(List<Personaje> listaPersonajes, Personaje personaje)
		{
			foreach (Personaje item in listaPersonajes)
			{
				if (item.nombre == personaje.nombre && item.GetType() == personaje.GetType())
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Verifica la No existencia del personaje en la lista.
		/// </summary>
		/// <param name="listaPersonajes">Lista de personajes donde se buscara el personaje</param>
		/// <param name="personaje">Personaje que sera buscado en la lista</param>
		/// <returns>False si el personaje se encuentra en la lista, True caso contrario</returns>
		public static bool operator !=(List<Personaje> listaPersonajes, Personaje personaje)
		{
			return !(listaPersonajes == personaje);
		}

		/// <summary>
		/// Suma un personaje a la lista siempre y cuando este no exista en la misma.
		/// </summary>
		/// <param name="listaPersonajes">Lista a la que se agrega el personaje</param>
		/// <param name="personaje">Personaje a agregar a la lista</param>
		/// <returns></returns>
		public static List<Personaje> operator +(List<Personaje> listaPersonajes, Personaje personaje)
		{
			if (listaPersonajes != personaje)
			{
				listaPersonajes.Add(personaje);
			}
			return listaPersonajes;
		}
}

}

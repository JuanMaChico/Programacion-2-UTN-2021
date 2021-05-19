using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
	public static class Marvel
	{
		private static List<Personaje> listaPersonajes;
		
		/// <summary>
		/// Constructor estatico de la Clase Marvel, Encargado de instanciar la lista de personajes.
		/// </summary>
		static Marvel()
		{
			listaPersonajes = new List<Personaje>();
		}

		/// <summary>
		/// Set de lista de personajes, encargado de incluir los personajes a la lista. 
		/// </summary>
		public static Personaje Personaje
		{
			set 
			{
				listaPersonajes = listaPersonajes + value;
			}
		}

		/// <summary>
		/// Metodo Mostrar Informacion, encargado de mostrar la informacion completa del personaje.
		/// </summary>
		/// <returns> String con la informacion del personaje</returns>
		public static string MostrarInformacion()
		{
			StringBuilder texto = new StringBuilder();
			foreach (Personaje item in listaPersonajes)
			{
				texto.AppendLine(item.ToString());
			}
			return texto.ToString();
		}
	}


	/// <summary>
	/// Enumerado con los Equipamientos 
	/// </summary>
	public enum EEquipamiento
	{
		Armadura,
		Escudo,
		Martillo,
		Arco,
		Transformacion,
		ArtesMarciales
	}

	/// <summary>
	/// Enumerado con las Habilidades.
	/// </summary>
	public enum EHabilidades
	{
		Volar,
		SuperFuerza,
		Resistencia,
		Rayos,
		Energia,
		InteligenciaSuperior,
		Sigilo,
		Astucia
	}
}

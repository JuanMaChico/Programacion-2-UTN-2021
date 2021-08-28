using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
	public class Conductor
	{
		//Atributos
		string nombre;
		Dictionary<int, int> kmsSemanales = new Dictionary<int, int>();
		
		public string Nombre { get => nombre; set => nombre = value; }
		public Dictionary<int, int> KmsSemanales { get => kmsSemanales; set => kmsSemanales = value; }

		public Conductor(string nomb, int[] kms)
		{
			Nombre = nomb;

			for (int i = 0; i < 7; i++)
			{
				KmsSemanales.Add(i + 1, kms[i]);
			}
		}


		/// <summary>
		/// Muestra la cantidad de kms totales recorridos en una semana
		/// </summary>
		/// <returns>cantidad de kms totales recorridos en una semana </returns>
		public int MostrarKmsSemanales() 
		{
			int kmsTotales = 0;
			foreach (var item in KmsSemanales)
			{
				kmsTotales += item.Value;
			}
			return kmsTotales;
		}

		/// <summary>
		/// Devuelve el valor de kilometros del dia pasado como parametro
		/// </summary>
		/// <param name="dia">Dia del que se quiere saber cantidad de kms</param>
		/// <returns>Cantidad de Kilometros recorridos</returns>
		public int KmsXdia(int dia) 
		{
			int retorno =0;
			foreach (var item in KmsSemanales)
			{
				if (dia == item.Key)
				{
					retorno = item.Value;
				} 
			}
			return retorno;
		}




	}
}

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
		int kms;

		public string Nombre { get => nombre; set => nombre = value; }
		public int Kms { get => kms; set => kms = value; }

		public Conductor(string nomb, int kms)
		{
			Nombre = nomb;
			Kms = kms;
		}






	}
}

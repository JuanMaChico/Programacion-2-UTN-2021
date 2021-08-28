using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
	public class Transporte
	{
		List<Conductor> conductores = new List<Conductor>();

		public Transporte(Conductor c1, Conductor c2, Conductor c3)
		{
			conductores.Add(c1);
			conductores.Add(c2);
			conductores.Add(c3);
		}


		public string ConductorMasKmsSemanales() 
		{
			string nombre="";
			int maxKmsSemanales = int.MinValue;
			foreach (var item in conductores)
			{
				if (item.MostrarKmsSemanales() > maxKmsSemanales)
				{
					nombre = item.Nombre;
					maxKmsSemanales = item.MostrarKmsSemanales();
				}
			}
			return $"El conductor {nombre} fue el que mas kms hizo con {maxKmsSemanales}";
		}

		public string ConductorMasKmsDia(int dia) 
		{
			int maxKmsDia = int.MinValue;
			string nombre="";
			foreach (var item in conductores)
			{
				if (item.KmsXdia(dia) > maxKmsDia)
				{
					nombre = item.Nombre;
					maxKmsDia = item.KmsXdia(dia);
				}
			}
			return $"El chofer con mas KMS el dia {dia} es {nombre} con {maxKmsDia}";
		}










	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
	public class Alumno
	{
		// Atributos

		string nombre;
		string apellido;
		float nota1;
		float nota2;


		public Alumno(string nomb, string ape, float n1, float n2)
		{
			this.nombre = nomb;
			this.apellido = ape;
			this.nota1 = n1;
			this.nota2 = n2;
		}

		public string MostrarPromedio() 
		{
			float promedio = (nota1 + nota2) / 2;
			return $"El promedio del alumno{nombre} {apellido} es: {promedio}";
		}

	}
}

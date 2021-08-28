using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
	public class Persona
	{
		//Atributos
		string nombre;
		int edad;
		string dni;

		public string Nombre { get => nombre; set => nombre = value; }
		public int Edad { get => edad; set => edad = value; }
		public string Dni { get => dni; set => dni = value; }
		
		public Persona(string nom, int ed,string doc)
		{
			Nombre = nom;
			Edad = ed;
			Dni = doc;
		}

		public string Mostrar()
		{
			return $"Nombre: {Nombre}\nEdad: {Edad}\nDNI: {Dni}";
		}

		public string EsMayorDeEdad() 
		{
			return (Edad > 18) ? "Es Mayor de edad\n" : "Es menor de edad\n";
		}



	}
}

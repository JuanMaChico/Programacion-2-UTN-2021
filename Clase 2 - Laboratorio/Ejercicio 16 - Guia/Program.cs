using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_De_Clases;

namespace Clase_2___Laboratorio
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 16";


			Alumno alumnoUno = new Alumno("Juan","Chico",444);
			Alumno alumnoDos = new Alumno("Sasha", "Lospa", 476);
			Alumno alumnoTres = new Alumno("Charly", "Lospa", 456);
			
			
			alumnoUno.Estudiar(9,6);
			alumnoDos.Estudiar(3, 4);
			alumnoTres.Estudiar(10, 9);

			alumnoUno.CalcularFinal();
			alumnoDos.CalcularFinal();
			alumnoTres.CalcularFinal();

			Console.Write(alumnoUno.Mostrar());

			Console.Write(alumnoDos.Mostrar());

			Console.Write(alumnoTres.Mostrar());

			Console.ReadKey();
		}
	}
}

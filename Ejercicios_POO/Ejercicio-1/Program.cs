using System;

namespace Ejercicio_1
{
	class Program
	{
		static void Main(string[] args)
		{
			//	Crear la clase Alumno que contenga la siguiente información:
			//	Atributos:
			//		• nombre
			//		• apellido
			//		• nota1
			//		• nota2
			//	Constructor: Deberá tener un constructor que permita cargarle información a los 4
			//	atributos.
			//	Métodos: El método “mostrar promedio” deberá mostrar el promedio de las notas del
			//	alumno.
			//	Cargar 3 alumnos en el main y mostrarlos por pantalla.

			Console.WriteLine("\n Ejercicio-1_POO \n");

			//Instanciamos la clase Alumno
			Alumno a1 = new Alumno("Juan", "Chico", 9, 5);
			Alumno a2 = new Alumno("Pepe", "Rodriges", 8, 7);
			Alumno a3 = new Alumno("Sasha", "Lospa", 2, 4);
			Alumno a4 = new Alumno("Carlos", "Lospa", 5, 9);

			//Mostramos el metodo Mostrar promedio
			Console.WriteLine(a1.MostrarPromedio());
			Console.WriteLine(a2.MostrarPromedio());
			Console.WriteLine(a3.MostrarPromedio());
			Console.WriteLine(a4.MostrarPromedio());

		}
	}
}

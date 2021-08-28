using System;

namespace Ejercicio_2
{
	class Program
	{
		static void Main(string[] args)
		{	/*	Crear una clase llamada Persona.
					Sus atributos son:
						• nombre,
						• edad
						• DNI.
				Construir los siguientes métodos para la clase:
					• Los setters y getters para cada uno de los atributos.
					• mostrar(): Muestra los datos de la persona.
					• esMayorDeEdad(): Devuelve un valor “Es mayor de edad” indicando si es
						mayor de edad.Sino devuelve “es menor”.
				 Crear 3 personas en el main y mostrar quienes son mayores de edad, y quienes no.
			 */
			Console.WriteLine("\nEjercicio-2_POO\n");

			Persona p1 = new Persona("Juan", 24, "40.547.247");
			Persona p2 = new Persona("Sasha", 24, "40.547.246");
			Persona p3 = new Persona("carlos", 14, "40.547.249");
			Persona p4 = new Persona("facu", 11, "40.543.245");

			Console.WriteLine(p1.Mostrar());
			Console.WriteLine(p1.EsMayorDeEdad());
			
			Console.WriteLine(p2.Mostrar());
			Console.WriteLine(p2.EsMayorDeEdad());
			
			Console.WriteLine(p3.Mostrar());
			Console.WriteLine(p3.EsMayorDeEdad());
			
			Console.WriteLine(p4.Mostrar());
			Console.WriteLine(p4.EsMayorDeEdad());




		}
	}
}

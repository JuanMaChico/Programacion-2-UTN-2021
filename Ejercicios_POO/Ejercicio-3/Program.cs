using System;

namespace Ejercicio_3
{
	class Program
	{
		static void Main(string[] args)
		{
			//	Crea una clase llamada Cuenta que tendrá los siguientes atributos:
			//		• titular(que es una persona)
			//		• cantidad(puede tener decimales).
			//	Construye los siguientes métodos para la clase:
			//		• Un constructor que permita cargar todos los valores.
			//		• mostrar(): Muestra los datos de la cuenta.
			//		• ingresar(cantidad): se ingresa una cantidad a la cuenta, si la cantidad
			//			introducida es negativa, no se hará nada.
			//		• retirar(cantidad): se retira una cantidad a la cuenta.La cuenta puede estar
			//		en números rojos.
			//	En el main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va
			//	variando el saldo. 
			Console.WriteLine("Ejercicio-3_POO");

			Cuenta c1 = new Cuenta("Juan", 190000);
			Cuenta c2 = new Cuenta("Sasha", 13400);
			Cuenta c3 = new Cuenta("Carlos", 50000);

			Console.WriteLine(c1.Mostrar());
			Console.WriteLine(c1.Ingresar(120));
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(c1.Retirar(1500));
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(c1.Mostrar());


			Console.WriteLine(c2.Mostrar());
			Console.WriteLine(c2.Ingresar(15000));
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(c2.Retirar(259000));
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(c2.Mostrar());


			Console.WriteLine(c3.Mostrar());
			Console.WriteLine(c3.Ingresar(-200));
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(c3.Retirar(750));
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(c3.Mostrar());

		}
	}
}

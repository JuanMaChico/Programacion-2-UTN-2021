using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_De_Clases;


namespace Ejercicio_21___Guia
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 21";
			Console.WriteLine("---------------------------------------------------------------------------------------");
			Console.WriteLine("--Pruebas desde Fahrenheit--");


			Fahrenheit gradosF = new Fahrenheit(1);

			Console.WriteLine("\nGrados Fahrenheit: {0}", gradosF.GetGrados());
			Console.WriteLine("\nGrados Fahrenheit casteados a Celsius: {0}", ((Celsius)gradosF).GetGrados());
			Console.WriteLine("\nGrados Fahrenheit casteados a Kelvin: {0}", ((Kelvin)gradosF).GetGrados());



			Console.WriteLine("---------------------------------------------------------------------------------------");
			Console.WriteLine("--Pruebas desde Celsius--");


			Celsius gradosC = new Celsius(1);

			Console.WriteLine("\nGrados Celsius: {0}", gradosC.GetGrados());
			Console.WriteLine("\nGrados Celsius Casteados a Fahrenheit: {0}", ((Fahrenheit)gradosC).GetGrados());
			Console.WriteLine("\nGrados Celsius Casteados a Kelvin: {0}", ((Kelvin)gradosC).GetGrados());


			Console.WriteLine("---------------------------------------------------------------------------------------");
			Console.WriteLine("--Pruebas desde Kelvin--");

			Kelvin gradosK = new Kelvin(1);

			Console.WriteLine("\nGrados Kelvin:{0}", gradosK.GetGrados());
			Console.WriteLine("\nGrados Kelvin casteados a Fahrenheit: {0}",((Fahrenheit)gradosK).GetGrados());
			Console.WriteLine("\nGrados Kelvin casteados a Celsius: {0}", ((Celsius)gradosK).GetGrados());

			Console.WriteLine("--Pruebas de Igualdad--");
			Kelvin k1 = new Kelvin(1);
			Celsius c1 = new Celsius(-272.15);
			Console.WriteLine("Es igual {0} Grados kelvin que {1} Grados Celsius: {2}",k1.GetGrados(),c1.GetGrados(),(k1 == c1)?"si":"no");


			Console.WriteLine("---------------------------------------------------------------------------------------");











			Console.ReadKey();
		}
	}
}

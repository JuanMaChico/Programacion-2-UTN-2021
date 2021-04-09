using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_De_Clases;


namespace Ejercicio_19___Guia
{
	class Program
	{
		static void Main(string[] args)
		{
			long retorno;
			string retornoTx;
			bool retornoteste;


			Console.Title = "Ejercicio 19";

			Sumador testSuma = new Sumador();
			Sumador testSuma2 = new Sumador();

			Console.WriteLine((int)testSuma);

			retorno=testSuma.Sumar(2,2);

			Console.WriteLine((int)testSuma);
			Console.WriteLine("retorno:{0}",retorno);

			retornoTx = testSuma.Sumar("Hola","Mundo");

			Console.WriteLine((int)testSuma);
			Console.WriteLine("retorno:{0}", retornoTx);


			//
			testSuma2.Sumar(2, 2);


			retorno = testSuma + testSuma2;

			Console.WriteLine("Retorno de la suma tst1 y test2:{0}",retorno);
			retornoteste = testSuma | testSuma2;
			Console.WriteLine("Retorno |: {0} ", retornoteste);


			Console.ReadKey();
		}
	}
}

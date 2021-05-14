using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_De_Clases;




namespace Ejercicio_27___Guia
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 27";
			Console.WriteLine("---Stack o Pila---");
			Stack<int> pilaNumeros = new Stack<int>();
			Random r = new Random();
			for (int i = 0; i < 5; i++)
			{
				int numAleatorio = r.Next(-100, 100);
				pilaNumeros.Push(numAleatorio);
			}
			//Console.WriteLine(pilaNumeros.Pop());
			for (int i = 5; i > 0; i--)
			{
				Console.Write(" / ");
				Console.Write(pilaNumeros.Pop());
			}


			Console.WriteLine("\n\n---Colas o Queue---");
			Queue<int> colaInt = new Queue<int>();
			Random r1 = new Random();

			colaInt.Enqueue(r1.Next(1,100));
			colaInt.Enqueue(r1.Next(1, 100));
			colaInt.Enqueue(r1.Next(1, 100));
			colaInt.Enqueue(r1.Next(1, 100));
			colaInt.Enqueue(r1.Next(1, 100));
			foreach (int item in colaInt)
			{
				Console.Write(" / ");
				Console.Write(item);
			}

			//Listas esta tambien en el 26.








			Console.ReadKey();
		}
	}
}

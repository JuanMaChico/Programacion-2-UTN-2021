using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_De_Clases;

namespace Ejercicio_26___Guia
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Ejercicio 26";
			// Colas //Queue<int> callerIds = new Queue<int>();
			// array
			// pilas stack
			// 
			// 

			List<int> listNumeros = new List<int>();
			Random r = new Random();

			for (int i = 0; i < 20; i++)
			{
				int numAleatorio = r.Next(-100, 100);
				listNumeros.Add(numAleatorio);
			}
			Console.WriteLine("Lista Original");
			foreach (var item in listNumeros)
			{
				Console.Write("/");
				Console.Write(item);
			}

			Console.WriteLine("\n-------------------------------------------------------------------");
			listNumeros.Sort(ordenar);
			Console.WriteLine("Lista Ordenada de Mayor a menor");
			foreach (var item in listNumeros)
			{
				Console.Write("/");
				Console.Write(item);
			}

			Console.WriteLine("\n-------------------------------------------------------------------");
			listNumeros.Sort(ordenar1);
			Console.WriteLine("Lista Ordenada de Menor a mayor");
			foreach (var item in listNumeros)
			{
				Console.Write("/");
				Console.Write(item);
			}
			Console.WriteLine("\n-------------------------------------------------------------------");
			
			Console.WriteLine("Lista Ordenada de Mayor a Menor Solo negativos");
			foreach (var item in listNumeros)
			{
				if (item<0)
				{
					Console.Write("/");
					Console.Write(item);
				}
			}


			int ordenar(int x, int y)
			{
				if (x > y)
				{
					return -1;
				}
				else if (x < y)
				{
					return 1;
				}
				else if (x == y)
				{
					return 0;
				}
				return 0;
			}

			int ordenar1(int x, int y)
			{
				if (x > y)
				{
					return 1;
				}
				else if (x < y)
				{
					return -1;
				}
				else if (x == y)
				{
					return 0;
				}
				return 0;
			}
			
			Console.ReadKey();
		}
	}
}

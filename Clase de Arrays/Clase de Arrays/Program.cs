using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_de_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int numeroRandom;

			Console.Title = "Clase de Arrays";
			Console.WriteLine("Clase de Arrays");



			//Declaracion de Un Array
			//Tipo[] nombre = new tipo (Formato de declaracion)

			int[] listaNumeros = new int [10];   //----->Declaracion de una Array de numeros
			Random r = new Random();
			//Recorro la lista.
			for (int i = 0; i < listaNumeros.Length; i++)
			{
				numeroRandom = r.Next(1,10);
				listaNumeros[i] = numeroRandom;
			}
			Console.Write("--Cargando Un Array--");
			for (int i = 0; i < listaNumeros.Length; i++)
			{
				Console.Write("\nPosition:{0} - Dato:{1}",i,listaNumeros[i]);
			}
			Console.Write("\n------------------------------------------------------------ \n");






			Console.WriteLine("Colecciones");
			//Colecciones
			//Existen 3 tipos de colecciones <Genericas, No genericas, Concurrentes>
			//Genericas = Dictionary, List, Queue(Cola),SortedList(Clave,Valor Ordenada), stack(idem Queue invertido).
			


			//Palabra reservada List<Tipo de dato> Nombre de la lista
			//IMPORTANTE --> La lista siempre incorpora los elementos al final
			List<string> listaPalabras;

			//Instancia de la lista (Creacion del Objeto lista)
			listaPalabras = new List<string>();
			Console.Write("Agrego palabras a la LIST<>\n");
			
			//Agrego
			//.add agrega elementos al final de la lista
			listaPalabras.Add("Hola");
			listaPalabras.Add("Mundo");
			listaPalabras.Add("Mundo");
			
			
			//Recorro y muesto los elementos de la lista
			foreach (string item in listaPalabras)
			{
				Console.WriteLine(item);
			}

			//remover elementos de mas
			Console.Write("Remover palabras a la LIST<>\n");
			listaPalabras.Remove("Mundo");//Remuevo un elemento Mundo
			
			//recorrer y mostrar la lista sin un elemento Mundo
			foreach (string item in listaPalabras)
			{
				Console.WriteLine(item);
			}

			//Queue<>
			//Cola de tipo FIFO First In First Out(Primero entra primero sale)
			Queue<int> colaInt = new Queue<int>();

			//Dictionary<>
			//Clave-Valor
			Console.WriteLine("\n-------------------------------------------\n");
			Console.WriteLine("Diccionarios");
			Dictionary<string, int> diccionarioNumeros = new Dictionary<string, int>();
			diccionarioNumeros.Add("PrimerAlumno",20);
			diccionarioNumeros.Add("SegundoAlumno", 32);

			/*Console.WriteLine(diccionarioNumeros["PrimerAlumno"].ToString());
			Console.WriteLine(diccionarioNumeros["SegundoAlumno"].ToString());*/

			foreach (KeyValuePair<string,int> item in diccionarioNumeros)
			{
				Console.WriteLine($"La clave: {item.Key} del valor: {item.Value}");
			}


			Console.WriteLine("-Borramos un elemento mediante la calve \n");
			
			diccionarioNumeros.Remove("PrimerAlumno");

			foreach (KeyValuePair<string, int> item in diccionarioNumeros)
			{
				Console.WriteLine($"La clave: {item.Key} del valor: {item.Value}");
			}

			Console.WriteLine("\n-------------------------------------------\n");
			Console.WriteLine("SortedList");
			//Lista Ordenada, cada vez que agregamos un elemento esta se reordena por si sola
			//Ordena Segun la Key lo que hace que la misma sea mas costosa
			SortedList<string, string> listaOrdenada = new SortedList<string, string>();
			listaOrdenada.Add("Nombre 1:","Juan");
			listaOrdenada.Add("Nombre 4:", "Sasha");
			listaOrdenada.Add("Nombre 3:", "Carolina");
			listaOrdenada.Add("Nombre 2:", "Evelyn");
			listaOrdenada.Add("Nombre 0:", "Carlitos");

			foreach (KeyValuePair<string, string> item in listaOrdenada)
			{
				Console.WriteLine($"La clave: {item.Key} del valor: {item.Value}");
			}
			Console.WriteLine("\n-------------------------------------------\n");
			
			//La particularidad del stack es que el primero en entrar es el ultimo en salir.
			//
			Console.WriteLine("Stack");
			Stack<int> stackNumeros = new Stack<int>();

			stackNumeros.Push(1);
			stackNumeros.Push(2);
			stackNumeros.Push(3);
			stackNumeros.Push(4);

			//de esta manera mostramos en orden ultimo a primero la pila.
			Console.WriteLine(stackNumeros.Pop());
			Console.WriteLine(stackNumeros.Pop());
			Console.WriteLine(stackNumeros.Pop());
			Console.WriteLine(stackNumeros.Pop());

			//Console.WriteLine(stackNumeros.Peek());





			Console.ReadKey();
		}
	}
}

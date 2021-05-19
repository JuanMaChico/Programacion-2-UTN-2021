using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;



namespace ModeloParcial_2017
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Modelo de parcial 2017 - Grupo";

			Perro moro = new Perro("Moro","Pitbull",0,false);
			Perro julio = new Perro("Julio", "Cruza",13,false);
			Perro ramon = new Perro("Ramon", "Salchicha",2,true);
			Gato jose = new Gato("Jose", "angora");
			Gato hernan = new Gato("Hernan", "Cruza");
			Gato fer = new Gato("Fer","siames");

			Grupo riounica = new Grupo("Rio Unica");

			bool retorno = riounica + moro;

			Console.WriteLine(riounica);

			retorno = riounica - moro;

			Console.WriteLine(riounica);

			Console.ReadKey();
		}
	}
}

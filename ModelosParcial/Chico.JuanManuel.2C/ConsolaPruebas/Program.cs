using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chico.JuanManuel._2C;

namespace ConsolaPruebas
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Pruebas RPP LABO 2";

			Estacionamiento miEstacionamiento = Estacionamiento.GetEstacionamiento("24HS", 5);

			Vehiculo[] vehiculos = 
			{
				new Automovil("IZO718", DateTime.Now.AddHours(-3),"Ford"),
				new Automovil("EPX277", DateTime.Now.AddHours(-3), "Chevrolet"),
				new Automovil("IDW900", DateTime.Now.AddHours(-3), "VolksWagen"),
				new Automovil("IDW900", DateTime.Now.AddHours(-3), "VolksWagen"),
				new Moto("LDP123", DateTime.Now.AddHours(-3), Moto.Etipo.Scooter),
				new Moto("JUY866", DateTime.Now.AddHours(-3), Moto.Etipo.Ciclomotor),
				new Moto("AAA999", DateTime.Now.AddHours(-3), Moto.Etipo.Sport)
			};
			
			foreach (Vehiculo item in vehiculos)
			{
				if (miEstacionamiento + item)
				{
					Console.WriteLine($"Se agregro{item.ToString()}");
				}
				else
				{
					Console.WriteLine($"No se pudo Agregar{ item.ToString()}");
			   }
			}
			Console.ReadKey();
			Console.Clear();
			foreach (Vehiculo item in vehiculos)
			{
				if (miEstacionamiento - item)
				{

					Console.WriteLine($"{miEstacionamiento.InformarSalida(item)}");
				}
				else
				{
					Console.WriteLine($"No se pudo retirar{ item.ToString()}");
			    }
			}

			Console.ReadKey();
		}
	}
}

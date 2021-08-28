using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
	public class Cuenta
	{
		//Atributos
		string titular;
		float cantidad;

		public string Titular { get => titular; set => titular = value; }
		public float Cantidad { get => cantidad; set => cantidad = value; }

		public Cuenta(string titular, float cantidad)
		{
			Titular = titular;
			Cantidad = cantidad;
		}


		public string Ingresar(float ingreso) 
		{
			string retorno;
			if (ingreso > 0)
			{
				Cantidad += ingreso;
				Console.ForegroundColor = ConsoleColor.Green;
				retorno = $"Ingreso de ${ingreso} Correcto.";
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				retorno = "No se admite Ingreso negativo";
			}
			return retorno;
		}

		public string Retirar(float retiro)
		{
			string retorno;
			if (retiro < Cantidad)
			{
				Cantidad -= retiro;
				Console.ForegroundColor = ConsoleColor.Red;
				retorno = $"Retiro de ${retiro} Correcto";

			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				retorno = $"Saldo insuficiente para retirar {retiro}";
			}
			return retorno;
		}

		public string Mostrar() 
		{
			return $"\nTitular: {Titular}\nCantidad: {Cantidad}";
		}


	}
}

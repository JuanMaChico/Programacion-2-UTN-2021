using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
	//La clase factura no puede tener Objetos! 
	//por que no existe factura! existen factura A,B,C Pero no solo Factura
	public abstract class Factura
	{
		protected string nombreCliente;
		protected float importeFinal;


		public Factura(string nombreCliente) 
		{
			this.nombreCliente = nombreCliente;
		}

		public static string NombreCliente
		{
			get { return NombreCliente; }

			set { NombreCliente = value; }
		}

		public static float ImporteFinal
		{
			get { return ImporteFinal; }

			set { ImporteFinal = value; }
		}

		public string RetornaDatosClientes()
		{
			return this.nombreCliente;
		}

		public abstract string MostrarDatosCompletos();
	}
}

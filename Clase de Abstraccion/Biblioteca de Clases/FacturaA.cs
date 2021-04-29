using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
	public abstract class FacturaA : Factura
	{
		private float importeSinIVA;


		public FacturaA(string nombreCliente) : base(nombreCliente) 
		{

		}

		public float ImporteSinIVA 
		{
			get 
			{
				return this.ImporteSinIVA;
			}
			set 
			{
				this.ImporteSinIVA = value;
			}
		}
		public override string MostrarDatosCompletos()
		{
			return this.RetornaDatosClientes();
		}
	}
}

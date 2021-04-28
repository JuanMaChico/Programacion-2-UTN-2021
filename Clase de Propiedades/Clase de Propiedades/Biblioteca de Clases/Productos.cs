using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Productos
    {
        private string nombre;
        private double precioBruto;
        private double impuesto;

		public Productos(double impuesto)
		{
			this.impuesto = impuesto;
		}

		public double Impuesto
		{
			get { return this.impuesto; }
		}
		public double PrecioBruto
		{
			set { this.precioBruto = value; }
		}
		public string Nombre
		{
			get { return this.nombre; }
			set { this.nombre = value; }
		}
		public double PrecioFinal
		{
			get { return this.calcularPrecioFinal(); }
		}

		private double calcularPrecioFinal()//200,21
		{
			return this.precioBruto * (1 + this.impuesto/100);
		}
	}
}

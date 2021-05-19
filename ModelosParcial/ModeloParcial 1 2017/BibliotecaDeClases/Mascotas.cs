using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
	public abstract class Mascota
	{
		private string nombre;
		private string raza;


		public Mascota(string nombre, string raza)
		{
			this.nombre = nombre;
			this.raza = raza;
		}
		public string Nombre 
		{
			get { return this.nombre; }
		}

		public string Raza 
		{
			get {	return this.raza;	}
		}

		virtual protected string DatosCompletos() 
		{
			string nombreMascota = this.nombre;
			string razaMascota = this.raza;
			string retorno = string.Format("Nombre: {0}, Raza: {1}",nombreMascota,razaMascota);
			return retorno;
		}

		abstract protected string Ficha();

	}

}

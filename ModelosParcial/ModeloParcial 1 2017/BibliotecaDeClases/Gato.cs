using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
	public class Gato : Mascota
	{

		public Gato(string nombre, string raza) : base(nombre,raza){}

		protected override string Ficha()
		{
			return base.DatosCompletos();
		}
		public override bool Equals(object obj)
		{
			if (obj is Gato)
			{
				return (this == (Gato)obj);
			}
			else 
			{
				return false;
			}
		}
		public override string ToString()
		{
			return this.DatosCompletos();
		}

		public static bool operator ==(Gato cat1, Gato cat2)
		{
			if (cat1.Nombre == cat2.Nombre && cat1.Raza == cat2.Raza)
			{
				return true;
			}
			return false;
		}
		public static bool operator !=(Gato cat1, Gato cat2)
		{
			return !(cat1==cat2);
		}











	}
}

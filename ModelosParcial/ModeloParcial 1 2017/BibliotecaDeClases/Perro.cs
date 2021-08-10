using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
	public class Perro : Mascota
	{
		private int edad;
		private bool esAlfa;


		public Perro (string nombre, string raza):base(nombre, raza)
		{
			this.esAlfa = false;
			this.edad = 0;
		}
		public Perro (string nombre, string raza, int edad, bool esAlfa)
			: base (nombre, raza)
		{
			this.edad = edad;
			this.esAlfa = esAlfa;
		}

		public int Edad 
		{
			get { return this.edad; }
			set { this.edad = value; }
		}
		public bool EsAlfa
		{
			get { return this.esAlfa; }
			set { this.esAlfa = value; }
		}

		protected override string Ficha()
		{
			string retorno;
			if (this.esAlfa == true)
			{
				retorno = string.Format("{0} Es Alfa de la manda, Edad:{1}", this.Nombre, this.Edad);
			}
			else
			{
				retorno = string.Format("{0}, Edad:{1}", this.Nombre, this.Edad);
			}
			return retorno;
		}
		
		public static bool operator ==(Perro dog1, Perro dog2)
		{
			if (dog1.Nombre == dog2.Nombre && dog1.Raza == dog2.Raza)
			{
				return true;
			}
			return false;
		}
		
		public static bool operator !=(Perro dog1, Perro dog2)
		{
			return !(dog1 == dog2);
		}
		
		public override string ToString()
		{
			return this.Ficha();
		}
		

		public static explicit operator int(Perro dog)
		{
			return dog.edad;
		}


		public override bool Equals(object obj)
		{
			if (obj is Perro)
			{
				return (this == (Perro)obj);
			}
			else
			{
				return false;
			}
		}






	}
}

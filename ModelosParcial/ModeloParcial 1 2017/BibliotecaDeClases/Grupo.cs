using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Grupo
    {
		private List<Mascota> manada;
		private string nombre;
		private static TipoManada tipo;

		static Grupo()
		{
			tipo = TipoManada.Unica;
		}
		private Grupo()
		{
			this.manada = new List<Mascota>();
		}
		public Grupo(string nombre) : this()
		{
			this.nombre = nombre;
		}
		public Grupo(string nombre, TipoManada tipo) : this(nombre)
		{
			tipo = tipo;
		}
		public enum TipoManada
		{
			Unica,
			Mixta
		}

		public TipoManada Tipo 
		{
			set 
			{
				tipo = value;
			}
		}

		public static bool operator ==(Grupo g, Mascota m)
		{
			foreach (Mascota item in g.manada)
			{
				if (item == m)
				{
					return true;
				}
			}
			return false;
		}

		public static bool operator !=(Grupo g, Mascota m)
		{
			return !(g == m);
		}

		public static bool operator +(Grupo g, Mascota m)
		{
			if (g == m)
			{
				return false;
			}
			else
			{
				g.manada.Add(m);
				return true;
			}
		}

		public static bool operator -(Grupo g, Mascota m)
		{
			if (g == m)
			{
				g.manada.Remove(m);
				return true;
			}
			else
			{
				return false;
			}
		}

		public static implicit operator string(Grupo g)
		{
			string retorno = "";
			foreach (Mascota item in g.manada)
			{
				retorno = string.Concat(retorno, item.ToString());
			}
			return retorno;
		}
	}
}

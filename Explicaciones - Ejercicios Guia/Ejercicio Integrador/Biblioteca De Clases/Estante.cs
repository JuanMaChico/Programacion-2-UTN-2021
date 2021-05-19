using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_De_Clases;



namespace Biblioteca_De_Clases
{
	public class Estante
	{
		private Producto []Productos;
		private int ubicacionEstante;

		private Estante(int capacidad) 
		{
			this.Productos = new Producto[capacidad];
		}
		public Estante(int capacidad, int ubicacion) : this(capacidad)
		{
			this.ubicacionEstante = ubicacion;
		}
		public Producto[] GetProductos() 
		{
			return this.Productos;
		}
		public static string MostrarEstante(Estante e) 
		{
			StringBuilder infoEstante = new StringBuilder();
			infoEstante.Append("Ubicacion: ");
			infoEstante.AppendLine(e.ubicacionEstante.ToString());
			infoEstante.Append("Capacidad: ");
			infoEstante.AppendLine(e.Productos.Length.ToString());

			foreach (Producto p in e.Productos)
			{
				infoEstante.Append(Producto.MostrarProducto(p));
			}
			return infoEstante.ToString();
		}
		public static bool operator ==(Estante e, Producto p)
		{
			bool retorno = false;
			foreach (Producto x in e.Productos)
			{
				if (!(x is null))
				{
					if (x == p)
					{
						retorno = true;
					}

				}
			}
			return retorno;
		}
		public static bool operator !=(Estante e, Producto p)
		{
			return !(e == p);
		}
		public static bool operator +(Estante e, Producto p)
		{
			bool lugar = false;

			if (e != p)
			{
				for (int i = 0; i < e.Productos.Length; i++)
				{
					if (e.Productos[i] is null)
					{
						lugar = true;
						e.Productos[i] = p;
						break;
					}
				}
			}
			return lugar;
		}


		public static Estante operator -(Estante e, Producto p)
		{
			if (e == p)
			{
				for (int i = 0; i < e.Productos.Length; i++)
				{
					if (e.Productos[i] == p)
					{
						e.Productos[i] = null;
						break;
					}
				}
			}
			return e;
		}


	}
}

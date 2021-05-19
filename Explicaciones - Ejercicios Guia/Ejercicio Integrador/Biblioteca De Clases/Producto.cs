using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;


		public Producto(string marca, string codigo, float precio)
		{
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
		}

        public string GetMarca() 
        {
            return this.marca;
        }

        public float GetPrecio() 
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p) 
        {
            string retorno;
            retorno = "\nMarca: "+p.marca+"\nPrecio: "+p.precio+"\nCodigo de Barras: "+p.codigoDeBarra+"\n";
            return retorno;
        }
        public static explicit operator string(Producto p) 
        {
            return p.codigoDeBarra;
        }
        public static bool operator ==(Producto p1, Producto p2) 
        {
            bool retorno = false;
			if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
			{
                retorno = true;
			}
            return retorno;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            bool retorno = false;
            if (p1.marca != p2.marca && p1.codigoDeBarra != p2.codigoDeBarra)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ==(Producto p1, string marca)
        {
            bool retorno = false;
            if (p1.marca == marca)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Producto p1, string marca)
        {
            bool retorno = false;
            if (p1.marca != marca)
            {
                retorno = true;
            }
            return retorno;
        }


    }
}

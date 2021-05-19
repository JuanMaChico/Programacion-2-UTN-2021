using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases
{
	public class Boligrafo
	{
		const short cantidadTintaMaxima = 100;
		private ConsoleColor color;
		private short tinta;

		public Boligrafo(short tinta, ConsoleColor color)
		{
			this.tinta = tinta;
			this.color = color;
		}

		public ConsoleColor GetColor()
		{
			return this.color;
		}
		public short GetTinta() 
		{
			return this.tinta;
		}



		private void SetTinta(short tinta) 
		{
			if (this.tinta + (tinta) >= 0 && this.tinta + (tinta) <= cantidadTintaMaxima)
			{
				this.tinta += tinta;
			}
		}
		
				
		public void Recargar() 
		{
			short faltante;
			faltante = (short)(cantidadTintaMaxima - this.tinta);
			this.SetTinta(faltante);
		}



		public bool Pintar(short gasto, out string dibujo) 
		{
			bool pinto = false;
			dibujo = "";

			if (this.GetTinta() >= gasto)
			{
				dibujo = dibujo.PadLeft(gasto, '*');
				pinto = true;
				this.SetTinta((short)-gasto);
			}
			else 
			{
				dibujo = dibujo.PadLeft(this.GetTinta(), '*');
				this.SetTinta((short)-this.GetTinta());
			}
			return pinto;
		}
	}
}

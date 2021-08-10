using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
	public class PlanetaEventArgs
	{
		private short avance;
		private short radioRespectoSol;

		public short Avance 
		{
			get 
			{
				return avance;
			}
		}

		public short RadioRespectoSol 
		{
			get 
			{
				return radioRespectoSol;
			}
		}

		public PlanetaEventArgs(short avance, short radio) 
		{

		}



	}
}

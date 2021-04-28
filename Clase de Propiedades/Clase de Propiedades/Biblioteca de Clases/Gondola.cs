using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
	public class Gondola
	{
		private List<Productos> Productos;

		public Productos this[int i]
		{
			get { return this.Productos[i]; }
			set { this.Productos[i] = value; }
		}
	}
}

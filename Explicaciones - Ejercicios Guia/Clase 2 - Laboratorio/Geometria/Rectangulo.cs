using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
	public class Rectangulo
	{
		private Punto vertice1;
		private Punto vertice2;
		private Punto vertice3;
		private Punto vertice4;

		private float area;
		private float perimetro;


		public Rectangulo (Punto vertice1, Punto vertice3) 
		{
			this.vertice1 = vertice1;
			this.vertice2 = new Punto( vertice3.GetX(), vertice1.GetY() );
			this.vertice3 = vertice3;
			this.vertice4 = new Punto( vertice1.GetX(), vertice3.GetY() );
			this.area = 0;
			this.perimetro = 0;
		}

		public float Area() 
		{
			return this.area;
		}
		public float Perimetro()
		{
			return this.perimetro;
		}


		public float GetArea() 
		{
			float baseArea = Math.Abs(this.vertice1.GetX()- this.vertice3.GetX());
			float altura = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());

			this.area = (baseArea * altura);
			return this.area;
		}

		public float GetPerimetro()
		{
			float baseArea = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
			float altura = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());

			this.perimetro = ((baseArea + altura) * 2);
			return this.perimetro;
		}
		public static string InfoRectangulo (Rectangulo infoRectangulo) 
		{
			string info = "";
			info ="-Perimetro ="+ infoRectangulo.perimetro + "\n-Area="+ infoRectangulo.area +"\n -vert1=("+ infoRectangulo.vertice1.GetX()+","+ infoRectangulo.vertice1.GetY()+")\n-vert2=" + infoRectangulo.vertice2 + " -vert3=" + infoRectangulo.vertice3 + " -vert4=" + infoRectangulo.vertice4;
			return info;
		}


	}
}

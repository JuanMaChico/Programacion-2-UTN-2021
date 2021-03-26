using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
	public class CalculoDeArea
	{

		//Calcula el perimetro de A
		public static double CalcularCuadrado(double a) 
		{
			double retorno;
			retorno = a * 4;
			return retorno;
		}


		//Calcula el perimetro de un triangulo A & B
		public static double CalcularTriangulo(double a, double b)
		{
			double retorno;
			retorno = a + b + a;
			return retorno;
		}


		//Calcula el perimetro de un circulo de Radio A
		public static double CalcularCirculo(double r)
		{
			double retorno;
			retorno = 2 * Math.PI * r;
			return retorno;
		}







	}
}

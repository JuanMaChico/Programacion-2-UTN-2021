using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
	class Program
	{
		static void Main(string[] args)
		{
			//	De una empresa de transporte se quiere guardar el nombre de los conductores que tiene y
			//	los kilómetros que conducen cada día de la semana.
			//	Para guardar esta información, la empresa de transporte tendrá un array de conductores.
			//	Cada conductor tendrá:
			//		• Nombre->contendrá el nombre del conductor
			//		• Kms->contendrá los km que hace el conductor por semana. Por ej
			//		▪ Dia 1: 200
			//		▪ Dia 2:599
			//		▪ Dia 3: 899
			//		▪ Dia 4: 0(tiene franco)
			//		▪ Dia 5: 256
			//		▪ Dia 6: 0
			//		▪ Dia 7: 0
			//	Desarrollar los métodos necesarios en conductor.
			//	En el program, cargar 3 conductores, y mostrar:
			//		• conductor hizo más km en esa semana
			//		• conductor hizo más km el día 3.
			//		• conductor hizo más km el día 5
			Console.WriteLine("\nEjercicio-4_POO\n\n");

			int[] kmsSemanalesC1 = {150, 270, 0, 420, 498, 543, 0};
			Conductor c1 = new Conductor("Juan", kmsSemanalesC1);


			int[] kmsSemanalesC2 = { 1500, 27000, 2, 4200, 56, 5493, 8 };
			Conductor c2 = new Conductor("sasha", kmsSemanalesC2);


			int[] kmsSemanalesC3 = { 1850, 2790, 720, 420, 23, 543, 456 };
			Conductor c3 = new Conductor("carlos", kmsSemanalesC3);

			Transporte meli = new Transporte(c1, c2, c3);


			Console.WriteLine(meli.ConductorMasKmsSemanales());

			Console.WriteLine(meli.ConductorMasKmsDia(3));

			Console.WriteLine(meli.ConductorMasKmsDia(5));




		}
	}
}

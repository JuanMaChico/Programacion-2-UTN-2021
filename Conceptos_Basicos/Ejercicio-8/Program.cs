using System;

namespace Ejercicio_8
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			//Por teclado se ingresa el valor hora, el nombre, la antigüedad(en años) y la cantidad de horas
			//trabajadas en el mes de N empleados de una fábrica.
			
			//Se pide calcular el importe a cobrar teniendo en cuenta que el total(que resulta de multiplicar el
			//valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
			//multiplicados por $ 150, y al total de todas esas operaciones restarle el 13 % en concepto de
			//descuentos.
	
			//Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
			//bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
			//Nota: Utilizar estructuras repetitivas y selectivas.


			float valorHora;
			string nombre;
			int antiguedad;
			int horasTrabajadas;

			//total = [(valorHora * horasTrabajadas) + 150 * antiguedad] - 13%;
			double liquidacionTotal;
			//total = [(valorHora * horasTrabajadas) + 150 * antiguedad]
			double totalBruto;



			Console.Write("Ingrese valor hora del empleado: ");
			valorHora = float.Parse( Console.ReadLine() );
			
			Console.Write("Ingrese nombre del empleado: ");
			nombre = Console.ReadLine();
			
			Console.Write("Ingrese antiguedad del empleado: ");
			antiguedad = int.Parse( Console.ReadLine() );
			
			Console.Write("Ingrese horas trabajadas en el mes: ");
			horasTrabajadas = int.Parse( Console.ReadLine() );

			liquidacionTotal = (valorHora * horasTrabajadas) + (150 * antiguedad);
			totalBruto = liquidacionTotal;
			double aux = liquidacionTotal * 0.13;
			liquidacionTotal = liquidacionTotal - aux;


			Console.WriteLine("\n\n--Recibo de sueldo--\n\n");
			Console.WriteLine($"Empleado:  {nombre}");
			Console.WriteLine($"antiguedad:  {antiguedad}");
			Console.WriteLine($"Valor hora:  {valorHora}");
			Console.WriteLine($"La liquidacion final es de: {liquidacionTotal}");
			Console.WriteLine($"El total Bruto es de: {totalBruto}");

		}
	}
}

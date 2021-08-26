using System;

namespace Ejercicio_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ejercicio-1");
			//Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
			//valor máximo, el valor mínimo y el promedio.
			
			//Variables
			int contador = 0;
			float numeroIngresado;
			float sumatoria = 0;
			float numeroMax = float.MinValue;
			float numeroMin = float.MaxValue;
			float promedio;

			//Bucle de 5 vueltas
			while ( contador < 5 )
			{
				//Mensaje por Consola
				Console.Write("Ingrese un Numero: ");

				//Solicitamos el ingreso por teclado y validamos que sea un numero
				if (float.TryParse(Console.ReadLine(), out numeroIngresado))
				{
					//Sumamos al contador de vueltas
					contador++;
					//Sumamos los numeros ingresados
					sumatoria += numeroIngresado;
					//Guardamos el mayor nuevo ingresado
					if (numeroIngresado > numeroMax)
						numeroMax = numeroIngresado;
					//Guardamos el menor numero ingresado
					if (numeroIngresado < numeroMin)
						numeroMin = numeroIngresado;
				}
				else
				{
					//Mostramos el mensaje de error para el usuario
					Console.Write("ERROR..Ingreso no valido.");
				}
			}
			//Calculamos el promedio de los numeros ingresados
			promedio = sumatoria / contador;

			//Mostramos resultados por pantalla
			Console.WriteLine($"El promedio de los numeros ingresados es: {promedio}");
			Console.WriteLine($"El numero maximo ingresado es: {numeroMax}");
			Console.WriteLine($"El numero minimo ingresado es:{numeroMin}");

		}
	}
}

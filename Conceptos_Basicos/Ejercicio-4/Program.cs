using System;

namespace Ejercicio_4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ejercicio-4\n");
            //Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
            //(excluido el mismo) que son divisores del número.
            //El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            //Escribir una aplicación que encuentre los 4 primeros números perfectos.
            //Nota: Utilizar estructuras repetitivas y selectivas.

            short perfectosEncontrados = 0;
            // Número actual, comenzando en 1
            int numero = 1;

            do
            {
                int sumador = 0;
                //Busco los divisores del número actual
                for (int i = numero - 1; i > 0; i--)
                {
                    if ((numero % i) == 0)
                    {
                        // Sumo los divisores en busca del número Perfecto
                        sumador += i;

                        if (sumador > numero)
                            break;
                    }
                }
                // Si la suma de los divisores es igual al número, es PERFECTO
                if (sumador == numero)
                {
                    perfectosEncontrados++;
                    Console.WriteLine("El número {0} es PERFECTO", numero);
                }
                // Incremento el número actual
                numero++;
            } while (perfectosEncontrados < 4);




        }
	}
}

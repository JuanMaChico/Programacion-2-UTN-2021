using System;

namespace Ejercicio_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ejercicio-3");
            //Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
            //por consola.
            //Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).

            int aux;
            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out aux))
            {
                int i = 0;
                // Analizo todos los números entre 2 y el número ingresado
                for (int j = 2; j <= aux; j++)
                {
                    // Verifico si J es primo
                    for (i = 2; i < j; i++)
                    {
                        // Si tiene un divisor con resto cero, salgo ya que NO ES PRIMO
                        if ((j % i) == 0)
                        {
                            break;
                        }
                    }

                    if (i == j)
                        Console.WriteLine("{0} es primo", j);
                }
            }

            Console.ReadLine();


        }
	}
}

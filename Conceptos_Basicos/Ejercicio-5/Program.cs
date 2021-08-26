﻿using System;

namespace Ejercicio_5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ejercicio-5");

            //Un centro numérico es un número que separa una lista de números enteros(comenzando en 1) en
            //dos grupos de números, cuyas sumas son iguales.
            //El primer centro numérico es el 6, el cual separa la lista(1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8)
            //cuyas sumas son ambas iguales a 15.El segundo centro numérico es el 35, el cual separa la lista(1 a
            //49) en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595.
            //Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
            //usuario ingrese por consola.
            //Nota: Utilizar estructuras repetitivas y selectivas.

            Console.Write("Ingrese un número: ");
            
            int j;
            
            if (int.TryParse(Console.ReadLine(), out j))
            {
                for (int centro = 1; centro <= j; centro++)
                {
                    int acum = 0;
                    for (int i = 1; i < centro; i++)
                    {
                        acum += i;
                    }

                    int contador = centro + 1;
                    do
                    {
                        acum -= contador;
                        contador++;
                    } while (acum > 0);

                    if (acum == 0)
                        Console.WriteLine("{0} es centro numérico", centro);
                }
            }
            else
                Console.Write("No es un número");

        }
	}
}

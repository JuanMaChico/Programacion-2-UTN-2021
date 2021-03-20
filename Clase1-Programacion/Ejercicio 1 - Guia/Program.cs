using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//      Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
//      valor máximo, el valor mínimo y el promedio.

namespace Ejercicio_1
{
    class Ejercicio_1
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";
            int aux;
            int cantidadIngresos = 5;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            float promedio = 0;
            string lectura;

            
            for (int i = 0; i < cantidadIngresos ; i++)
            {
                Console.Write("Ingrese un número: ");
                lectura = Console.ReadLine();
                if (int.TryParse(lectura, out aux))
                {
                    if (aux > maximo)
                    {
                        maximo = aux;
                    }
                    if (aux < minimo)
                    {
                        minimo = aux;
                    }
                    promedio = (promedio + aux);
                }
                else
                {
                    Console.Write("Ingrese un numero valido.");
                    i--;
                }
            }
            promedio = (promedio / cantidadIngresos);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El maximo es: {0}", maximo);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("El minimo es: {0}", minimo);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Promedio: {0:#.##}", promedio);
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Máximo : {0,3} - Mínimo : {1,3} - Promedio: {2,3:#.##}", maximo, minimo, promedio);
            Console.ReadKey();


            Console.ReadLine();
        }
    }
}

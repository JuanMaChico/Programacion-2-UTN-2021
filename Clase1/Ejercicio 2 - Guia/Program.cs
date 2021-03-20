using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/


namespace Ejercicio_2___Guia
{
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_2";
            string numero;
            int aux;
            double cuadrado;
            double cubo;
            
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = Console.ReadLine();
            } while (!(int.TryParse(numero,out aux)));

            cuadrado = Math.Pow(aux,2);
            cubo = Math.Pow(aux, 3);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} elevado al cuadrado es: {1}", aux, cuadrado);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} elevado al cuadrado es: {1}", aux, cubo);

            Console.ReadKey();
        }
    }
}

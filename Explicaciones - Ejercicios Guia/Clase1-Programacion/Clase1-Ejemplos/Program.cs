using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string textoIngresado;
            int contador = 0;
            string cadena;

            Console.WriteLine("Ingrese un texto: ");

            textoIngresado = Console.ReadLine();                //permite ingresar texto por teclado! 

            textoIngresado =  textoIngresado.ToLower();         //baja el texto ingresado a minuscula

            for (int i = 0; i < textoIngresado.Length; i++)      //recorremos la cadena 
            {
                cadena = textoIngresado.Substring(i, 1);        //toma cada caracter de el string ingresado y lo guarda en cadena.

                if (cadena == "a"){
                    contador++;                                 //si la letra es A suma al contador! 
                }
            }

            Console.WriteLine("Cantidad de A: {0}", contador);

            //Console.WriteLine(textoIngresado);                //Muestra el texto por pantalla

            Console.ReadLine();

        }

    }
}

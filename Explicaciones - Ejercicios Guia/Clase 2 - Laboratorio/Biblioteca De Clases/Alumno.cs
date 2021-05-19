using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string nombre, string apellido, int legajo) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void Estudiar(byte notaUno,byte notaDos) 
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal() 
        {
            Random numRandom = new Random();

            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = numRandom.Next(1, 11);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Nombre: " + this.nombre);
            cadena.AppendLine("Apellido: " + this.apellido);
            cadena.AppendLine("Nota 1: " + this.nota1);
            cadena.AppendLine("Nota 2: " + this.nota2);
            if (this.notaFinal != -1)
            {
                cadena.AppendLine("Nota final: " + this.notaFinal+ "\n");
            }
            else
            {
                cadena.AppendLine("Nota final: " + "Alumno Desaprobado" + "\n");
            }
            return cadena.ToString();
        }
    }
}
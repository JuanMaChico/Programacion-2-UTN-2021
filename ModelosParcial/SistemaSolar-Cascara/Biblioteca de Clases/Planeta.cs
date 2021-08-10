using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public delegate void InformacionDeAvance(object sender, PlanetaEventArgs e);
    //para poder serializar debe tener constructor
    //sin parametros y propiedades publicas con geter y seter
    public class Planeta
    {
        private object objetoAsociado;
        private short posicionActual;
        private short radioRespectoSol;
        private short velocidadTraslacion;
        /*FirmaEvento*/
        public event InformacionDeAvance InformarAvance;

        public object ObjetoAsociado 
        {
            get 
            {
                return objetoAsociado;
            }
            set 
            {
                objetoAsociado = value;
            }
        }

        public void AnimarSistemaSolar() 
        {
			do
			{
                System.Threading.Thread.Sleep(60 + this.velocidadTraslacion);
                InformarAvance.Invoke(this, new PlanetaEventArgs(this.Avanzar(),radioRespectoSol));

			} while (true);



        }
        public short Avanzar() 
        {
            this.posicionActual += velocidadTraslacion;
            return this.posicionActual;
        }


    }
}

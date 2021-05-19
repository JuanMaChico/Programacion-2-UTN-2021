using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sala_de_juegos
{
	public partial class Adivinador : Form
	{
		string nombre;
		int numeroIngresado;
		bool validacion;
		int contador;
		public Adivinador(string nombre)
		{
			InitializeComponent();
			this.nombre = nombre;
			this.txtNameJugador.Text = nombre;
		}

		private void Adivinador_Load(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{

			int nivel = 0;
			if (this.RdBtn_Lvl1.Checked)
			{
				nivel = 10; 
			}
			else if (this.RdBtn_Lvl2.Checked)
			{
				nivel = 20;
			}
			else if (this.RdBtn_Lvl3.Checked)
			{
				nivel = 30;
			}


			Random r = new Random();
			int numeroX = r.Next(1, nivel);

			if (contador < 3)
			{
				validacion = int.TryParse(this.txtNumeroIngresado.Text, out numeroIngresado);
				if (validacion && numeroIngresado == numeroX)
				{
					MessageBox.Show("Correctoooooo");
					this.Close();
					contador++;
				}
				else
				{
					StringBuilder mensaje = new StringBuilder();
					mensaje.Append("Perdiste ");
					mensaje.Append(nombre);
					MessageBox.Show(mensaje.ToString());
					contador++;
				}
			}
			else 
			{
				MessageBox.Show("Cantidad de intentos Exedida");
				this.Close();
			}
		}


	}
}

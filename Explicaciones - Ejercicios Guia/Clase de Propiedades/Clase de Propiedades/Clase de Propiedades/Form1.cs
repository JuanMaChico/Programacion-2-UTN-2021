using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_de_Clases;

namespace Clase_de_Propiedades
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Productos producto = new Productos(21);
			producto.Nombre = "Leche";
			producto.PrecioBruto = 200;
			//producto.Impuesto(33);//solo lectura
			MessageBox.Show(producto.Nombre);
			MessageBox.Show(producto.Impuesto.ToString());
			MessageBox.Show(producto.PrecioFinal.ToString());

			Gondola unaGondola = new Gondola();
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
		Utilizar Diccionarios(Dictionary<string, int>) para realizar un contador de palabras, recorriendo el
		texto palabra por palabra se deberá lograr que si se trata de una nueva palabra, se la agregará al
		diccionario e inicializar su contador en 1, caso contrario se deberá incrementar dicho contador.
		Ordenar los resultados de forma descendente por cantidad de apariciones de cada palabra.
		Informar mediante un MessageBox el TOP 3 de palabras con más apariciones.
*/
namespace Ejercicio_28___Guia
{
	public partial class FormPrincipal : Form
	{
		Dictionary<string, int> palabras;
		
		
		
		
		public FormPrincipal()
		{
			InitializeComponent();
		}
				
		private void FormPrincipal_Load(object sender, EventArgs e)
		{
			
		}
				
		/// <summary>
		/// Cuenta la cantidad de palabras cuando se preciona el boton
		/// </summary>
		private void BtnCalcular_Click(object sender, EventArgs e)
		{
			string textoIngresado = TextBox.Text;
			string palabra = "";
			textoIngresado = string.Concat(textoIngresado, " ");
			palabras = new Dictionary<string, int>();
			string top1 = "";
			string top2 = ""; 
			string top3 = ""; 
			int claveTop1= int.MinValue;
			int claveTop2 = int.MinValue;
			int claveTop3 = int.MinValue;

			for (int i = 0; i < textoIngresado.Length; i++)
			{
				if (!(Char.IsWhiteSpace(textoIngresado[i])))
				{
					palabra = string.Concat(palabra, textoIngresado[i]);
				}
				else
				{
					if (palabras.ContainsKey(palabra))
					{
						palabras[palabra] += 1;
					}
					else
					{
						palabras.Add(palabra, 1);				
					}
					palabra = "";
				}
			} 
			foreach (KeyValuePair<string, int> item in palabras)
			{
				if (item.Value > claveTop1)
				{
					claveTop1  = item.Value;
					top1 = item.Key;
				}
				else if (item.Value > claveTop2)
				{
					claveTop2 = item.Value;
					top2 = item.Key;
				}
				else if (item.Value > claveTop3)
				{
					claveTop3 = item.Value;
					top3 = item.Key;
				}
			}

			StringBuilder mensajeSalida = new StringBuilder();
			mensajeSalida.Append("\n-Top 1: ");
			mensajeSalida.Append(top1);
			mensajeSalida.Append(" Cantidad de apariciones: ");
			mensajeSalida.Append(claveTop1);
			mensajeSalida.Append("\n-Top 2: ");
			mensajeSalida.Append(top2);
			mensajeSalida.Append("Cantidad de apariciones: ");
			mensajeSalida.Append(claveTop2);
			mensajeSalida.Append("\n-Top 3: ");
			mensajeSalida.Append(top3);
			mensajeSalida.Append("Cantidad de apariciones: ");
			mensajeSalida.Append(claveTop3);

			MessageBoxButtons buttons = MessageBoxButtons.OK;
			MessageBox.Show(mensajeSalida.ToString(),"Top de palabras", buttons, MessageBoxIcon.Warning);
		}












	}
}

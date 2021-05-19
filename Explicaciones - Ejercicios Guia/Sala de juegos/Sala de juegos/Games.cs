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
	public partial class FrmPrincipal : Form
	{
		
		public FrmPrincipal()
		{
			InitializeComponent();
		}

		private void FrmPrincipal_Load(object sender, EventArgs e)
		{



		}

		private void btnAdivinaNumero_Click(object sender, EventArgs e)
		{

			Adivinador a = new Adivinador(this.txtNombre.Text);
			a.Show();			

		}

	}
}

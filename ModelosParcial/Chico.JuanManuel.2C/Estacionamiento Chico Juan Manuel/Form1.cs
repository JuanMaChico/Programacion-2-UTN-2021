using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chico.JuanManuel._2C;

namespace Estacionamiento_Chico_Juan_Manuel
{
	public partial class Form1 : Form
	{
		private Estacionamiento estacionamiento;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.CboxTipoVechiculo.DataSource = Enum.GetValues(typeof(Vehiculo.EVehiculos));
			this.CboxTipoMoto.DataSource = Enum.GetValues(typeof(Moto.Etipo));

			this.estacionamiento = Estacionamiento.GetEstacionamiento("Estacionamiento Chico",20);

			this.txtNombreEstacionamiento.Text = this.estacionamiento.Nombre;
			
			//-El Evento SelectedIndexChanged del ComboBox TipoVehiculo tendrá el siguiente código:

		}

		private void CboxTipoVechiculo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((Vehiculo.EVehiculos)this.CboxTipoVechiculo.SelectedItem == Vehiculo.EVehiculos.Automovil)
			{
				this.CboxTipoMoto.Visible = false;
				LblTipo.Text = "Marca:";
				this.TxtMarca.Location = this.CboxTipoMoto.Location;
				this.TxtMarca.Visible = true;
			}
			else
			{
				this.CboxTipoMoto.Visible = true;
				LblTipo.Text = "Tipo Moto:";
				this.TxtMarca.Visible = false;
			}
		}

		private void btnAgregarVehiculo_Click(object sender, EventArgs e)
		{
			Vehiculo vehiculo;
			if ((Vehiculo.EVehiculos)this.CboxTipoMoto.SelectedItem == Vehiculo.EVehiculos.Automovil)
			{
				vehiculo = new Automovil(this.TxtPatente.Text, DateTime.Now, this.TxtMarca.Text);
			}
			else
			{
				vehiculo = new
				Moto(this.TxtPatente.Text, DateTime.Now, (Moto.Etipo)this.CboxTipoMoto.SelectedItem)
				;
			}
			if (this.estacionamiento + vehiculo)
			{
				this.ListBListaVehiculos.Items.Add(vehiculo);
				MessageBox.Show(vehiculo.ToString(), "Ingreso al Estacionamiento",MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void ListBListaVehiculos_DoubleClick(object sender, EventArgs e)
		{
			if (this.estacionamiento - (Vehiculo)this.ListBListaVehiculos.SelectedItem)
			{
				MessageBox.Show(this.estacionamiento.InformarSalida((Vehiculo)this.ListBListaVehiculos.SelectedItem),
					"Ingreso al Estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.ListBListaVehiculos.Items.Remove((Vehiculo)this.ListBListaVehiculos.SelectedItem);
			}
		}
	}
}


namespace Estacionamiento_Chico_Juan_Manuel
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LblTipo = new System.Windows.Forms.Label();
			this.TxtPatente = new System.Windows.Forms.TextBox();
			this.TxtMarca = new System.Windows.Forms.TextBox();
			this.btnAgregarVehiculo = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.CboxTipoVechiculo = new System.Windows.Forms.ComboBox();
			this.CboxTipoMoto = new System.Windows.Forms.ComboBox();
			this.ListBListaVehiculos = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombreEstacionamiento = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tipo Vehiculo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Patente";
			// 
			// LblTipo
			// 
			this.LblTipo.AutoSize = true;
			this.LblTipo.Location = new System.Drawing.Point(12, 146);
			this.LblTipo.Name = "LblTipo";
			this.LblTipo.Size = new System.Drawing.Size(55, 13);
			this.LblTipo.TabIndex = 2;
			this.LblTipo.Text = "Tipo Moto";
			// 
			// TxtPatente
			// 
			this.TxtPatente.Location = new System.Drawing.Point(90, 89);
			this.TxtPatente.Name = "TxtPatente";
			this.TxtPatente.Size = new System.Drawing.Size(121, 20);
			this.TxtPatente.TabIndex = 4;
			// 
			// TxtMarca
			// 
			this.TxtMarca.Location = new System.Drawing.Point(217, 142);
			this.TxtMarca.Name = "TxtMarca";
			this.TxtMarca.Size = new System.Drawing.Size(100, 20);
			this.TxtMarca.TabIndex = 6;
			// 
			// btnAgregarVehiculo
			// 
			this.btnAgregarVehiculo.Location = new System.Drawing.Point(34, 356);
			this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
			this.btnAgregarVehiculo.Size = new System.Drawing.Size(187, 66);
			this.btnAgregarVehiculo.TabIndex = 7;
			this.btnAgregarVehiculo.Text = "Agregar Vehiculo";
			this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
			this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.PaleGreen;
			this.richTextBox1.Location = new System.Drawing.Point(471, 34);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(317, 96);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "";
			// 
			// CboxTipoVechiculo
			// 
			this.CboxTipoVechiculo.FormattingEnabled = true;
			this.CboxTipoVechiculo.Items.AddRange(new object[] {
            "Moto",
            "Automovil"});
			this.CboxTipoVechiculo.Location = new System.Drawing.Point(90, 56);
			this.CboxTipoVechiculo.Name = "CboxTipoVechiculo";
			this.CboxTipoVechiculo.Size = new System.Drawing.Size(121, 21);
			this.CboxTipoVechiculo.TabIndex = 10;
			this.CboxTipoVechiculo.SelectedIndexChanged += new System.EventHandler(this.CboxTipoVechiculo_SelectedIndexChanged);
			// 
			// CboxTipoMoto
			// 
			this.CboxTipoMoto.FormattingEnabled = true;
			this.CboxTipoMoto.Items.AddRange(new object[] {
            "Ciclomotor",
            "Scooter",
            "Sport"});
			this.CboxTipoMoto.Location = new System.Drawing.Point(90, 142);
			this.CboxTipoMoto.Name = "CboxTipoMoto";
			this.CboxTipoMoto.Size = new System.Drawing.Size(121, 21);
			this.CboxTipoMoto.TabIndex = 11;
			// 
			// ListBListaVehiculos
			// 
			this.ListBListaVehiculos.BackColor = System.Drawing.Color.LightGreen;
			this.ListBListaVehiculos.FormattingEnabled = true;
			this.ListBListaVehiculos.Location = new System.Drawing.Point(471, 142);
			this.ListBListaVehiculos.Name = "ListBListaVehiculos";
			this.ListBListaVehiculos.Size = new System.Drawing.Size(317, 277);
			this.ListBListaVehiculos.TabIndex = 13;
			this.ListBListaVehiculos.DoubleClick += new System.EventHandler(this.ListBListaVehiculos_DoubleClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Nombre Estacionemiento: ";
			// 
			// txtNombreEstacionamiento
			// 
			this.txtNombreEstacionamiento.AutoSize = true;
			this.txtNombreEstacionamiento.Location = new System.Drawing.Point(149, 9);
			this.txtNombreEstacionamiento.Name = "txtNombreEstacionamiento";
			this.txtNombreEstacionamiento.Size = new System.Drawing.Size(10, 13);
			this.txtNombreEstacionamiento.TabIndex = 15;
			this.txtNombreEstacionamiento.Text = "-";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtNombreEstacionamiento);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ListBListaVehiculos);
			this.Controls.Add(this.CboxTipoMoto);
			this.Controls.Add(this.CboxTipoVechiculo);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnAgregarVehiculo);
			this.Controls.Add(this.TxtMarca);
			this.Controls.Add(this.TxtPatente);
			this.Controls.Add(this.LblTipo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Estacionamiento Juan Chico";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label LblTipo;
		private System.Windows.Forms.TextBox TxtPatente;
		private System.Windows.Forms.TextBox TxtMarca;
		private System.Windows.Forms.Button btnAgregarVehiculo;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ComboBox CboxTipoVechiculo;
		private System.Windows.Forms.ComboBox CboxTipoMoto;
		private System.Windows.Forms.ListBox ListBListaVehiculos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label txtNombreEstacionamiento;
	}
}


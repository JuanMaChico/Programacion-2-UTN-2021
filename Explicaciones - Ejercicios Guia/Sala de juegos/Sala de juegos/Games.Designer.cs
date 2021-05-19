
namespace Sala_de_juegos
{
	partial class FrmPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
			this.btnAdivinaNumero = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAdivinaNumero
			// 
			this.btnAdivinaNumero.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnAdivinaNumero.Location = new System.Drawing.Point(12, 67);
			this.btnAdivinaNumero.Name = "btnAdivinaNumero";
			this.btnAdivinaNumero.Size = new System.Drawing.Size(156, 42);
			this.btnAdivinaNumero.TabIndex = 0;
			this.btnAdivinaNumero.Text = "Adivina Numero";
			this.btnAdivinaNumero.UseVisualStyleBackColor = false;
			this.btnAdivinaNumero.Click += new System.EventHandler(this.btnAdivinaNumero_Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(89, 30);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(156, 20);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nombre : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(75, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Seleccion de Games";
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 168);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btnAdivinaNumero);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Games";
			this.Load += new System.EventHandler(this.FrmPrincipal_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdivinaNumero;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

